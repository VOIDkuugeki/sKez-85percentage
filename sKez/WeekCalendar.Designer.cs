namespace sKez
{
    partial class WeekCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeekCalendar));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CrtMonthLbl = new System.Windows.Forms.Label();
            this.PreBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.NextBtn = new System.Windows.Forms.Button();
            this.SatLbl = new System.Windows.Forms.Label();
            this.FriLbl = new System.Windows.Forms.Label();
            this.ThuLbl = new System.Windows.Forms.Label();
            this.WedLbl = new System.Windows.Forms.Label();
            this.TueLbl = new System.Windows.Forms.Label();
            this.MonLbl = new System.Windows.Forms.Label();
            this.SunLbl = new System.Windows.Forms.Label();
            this.dayCtner = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dayCtner.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PreBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NextBtn, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(280, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 58);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CrtMonthLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(48, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 52);
            this.panel1.TabIndex = 2;
            // 
            // CrtMonthLbl
            // 
            this.CrtMonthLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrtMonthLbl.Font = new System.Drawing.Font("Meiryo", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrtMonthLbl.Location = new System.Drawing.Point(0, 0);
            this.CrtMonthLbl.Name = "CrtMonthLbl";
            this.CrtMonthLbl.Size = new System.Drawing.Size(204, 52);
            this.CrtMonthLbl.TabIndex = 0;
            this.CrtMonthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreBtn
            // 
            this.PreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.PreBtn.FlatAppearance.BorderSize = 0;
            this.PreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreBtn.ImageKey = "single_arrow.png";
            this.PreBtn.ImageList = this.imageList1;
            this.PreBtn.Location = new System.Drawing.Point(3, 3);
            this.PreBtn.Name = "PreBtn";
            this.PreBtn.Size = new System.Drawing.Size(39, 52);
            this.PreBtn.TabIndex = 3;
            this.PreBtn.TabStop = false;
            this.PreBtn.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "single_arrow.png");
            this.imageList1.Images.SetKeyName(1, "single_arrow_right.png");
            // 
            // NextBtn
            // 
            this.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.NextBtn.FlatAppearance.BorderSize = 0;
            this.NextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.ImageKey = "single_arrow_right.png";
            this.NextBtn.ImageList = this.imageList1;
            this.NextBtn.Location = new System.Drawing.Point(258, 3);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(39, 52);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.TabStop = false;
            this.NextBtn.UseVisualStyleBackColor = true;
            // 
            // SatLbl
            // 
            this.SatLbl.AutoSize = true;
            this.SatLbl.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SatLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SatLbl.Location = new System.Drawing.Point(739, 84);
            this.SatLbl.Name = "SatLbl";
            this.SatLbl.Size = new System.Drawing.Size(85, 22);
            this.SatLbl.TabIndex = 5;
            this.SatLbl.Text = "Saturday";
            this.SatLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FriLbl
            // 
            this.FriLbl.AutoSize = true;
            this.FriLbl.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FriLbl.Location = new System.Drawing.Point(631, 84);
            this.FriLbl.Name = "FriLbl";
            this.FriLbl.Size = new System.Drawing.Size(61, 22);
            this.FriLbl.TabIndex = 6;
            this.FriLbl.Text = "Friday";
            this.FriLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThuLbl
            // 
            this.ThuLbl.AutoSize = true;
            this.ThuLbl.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThuLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ThuLbl.Location = new System.Drawing.Point(498, 84);
            this.ThuLbl.Name = "ThuLbl";
            this.ThuLbl.Size = new System.Drawing.Size(88, 22);
            this.ThuLbl.TabIndex = 7;
            this.ThuLbl.Text = "Thursday";
            this.ThuLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WedLbl
            // 
            this.WedLbl.AutoSize = true;
            this.WedLbl.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WedLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WedLbl.Location = new System.Drawing.Point(370, 84);
            this.WedLbl.Name = "WedLbl";
            this.WedLbl.Size = new System.Drawing.Size(105, 22);
            this.WedLbl.TabIndex = 8;
            this.WedLbl.Text = "Wednesday";
            this.WedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TueLbl
            // 
            this.TueLbl.AutoSize = true;
            this.TueLbl.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TueLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TueLbl.Location = new System.Drawing.Point(267, 84);
            this.TueLbl.Name = "TueLbl";
            this.TueLbl.Size = new System.Drawing.Size(78, 22);
            this.TueLbl.TabIndex = 9;
            this.TueLbl.Text = "Tuesday";
            this.TueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonLbl
            // 
            this.MonLbl.AutoSize = true;
            this.MonLbl.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MonLbl.Location = new System.Drawing.Point(147, 84);
            this.MonLbl.Name = "MonLbl";
            this.MonLbl.Size = new System.Drawing.Size(75, 22);
            this.MonLbl.TabIndex = 10;
            this.MonLbl.Text = "Monday";
            this.MonLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SunLbl
            // 
            this.SunLbl.AutoSize = true;
            this.SunLbl.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SunLbl.Location = new System.Drawing.Point(28, 84);
            this.SunLbl.Name = "SunLbl";
            this.SunLbl.Size = new System.Drawing.Size(73, 22);
            this.SunLbl.TabIndex = 4;
            this.SunLbl.Text = "Sunday";
            this.SunLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayCtner
            // 
            this.dayCtner.AutoScroll = true;
            this.dayCtner.BackColor = System.Drawing.Color.Transparent;
            this.dayCtner.Controls.Add(this.panel2);
            this.dayCtner.Controls.Add(this.panel4);
            this.dayCtner.Controls.Add(this.panel3);
            this.dayCtner.Controls.Add(this.panel5);
            this.dayCtner.Controls.Add(this.panel6);
            this.dayCtner.Controls.Add(this.panel7);
            this.dayCtner.Controls.Add(this.panel8);
            this.dayCtner.Location = new System.Drawing.Point(3, 125);
            this.dayCtner.Name = "dayCtner";
            this.dayCtner.Size = new System.Drawing.Size(867, 687);
            this.dayCtner.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 695);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(92, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 695);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(212, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 695);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(332, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 695);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(452, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(114, 695);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Location = new System.Drawing.Point(572, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(114, 695);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Location = new System.Drawing.Point(692, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(114, 695);
            this.panel8.TabIndex = 0;
            // 
            // weekCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dayCtner);
            this.Controls.Add(this.SunLbl);
            this.Controls.Add(this.SatLbl);
            this.Controls.Add(this.FriLbl);
            this.Controls.Add(this.ThuLbl);
            this.Controls.Add(this.WedLbl);
            this.Controls.Add(this.TueLbl);
            this.Controls.Add(this.MonLbl);
            this.ForeColor = System.Drawing.Color.Lavender;
            this.Name = "weekCalendar";
            this.Size = new System.Drawing.Size(870, 815);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.dayCtner.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CrtMonthLbl;
        private System.Windows.Forms.Button PreBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.FlowLayoutPanel dayCtner;
        private System.Windows.Forms.Label SatLbl;
        private System.Windows.Forms.Label FriLbl;
        private System.Windows.Forms.Label ThuLbl;
        private System.Windows.Forms.Label WedLbl;
        private System.Windows.Forms.Label TueLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label MonLbl;
        private System.Windows.Forms.Label SunLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}
