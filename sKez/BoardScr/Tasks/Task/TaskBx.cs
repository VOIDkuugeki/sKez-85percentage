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
        private int t_id;
        private int l_id;
        private String name;
        private Control c;

        public TaskBx()
        {
            InitializeComponent();
        }
        public TaskBx(int id, string name, Control c)
        {
            InitializeComponent();
            this.t_id = id;
            this.name = name;
            this.c = c;
        }
        public TaskBx(int id, int lid, string name, Control c)
        {
            InitializeComponent();
            this.t_id = id;
            this.l_id = lid;
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
            T_EditForm ef = new T_EditForm(t_id, name, c);
            ef.ShowDialog();
        }

        //Delete task
        private void DeleteTask()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "delete from Tasks where TaskID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = this.t_id;
            comm.ExecuteNonQuery();

            comm.Dispose();
            cnt.Close();
        }

        //Convert the task to group
        private void Convert2Group()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "insert into TaskGroup (GroupName, LID)" +
                "values (@name, @id)";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = this.l_id;
            comm.Parameters.AddWithValue("@name", this.name);
            comm.ExecuteNonQuery();
            cnt.Close();
            comm.Dispose();

            openUControls(new TaskTab());
            this.Dispose();
        }

        //Delete click
        private void delMB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) //Yes
            {
                DeleteTask();
                openUControls(new TaskTab());
            }
        }

        //Convert click
        private void convertMB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to convert this task to group?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Convert2Group();
                DeleteTask();
                openUControls(new TaskTab());
            }
        }
    }
}
