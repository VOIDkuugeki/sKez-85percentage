using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sKez
{
    public partial class UCBoard : UserControl
    {
        private int id;
        private String name;
        private Control c; //Content panel in MainScreen -> BoardPage
        private Control d; //Mainpage in MainScreen -> Rename/Delete
        public UCBoard()
        {
            InitializeComponent();
        }
        public UCBoard(int id, String name,Control c, Control d)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.c = c;
            this.d = d;
        }

        //Show Board's name and set id
        public void SetBoard()
        {
            this.BrdBtn.Text = this.name;
        }

        //Open UC in Control c
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

        //Show Option Btn
        private void BrdBtn_MouseEnter(object sender, EventArgs e)
        {
            this.settingBtn.Visible = true;
        }

        //Hide Option Btn
        private void BrdBtn_MouseLeave(object sender, EventArgs e)
        {
            this.settingBtn.Visible = false;
        }

        //Rename Board
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenameForm rename = new RenameForm(this.id,d);
            rename.ShowDialog();
        }

        //Delete Board
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) //Yes
            {
                SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
                String query = "delete from Board where BoardID = @id";
                cnt.Open();
                SqlCommand comm = new SqlCommand(query, cnt);
                comm.Parameters.Add("@id", SqlDbType.Int).Value = this.id;
                comm.ExecuteNonQuery();

                comm.Dispose();
                cnt.Close();
                openUControls(new WSTab(), d);
            }
        }


        //Open Board
        private void BrdBtn_Click(object sender, EventArgs e)
        {
            openUControls(new BoardPg(this.id, this.name), c);
        }
    }
}
