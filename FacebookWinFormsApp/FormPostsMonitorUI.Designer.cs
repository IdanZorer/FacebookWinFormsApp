namespace BasicFacebookFeatures
{
    public partial class FormPostsMonitorUI
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
            this.buttonSetSettings = new System.Windows.Forms.Button();
            this.buttonStartStopMonitoring = new System.Windows.Forms.Button();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.listBoxMonitoredPosts = new System.Windows.Forms.ListBox();
            this.buttonShowMonitoredPosts = new System.Windows.Forms.Button();
            this.labelSelectGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSetSettings
            // 
            this.buttonSetSettings.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSetSettings.Location = new System.Drawing.Point(53, 26);
            this.buttonSetSettings.Name = "buttonSetSettings";
            this.buttonSetSettings.Size = new System.Drawing.Size(140, 36);
            this.buttonSetSettings.TabIndex = 0;
            this.buttonSetSettings.Text = "Set Settings";
            this.buttonSetSettings.UseVisualStyleBackColor = true;
            this.buttonSetSettings.Click += new System.EventHandler(this.buttonSetSettings_Click);
            // 
            // buttonStartStopMonitoring
            // 
            this.buttonStartStopMonitoring.Enabled = false;
            this.buttonStartStopMonitoring.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonStartStopMonitoring.Location = new System.Drawing.Point(53, 176);
            this.buttonStartStopMonitoring.Name = "buttonStartStopMonitoring";
            this.buttonStartStopMonitoring.Size = new System.Drawing.Size(140, 36);
            this.buttonStartStopMonitoring.TabIndex = 1;
            this.buttonStartStopMonitoring.Text = "Start Monitoring";
            this.buttonStartStopMonitoring.UseVisualStyleBackColor = true;
            this.buttonStartStopMonitoring.Click += new System.EventHandler(this.buttonStartStopMonitoring_Click);
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(24, 130);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(201, 26);
            this.comboBoxGroups.TabIndex = 2;
            // 
            // listBoxMonitoredPosts
            // 
            this.listBoxMonitoredPosts.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxMonitoredPosts.FormattingEnabled = true;
            this.listBoxMonitoredPosts.ItemHeight = 18;
            this.listBoxMonitoredPosts.Location = new System.Drawing.Point(307, 26);
            this.listBoxMonitoredPosts.Name = "listBoxMonitoredPosts";
            this.listBoxMonitoredPosts.Size = new System.Drawing.Size(316, 130);
            this.listBoxMonitoredPosts.TabIndex = 3;
            // 
            // buttonShowMonitoredPosts
            // 
            this.buttonShowMonitoredPosts.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonShowMonitoredPosts.Location = new System.Drawing.Point(359, 176);
            this.buttonShowMonitoredPosts.Name = "buttonShowMonitoredPosts";
            this.buttonShowMonitoredPosts.Size = new System.Drawing.Size(208, 36);
            this.buttonShowMonitoredPosts.TabIndex = 4;
            this.buttonShowMonitoredPosts.Text = "Show Monitored Posts";
            this.buttonShowMonitoredPosts.UseVisualStyleBackColor = true;
            this.buttonShowMonitoredPosts.Click += new System.EventHandler(this.buttonShowMonitoredPosts_Click);
            // 
            // labelSelectGroup
            // 
            this.labelSelectGroup.AutoSize = true;
            this.labelSelectGroup.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSelectGroup.Location = new System.Drawing.Point(24, 104);
            this.labelSelectGroup.Name = "labelSelectGroup";
            this.labelSelectGroup.Size = new System.Drawing.Size(186, 18);
            this.labelSelectGroup.TabIndex = 5;
            this.labelSelectGroup.Text = "Select a group to monitor:";
            // 
            // FormPostsMonitorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 262);
            this.Controls.Add(this.labelSelectGroup);
            this.Controls.Add(this.buttonShowMonitoredPosts);
            this.Controls.Add(this.listBoxMonitoredPosts);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.buttonStartStopMonitoring);
            this.Controls.Add(this.buttonSetSettings);
            this.Name = "FormPostsMonitorUI";
            this.Text = "FormPostsMonitorUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetSettings;
        private System.Windows.Forms.Button buttonStartStopMonitoring;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.ListBox listBoxMonitoredPosts;
        private System.Windows.Forms.Button buttonShowMonitoredPosts;
        private System.Windows.Forms.Label labelSelectGroup;
    }
}