using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sKez
{
    public partial class MonthCalendar : UserControl
    {
        static DateTime currentDT = DateTime.Now;
        static int currentYear = currentDT.Year;
        static int currentMonth = currentDT.Month;
        public MonthCalendar()
        {
            InitializeComponent();
        }

        private void monthCalendar_Load(object sender, EventArgs e)
        {
            DisplayDay();   
        }

        private void DisplayDay()
        {
            //Label
            this.CrtMonthLbl.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(currentMonth) + " " + currentYear.ToString();


            //DT
            DateTime startMonth = new DateTime(currentYear, currentMonth, 1);

            int dayNumb = DateTime.DaysInMonth(currentYear, currentMonth);

            int dayOfWeek = Convert.ToInt32(startMonth.DayOfWeek.ToString("d"));


            //Blank day
            for(int i = 1; i < dayOfWeek; i++)
            {
                UCBlank blank = new UCBlank();
                dayCtner.Controls.Add(blank);
            }

            //Day's Num
            for(int i = 1; i <= dayNumb; i++)
            {
                UCDays_month ucdays = new UCDays_month();
                ucdays.days(i);
                dayCtner.Controls.Add(ucdays);
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            dayCtner.Controls.Clear();
            if (currentMonth == 12)
            {
                currentMonth = 1;
                currentYear += 1;
            }
            else currentMonth += 1;
            DisplayDay();
        }

        private void PreBtn_Click(object sender, EventArgs e)
        {
            dayCtner.Controls.Clear();
            if (currentMonth == 1)
            {
                currentMonth = 12;
                currentYear -= 1;
            }
            else currentMonth -= 1;
            DisplayDay();
        }
    }
}
