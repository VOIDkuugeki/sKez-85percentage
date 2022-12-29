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
    public partial class registerInfo : UserControl
    {
        int id;
        public registerInfo(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void confirmBtn_MouseHover(object sender, EventArgs e)
        {
            confirmPnl.BackColor = Color.Gold;
            confirmBtn.ImageIndex = 1;
        }

        private void confirmBtn_MouseLeave(object sender, EventArgs e)
        {
            confirmPnl.BackColor = Color.Transparent;
            confirmBtn.ImageIndex = 0;
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            cnt.Open();
            String query = "update [dbo].[User_info]" +
                           "set FirstName = @fname, LastName = @lname" +
                           "where Id = @id";
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.AddWithValue("@fname", this.fname_txt.Text);
            comm.Parameters.AddWithValue("@lname", this.lname_txt.Text);
            comm.Parameters.Add("@id", SqlDbType.Int);
            comm.Parameters["@id"].Value = this.id;
            comm.CommandTimeout = 3000;
            cnt.Close();
            this.ParentForm.Hide();
        }

        private void skipBtn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();
        }
    }
}
