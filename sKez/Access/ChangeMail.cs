using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sKez
{
    public partial class ChangeMail : UserControl
    {
        private Control c;
        public ChangeMail()
        {
            InitializeComponent();
        }
        public ChangeMail(Control c)
        {
            InitializeComponent();
            this.c = c;
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
        private void txt_mail_Leave(object sender, EventArgs e)
        {
            String input = this.txt_mail.Text;
            if (!checkFormatMail(input) | !availableMail(input))
            {
                incorrectMail.Visible = true;
            }
            incorrectMail.Visible = false;
        }

        //Check format
        private Boolean checkFormatMail(String input)
        {
            Regex mRegxExpression;
            if (txt_mail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

                if (!mRegxExpression.IsMatch(txt_mail.Text.Trim()))
                {
                    return false;
                }
            }
            return true;
        }



        //Check available Mail
        private Boolean availableMail(String input)
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "select id from [dbo].[User_info] where Mail = @mail";
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.AddWithValue("@mail", this.txt_mail.Text);
            cnt.Open();

            var res = comm.ExecuteScalar();
            if (res != null)
            {
                return false;
            }
            return true;
        }

        //Update Mail
        private void updateMail()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "update User_info set Mail = @mail where Id = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = User.Id;
            comm.Parameters.AddWithValue("@mail", txt_mail.Text);
            comm.ExecuteNonQuery();

            cnt.Close();
            comm.Dispose();
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

        //Confirm
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            String input = this.txt_mail.Text;
            if (checkFormatMail(input) | availableMail(input))
            {
                updateMail();
                User.SetMail();
                openUControls(new ProfilePg());

                this.ParentForm.Close();
                this.ParentForm.Dispose();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            this.ParentForm.Dispose();
        }
    }
}
