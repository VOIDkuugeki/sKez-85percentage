using System.Windows.Forms;
using System;

namespace sKez
{
    partial class T_EditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.Content = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimeCBx = new System.Windows.Forms.CheckBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.startLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NoteCtn = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.Content.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBox
            // 
            this.TxtBox.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtBox.Location = new System.Drawing.Point(24, 48);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(345, 33);
            this.TxtBox.TabIndex = 1;
            this.TxtBox.Text = "New name";
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.Lavender;
            this.Content.Controls.Add(this.panel1);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(1, 1);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(388, 478);
            this.Content.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.NameLbl);
            this.panel1.Controls.Add(this.NoteCtn);
            this.panel1.Controls.Add(this.TxtBox);
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.CreateBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(388, 478);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimeCBx);
            this.groupBox1.Controls.Add(this.startDate);
            this.groupBox1.Controls.Add(this.startLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.endDate);
            this.groupBox1.Controls.Add(this.startTime);
            this.groupBox1.Controls.Add(this.endTime);
            this.groupBox1.Font = new System.Drawing.Font("Meiryo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 161);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // TimeCBx
            // 
            this.TimeCBx.AutoSize = true;
            this.TimeCBx.Location = new System.Drawing.Point(60, 5);
            this.TimeCBx.Name = "TimeCBx";
            this.TimeCBx.Size = new System.Drawing.Size(18, 17);
            this.TimeCBx.TabIndex = 5;
            this.TimeCBx.UseVisualStyleBackColor = true;
            this.TimeCBx.CheckedChanged += new System.EventHandler(this.TimeCBx_CheckedChanged);
            // 
            // startDate
            // 
            this.startDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.startDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.startDate.CustomFormat = "‎ ";
            this.startDate.Font = new System.Drawing.Font("Meiryo", 10.2F);
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(74, 38);
            this.startDate.Name = "startDate";
            this.startDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startDate.Size = new System.Drawing.Size(156, 33);
            this.startDate.TabIndex = 3;
            this.startDate.Value = new System.DateTime(2023, 2, 21, 0, 0, 0, 0);
            this.startDate.DropDown += new System.EventHandler(this.starttime_DropDown);
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Font = new System.Drawing.Font("Meiryo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLbl.ForeColor = System.Drawing.Color.Black;
            this.startLbl.Location = new System.Drawing.Point(7, 43);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(71, 27);
            this.startLbl.TabIndex = 0;
            this.startLbl.Text = "From: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "To: ";
            // 
            // endDate
            // 
            this.endDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.endDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.endDate.CustomFormat = "‎";
            this.endDate.Enabled = false;
            this.endDate.Font = new System.Drawing.Font("Meiryo", 10.2F);
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(74, 96);
            this.endDate.Name = "endDate";
            this.endDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.endDate.Size = new System.Drawing.Size(156, 33);
            this.endDate.TabIndex = 3;
            this.endDate.Value = new System.DateTime(2023, 2, 21, 22, 16, 0, 0);
            this.endDate.DropDown += new System.EventHandler(this.starttime_DropDown);
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "‎";
            this.startTime.Enabled = false;
            this.startTime.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime.Location = new System.Drawing.Point(236, 38);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(107, 33);
            this.startTime.TabIndex = 4;
            this.startTime.Value = new System.DateTime(2023, 2, 21, 21, 46, 0, 0);
            // 
            // endTime
            // 
            this.endTime.CustomFormat = "‎";
            this.endTime.Enabled = false;
            this.endTime.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTime.Location = new System.Drawing.Point(236, 96);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(107, 33);
            this.endTime.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Note";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Meiryo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.Black;
            this.NameLbl.Location = new System.Drawing.Point(8, 18);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(130, 27);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "List\'s name:*";
            // 
            // NoteCtn
            // 
            this.NoteCtn.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteCtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.NoteCtn.Location = new System.Drawing.Point(25, 297);
            this.NoteCtn.Multiline = true;
            this.NoteCtn.Name = "NoteCtn";
            this.NoteCtn.Size = new System.Drawing.Size(344, 122);
            this.NoteCtn.TabIndex = 1;
            this.NoteCtn.Text = "Type note here...";
            this.NoteCtn.TextChanged += new System.EventHandler(this.NoteCtn_TextChanged);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.ClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.Black;
            this.ClearBtn.Location = new System.Drawing.Point(14, 438);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 33);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelBtn.Location = new System.Drawing.Point(230, 438);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 33);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.CreateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBtn.FlatAppearance.BorderSize = 0;
            this.CreateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.CreateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CreateBtn.Location = new System.Drawing.Point(311, 438);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(67, 33);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.Text = "Save";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // T_EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(390, 480);
            this.Controls.Add(this.Content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "T_EditForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Content.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.Label label2;
        private Button ClearBtn;
        private DateTimePicker startTime;
        private DateTimePicker endTime;
        private DateTimePicker endDate;
        private Label label6;
        private TextBox NoteCtn;
        private GroupBox groupBox1;
        private CheckBox TimeCBx;
    }
}