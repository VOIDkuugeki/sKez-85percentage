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
    public partial class mainPg : UserControl
    {
        workSpaceTab wp = new workSpaceTab();
        calendarTab cal = new calendarTab();
        public mainPg()
        {
            InitializeComponent();
            this.wp.Visible = false;
            this.cal.Visible = false;
            this.content.Controls.Add(wp);
            this.content.Controls.Add(cal);
            this.wp.Dock = DockStyle.Fill;
            this.cal.Dock = DockStyle.Fill;
        }

        private void workspaceBtn_Click(object sender, EventArgs e)
        {
            workspaceBtn.ForeColor = Color.Black;
            calendarBtn.ForeColor = Color.DarkGray;
            this.wp.Visible = true;
            this.cal.Visible = false;
        }

        private void calendarBtn_Click(object sender, EventArgs e)
        {
            calendarBtn.ForeColor = Color.Black;
            workspaceBtn.ForeColor = Color.DarkGray;
            this.wp.Visible = false;
            this.cal.Visible = true;
        }
    }
}
