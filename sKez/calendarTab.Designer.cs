namespace sKez
{
    partial class CalendarTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarTab));
            this.calendarIcon = new System.Windows.Forms.ImageList(this.components);
            this.content = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new sKez.MonthCalendar();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarIcon
            // 
            this.calendarIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("calendarIcon.ImageStream")));
            this.calendarIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.calendarIcon.Images.SetKeyName(0, "Day View.png");
            this.calendarIcon.Images.SetKeyName(1, "Week View.png");
            this.calendarIcon.Images.SetKeyName(2, "Month View.png");
            // 
            // content
            // 
            this.content.Controls.Add(this.monthCalendar1);
            this.content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(864, 642);
            this.content.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Lavender;
            this.monthCalendar1.Location = new System.Drawing.Point(3, 29);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.Size = new System.Drawing.Size(860, 610);
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.Load += new System.EventHandler(this.monthCalendar1_Load);
            // 
            // calendarTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.content);
            this.Name = "calendarTab";
            this.Size = new System.Drawing.Size(864, 642);
            this.content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList calendarIcon;
        private System.Windows.Forms.Panel content;
        private MonthCalendar monthCalendar1;
    }
}
