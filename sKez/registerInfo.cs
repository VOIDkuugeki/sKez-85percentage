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
        String mail;
        public registerInfo(String mail)
        {
            InitializeComponent();
            this.mail = mail;
        }

        private void confirmBtn_MouseHover(object sender, EventArgs e)
        {
            confirmBtn.ForeColor = Color.Gold;
            confirmPnl.BackColor = Color.Gold;
        }

        private void confirmBtn_MouseLeave(object sender, EventArgs e)
        {
            confirmPnl.BackColor = Color.Transparent;
            confirmBtn.ForeColor = Color.WhiteSmoke;
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            try
            {
                cnt.Open();
                String query = "update User_info " +
                    "set FirstName = @fname, LastName = @lname " +
                    "where Mail = @mail";
                SqlCommand comm = new SqlCommand(query, cnt);
                comm.Parameters.AddWithValue("@fname", fname_txt.Text);
                comm.Parameters.AddWithValue("@lname", lname_txt.Text);
                comm.Parameters.AddWithValue("@mail", this.mail);
                comm.ExecuteNonQuery();
                comm.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnt.Close();
            }
            Application.Restart();
        }

        private void skipBtn_Click(object sender, EventArgs e)
        {
            Application.Restart(); 
        }
    }
}
