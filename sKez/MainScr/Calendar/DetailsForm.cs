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
    public partial class DetailsForm : Form
    {
        private int day;
        private int month;
        private int year;

        public DetailsForm()
        {
            InitializeComponent();
        }
        public DetailsForm(int d, int m, int y)
        {
            InitializeComponent();
            this.day= d;
            this.month= m;
            this.year= y;
        }

        //Close
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        //Load content
        private void DetailsForm_Load(object sender, EventArgs e)
        {
            GetData();
        }

        //Get data
        private void GetData()
        {
            String date, month;

            if (this.day < 10) date = "0" + this.day.ToString();
            else date = this.day.ToString();

            if (this.month < 10) month = "0" + this.month.ToString();
            else month = this.month.ToString();

            String time = this.year.ToString() + month + date;

            //Query
            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "select TaskName, cast(StartTime as date), cast(StartTime as time(0)), cast(EndTime as date), cast(EndTime as time(0)), note from Tasks " +
                "where UID = @uid and @date between cast(StartTime as date) and CAST(EndTime as date)";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@uid", SqlDbType.Int).Value = User.Id;
            comm.Parameters.AddWithValue("@date", time);
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comm.ExecuteNonQuery();

            //Check DT null or not
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    //Adapt controls
                    foreach (DataRow row in dt.Rows)
                    {
                        String t_name = row[0].ToString();
                        DateTime sdate = Convert.ToDateTime(row[1]);
                        TimeSpan stime = TimeSpan.Parse(row[2].ToString());
                        DateTime edate = Convert.ToDateTime(row[3]);
                        TimeSpan etime = TimeSpan.Parse(row[4].ToString());
                        String note = row[5].ToString();
                        UCDetailsTask tmp = new UCDetailsTask(t_name, sdate, stime, edate, etime, note);
                        this.Ctn.Controls.Add(tmp);
                    }
                }
            }
            cnt.Close();
            comm.Dispose();
            sda.Dispose();
            dt.Dispose();
        }
    }
}
