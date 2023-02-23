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
    public partial class BoardPg : UserControl
    {
        private Board Cboard;
        public BoardPg(int id, String name)
        {
            InitializeComponent();
            CurrentBoard.Id= id;
            CurrentBoard.Bname = name;
            openUControls(new TaskTab(), this.BoardContent);
        }

        //Open UC
        private void openUControls(UserControl u, Control l)
        {
            //Clear and dipose controls
            List<Control> ctrls = new List<Control>(l.Controls.Count);
            foreach (Control c in ctrls) c.Dispose();

            //Add new control
            l.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        //Open task
        private void TaskBtn_Click(object sender, EventArgs e)
        {
            TaskBtn.ForeColor = Color.Black;
            ProgressBtn.ForeColor = Color.DarkGray;
#pragma warning disable CS0436 // The type 'WSTab' in 'D:\Uni\OOP\sKez project\sKez\sKez\WSTab.cs' conflicts with the imported type 'WSTab' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\WSTab.cs'.
            openUControls(new TaskTab(), this.BoardContent);
#pragma warning restore CS0436 // The type 'WSTab' in 'D:\Uni\OOP\sKez project\sKez\sKez\WSTab.cs' conflicts with the imported type 'WSTab' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\WSTab.cs'.
        }

        //Open progress
        private void progressBtn_Click(object sender, EventArgs e)
        {
            ProgressBtn.ForeColor = Color.Black;
            TaskBtn.ForeColor = Color.DarkGray;
#pragma warning disable CS0436 // The type 'CalendarTab' in 'D:\Uni\OOP\sKez project\sKez\sKez\CalendarTab.cs' conflicts with the imported type 'CalendarTab' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\CalendarTab.cs'.
#pragma warning restore CS0436 // The type 'CalendarTab' in 'D:\Uni\OOP\sKez project\sKez\sKez\CalendarTab.cs' conflicts with the imported type 'CalendarTab' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\CalendarTab.cs'.
            openUControls(new ProgressTab(), this.BoardContent);
        }

        //Back
        private void backBtn_Click(object sender, EventArgs e)
        {
            openUControls(new MainPg(), this.Parent);
            CurrentBoard.Id = 0;
            CurrentBoard.Bname = null;
            this.Dispose();
        }
    }
}
