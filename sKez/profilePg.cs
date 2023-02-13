using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sKez
{
    public partial class ProfilePg : UserControl
    {
        public ProfilePg()
        {
            InitializeComponent();
        }
        private void openUControls(UserControl u)
        {
            //Clear and dipose controls
            List<Control> ctrls = new List<Control>(this.Parent.Controls.Count);
            foreach (Control c in ctrls) c.Dispose();
            
            //Add new control
            this.Parent.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }
        private void confirmBtn_MouseLeave(object sender, EventArgs e)
        {
            confirmPnl.BackColor = Color.Transparent;
            confirmBtn.ImageIndex = 0;
        }

        private void confirmBtn_MouseEnter(object sender, EventArgs e)
        {
            confirmPnl.BackColor = Color.Gold;
            confirmBtn.ImageIndex = 1;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            openUControls(new MainPg());
            this.Dispose();
        }

        private void ProfilePg_Load(object sender, EventArgs e)
        {
            this.ID.Text = "#"+User.Id.ToString();
            this.mail_txt.Text = User.getMail().ToString();
            this.fname_txt.Text = Profile.getFname();
            this.lname_txt.Text = Profile.getLname();
        }

        private void dltBtn_DragEnter(object sender, DragEventArgs e)
        {
            this.dltBtn.ForeColor = Color.Gold;
        }

        private void dltBtn_DragLeave(object sender, EventArgs e)
        {
            this.dltBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
        }
    }
}
