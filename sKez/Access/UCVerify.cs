using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sKez
{
    public partial class UCVerify : UserControl
    {
        private int code;
        private Random random = new Random();
        private String purpose;
        private Control c;
        public UCVerify()
        {
            InitializeComponent();
        }
        public UCVerify(String pp, Control c)
        {
            InitializeComponent();
            this.purpose = pp;
            this.c = c;
        }
        private void ConfirmBtn_MouseHover(object sender, EventArgs e)
        {
            confirmPnl.BackColor = Color.Gold;
            confirmBtn.ForeColor = Color.Gold;
        }

        private void ConfirmBtn_MouseLeave(object sender, EventArgs e)
        {
            confirmPnl.BackColor = Color.Transparent;
            confirmBtn.ForeColor = Color.WhiteSmoke;
        }

        private void openUControls(UserControl u)
        {
            List<Control> ctrls = new List<Control>(this.Parent.Controls.Count);
            foreach (Control c in ctrls) c.Dispose();

            this.Parent.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        //Confirm
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (codeBx.Text == code.ToString())
            {
                if(purpose == "mail")
                {
                    openUControls(new ChangeMail(this.c));
                }
                if(purpose == "password")
                {
                    openUControls(new ChangePwd(this.c));
                }
            }
            else
            {
                invalidCode.Visible = true;
            }
        }

        //Send OTP
        private async void sendOTPBtn_Click(object sender, EventArgs e)
        {
            //Generate code
            code = random.Next(10000, 100000);

            //From
            MailAddress fromAddress = new MailAddress("reincarvoid@gmail.com");

            //To
            MailAddress toAddress = new MailAddress(User.GetMail());

            const String pass = "vsrtxygyyssjjmzl";

            //Mail
            MailMessage msg = new MailMessage();
            msg.From = fromAddress;
            msg.To.Add(toAddress);
            const String subject = "Verification Code";
            String body = code.ToString();
            msg.Subject = subject;
            msg.Body = body;    

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(fromAddress.Address, pass);
            smtp.Timeout = 20000;
            
            try
            {
                smtp.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                smtp.Dispose();
                smtp.Dispose();
            }
        }
        private void codeBx_TextChanged(object sender, EventArgs e)
        {
            invalidCode.Visible = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            this.ParentForm.Dispose();
        }
    }
}
