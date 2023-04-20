using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPostsMonitorSettings : Form
    {
        private bool m_MonitorLinks = false;
        private bool m_MonitorPhotos = false;
        private bool m_MonitorVideos = false;
        private bool m_MonitorStatuses = false;
        private bool m_MonitorText = false;
        private string m_TextToMonitor;
        private int m_MonitoringInterval = 30;

        public FormPostsMonitorSettings()
        {
            InitializeComponent();
        }

        public bool MonitorLinks
        {
            get { return m_MonitorLinks; }
        }

        public bool MonitorPhotos
        {
            get { return m_MonitorPhotos; }
        }

        public bool MonitorVideos
        {
            get { return m_MonitorVideos; }
        }

        public bool MonitorStatuses
        {
            get { return m_MonitorStatuses; }
        }

        public bool MonitorText
        {
            get { return m_MonitorText; }
        }

        public string TextToMonitor
        {
            get { return m_TextToMonitor; }
        }

        public int MonitoringInterval
        {
            get { return m_MonitoringInterval; }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            checkBoxMonitorLinks.Checked = m_MonitorLinks;
            checkBoxMonitorPhotos.Checked = m_MonitorPhotos;
            checkBoxMonitorVideos.Checked = m_MonitorVideos;
            checkBoxMonitorStatuses.Checked = m_MonitorStatuses;
            checkBoxMonitorText.Checked = m_MonitorText;
            textBoxTextToMonitor.Text = m_TextToMonitor;
            textBoxMonitoringIntervals.Text = m_MonitoringInterval.ToString();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            m_MonitorLinks = checkBoxMonitorLinks.Checked;
            m_MonitorPhotos = checkBoxMonitorPhotos.Checked;
            m_MonitorVideos = checkBoxMonitorVideos.Checked;
            m_MonitorStatuses = checkBoxMonitorStatuses.Checked;
            m_MonitorText = checkBoxMonitorText.Checked;

            if (m_MonitorText)
            {
                m_TextToMonitor = textBoxTextToMonitor.Text;
            }

            if(!m_MonitorLinks && !m_MonitorPhotos && !m_MonitorVideos && !m_MonitorStatuses)
            {
                MessageBox.Show("At least one post type should be selected in order to start monitoring", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void monitoringIntervalInputValidation()
        {
            int monitoringInterval;

            if(!int.TryParse(textBoxMonitoringIntervals.Text, out monitoringInterval))
            {
                MessageBox.Show("Only integers are allowed as monitoring intervals input!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMonitoringIntervals.Text = m_MonitoringInterval.ToString();
            }
            else
            {
                if (monitoringInterval >= 30)
                {
                    m_MonitoringInterval = monitoringInterval;
                }
                else
                {
                    MessageBox.Show("The minimum acceptable value of an interval is 30", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxMonitoringIntervals.Text = m_MonitoringInterval.ToString();
                }
            }
        }

        private void textBoxMonitoringIntervals_Leave(object sender, EventArgs e)
        {
            monitoringIntervalInputValidation();
        }

        private void checkBoxMonitorText_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as CheckBox).Checked)
            {
                textBoxTextToMonitor.Enabled = true;
            }
            else
            {
                textBoxTextToMonitor.Enabled = false;
            }
        }
    }
}