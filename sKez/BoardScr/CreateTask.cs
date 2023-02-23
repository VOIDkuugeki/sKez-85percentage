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
    public partial class CreateTask : Form
    {
        private int id;
        private Control c;
        public CreateTask()
        {
            InitializeComponent();
        }
        public CreateTask(int i, Control c)
        {
            InitializeComponent();
            this.id = i;
            this.c = c;
        }

        private void CreateBtn_MouseEnter(object sender, EventArgs e)
        {
            CreateBtn.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void CreateBtn_MouseLeave(object sender, EventArgs e)
        {
            CreateBtn.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void CancelBtn_MouseLeave(object sender, EventArgs e)
        {
            CancelBtn.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void CancelBtn_MouseEnter(object sender, EventArgs e)
        {
            CancelBtn.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

        //Create new note
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            //Query
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "insert into Tasks (TaskName,UID, LID)" +
                "values (@name,@uid, @lid)";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@lid", SqlDbType.Int).Value = this.id;
            comm.Parameters.Add("@uid", SqlDbType.Int).Value = User.Id;
            comm.Parameters.AddWithValue("@name", textBox1.Text);
            comm.ExecuteNonQuery();
            cnt.Close();
            comm.Dispose();

            openUControls(new TaskTab());
            this.Close();
            this.Dispose();
        }

        //Cancel the process
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
