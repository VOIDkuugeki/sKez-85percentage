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
    public partial class workSpaceTab : UserControl
    {
        public workSpaceTab()
        {
            InitializeComponent();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            cancelBtn.Visible = true;
            newBtn.Visible = true;
            dltBtn.Visible = true;
            editBtn.Visible = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cancelBtn.Visible = false;
            newBtn.Visible = false;
            dltBtn.Visible = false;
            editBtn.Visible = true;
        }
    }
}
