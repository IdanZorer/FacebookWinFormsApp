namespace BasicFacebookFeatures
{
    public partial class FormMemeGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxMemePicture = new System.Windows.Forms.PictureBox();
            this.textBoxMemeText = new System.Windows.Forms.TextBox();
            this.buttonAddLabel = new System.Windows.Forms.Button();
            this.buttonDeleteLabel = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.colorDialogFontColor = new System.Windows.Forms.ColorDialog();
            this.buttonSelectFontColor = new System.Windows.Forms.Button();
            this.labelEnterText = new System.Windows.Forms.Label();
            this.labelEnterFontSize = new System.Windows.Forms.Label();
            this.labelCurrentTextFontColor = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonImportImageFile = new System.Windows.Forms.Button();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.labelSelectGroup = new System.Windows.Forms.Label();
            this.textBoxMemeTitle = new System.Windows.Forms.TextBox();
            this.labelMemeCaption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMemePicture
            // 
            this.pictureBoxMemePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMemePicture.Location = new System.Drawing.Point(202, 21);
            this.pictureBoxMemePicture.Name = "pictureBoxMemePicture";
            this.pictureBoxMemePicture.Size = new System.Drawing.Size(500, 680);
            this.pictureBoxMemePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMemePicture.TabIndex = 0;
            this.pictureBoxMemePicture.TabStop = false;
            // 
            // textBoxMemeText
            // 
            this.textBoxMemeText.BackColor = System.Drawing.Color.White;
            this.textBoxMemeText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxMemeText.Location = new System.Drawing.Point(864, 46);
            this.textBoxMemeText.Name = "textBoxMemeText";
            this.textBoxMemeText.Size = new System.Drawing.Size(214, 26);
            this.textBoxMemeText.TabIndex = 3;
            this.textBoxMemeText.TextChanged += new System.EventHandler(this.textBoxMemeText_TextChanged);
            // 
            // buttonAddLabel
            // 
            this.buttonAddLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAddLabel.Location = new System.Drawing.Point(40, 171);
            this.buttonAddLabel.Name = "buttonAddLabel";
            this.buttonAddLabel.Size = new System.Drawing.Size(114, 43);
            this.buttonAddLabel.TabIndex = 5;
            this.buttonAddLabel.Text = "Add Label";
            this.buttonAddLabel.UseVisualStyleBackColor = true;
            this.buttonAddLabel.Click += new System.EventHandler(this.buttonAddLabel_Click);
            // 
            // buttonDeleteLabel
            // 
            this.buttonDeleteLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonDeleteLabel.Location = new System.Drawing.Point(40, 96);
            this.buttonDeleteLabel.Name = "buttonDeleteLabel";
            this.buttonDeleteLabel.Size = new System.Drawing.Size(114, 43);
            this.buttonDeleteLabel.TabIndex = 6;
            this.buttonDeleteLabel.Text = "Delete Label";
            this.buttonDeleteLabel.UseVisualStyleBackColor = true;
            this.buttonDeleteLabel.Click += new System.EventHandler(this.buttonDeleteLabel_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.Location = new System.Drawing.Point(1065, 332);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(114, 43);
            this.buttonPost.TabIndex = 7;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // textBoxFont
            // 
            this.textBoxFont.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxFont.Location = new System.Drawing.Point(891, 93);
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.Size = new System.Drawing.Size(49, 26);
            this.textBoxFont.TabIndex = 8;
            this.textBoxFont.TextChanged += new System.EventHandler(this.textBoxFont_TextChanged);
            // 
            // buttonSelectFontColor
            // 
            this.buttonSelectFontColor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSelectFontColor.Location = new System.Drawing.Point(974, 127);
            this.buttonSelectFontColor.Name = "buttonSelectFontColor";
            this.buttonSelectFontColor.Size = new System.Drawing.Size(147, 38);
            this.buttonSelectFontColor.TabIndex = 9;
            this.buttonSelectFontColor.Text = "Select Font Color";
            this.buttonSelectFontColor.UseVisualStyleBackColor = true;
            this.buttonSelectFontColor.Click += new System.EventHandler(this.buttonSelectFontColor_Click);
            // 
            // labelEnterText
            // 
            this.labelEnterText.AutoSize = true;
            this.labelEnterText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEnterText.Location = new System.Drawing.Point(739, 52);
            this.labelEnterText.Name = "labelEnterText";
            this.labelEnterText.Size = new System.Drawing.Size(114, 18);
            this.labelEnterText.TabIndex = 10;
            this.labelEnterText.Text = "Enter label text:";
            // 
            // labelEnterFontSize
            // 
            this.labelEnterFontSize.AutoSize = true;
            this.labelEnterFontSize.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEnterFontSize.Location = new System.Drawing.Point(739, 96);
            this.labelEnterFontSize.Name = "labelEnterFontSize";
            this.labelEnterFontSize.Size = new System.Drawing.Size(138, 18);
            this.labelEnterFontSize.TabIndex = 11;
            this.labelEnterFontSize.Text = "Enter text font size:";
            // 
            // labelCurrentTextFontColor
            // 
            this.labelCurrentTextFontColor.AutoSize = true;
            this.labelCurrentTextFontColor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCurrentTextFontColor.Location = new System.Drawing.Point(739, 140);
            this.labelCurrentTextFontColor.Name = "labelCurrentTextFontColor";
            this.labelCurrentTextFontColor.Size = new System.Drawing.Size(158, 18);
            this.labelCurrentTextFontColor.TabIndex = 12;
            this.labelCurrentTextFontColor.Text = "Current text font color:";
            // 
            // labelColor
            // 
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelColor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelColor.Location = new System.Drawing.Point(911, 135);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(25, 25);
            this.labelColor.TabIndex = 13;
            // 
            // buttonImportImageFile
            // 
            this.buttonImportImageFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonImportImageFile.Location = new System.Drawing.Point(21, 21);
            this.buttonImportImageFile.Name = "buttonImportImageFile";
            this.buttonImportImageFile.Size = new System.Drawing.Size(156, 43);
            this.buttonImportImageFile.TabIndex = 14;
            this.buttonImportImageFile.Text = "Import Image File";
            this.buttonImportImageFile.UseVisualStyleBackColor = true;
            this.buttonImportImageFile.Click += new System.EventHandler(this.buttonImportImageFile_Click);
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(742, 340);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(301, 26);
            this.comboBoxGroups.TabIndex = 15;
            // 
            // labelSelectGroup
            // 
            this.labelSelectGroup.AutoSize = true;
            this.labelSelectGroup.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSelectGroup.Location = new System.Drawing.Point(738, 317);
            this.labelSelectGroup.Name = "labelSelectGroup";
            this.labelSelectGroup.Size = new System.Drawing.Size(181, 18);
            this.labelSelectGroup.TabIndex = 16;
            this.labelSelectGroup.Text = "Select a group to post to:";
            // 
            // textBoxMemeTitle
            // 
            this.textBoxMemeTitle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxMemeTitle.Location = new System.Drawing.Point(742, 259);
            this.textBoxMemeTitle.Name = "textBoxMemeTitle";
            this.textBoxMemeTitle.Size = new System.Drawing.Size(301, 26);
            this.textBoxMemeTitle.TabIndex = 17;
            // 
            // labelMemeCaption
            // 
            this.labelMemeCaption.AutoSize = true;
            this.labelMemeCaption.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMemeCaption.Location = new System.Drawing.Point(738, 236);
            this.labelMemeCaption.Name = "labelMemeCaption";
            this.labelMemeCaption.Size = new System.Drawing.Size(185, 18);
            this.labelMemeCaption.TabIndex = 18;
            this.labelMemeCaption.Text = "Enter a title for the meme:";
            // 
            // FormMemeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 801);
            this.Controls.Add(this.labelMemeCaption);
            this.Controls.Add(this.textBoxMemeTitle);
            this.Controls.Add(this.labelSelectGroup);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.buttonImportImageFile);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelCurrentTextFontColor);
            this.Controls.Add(this.labelEnterFontSize);
            this.Controls.Add(this.labelEnterText);
            this.Controls.Add(this.buttonSelectFontColor);
            this.Controls.Add(this.textBoxFont);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonDeleteLabel);
            this.Controls.Add(this.buttonAddLabel);
            this.Controls.Add(this.textBoxMemeText);
            this.Controls.Add(this.pictureBoxMemePicture);
            this.Name = "FormMemeGenerator";
            this.Text = "Meme Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMemePicture;
        private System.Windows.Forms.TextBox textBoxMemeText;
        private System.Windows.Forms.Button buttonAddLabel;
        private System.Windows.Forms.Button buttonDeleteLabel;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.ColorDialog colorDialogFontColor;
        private System.Windows.Forms.Button buttonSelectFontColor;
        private System.Windows.Forms.Label labelEnterText;
        private System.Windows.Forms.Label labelEnterFontSize;
        private System.Windows.Forms.Label labelCurrentTextFontColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonImportImageFile;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Label labelSelectGroup;
        private System.Windows.Forms.TextBox textBoxMemeTitle;
        private System.Windows.Forms.Label labelMemeCaption;
    }
}