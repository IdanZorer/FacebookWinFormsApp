using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly LoginDetails r_AppSettings = LoginDetails.LoadFromFile();
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (r_AppSettings.RememberUser && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(LoginDetails.LoadFromFile().LastAccessToken);
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                buttonLogin.Text = $"Logged in as {m_LoggedInUser.Name}";
                loadUI();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if(checkBoxRememberMe.Checked)
            {
                r_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                r_AppSettings.RememberUser = true;
                r_AppSettings.SaveToFile();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!r_AppSettings.RememberUser)
            {
                FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                    "139222482176194",
                        "email",
                        "public_profile",
                        "user_age_range",
                        "user_birthday",
                        "user_events",
                        "user_friends",
                        "user_gender",
                        "user_hometown",
                        "user_likes",
                        "user_link",
                        "user_location",
                        "user_photos",
                        "user_posts",
                        "user_videos",
                        "publish_to_groups",
                        "pages_read_engagement",
                        "pages_manage_posts");
                m_LoginResult = loginResult;
            }

            if (m_LoginResult.AccessToken != null)
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                buttonLogin.Text = $"Logged in as {m_LoggedInUser.Name}";
                loadUI();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			buttonLogin.Text = "Login";
            r_AppSettings.RememberUser = false;
            r_AppSettings.LastAccessToken = string.Empty;
            r_AppSettings.SaveToFile();
            m_LoginResult = null;
            m_LoggedInUser = null;
            cleanUI();
		}

        private void loadUI()
        {
            fetchPosts();
            fetchGroups();
            fetchLikedPages();
            fetchProfilePicture();
            fetchPersonalDetails();
            fetchAlbums();
        }

        private void cleanUI()
        {
            listBoxPosts.Items.Clear();
            listBoxGroups.Items.Clear();
            listBoxPages.Items.Clear();
            labelBirthday.Text = string.Empty;
            labelEmail.Text = string.Empty;
            labelGender.Text = string.Empty;
            labelNameField.Text = string.Empty;
            pictureBoxProfile.Image = null;
            listBoxAlbums.Items.Clear();
            pictureBoxAlbum.Image = null;
        }

        private void fetchPersonalDetails()
        {
            labelNameField.Text = m_LoggedInUser.Name;
            labelGender.Text = m_LoggedInUser.Gender.ToString();
            labelBirthday.Text = m_LoggedInUser.Birthday;
            labelEmail.Text = m_LoggedInUser.Email;
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void fetchLikedPages()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        private void fetchGroups()
        {
            try
            {
                foreach (Group group in m_LoggedInUser.Groups)
                {
                    listBoxGroups.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void fetchProfilePicture()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void buttonOpenMemeGenerator_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                FormMemeGenerator memeGenerator = new FormMemeGenerator(m_LoggedInUser);
                memeGenerator.Show();
            }
            else
            {
                MessageBox.Show("You need to be logged in to use this feature!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenPostsMonitor_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                FormPostsMonitorUI postsMonitor = new FormPostsMonitorUI(m_LoggedInUser);
                postsMonitor.Show();
            }
            else
            {
                MessageBox.Show("You need to be logged in to use this feature!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";
            foreach (Album album in m_LoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(album);
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                try
                {
                    Status postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text);
                    MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("You need to be logged in to post!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
