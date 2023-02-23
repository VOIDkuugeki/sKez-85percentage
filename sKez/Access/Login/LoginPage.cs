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
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();
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

        private void loginPg_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.lastUsername != String.Empty)
            {
                usrnameBx.Text = Properties.Settings.Default.lastUsername;
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "select * from [dbo].[Account] where Username = @uname and Password = @pwd";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.AddWithValue("@uname", usrnameBx.Text);
            comm.Parameters.AddWithValue("@pwd", pwdBx.Text);
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comm.ExecuteNonQuery();
            if(dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                User.Id = (int) row["id"];
                User.Uname = row["Username"].ToString();
                User.Pwd = row["Password"].ToString();
                User.SetMail();
                Profile.setProfile();

                this.ParentForm.Hide();
#pragma warning disable CS0436 // The type 'MainScreen' in 'D:\Uni\OOP\sKez project\sKez\sKez\Main\MainScreen.cs' conflicts with the imported type 'MainScreen' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\Main\MainScreen.cs'.
#pragma warning disable CS0436 // The type 'MainScreen' in 'D:\Uni\OOP\sKez project\sKez\sKez\Main\MainScreen.cs' conflicts with the imported type 'MainScreen' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\Main\MainScreen.cs'.
                MainScreen mscr = new MainScreen();
#pragma warning restore CS0436 // The type 'MainScreen' in 'D:\Uni\OOP\sKez project\sKez\sKez\Main\MainScreen.cs' conflicts with the imported type 'MainScreen' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\Main\MainScreen.cs'.
#pragma warning restore CS0436 // The type 'MainScreen' in 'D:\Uni\OOP\sKez project\sKez\sKez\Main\MainScreen.cs' conflicts with the imported type 'MainScreen' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\Main\MainScreen.cs'.
                mscr.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password");
            }

            pwdBx.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Properties.Settings.Default.lastUsername = usrnameBx.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
