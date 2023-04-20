namespace BasicFacebookFeatures
{
    public partial class FormPostsMonitorSettings
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
            this.checkBoxMonitorLinks = new System.Windows.Forms.CheckBox();
            this.checkBoxMonitorPhotos = new System.Windows.Forms.CheckBox();
            this.checkBoxMonitorVideos = new System.Windows.Forms.CheckBox();
            this.checkBoxMonitorStatuses = new System.Windows.Forms.CheckBox();
            this.checkBoxMonitorText = new System.Windows.Forms.CheckBox();
            this.textBoxTextToMonitor = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.labelMonitoringInterval = new System.Windows.Forms.Label();
            this.textBoxMonitoringIntervals = new System.Windows.Forms.TextBox();
            this.labelSelectPostType = new System.Windows.Forms.Label();
            this.labelInputFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxMonitorLinks
            // 
            this.checkBoxMonitorLinks.AutoSize = true;
            this.checkBoxMonitorLinks.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxMonitorLinks.Location = new System.Drawing.Point(16, 76);
            this.checkBoxMonitorLinks.Name = "checkBoxMonitorLinks";
            this.checkBoxMonitorLinks.Size = new System.Drawing.Size(71, 22);
            this.checkBoxMonitorLinks.TabIndex = 0;
            this.checkBoxMonitorLinks.Text = "Links";
            this.checkBoxMonitorLinks.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonitorPhotos
            // 
            this.checkBoxMonitorPhotos.AutoSize = true;
            this.checkBoxMonitorPhotos.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxMonitorPhotos.Location = new System.Drawing.Point(16, 117);
            this.checkBoxMonitorPhotos.Name = "checkBoxMonitorPhotos";
            this.checkBoxMonitorPhotos.Size = new System.Drawing.Size(83, 22);
            this.checkBoxMonitorPhotos.TabIndex = 1;
            this.checkBoxMonitorPhotos.Text = "Photos";
            this.checkBoxMonitorPhotos.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonitorVideos
            // 
            this.checkBoxMonitorVideos.AutoSize = true;
            this.checkBoxMonitorVideos.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxMonitorVideos.Location = new System.Drawing.Point(16, 159);
            this.checkBoxMonitorVideos.Name = "checkBoxMonitorVideos";
            this.checkBoxMonitorVideos.Size = new System.Drawing.Size(84, 22);
            this.checkBoxMonitorVideos.TabIndex = 2;
            this.checkBoxMonitorVideos.Text = "Videos";
            this.checkBoxMonitorVideos.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonitorStatuses
            // 
            this.checkBoxMonitorStatuses.AutoSize = true;
            this.checkBoxMonitorStatuses.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxMonitorStatuses.Location = new System.Drawing.Point(16, 199);
            this.checkBoxMonitorStatuses.Name = "checkBoxMonitorStatuses";
            this.checkBoxMonitorStatuses.Size = new System.Drawing.Size(95, 22);
            this.checkBoxMonitorStatuses.TabIndex = 3;
            this.checkBoxMonitorStatuses.Text = "Statuses";
            this.checkBoxMonitorStatuses.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonitorText
            // 
            this.checkBoxMonitorText.AutoSize = true;
            this.checkBoxMonitorText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxMonitorText.Location = new System.Drawing.Point(268, 120);
            this.checkBoxMonitorText.Name = "checkBoxMonitorText";
            this.checkBoxMonitorText.Size = new System.Drawing.Size(468, 33);
            this.checkBoxMonitorText.TabIndex = 4;
            this.checkBoxMonitorText.Text = "Monitor only if contains the following text:";
            this.checkBoxMonitorText.UseVisualStyleBackColor = true;
            this.checkBoxMonitorText.CheckedChanged += new System.EventHandler(this.checkBoxMonitorText_CheckedChanged);
            // 
            // textBoxTextToMonitor
            // 
            this.textBoxTextToMonitor.Enabled = false;
            this.textBoxTextToMonitor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxTextToMonitor.Location = new System.Drawing.Point(268, 161);
            this.textBoxTextToMonitor.Name = "textBoxTextToMonitor";
            this.textBoxTextToMonitor.Size = new System.Drawing.Size(315, 26);
            this.textBoxTextToMonitor.TabIndex = 5;
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonApply.Location = new System.Drawing.Point(484, 271);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(99, 38);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // labelMonitoringInterval
            // 
            this.labelMonitoringInterval.AutoSize = true;
            this.labelMonitoringInterval.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMonitoringInterval.Location = new System.Drawing.Point(265, 31);
            this.labelMonitoringInterval.Name = "labelMonitoringInterval";
            this.labelMonitoringInterval.Size = new System.Drawing.Size(226, 18);
            this.labelMonitoringInterval.TabIndex = 7;
            this.labelMonitoringInterval.Text = "Monitoring Interval (in seconds):";
            // 
            // textBoxMonitoringIntervals
            // 
            this.textBoxMonitoringIntervals.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxMonitoringIntervals.Location = new System.Drawing.Point(510, 28);
            this.textBoxMonitoringIntervals.Name = "textBoxMonitoringIntervals";
            this.textBoxMonitoringIntervals.Size = new System.Drawing.Size(48, 26);
            this.textBoxMonitoringIntervals.TabIndex = 8;
            this.textBoxMonitoringIntervals.Text = "30";
            this.textBoxMonitoringIntervals.Leave += new System.EventHandler(this.textBoxMonitoringIntervals_Leave);
            // 
            // labelSelectPostType
            // 
            this.labelSelectPostType.AutoSize = true;
            this.labelSelectPostType.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSelectPostType.Location = new System.Drawing.Point(12, 29);
            this.labelSelectPostType.Name = "labelSelectPostType";
            this.labelSelectPostType.Size = new System.Drawing.Size(204, 18);
            this.labelSelectPostType.TabIndex = 9;
            this.labelSelectPostType.Text = "Select post types to monitor:";
            // 
            // labelInputFormat
            // 
            this.labelInputFormat.AutoSize = true;
            this.labelInputFormat.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelInputFormat.Location = new System.Drawing.Point(284, 199);
            this.labelInputFormat.Name = "labelInputFormat";
            this.labelInputFormat.Size = new System.Drawing.Size(264, 36);
            this.labelInputFormat.TabIndex = 10;
            this.labelInputFormat.Text = "(for monitoring more than one text the\r\n input format is: Text1, Text2, Text3...)" +
    string.Empty;
            // 
            // FormPostsMonitorSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 350);
            this.Controls.Add(this.labelInputFormat);
            this.Controls.Add(this.labelSelectPostType);
            this.Controls.Add(this.textBoxMonitoringIntervals);
            this.Controls.Add(this.labelMonitoringInterval);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBoxTextToMonitor);
            this.Controls.Add(this.checkBoxMonitorText);
            this.Controls.Add(this.checkBoxMonitorStatuses);
            this.Controls.Add(this.checkBoxMonitorVideos);
            this.Controls.Add(this.checkBoxMonitorPhotos);
            this.Controls.Add(this.checkBoxMonitorLinks);
            this.Name = "FormPostsMonitorSettings";
            this.Text = "FormPostsMonitorSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxMonitorLinks;
        private System.Windows.Forms.CheckBox checkBoxMonitorPhotos;
        private System.Windows.Forms.CheckBox checkBoxMonitorVideos;
        private System.Windows.Forms.CheckBox checkBoxMonitorStatuses;
        private System.Windows.Forms.CheckBox checkBoxMonitorText;
        private System.Windows.Forms.TextBox textBoxTextToMonitor;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label labelMonitoringInterval;
        private System.Windows.Forms.TextBox textBoxMonitoringIntervals;
        private System.Windows.Forms.Label labelSelectPostType;
        private System.Windows.Forms.Label labelInputFormat;
    }
}