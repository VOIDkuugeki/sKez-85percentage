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
    public partial class UCDays_month : UserControl
    {
        public UCDays_month()
        {
            InitializeComponent();
        }

        private void ucDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int num)
        {
            numLbl.Text = num.ToString();
        }
    }
}
