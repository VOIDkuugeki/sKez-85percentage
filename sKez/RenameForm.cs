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
        public RenameForm(Control c)
        {
            InitializeComponent();
            this.c = c;
        }

        //Set Id
        public void setID(int id)
        {
            this.id = id;
        }

        //Open UC in Control c
        private void openUControls(UserControl u)
        {
            //Clear and dipose controls
            List<Control> ctrls = new List<Control>(c.Controls.Count);
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
            String query = "update Board " +
                "set BoardName = @newname " +
                "where BoardID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);

            comm.Parameters.Add("@id", SqlDbType.Int).Value = id;
            comm.Parameters.AddWithValue("@newname", NewnameLbl.Text);
            comm.ExecuteNonQuery();
            cnt.Close();
            comm.Dispose();

            openUControls(new WSTab());
            this.Close();
            this.Dispose();
        }

        //Cancel
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
