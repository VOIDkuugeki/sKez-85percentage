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
    public partial class UserPanel : UserControl
    {
        public UserPanel()
        {
            InitializeComponent();
            this.NameTag.Text = User.Uname;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
