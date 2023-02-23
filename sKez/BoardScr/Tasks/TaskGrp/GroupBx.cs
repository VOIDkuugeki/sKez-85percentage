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
    public partial class GroupBx : UserControl
    {
        private int g_id;
        private String name;
        private Control c;

        public GroupBx()
        {
            InitializeComponent();
        }
        public GroupBx(int id, String name, Control c)
        {
            InitializeComponent();
            this.g_id = id;
            this.name = name;
            this.c = c; 
        }

        //Get tasks
        private void setTask()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "select TaskID, TaskName from Tasks where GID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = this.g_id;
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comm.ExecuteNonQuery();

            //Check DT null or not
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    //Adapt controls
                    foreach (DataRow row in dt.Rows)
                    {
                        int t_id = Convert.ToInt32(row["TaskId"]);
                        String t_name = row["TaskName"].ToString();
                        TaskBx tmp = new TaskBx(t_id, t_name, this.Parent.Parent.Parent.Parent.Parent);
                        this.GContent.Controls.Add(tmp);
                    }
                }
            }
            cnt.Close();
            comm.Dispose();
            sda.Dispose();
            dt.Dispose();
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
        private void GroupBx_Load(object sender, EventArgs e)
        {
            this.GroupLbl.Text = this.name;
            setTask();
        }

        //Rename
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            G_RenameForm rf = new G_RenameForm(this.c, this.g_id);
            rf.ShowDialog();
        }

        //Delete
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) //Yes
            {
                SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
                String query = "delete from TaskGroup where GroupID = @id";
                cnt.Open();
                SqlCommand comm = new SqlCommand(query, cnt);
                comm.Parameters.Add("@id", SqlDbType.Int).Value = this.g_id;
                comm.ExecuteNonQuery();

                comm.Dispose();
                cnt.Close();
                openUControls(new TaskTab());
            }

        }

        //Add a task
        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            G_AddTask af = new G_AddTask(g_id, c);
            af.ShowDialog();
        }
    }
}
