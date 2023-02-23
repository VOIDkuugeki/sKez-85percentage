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

namespace sKez
{
    public partial class G_RenameForm : Form
    {
        private int g_id;
        private Control c;
        public G_RenameForm()
        {
            InitializeComponent();
        }

        // Group ->
        public G_RenameForm(Control c, int g_id)
        {
            InitializeComponent();
            this.c = c;
            this.g_id = g_id;
            FormLbl.Text = "Group's name: ";
        }

        //Open UC in Control c
        private void openUControls(UserControl u)
        {

            //Clear and dipose controls
            List<Control> ctrls = new List<Control>(c.Controls.Count);
            c.Controls.Clear();
            foreach (Control c in ctrls) c.Dispose();

            //Add new control
            c.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        //Rename a group
        private void renameGroup()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "update TaskGroup set GroupName = @name where GroupID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = this.g_id;
            comm.Parameters.AddWithValue("@name", TxtBox.Text);
            comm.ExecuteNonQuery();

            cnt.Close();
            comm.Dispose();
        }

        //Rename 
        private void rename()
        {
            renameGroup();
            openUControls(new TaskTab());
        }

        //Process
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            rename();
            this.Close();
            this.Dispose();
        }

        //Cancel
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
