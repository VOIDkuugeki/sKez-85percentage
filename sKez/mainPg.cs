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
        public mainPg()
        {
            InitializeComponent();
        }

        private void workspaceBtn_Click(object sender, EventArgs e)
        {
            workspaceBtn.ForeColor = Color.Black;
            calendarBtn.ForeColor = Color.DarkGray;
        }

        private void calendarBtn_Click(object sender, EventArgs e)
        {
            calendarBtn.ForeColor = Color.Black;
            workspaceBtn.ForeColor = Color.DarkGray;
        }
    }
}
