using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Reflection.Emit;
using System.Data.SqlClient;

namespace sKez
{
    public partial class verifyPg : UserControl
    {
        public verifyPg()
        {
            InitializeComponent();
        }

        int code;
        Random random = new Random();

        private static int i;

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
            if(codeBx.Text == code.ToString())
            {
                String mail = txt_mail.Text;
                openUControls(new signupPg(mail));
            }
            else
            {
                invalidCode.Visible = true;
            }
        }

        private Boolean checkFormatMail(String input)
        {
            Regex mRegxExpression;
            if (txt_mail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(txt_mail.Text.Trim()))
                {
                    return false;
                }
            }
            return true;
        }

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
        private void txt_mail_Leave(object sender, EventArgs e)
        {
            String input = this.txt_mail.Text;
            if (!checkFormatMail(input)|!availableMail(input))
            {
                incorrectMail.Visible = true;
            }
            incorrectMail.Visible = false;
        }

        private async void sendcodeBtn_Click(object sender, EventArgs e)
        {
            if(i == 0)
            {
                //Generate code
                code = random.Next(10000, 100000);

                //From
                var fromAddress = new MailAddress("reincarvoid@gmail.com");

                //To
                var toAddress = new MailAddress(txt_mail.ToString());

                const String pass = "shbujfeppnifgocs";

                //Mail
                const String subject = "Verification Code";
                String body = code.ToString();

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(fromAddress.Address, pass),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                //Start cooldown
                i = 60;
                cd.Text = i.ToString() + 's';
                timer1.Interval = 60000;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Enabled = true;
            }
            else
            {
                //Show cooldown
                cd.Visible = true;

                await System.Threading.Tasks.Task.Delay(5000).ContinueWith(_ =>
                {
                    Invoke(new MethodInvoker(() => { cd.Visible = false; }));
                });

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            cd.Text = i.ToString() + 's';
            if (i == 0)
            {
                timer1.Enabled = false;
            }
        }

        private void codeBx_TextChanged(object sender, EventArgs e)
        {
            invalidCode.Visible = false;
        }
    }
}
