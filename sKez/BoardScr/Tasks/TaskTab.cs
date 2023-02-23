using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sKez
{
    public partial class TaskTab : UserControl
    {
        public TaskTab()
        {
            InitializeComponent();
        }


        //Create Note
        private void EditBtn_Click(object sender, EventArgs e)
        {
            CreateNote cf = new CreateNote(this.BoardContent);
            cf.ShowDialog();
        }

        //Load Notes
        private void TaskTab_Load(object sender, EventArgs e)
        {
            //Load notes in board
            CurrentBoard.SetNList();

            //Create UC Note on screen
            if(CurrentBoard.GetNList() != null)
            {
                foreach(Note nt in CurrentBoard.GetNList())
                {
                    UCNote newnote = new UCNote(nt.getId(), nt.getName());
                    this.BoardContent.Controls.Add(newnote);
                }
            }
            else this.BoardContent.Controls.Clear();
        }
    }
}
