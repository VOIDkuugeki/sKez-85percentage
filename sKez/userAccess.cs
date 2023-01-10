using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sKez
{
    public partial class userAccess : Form
    {
        public userAccess()
        {
            InitializeComponent();
        }

        //Dragable
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Events
        private void userAccess_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void userAccess_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openUControls(UserControl u)
        {
            mainContainter.Controls.Clear();
            mainContainter.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }
        private void pagesBtn_Click(object sender, EventArgs e)
        {
            //Reset status of Buttons
            foreach (var pnl in pagePnl.Controls.OfType<Panel>())
            {
                pnl.BackColor = System.Drawing.Color.Transparent;
            }

            Button btn = (Button)sender;
            switch (btn.AccessibleName)
            {
                case "loginBtn":
                    openUControls(new loginPg());
                    loginPnl.BackColor = System.Drawing.Color.Gold;
                    break;
                case "signupBtn":
                    openUControls(new verifyPg());
                    signupPnl.BackColor = System.Drawing.Color.Gold;
                    break;
                default:
                    break;
            }
        }

        private void userAccess_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
