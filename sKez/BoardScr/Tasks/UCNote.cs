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
    public partial class UCNote : UserControl
    {
        private int id;
        private String name;

        public UCNote(int id, String name)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
        }

        //Set lable
        private void SetNote()
        {
            this.TitleTxt.Text = name;
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

        //Get tasks
        private void setTask(int id)
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "select TaskID, TaskName from Tasks where LID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
                        TaskBx tmp = new TaskBx(t_id, t_name, this.Parent.Parent.Parent);
                        this.NContent.Controls.Add(tmp);
                    }
                }
            }
            cnt.Close();
            comm.Dispose();
            sda.Dispose();
            dt.Dispose();
        }

        //Get task groups
        private void setGTask(int id)
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "select GroupID, GroupName from TaskGroup where LID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = this.id;
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
                        int g_id = Convert.ToInt32(row["GroupId"]);
                        String g_name = row["GroupName"].ToString();
                        GroupBx tmp = new GroupBx(g_id, g_name, this.Parent.Parent.Parent);
                        this.NContent.Controls.Add(tmp);
                    }
                }
            }
            cnt.Close();
            comm.Dispose();
            sda.Dispose();
            dt.Dispose();
        }

        //Load content
        private void UCNote_Load(object sender, EventArgs e)
        {
            SetNote();
            setTask(this.id);
            setGTask(this.id);
        }

        //Add task
        private void AddTskBtn_Click(object sender, EventArgs e)
        {
            CreateTask cf = new CreateTask(this.id, this.Parent.Parent.Parent);
            cf.ShowDialog();
        }

        //Add task group
        private void AddGrpBtn_Click(object sender, EventArgs e)
        {
            CreateGroup cf = new CreateGroup(this.id, this.Parent.Parent.Parent);
            cf.ShowDialog();
        }

        
    }
}
