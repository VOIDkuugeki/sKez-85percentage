using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace sKez
{
    public partial class CreateBoard : Form
    {
        private Control c; 

        public CreateBoard()
        {
            InitializeComponent();
        }

        public CreateBoard(Control c)
        {
            InitializeComponent();
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

        //Create new board
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            //Query
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "insert into Board (BoardName, UID)" +
                "values (@name, @id)";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = User.Id;
            comm.Parameters.AddWithValue("@name", textBox1.Text);
            comm.ExecuteNonQuery();
            cnt.Close();
            comm.Dispose();

#pragma warning disable CS0436 // The type 'WSTab' in 'D:\Uni\OOP\sKez project\sKez\sKez\WSTab.cs' conflicts with the imported type 'WSTab' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\WSTab.cs'.
            openUControls(new WSTab());
#pragma warning restore CS0436 // The type 'WSTab' in 'D:\Uni\OOP\sKez project\sKez\sKez\WSTab.cs' conflicts with the imported type 'WSTab' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\WSTab.cs'.
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
