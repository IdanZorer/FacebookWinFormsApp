using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormPostsMonitorUI : Form
    {
        private readonly FormPostsMonitorSettings r_MonitorSettings = new FormPostsMonitorSettings();
        private readonly User r_LoggedInUser;
        private readonly PostsMonitor r_PostsMonitor;
        private bool m_IsMonitoring = false;

        public FormPostsMonitorUI(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            r_PostsMonitor = new PostsMonitor();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            formPostsMonitorSettingsShow();
            loadGroupsToComboBox();
        }

        private void formPostsMonitorSettingsShow()
        {
            if (r_MonitorSettings.ShowDialog() == DialogResult.OK)
            {
                buttonStartStopMonitoring.Enabled = true;
            }
            else
            {
                if (!r_MonitorSettings.MonitorLinks && !r_MonitorSettings.MonitorPhotos
                        && !r_MonitorSettings.MonitorVideos && !r_MonitorSettings.MonitorStatuses)
                {
                    buttonStartStopMonitoring.Enabled = false;
                }
            }
        }

        private void buttonSetSettings_Click(object sender, EventArgs e)
        {
            formPostsMonitorSettingsShow();
        }

        private void buttonStartStopMonitoring_Click(object sender, EventArgs e)
        {
            if (!m_IsMonitoring)
            {
                if (comboBoxGroups.SelectedItem != null)
                {
                    if (r_MonitorSettings.MonitorText)
                    {
                        r_PostsMonitor.SequencesToLookFor = r_MonitorSettings.TextToMonitor;
                    }

                    r_PostsMonitor.GroupToMonitor = comboBoxGroups.SelectedItem as Group;
                    r_PostsMonitor.Interval = r_MonitorSettings.MonitoringInterval;
                    r_PostsMonitor.PostTypesToMonitor = createMonitoredPostTypesList();
                    r_PostsMonitor.StartMonitoring();
                    m_IsMonitoring = true;
                    (sender as Button).Text = "Stop Monitoring";
                }
                else
                {
                    MessageBox.Show("Please select a group");
                }
            }
            else
            {
                r_PostsMonitor.StopMonitoring();
                m_IsMonitoring = false;
                (sender as Button).Text = "Start Monitoring";
            }

            buttonSetSettings.Enabled = !m_IsMonitoring;
            comboBoxGroups.Enabled = !m_IsMonitoring;
        }

        private List<Post.eType> createMonitoredPostTypesList()
        {
            List<Post.eType> postTypesToMonitor = new List<Post.eType>();

            if(r_MonitorSettings.MonitorLinks)
            {
                postTypesToMonitor.Add(Post.eType.link);
            }

            if (r_MonitorSettings.MonitorPhotos)
            {
                postTypesToMonitor.Add(Post.eType.photo);
            }

            if (r_MonitorSettings.MonitorVideos)
            {
                postTypesToMonitor.Add(Post.eType.video);
            }

            if (r_MonitorSettings.MonitorStatuses)
            {
                postTypesToMonitor.Add(Post.eType.status);
            }

            return postTypesToMonitor;
        }

        private void buttonShowMonitoredPosts_Click(object sender, EventArgs e)
        {
            addPostsToListBox();
        }

        private void addPostsToListBox()
        {
            listBoxMonitoredPosts.Items.Clear();

            foreach (Post post in r_PostsMonitor.MonitoredPosts)
            {
                if (post.Message != null)
                {
                    listBoxMonitoredPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxMonitoredPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxMonitoredPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBoxMonitoredPosts.Items.Count == 0)
            {
                MessageBox.Show("There are no monitored posts.");
            }
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