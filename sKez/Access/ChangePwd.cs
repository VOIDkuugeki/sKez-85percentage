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
    public partial class ChangePwd : UserControl
    {
        private Control c;
        public ChangePwd()
        {
            InitializeComponent();
        }
        public ChangePwd(Control c)
        {
            InitializeComponent();
            this.c = c;
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
        private void txt_pwdcfm_Leave(object sender, EventArgs e)
        {
            if (!txt_pwdcfm.Text.Equals(pwdBx.Text)) matchPwd.Visible = true;
            else matchPwd.Visible = false;
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
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            //Check password match
            if (!txt_pwdcfm.Text.Equals(pwdBx.Text)) matchPwd.Visible = true;
            else
            {
                SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
                String query = "update Account set password = @pwd where Id = @id";
                cnt.Open();
                SqlCommand comm = new SqlCommand(query, cnt);
                comm.Parameters.Add("@id", SqlDbType.Int).Value = User.Id;
                comm.Parameters.AddWithValue("@pwd", pwdBx.Text);
                comm.ExecuteNonQuery();

                cnt.Close();
                comm.Dispose();

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
