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

        //Create Board
        private void newBtn_Click(object sender, EventArgs e)
        {
            CreateBoard cf = new CreateBoard(this.Parent);
            cf.ShowDialog();
        }

        //Load Board
        private void WSTab_Load(object sender, EventArgs e)
        {
            //Load the Board of User
            User.SetBLst();

            //Create UCBoard on Screen
            if(User.BLst != null)
            {
                foreach (Board bd in User.BLst)
                {
                    UCBoard newBrd = new UCBoard(bd.getId(), bd.getName(), this.Parent.Parent.Parent, this.Parent);
                    newBrd.SetBoard();
                    this.BrdCtn.Controls.Add(newBrd);
                }
            }
            else this.BrdCtn.Controls.Clear();
        }
    }
}
