namespace sKez
{
    partial class calendarTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calendarTab));
            this.button2 = new System.Windows.Forms.Button();
            this.mthvwBtn = new System.Windows.Forms.Button();
            this.dayvwBtn = new System.Windows.Forms.Button();
            this.calendarIcon = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "Month View.png";
            this.button2.ImageList = this.calendarIcon;
            this.button2.Location = new System.Drawing.Point(834, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mthvwBtn
            // 
            this.mthvwBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mthvwBtn.FlatAppearance.BorderSize = 0;
            this.mthvwBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mthvwBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mthvwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mthvwBtn.ImageKey = "Week View.png";
            this.mthvwBtn.ImageList = this.calendarIcon;
            this.mthvwBtn.Location = new System.Drawing.Point(792, 5);
            this.mthvwBtn.Name = "mthvwBtn";
            this.mthvwBtn.Size = new System.Drawing.Size(36, 32);
            this.mthvwBtn.TabIndex = 2;
            this.mthvwBtn.UseVisualStyleBackColor = true;
            // 
            // dayvwBtn
            // 
            this.dayvwBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dayvwBtn.FlatAppearance.BorderSize = 0;
            this.dayvwBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dayvwBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dayvwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayvwBtn.ImageKey = "Day View.png";
            this.dayvwBtn.ImageList = this.calendarIcon;
            this.dayvwBtn.Location = new System.Drawing.Point(750, 5);
            this.dayvwBtn.Name = "dayvwBtn";
            this.dayvwBtn.Size = new System.Drawing.Size(36, 32);
            this.dayvwBtn.TabIndex = 3;
            this.dayvwBtn.UseVisualStyleBackColor = true;
            // 
            // calendarIcon
            // 
            this.calendarIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("calendarIcon.ImageStream")));
            this.calendarIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.calendarIcon.Images.SetKeyName(0, "Day View.png");
            this.calendarIcon.Images.SetKeyName(1, "Week View.png");
            this.calendarIcon.Images.SetKeyName(2, "Month View.png");
            // 
            // calendarPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mthvwBtn);
            this.Controls.Add(this.dayvwBtn);
            this.Name = "calendarPg";
            this.Size = new System.Drawing.Size(876, 650);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button mthvwBtn;
        private System.Windows.Forms.Button dayvwBtn;
        private System.Windows.Forms.ImageList calendarIcon;
    }
}
