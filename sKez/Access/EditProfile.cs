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
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
             
        }
        public EditProfile(String pp, Control c)
        {
            InitializeComponent();
            UCVerify vf = new UCVerify(pp,c);
            panel1.Controls.Add(vf);
            vf.Dock= DockStyle.Fill;
            vf.BringToFront();
        }
    }
}
