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
    public partial class T_EditForm : Form
    {
        private int t_id;
        private String name;
        private Control c;
        private int checkNote = 0;

        public T_EditForm()
        {
            InitializeComponent();
        }
        public T_EditForm(int id, String name, Control c)
        {
            InitializeComponent();
            this.t_id = id;
            this.name = name;
            this.c = c;
            this.TxtBox.Text = name;
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

        //Check Time
        private void TimeCBx_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TimeCBx.Checked)
            {
                this.startDate.Enabled = true;
                this.startDate.Format = DateTimePickerFormat.Short;
                this.startTime.Enabled = true;
                this.startTime.Format = DateTimePickerFormat.Time;
                this.endDate.Enabled = true;
                this.endDate.Format = DateTimePickerFormat.Short;
                this.endTime.Enabled = true;
                this.endTime.Format = DateTimePickerFormat.Time;
            }
            else
            {
                this.startDate.Enabled = false;
                this.startDate.Format = DateTimePickerFormat.Custom;
                this.startTime.Enabled = false;
                this.startTime.Format = DateTimePickerFormat.Custom;
                this.endDate.Enabled = false;
                this.endDate.Format = DateTimePickerFormat.Custom;
                this.endTime.Enabled = false;
                this.endTime.Format = DateTimePickerFormat.Custom;
            }
        }

        //Check Note
        private void NoteCtn_TextChanged(object sender, EventArgs e)
        {
            this.checkNote += 1;
        }

        //Set MinDate
        private void starttime_DropDown(object sender, EventArgs e)
        {
            this.startDate.MinDate = Convert.ToDateTime(DateTime.Now);
            this.endDate.MinDate = Convert.ToDateTime(this.startDate.Value);
        }


        //Cancel
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        //Clear
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.TxtBox.Text = this.name;
            this.NoteCtn.Text = "Type note here...";
            this.TimeCBx.Checked = false;
            this.checkNote = 0;
        }

        //Rename
        private void Rename()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "update Tasks set TaskName = @name where TaskID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = this.t_id;
            comm.Parameters.AddWithValue("@name", TxtBox.Text);
            comm.ExecuteNonQuery();

            cnt.Close();
            comm.Dispose();
        }

        //Rename and set Time
        private void RenameSTime()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "update Tasks set TaskName = @name, StartTime = @stime, EndTime = @etime where TaskID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = this.t_id;
            comm.Parameters.Add("@stime", SqlDbType.DateTime).Value = this.startDate.Value.Date + this.startTime.Value.TimeOfDay;
            comm.Parameters.Add("@etime", SqlDbType.DateTime).Value = this.endDate.Value.Date + this.endTime.Value.TimeOfDay;
            comm.Parameters.AddWithValue("@name", TxtBox.Text);
            comm.ExecuteNonQuery();

            cnt.Close();
            comm.Dispose();
        }

        //Set time
        private void SetTime()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "update Tasks set StartTime = @stime, EndTime = @etime where TaskID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = this.t_id;
            comm.Parameters.Add("@stime", SqlDbType.DateTime).Value = this.startDate.Value.Date + this.startTime.Value.TimeOfDay;
            comm.Parameters.Add("@etime", SqlDbType.DateTime).Value = this.endDate.Value.Date + this.endTime.Value.TimeOfDay;
            comm.ExecuteNonQuery();

            cnt.Close();
            comm.Dispose();
        }

        //Rename and add Note
        private void RenameANote()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "update Tasks set TaskName = @name, Note = @note where TaskID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = this.t_id;
            comm.Parameters.AddWithValue("@name", TxtBox.Text);
            comm.Parameters.AddWithValue("@note", NoteCtn.Text);
            comm.ExecuteNonQuery();

            cnt.Close();
            comm.Dispose();
        }

        //Add note
        private void AddNote()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "update Tasks set Note = @note where TaskID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = this.t_id;
            comm.Parameters.AddWithValue("@note", NoteCtn.Text);
            comm.ExecuteNonQuery();

            cnt.Close();
            comm.Dispose();
        }

        //Rename,set Time and add Note
        private void RTN()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "update Tasks set TaskName = @name, StartTime = @stime, EndTime = @etime, Note = @note where TaskID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = this.t_id;
            comm.Parameters.Add("@stime", SqlDbType.DateTime).Value = this.startDate.Value.Date + this.startTime.Value.TimeOfDay;
            comm.Parameters.Add("@etime", SqlDbType.DateTime).Value = this.endDate.Value.Date + this.endTime.Value.TimeOfDay;
            comm.Parameters.AddWithValue("@name", TxtBox.Text);
            comm.Parameters.AddWithValue("@note", NoteCtn.Text);
            comm.ExecuteNonQuery();

            cnt.Close();
            comm.Dispose();
        }

        private void STimeANote()
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "update Tasks set StartTime = @stime, EndTime = @etime, Note = @note where TaskID = @id";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = this.t_id;
            comm.Parameters.Add("@stime", SqlDbType.DateTime).Value = this.startDate.Value.Date + this.startTime.Value.TimeOfDay;
            comm.Parameters.Add("@etime", SqlDbType.DateTime).Value = this.endDate.Value.Date + this.endTime.Value.TimeOfDay;
            comm.Parameters.AddWithValue("@note", NoteCtn.Text);
            comm.ExecuteNonQuery();

            cnt.Close();
            comm.Dispose();
        }

        //Update
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if(TimeCBx.Checked && checkNote == 0) 
            {
                //Only rename
                if(!this.TxtBox.Text.Equals(this.name))
                {
                    Rename();

                    this.Close();
                    this.Dispose();
                }
            }
            if(TimeCBx.Checked && checkNote == 0)
            {
                //Rename and set Time
                if(!this.TxtBox.Text.Equals(this.name))
                {
                    RenameSTime();

                    this.Close();
                    this.Dispose();
                }
                //Set Time only
                else
                {
                    SetTime();
                    
                    this.Close();
                    this.Dispose();
                }
            }
            if(checkNote > 0 && !TimeCBx.Checked)
            {
                //Rename and add Note
                if (!this.TxtBox.Text.Equals(this.name))
                {
                    RenameANote();

                    this.Close();
                    this.Dispose();
                }
                //Add Note only
                else
                {
                    AddNote();

                    this.Close();
                    this.Dispose();
                }
            }
            if(TimeCBx.Checked && checkNote >0)
            {
                //Rename,set Time and add Note
                if (!this.TxtBox.Text.Equals(this.name))
                {
                    RTN();

                    this.Close();
                    this.Dispose();
                }
                //Set Time and add Note
                else
                {
                    STimeANote();

                    this.Close();
                    this.Dispose();
                }
            }
        }
    }
}
