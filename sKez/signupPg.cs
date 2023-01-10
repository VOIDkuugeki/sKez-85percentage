using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace sKez
{
    public partial class signupPg : UserControl
    {
        String mail;
        public signupPg(String mail)
        {
            InitializeComponent();
            this.mail = mail;
        }

        private void confirmBtn_MouseHover(object sender, EventArgs e)
        {
            confirmPnl.BackColor = Color.Gold;
            confirmBtn.ForeColor = Color.Gold;
        }

        private void confirmBtn_MouseLeave(object sender, EventArgs e)
        {
            confirmPnl.BackColor = Color.Transparent;
            confirmBtn.ForeColor = Color.WhiteSmoke;
        }

        private void openUControls(UserControl u)
        {
            this.Visible = false;
            this.Parent.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            //Check password match
            if (!txt_pwdcfm.Text.Equals(pwdBx.Text)) matchPwd.Visible = true;

            else
            {
                SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
                try
                {
                    String query = "insert into Account(Username,password)" + //Insert username & password
                        "values (@uname,@pwd);" +
                        "update User_info " +
                        "set Mail = @mail " + //Insert mail
                        "where User_info.Id in " +
                        "(select * from(select Id from Account where Username = @uname) as id)";
                    SqlCommand comm = new SqlCommand(query, cnt);
                    comm.Parameters.AddWithValue("@uname", this.txt_usrname.Text);
                    comm.Parameters.AddWithValue("@pwd", this.pwdBx.Text);
                    comm.Parameters.AddWithValue("@mail", this.mail);

                    cnt.Open();
                    comm.ExecuteNonQuery();
                    comm.Dispose();
                }
                catch
                {

                }
                finally
                {
                    cnt.Close();
                }
                openUControls(new registerInfo(mail));
            }
        }
        
        private void pwdBx_Click(object sender, EventArgs e)
        {
            strongPwd.Visible = false;
            cdtPwd.Visible = false;
        }

        private void txt_pwdcfm_Click(object sender, EventArgs e)
        {
            matchPwd.Visible = false;
        }

        private void txt_usrname_Leave(object sender, EventArgs e)
        {
            //Check available username
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            cnt.Open();
            String query = "select Id from Account where Username = @uname";
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.AddWithValue("@uname", this.txt_usrname.Text);

            var res = comm.ExecuteScalar();
            if (res != null)
            {
                unavailableUsername.Visible = true;
            }
            else unavailableUsername.Visible = false;
            cnt.Close();
        }

        private void pwdBx_Leave(object sender, EventArgs e)
        {
            //Check password's condition
            String password = pwdBx.Text;

            //Length
            if (password.Length < 8)
            {
                strongPwd.Visible = true;
                cdtPwd.Visible = true;
            }

            //Number
            int count = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c)) count++;
            }
            if (count < 1)
            {
                strongPwd.Visible = true;
                cdtPwd.Visible = true;
            }

            //Uppercase
            count = 0;
            foreach (char c in password)
            {
                if (char.IsUpper(c)) count++;
            }
            if (count < 1)
            {
                strongPwd.Visible = true;
                cdtPwd.Visible = true;
            }
            //Lowercase
            count = 0;
            foreach (char c in password)
            {
                if (char.IsLower(c)) count++;
            }
            if (count < 1)
            {
                strongPwd.Visible = true;
                cdtPwd.Visible = true;
            }
        }

        private void txt_usrname_Click(object sender, EventArgs e)
        {
            matchPwd.Visible = false;
        }

        private void txt_pwdcfm_Leave(object sender, EventArgs e)
        {
            if (!txt_pwdcfm.Text.Equals(pwdBx.Text)) matchPwd.Visible = true;
            else matchPwd.Visible = false;
        }
    }
}
