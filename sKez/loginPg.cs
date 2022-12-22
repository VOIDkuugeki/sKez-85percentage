﻿using System;
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
    public partial class loginPg : UserControl
    {
        public loginPg()
        {
            InitializeComponent();
        }

        private void confirmBtn_MouseHover(object sender, EventArgs e)
        {
            confirmPnl.BackColor = Color.Gold;
            confirmBtn.ImageIndex = 1;
        }

        private void confirmBtn_MouseLeave(object sender, EventArgs e)
        {
            confirmPnl.BackColor = Color.Transparent;
            confirmBtn.ImageIndex = 0;
        }
    }
}