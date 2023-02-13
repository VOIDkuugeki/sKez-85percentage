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
        private Control c;
        public UCBoard()
        {
            InitializeComponent();
        }
        public UCBoard(Control c)
        {
            InitializeComponent();
            this.c = c;
        }

        //Show Board's name and set id
        public void SetBoard(int id, String name)
        {
            this.id = id;
            this.BrdBtn.Text = name;
        }

        //Open UC in Control c
        private void openUControls(UserControl u)
        {

            //Clear and dipose controls
            List<Control> ctrls = new List<Control>(c.Controls.Count);
            foreach (Control c in ctrls) c.Dispose();

            //Add new control
            c.Controls.Add(u);
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

        //Open rename form
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenameForm rename = new RenameForm(c);
            rename.ShowDialog();
            rename.setID(id);
        }

        //Excute delete command
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) //Yes
            {
                SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
                String query = "delete from Board where BoardID = @id";
                cnt.Open();
                SqlCommand comm = new SqlCommand(query, cnt);
                comm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                comm.ExecuteNonQuery();
                cnt.Close();
                comm.Dispose();

                openUControls(new WSTab());
            }
        }

        private void settingBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BoardMenu.Show(this, Control.MousePosition); 
            }
        }
    }
}
