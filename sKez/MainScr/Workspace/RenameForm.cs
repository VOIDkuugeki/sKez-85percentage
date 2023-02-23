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
    public partial class RenameForm : Form
    {
        private int id;
        private Control c;

        public RenameForm()
        {
            InitializeComponent();
        }
        public RenameForm(int id, Control c)
        {
            InitializeComponent();
            this.id = id;
            this.c = c;
        }

        //ReOpen UC 
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
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            cnt.Open();
            String query = "UPDATE Board SET BoardName = @newname WHERE BoardID = @bid";

            SqlCommand comm = new SqlCommand(query, cnt);
            SqlParameter bid = new SqlParameter("@bid", this.id);
            comm.Parameters.Add(bid);
            comm.Parameters.Add(new SqlParameter("@newname", Txtbox.Text));
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnt.Close();
                comm.Dispose();
                openUControls(new WSTab());

                this.Close();
                this.Dispose();
            }
        }

        //Cancel
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
