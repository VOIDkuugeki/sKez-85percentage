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
    public partial class UCDays_month : UserControl
    {
        private int day;
        private int month;
        private int year;
        public UCDays_month()
        {
            InitializeComponent();
        }
        public UCDays_month(int day, int month, int year) 
        {
            InitializeComponent();
            this.day = day;
            this.month = month;
            this.year = year;
        }

        //Load
        private void ucDays_Load(object sender, EventArgs e)
        {
            numLbl.Text = day.ToString();
            countTask();
        }

        //Coun tanks in date
        private void countTask()
        {
            String date, month;

            if (this.day <10) date = "0"+this.day.ToString();
            else date = this.day.ToString();

            if (this.month < 10) month = "0" + this.month.ToString();
            else month = this.month.ToString();
            
            String time = this.year.ToString()+month+date;


            SqlConnection cnt = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Uni\OOP\sKez project\sKez\sKez\Database.mdf"";Integrated Security=True");
            String query = "select count(TaskName) from Tasks " +
                "where UID = @uid and @date between cast(StartTime as date) and CAST(EndTime as date)";
            cnt.Open();
            SqlCommand comm = new SqlCommand(query, cnt);
            comm.Parameters.Add("@uid", SqlDbType.Int).Value = User.Id;
            comm.Parameters.AddWithValue("@date", time);
            int count = (Int32) comm.ExecuteScalar();

            if(count > 0) this.TLbl.Text = count.ToString() + " Tasks";

            cnt.Close();
            comm.Dispose();
        }

        //Open the detail of tasks
        private void UCDays_month_Click(object sender, EventArgs e)
        {
            DetailsForm df = new DetailsForm(this.day, this.month, this.year);
            df.ShowDialog();
        }
    }
}
