using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PostsMonitor
    {
        private readonly Timer r_ReFetchTimer = new Timer();
        private readonly List<Post> r_MonitoredPosts = new List<Post>();
        private Group m_GroupToMonitor;
        private DateTime m_LatestUpdateDateTime = DateTime.Now;
        private List<Post.eType> m_PostTypesToMonitor;
        private int m_Interval = 30;
        private string m_SequencesToLookFor;
        private bool m_MonitorText = false;

        public PostsMonitor()
        {
            r_ReFetchTimer.Tick += new EventHandler(timerReFetch_Tick);
        }

        public Group GroupToMonitor
        {
            set { m_GroupToMonitor = value; }
        }

        public List<Post.eType> PostTypesToMonitor
        {
            set { m_PostTypesToMonitor = value; }
        }

        public int Interval
        {
            set { m_Interval = value; }
        }

        public string SequencesToLookFor
        {
            set { m_SequencesToLookFor = value; }
        }

        public List<Post> MonitoredPosts
        {
            get { return r_MonitoredPosts; }
        }

        public void StartMonitoring()
        {
            r_ReFetchTimer.Interval = 1000 * m_Interval;
            r_ReFetchTimer.Start();
        }

        public void StopMonitoring()
        {
            r_ReFetchTimer.Stop();
        }

        private void timerReFetch_Tick(object sender, EventArgs e)
        {
            monitorPosts();
        }

        private void monitorPosts()
        {
            string monitorMessage = string.Empty;
            Dictionary<string, int> matches = null;
            m_MonitorText = !string.IsNullOrEmpty(m_SequencesToLookFor);
            m_GroupToMonitor.ReFetch();
            if (m_MonitorText)
            {
                matches = sequencesDictionaryBuilder(m_SequencesToLookFor);
            }

            foreach (Post post in m_GroupToMonitor.WallPosts)
            {
                if (post.CreatedTime.Value > m_LatestUpdateDateTime)
                {
                    if (m_PostTypesToMonitor.Contains(post.Type.Value))
                    {
                        if (m_MonitorText)
                        {
                            if (textFinder(post.Message, ref matches))
                            {
                                r_MonitoredPosts.Add(post);
                                m_LatestUpdateDateTime = post.CreatedTime.Value;
                            }
                        }
                        else
                        {
                            r_MonitoredPosts.Add(post);
                            m_LatestUpdateDateTime = post.CreatedTime.Value;
                            MessageBox.Show(string.Format("New {0} post monitored!\nTo see the post click the Show Monitored Posts button on the UI.", post.Type.Value));
                        }
                    }
                }
            }

            if (m_MonitorText)
            {
                monitorMessage = sequencesDictionaryToString(matches);
            }

            if (!string.IsNullOrEmpty(monitorMessage))
            {
                MessageBox.Show(string.Format("The text you have set was monitored!\n{0}\nTo see the monitored posts click the Show Monitored Posts button on the UI.", monitorMessage));
            }
        }

        private string sequencesDictionaryToString(Dictionary<string, int> i_Matches)
        {
            StringBuilder message = new StringBuilder();

            foreach(string key in i_Matches.Keys)
            {
                if (i_Matches[key] > 0)
                {
                    message.Append(string.Format("The sequence \"{0}\" found {1} times.\n", key, i_Matches[key]));
                }
            }

            return message.ToString();
        }

        private Dictionary<string, int> sequencesDictionaryBuilder(string i_Sequences)
        {
            Dictionary<string, int> matches = new Dictionary<string, int>();
            string[] sequences = i_Sequences.Split(',');
            string cleanedSequence;
            int currIndex = 0;

            foreach (string sequence in sequences)
            {
                if (!string.IsNullOrEmpty(sequence))
                {
                    while (sequence[currIndex] == ' ')
                    {
                        currIndex++;
                    }

                    cleanedSequence = sequence.Remove(0, currIndex);
                    currIndex = 0;
                    if (!matches.Keys.Contains(cleanedSequence))
                    {
                        matches.Add(cleanedSequence, 0);
                    }
                }
            }

            return matches;
        }

        private bool textFinder(string i_PostText, ref Dictionary<string, int> o_Matches)
        {
            int matchesCount = 0;
            string[] keys = o_Matches.Keys.ToArray();
            bool sequenceFound = false;
            if (i_PostText != null)
            {
                foreach (string key in keys)
                {
                    matchesCount = kmpSearch(key, i_PostText);
                    o_Matches[key] += matchesCount;
                }
            }
            
            if(matchesCount > 0)
            {
                sequenceFound = true;
            }

            return sequenceFound;
        }

        private int kmpSearch(string i_Pattern, string i_Text)
        {
            int M = i_Pattern.Length;
            int N = i_Text.Length;
            int matchesCount = 0;
            int[] lps = new int[M];
            int j = 0;
            computeLPSArray(i_Pattern, M, lps);
            int i = 0;
            while (i < N)
            {
                if (i_Pattern[j] == i_Text[i])
                {
                    j++;
                    i++;
                }

                if (j == M)
                {
                    matchesCount++;
                    j = lps[j - 1];
                }
                else
                {
                    if (i < N && i_Pattern[j] != i_Text[i])
                    {
                        if (j != 0)
                        {
                            j = lps[j - 1];
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
            }

            return matchesCount;
        }

        private void computeLPSArray(string i_Pattern, int i_PatternLength, int[] i_LpsArray)
        {
            int len = 0;
            int i = 1;
            i_LpsArray[0] = 0;
            while (i < i_PatternLength)
            {
                if (i_Pattern[i] == i_Pattern[len])
                {
                    len++;
                    i_LpsArray[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = i_LpsArray[len - 1];
                    }
                    else
                    {
                        i_LpsArray[i] = len;
                        i++;
                    }
                }
            }
        }
    }
}