using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMemeGenerator : Form
    {
        private readonly User r_LoggedInUser;
        private readonly Dragger r_Dragger = new Dragger();
        private int m_LabelCounter = 0;
        private Label m_SelectedLabel = null;

        public FormMemeGenerator(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            loadGroupsToComboBox();
        }

        private void textBoxMemeText_TextChanged(object sender, EventArgs e)
        {
            if (m_SelectedLabel != null)
            {
                m_SelectedLabel.Text = textBoxMemeText.Text;
            }
        }

        private void buttonAddLabel_Click(object sender, EventArgs e)
        {
            Label label = createNewMemeLabel();
            r_Dragger.MakeDraggable(label);
            label.Click += new EventHandler(label_Click);
            pictureBoxMemePicture.Controls.Add(label);
        }

        private Label createNewMemeLabel()
        {
            Label label = new Label();
            m_LabelCounter++;
            label.AutoSize = true;
            label.Font = new Font("Impact", 14);
            label.Text = "Label" + m_LabelCounter;
            label.BackColor = Color.Transparent;

            return label;
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (m_SelectedLabel != null)
            {
                m_SelectedLabel.BorderStyle = BorderStyle.None;
            }

            m_SelectedLabel = sender as Label;
            m_SelectedLabel.BorderStyle = BorderStyle.FixedSingle;
            textBoxMemeText.Text = m_SelectedLabel.Text;
            textBoxFont.Text = m_SelectedLabel.Font.Size.ToString();
            labelColor.BackColor = m_SelectedLabel.ForeColor;
        }

        private void buttonDeleteLabel_Click(object sender, EventArgs e)
        {
            if (m_SelectedLabel != null)
            {
                pictureBoxMemePicture.Controls.Remove(m_SelectedLabel);
                m_SelectedLabel = null;
                textBoxMemeText.Text = string.Empty;
                textBoxFont.Text = string.Empty;
                labelColor.BackColor = Color.Transparent;
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            Group selectedGroup = comboBoxGroups.SelectedItem as Group;
            if(selectedGroup == null)
            {
                MessageBox.Show("Please select a group");
            }
            else
            {
                Bitmap bmp = createMeme();
                if (m_SelectedLabel != null)
                {
                    m_SelectedLabel.BorderStyle = BorderStyle.FixedSingle;
                }

                try
                {
                    selectedGroup.PostPhoto(convertImageToByte(bmp), textBoxMemeTitle.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error!, meme posting faild." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Meme posted successfully!");
            }
        }

        private Bitmap createMeme()
        {
            int width = Convert.ToInt32(pictureBoxMemePicture.Size.Width);
            int height = Convert.ToInt32(pictureBoxMemePicture.Size.Height);
            Bitmap bmp = new Bitmap(width, height);
            if (m_SelectedLabel != null)
            {
                m_SelectedLabel.BorderStyle = BorderStyle.None;
            }

            pictureBoxMemePicture.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
            
            return bmp;
        }

        private void textBoxFont_TextChanged(object sender, EventArgs e)
        {
            int fontSize;
            if (m_SelectedLabel != null)
            {
                if (int.TryParse(textBoxFont.Text, out fontSize) && fontSize > 0)
                {
                    m_SelectedLabel.Font = new Font("Impact", fontSize);
                }
                else
                {
                    if ((sender as TextBox).Text != string.Empty)
                    {
                        (sender as TextBox).Text = m_SelectedLabel.Font.Size.ToString();
                    }
                }
            }
        }

        private void buttonSelectFontColor_Click(object sender, EventArgs e)
        {
            if (m_SelectedLabel != null)
            {
                colorDialogFontColor.ShowDialog();
                m_SelectedLabel.ForeColor = colorDialogFontColor.Color;
                labelColor.BackColor = colorDialogFontColor.Color;
            }
        }

        private void buttonImportImageFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImageFile = new OpenFileDialog();
            openImageFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openImageFile.Filter = "Image Files Only (*.jpg, *.gif, *.png, *.bmp) | *.jpg; *.gif; *.png; *.bmp";
            if(openImageFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxMemePicture.Image = Image.FromFile(openImageFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!, The file could not be loaded." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                pictureBoxMemePicture.BorderStyle = BorderStyle.None;
            }
        }

        private byte[] convertImageToByte(Image i_Image)
        {
            ImageConverter imageConverter = new ImageConverter();
            byte[] imageByte = (byte[])imageConverter.ConvertTo(i_Image, typeof(byte[]));
            return imageByte;
        }

        private void loadGroupsToComboBox()
        {
            try
            {
                foreach (Group group in r_LoggedInUser.Groups)
                {
                    comboBoxGroups.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (comboBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }
    }
}