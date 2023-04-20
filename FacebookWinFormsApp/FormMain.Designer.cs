namespace BasicFacebookFeatures
{
    public partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelPosts = new System.Windows.Forms.Label();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonOpenMemeGenerator = new System.Windows.Forms.Button();
            this.labelGroups = new System.Windows.Forms.Label();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelNameField = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonOpenPostsMonitor = new System.Windows.Forms.Button();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGenderField = new System.Windows.Forms.Label();
            this.labelEmailField = new System.Windows.Forms.Label();
            this.labelBirthdayField = new System.Windows.Forms.Label();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogin.Location = new System.Drawing.Point(18, 18);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 35);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.Location = new System.Drawing.Point(18, 63);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 35);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(18, 119);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(138, 22);
            this.checkBoxRememberMe.TabIndex = 53;
            this.checkBoxRememberMe.Text = "Remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 18;
            this.listBoxPosts.Location = new System.Drawing.Point(330, 301);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(277, 148);
            this.listBoxPosts.TabIndex = 54;
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPosts.Location = new System.Drawing.Point(327, 270);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(52, 18);
            this.labelPosts.TabIndex = 55;
            this.labelPosts.Text = "Posts:";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 18;
            this.listBoxGroups.Location = new System.Drawing.Point(652, 301);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(277, 148);
            this.listBoxGroups.TabIndex = 56;
            // 
            // buttonOpenMemeGenerator
            // 
            this.buttonOpenMemeGenerator.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOpenMemeGenerator.Location = new System.Drawing.Point(1011, 179);
            this.buttonOpenMemeGenerator.Name = "buttonOpenMemeGenerator";
            this.buttonOpenMemeGenerator.Size = new System.Drawing.Size(188, 38);
            this.buttonOpenMemeGenerator.TabIndex = 57;
            this.buttonOpenMemeGenerator.Text = "Open Meme Generator";
            this.buttonOpenMemeGenerator.UseVisualStyleBackColor = true;
            this.buttonOpenMemeGenerator.Click += new System.EventHandler(this.buttonOpenMemeGenerator_Click);
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGroups.Location = new System.Drawing.Point(658, 270);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(63, 18);
            this.labelGroups.TabIndex = 58;
            this.labelGroups.Text = "Groups:";
            // 
            // listBoxPages
            // 
            this.listBoxPages.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 18;
            this.listBoxPages.Location = new System.Drawing.Point(652, 501);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(277, 148);
            this.listBoxPages.TabIndex = 59;
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikedPages.Location = new System.Drawing.Point(658, 470);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(99, 18);
            this.labelLikedPages.TabIndex = 60;
            this.labelLikedPages.Text = "Liked pages:";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(333, 18);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(160, 164);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 61;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxStatus.Location = new System.Drawing.Point(410, 711);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(327, 26);
            this.textBoxStatus.TabIndex = 62;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStatus.Location = new System.Drawing.Point(407, 690);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(89, 18);
            this.labelStatus.TabIndex = 63;
            this.labelStatus.Text = "Post status:";
            // 
            // labelNameField
            // 
            this.labelNameField.AutoSize = true;
            this.labelNameField.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNameField.Location = new System.Drawing.Point(638, 26);
            this.labelNameField.Name = "labelNameField";
            this.labelNameField.Size = new System.Drawing.Size(0, 18);
            this.labelNameField.TabIndex = 64;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGender.Location = new System.Drawing.Point(638, 68);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(0, 18);
            this.labelGender.TabIndex = 65;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBirthday.Location = new System.Drawing.Point(638, 110);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(0, 18);
            this.labelBirthday.TabIndex = 66;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEmail.Location = new System.Drawing.Point(638, 152);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 18);
            this.labelEmail.TabIndex = 67;
            // 
            // buttonOpenPostsMonitor
            // 
            this.buttonOpenPostsMonitor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOpenPostsMonitor.Location = new System.Drawing.Point(1011, 250);
            this.buttonOpenPostsMonitor.Name = "buttonOpenPostsMonitor";
            this.buttonOpenPostsMonitor.Size = new System.Drawing.Size(188, 38);
            this.buttonOpenPostsMonitor.TabIndex = 68;
            this.buttonOpenPostsMonitor.Text = "Open Posts Monitor";
            this.buttonOpenPostsMonitor.UseVisualStyleBackColor = true;
            this.buttonOpenPostsMonitor.Click += new System.EventHandler(this.buttonOpenPostsMonitor_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 18;
            this.listBoxAlbums.Location = new System.Drawing.Point(330, 501);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(277, 148);
            this.listBoxAlbums.TabIndex = 69;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(541, 602);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(87, 75);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 70;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAlbums.Location = new System.Drawing.Point(333, 470);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(64, 18);
            this.labelAlbums.TabIndex = 71;
            this.labelAlbums.Text = "Albums:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(559, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "Name:";
            // 
            // labelGenderField
            // 
            this.labelGenderField.AutoSize = true;
            this.labelGenderField.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGenderField.Location = new System.Drawing.Point(559, 68);
            this.labelGenderField.Name = "labelGenderField";
            this.labelGenderField.Size = new System.Drawing.Size(64, 18);
            this.labelGenderField.TabIndex = 73;
            this.labelGenderField.Text = "Gender:";
            // 
            // labelEmailField
            // 
            this.labelEmailField.AutoSize = true;
            this.labelEmailField.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEmailField.Location = new System.Drawing.Point(559, 152);
            this.labelEmailField.Name = "labelEmailField";
            this.labelEmailField.Size = new System.Drawing.Size(52, 18);
            this.labelEmailField.TabIndex = 74;
            this.labelEmailField.Text = "Email:";
            // 
            // labelBirthdayField
            // 
            this.labelBirthdayField.AutoSize = true;
            this.labelBirthdayField.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBirthdayField.Location = new System.Drawing.Point(559, 110);
            this.labelBirthdayField.Name = "labelBirthdayField";
            this.labelBirthdayField.Size = new System.Drawing.Size(69, 18);
            this.labelBirthdayField.TabIndex = 75;
            this.labelBirthdayField.Text = "Birthday:";
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(757, 711);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(90, 31);
            this.buttonPostStatus.TabIndex = 76;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 810);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.labelBirthdayField);
            this.Controls.Add(this.labelEmailField);
            this.Controls.Add(this.labelGenderField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAlbums);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.buttonOpenPostsMonitor);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelNameField);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelLikedPages);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.buttonOpenMemeGenerator);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonOpenMemeGenerator;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.Label labelLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelNameField;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonOpenPostsMonitor;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGenderField;
        private System.Windows.Forms.Label labelEmailField;
        private System.Windows.Forms.Label labelBirthdayField;
        private System.Windows.Forms.Button buttonPostStatus;
    }
}