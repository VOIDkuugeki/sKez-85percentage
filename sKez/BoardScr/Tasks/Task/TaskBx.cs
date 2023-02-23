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
    public partial class TaskBx : UserControl
    {
        private int id;
        private String name;
        private Control c;

        public TaskBx()
        {
            InitializeComponent();
        }
        public TaskBx(int id, string name, Control c)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.c = c;
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

        //Load content
        private void TaskBx_Load(object sender, EventArgs e)
        {
            this.TaskLbl.Text = this.name;
        }

        //Rename
        private void editMB_Click(object sender, EventArgs e)
        {
            T_EditForm ef = new T_EditForm(id, name, c);
            ef.ShowDialog();
        }

        //Delete
        private void delMB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) //Yes
            {
                SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
                String query = "delete from Tasks where TaskID = @id";
                cnt.Open();
                SqlCommand comm = new SqlCommand(query, cnt);
                comm.Parameters.Add("@id", SqlDbType.Int).Value = this.id;
                comm.ExecuteNonQuery();

                comm.Dispose();
                cnt.Close();
                openUControls(new TaskTab());
            }
        }
    }
}
