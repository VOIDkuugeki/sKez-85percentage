namespace sKez
{
    partial class Note
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
            this.header = new System.Windows.Forms.Panel();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newTsk1 = new sKez.NewTsk();
            this.newGrp1 = new sKez.NewGrp();
            this.header.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.titleTxt);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(172, 42);
            this.header.TabIndex = 0;
            // 
            // titleTxt
            // 
            this.titleTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTxt.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(0, 0);
            this.titleTxt.Multiline = true;
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(172, 42);
            this.titleTxt.TabIndex = 0;
            this.titleTxt.Text = "New List";
            this.titleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.newTsk1);
            this.flowLayoutPanel1.Controls.Add(this.newGrp1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(172, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // newTsk1
            // 
            this.newTsk1.BackColor = System.Drawing.Color.Transparent;
            this.newTsk1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newTsk1.Location = new System.Drawing.Point(3, 3);
            this.newTsk1.Name = "newTsk1";
            this.newTsk1.Size = new System.Drawing.Size(80, 36);
            this.newTsk1.TabIndex = 0;
            // 
            // newGrp1
            // 
            this.newGrp1.BackColor = System.Drawing.Color.Transparent;
            this.newGrp1.Location = new System.Drawing.Point(89, 3);
            this.newGrp1.Name = "newGrp1";
            this.newGrp1.Size = new System.Drawing.Size(80, 36);
            this.newGrp1.TabIndex = 1;
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.header);
            this.Name = "Note";
            this.Size = new System.Drawing.Size(172, 142);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private NewTsk newTsk1;
        private NewGrp newGrp1;
    }
}
