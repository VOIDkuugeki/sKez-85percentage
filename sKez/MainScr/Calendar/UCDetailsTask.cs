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
    public partial class UCDetailsTask : UserControl
    {
        private String name;
        private DateTime sdate;
        private TimeSpan stime;
        private DateTime edate;
        private TimeSpan etime;
        private String note;
        public UCDetailsTask()
        {
            InitializeComponent();
        }
        public UCDetailsTask(string name, DateTime sdate, TimeSpan stime, DateTime edate, TimeSpan etime, string note)
        {
            InitializeComponent();
            this.name = name;
            this.sdate = sdate;
            this.stime = stime;
            this.edate = edate;
            this.etime = etime;
            this.note = note;
        }

        private void UCDetailsTask_Load(object sender, EventArgs e)
        {
            //Set name
            this.Name_Lbl.Text = this.name;

            //Set time
            this.SDate_Lbl.Text = this.sdate.ToString("dd/MM/yyyy");
            this.STime_Lbl.Text = this.stime.ToString();
            this.EDate_Lbl.Text = this.edate.ToString("dd/MM/yyyy");
            this.ETime_Lbl.Text = this.etime.ToString();

            //Set note
            if(this.note == String.Empty)
            {
                this.Size = this.MinimumSize;
            }
            else this.NoteBx.Text = this.note;
        }
    }
}
