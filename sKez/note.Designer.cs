namespace sKez
{
    partial class note
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
            this.content = new System.Windows.Forms.Panel();
            this.newGrp1 = new sKez.newGrp();
            this.newTsk1 = new sKez.newTsk();
            this.header.SuspendLayout();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.titleTxt);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(160, 42);
            this.header.TabIndex = 0;
            // 
            // titleTxt
            // 
            this.titleTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTxt.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(0, 0);
            this.titleTxt.Multiline = true;
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(160, 42);
            this.titleTxt.TabIndex = 0;
            this.titleTxt.Text = "Title";
            this.titleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Controls.Add(this.newTsk1);
            this.content.Controls.Add(this.newGrp1);
            this.content.Dock = System.Windows.Forms.DockStyle.Top;
            this.content.Location = new System.Drawing.Point(0, 42);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(160, 80);
            this.content.TabIndex = 1;
            // 
            // newGrp1
            // 
            this.newGrp1.BackColor = System.Drawing.Color.Transparent;
            this.newGrp1.Dock = System.Windows.Forms.DockStyle.Top;
            this.newGrp1.Location = new System.Drawing.Point(0, 0);
            this.newGrp1.Name = "newGrp1";
            this.newGrp1.Size = new System.Drawing.Size(160, 40);
            this.newGrp1.TabIndex = 0;
            // 
            // newTsk1
            // 
            this.newTsk1.BackColor = System.Drawing.Color.Transparent;
            this.newTsk1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newTsk1.Dock = System.Windows.Forms.DockStyle.Top;
            this.newTsk1.Location = new System.Drawing.Point(0, 40);
            this.newTsk1.Name = "newTsk1";
            this.newTsk1.Size = new System.Drawing.Size(160, 40);
            this.newTsk1.TabIndex = 1;
            // 
            // note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.content);
            this.Controls.Add(this.header);
            this.Name = "note";
            this.Size = new System.Drawing.Size(160, 122);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.content.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Panel content;
        private newTsk newTsk1;
        private newGrp newGrp1;
    }
}
