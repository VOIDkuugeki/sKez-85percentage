using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sKez
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            openUControls(new MainPg());
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAccess access = new UserAccess();
            access.Show();
        }
        private void openUControls(UserControl u)
        {
            List<Control> ctrls = new List<Control>(this.Content.Controls.Count);
            this.Content.Controls.Clear();
            foreach (Control c in ctrls)
                c.Dispose();
            this.Content.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        /// Draggable panel:
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        //Open profile page
        private void userBtn_Click(object sender, EventArgs e)
        {
            openUControls(new ProfilePg());
        }


        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
