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
    public partial class WSTab : UserControl
    {
        public WSTab()
        {
            InitializeComponent();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            CreateBoard createfrm = new CreateBoard(this.Parent);
            createfrm.ShowDialog();
        }

        private void WSTab_Load(object sender, EventArgs e)
        {
            //Load the Board of User
            User.setBLst();

            //Create UCBoard on Screen
            foreach(Board bd in User.BLst)
            {
                UCBoard newBrd = new UCBoard(this.Parent);
                newBrd.SetBoard(bd.getId(), bd.getName());
                this.BrdCtn.Controls.Add(newBrd);
            }
        }
    }
}
