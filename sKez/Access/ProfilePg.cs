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
    public partial class ProfilePg : UserControl
    {
        public ProfilePg()
        {
            InitializeComponent();
        }
        private void openUControls(UserControl u)
        {
            //Clear and dipose controls
            List<Control> ctrls = new List<Control>(this.Parent.Controls.Count);
            foreach (Control c in ctrls) c.Dispose();
            
            //Add new control
            this.Parent.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }
        private void ConfirmBtn_MouseLeave(object sender, EventArgs e)
        {
            confirmPnl.BackColor = Color.Transparent;
            SaveBtn.ImageIndex = 0;
        }

        private void ConfirmBtn_MouseEnter(object sender, EventArgs e)
        {
            confirmPnl.BackColor = Color.Gold;
            SaveBtn.ImageIndex = 1;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            openUControls(new MainPg());
            this.Dispose();
        }

        private void ProfilePg_Load(object sender, EventArgs e)
        {
            this.IdLbl.Text += User.Id.ToString();
            this.UnameLbl.Text += User.Uname;
            this.mail_txt.Text = User.GetMail().ToString();
            this.Fname_txt.Text = Profile.getFname();
            this.Lname_txt.Text = Profile.getLname();
        }

        private void DltBtn_DragEnter(object sender, DragEventArgs e)
        {
            this.DltBtn.ForeColor = Color.Gold;
        }

        private void DltBtn_DragLeave(object sender, EventArgs e)
        {
            this.DltBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
        }

        //Change password
        private void ChangePwdBtn_Click(object sender, EventArgs e)
        {
            EditProfile ef = new EditProfile("password", this.Parent);
            ef.ShowDialog();
        }

        //Save name
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "UPDATE User_info SET Firstname = @fname, Lastname = @lname where Id = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.AddWithValue("@fname", Fname_txt.Text);
            comm.Parameters.AddWithValue("@lname", Lname_txt.Text);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = User.Id;
            comm.ExecuteNonQuery();

            comm.Dispose();
            cnt.Close();

            Profile.setProfile();
            openUControls(new ProfilePg());
        }

        //Delete account
        private void DltBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) //Yes
            {
                SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
                String query = "delete from Account where Id = @id";
                cnt.Open();
                SqlCommand comm = new SqlCommand(query, cnt);
                comm.Parameters.Add("@id", SqlDbType.Int).Value = User.Id;
                comm.ExecuteNonQuery();

                comm.Dispose();
                cnt.Close();
                
                Application.Restart();
            }
        }

        //Change mail
        private void mailBtn_Click(object sender, EventArgs e)
        {
            EditProfile ef = new EditProfile("mail", this.Parent);
            ef.ShowDialog();
        }
    }
}
