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
    public partial class MainPg : UserControl
    {
        public MainPg()
        {
            InitializeComponent();
            openUControls(new WSTab());
        }

        //Open UC
        private void openUControls(UserControl u)
        {

            //Clear and dipose controls
            List<Control> ctrls = new List<Control>(this.Content.Controls.Count);
            this.Content.Controls.Clear();
            foreach (Control c in ctrls) c.Dispose();

            //Add new control
            this.Content.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        //Open workspace 
        private void workspaceBtn_Click(object sender, EventArgs e)
        {
            WorkspaceBtn.ForeColor = Color.Black;
            CalendarBtn.ForeColor = Color.DarkGray;
            openUControls(new WSTab());
        }

        //Open calendar
        private void calendarBtn_Click(object sender, EventArgs e)
        {
            CalendarBtn.ForeColor = Color.Black;
            WorkspaceBtn.ForeColor = Color.DarkGray;
            openUControls(new CalendarTab());
        }
    }
}
