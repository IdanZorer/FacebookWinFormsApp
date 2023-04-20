using System.Windows.Forms;
using System.Drawing;

namespace BasicFacebookFeatures
{
    internal class Dragger
    {
        private Point m_MouseDownLocation;

        public void MakeDraggable(Control i_Control)
        {
            i_Control.MouseDown += new MouseEventHandler(control_MouseDown);
            i_Control.MouseMove += new MouseEventHandler(control_MouseMove);
        }

        private void control_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                control.Left = e.X + control.Left - m_MouseDownLocation.X;
                control.Top = e.Y + control.Top - m_MouseDownLocation.Y;
            }
        }

        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                m_MouseDownLocation = e.Location;
            }
        }
    }
}
