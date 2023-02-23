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
    public partial class VerifyPg : UserControl
    {        
        private int code;
        private Random random = new Random();
        public VerifyPg()
        {
            InitializeComponent();
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

        //Confirm
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if(codeBx.Text == code.ToString())
            {
                String mail = txt_mail.Text;
                openUControls(new SignupPg(mail));
            }
            else
            {
                invalidCode.Visible = true;
            }
        }

        //Check format
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
        private void txt_mail_Leave(object sender, EventArgs e)
        {
            String input = this.txt_mail.Text;
            if (!checkFormatMail(input)|!availableMail(input))
            {
                incorrectMail.Visible = true;
            }
            incorrectMail.Visible = false;
        }

        //Send OTP
        private async void sendOTPBtn_Click(object sender, EventArgs e)
        {
            //Generate code
            code = random.Next(10000, 100000);

            //From
            var fromAddress = new MailAddress("reincarvoid@gmail.com");

            //To
            var toAddress = new MailAddress(txt_mail.Text);

            const String pass = "vsrtxygyyssjjmzl";

            //Mail
            const String subject = "Verification Code";
            String body = code.ToString();

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
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
        }
        private void codeBx_TextChanged(object sender, EventArgs e)
        {
            invalidCode.Visible = false;
        }
    }
}
