namespace sKez
{
    partial class UCNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNote));
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.NContent = new System.Windows.Forms.FlowLayoutPanel();
            this.AddTskBtn = new System.Windows.Forms.Button();
            this.AddGrpBtn = new System.Windows.Forms.Button();
            this.NContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleTxt
            // 
            this.TitleTxt.BackColor = System.Drawing.Color.BlueViolet;
            this.TitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleTxt.Font = new System.Drawing.Font("Meiryo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleTxt.Location = new System.Drawing.Point(0, 0);
            this.TitleTxt.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(186, 35);
            this.TitleTxt.TabIndex = 0;
            this.TitleTxt.Text = "New List";
            this.TitleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NContent
            // 
            this.NContent.AutoSize = true;
            this.NContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NContent.Controls.Add(this.AddTskBtn);
            this.NContent.Controls.Add(this.AddGrpBtn);
            this.NContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NContent.Location = new System.Drawing.Point(0, 35);
            this.NContent.Margin = new System.Windows.Forms.Padding(0);
            this.NContent.MaximumSize = new System.Drawing.Size(186, 9999);
            this.NContent.MinimumSize = new System.Drawing.Size(186, 42);
            this.NContent.Name = "NContent";
            this.NContent.Padding = new System.Windows.Forms.Padding(3);
            this.NContent.Size = new System.Drawing.Size(186, 115);
            this.NContent.TabIndex = 3;
            // 
            // AddTskBtn
            // 
            this.AddTskBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddTskBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddTskBtn.BackgroundImage")));
            this.AddTskBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddTskBtn.FlatAppearance.BorderSize = 0;
            this.AddTskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddTskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddTskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTskBtn.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTskBtn.ForeColor = System.Drawing.Color.Black;
            this.AddTskBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddTskBtn.ImageIndex = 0;
            this.AddTskBtn.Location = new System.Drawing.Point(6, 3);
            this.AddTskBtn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.AddTskBtn.Name = "AddTskBtn";
            this.AddTskBtn.Size = new System.Drawing.Size(84, 54);
            this.AddTskBtn.TabIndex = 0;
            this.AddTskBtn.Text = "New\r\nTask";
            this.AddTskBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddTskBtn.UseVisualStyleBackColor = false;
            this.AddTskBtn.Click += new System.EventHandler(this.AddTskBtn_Click);
            // 
            // AddGrpBtn
            // 
            this.AddGrpBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddGrpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddGrpBtn.BackgroundImage")));
            this.AddGrpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddGrpBtn.FlatAppearance.BorderSize = 0;
            this.AddGrpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddGrpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddGrpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGrpBtn.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGrpBtn.ForeColor = System.Drawing.Color.Black;
            this.AddGrpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddGrpBtn.ImageIndex = 0;
            this.AddGrpBtn.Location = new System.Drawing.Point(96, 3);
            this.AddGrpBtn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.AddGrpBtn.Name = "AddGrpBtn";
            this.AddGrpBtn.Size = new System.Drawing.Size(84, 54);
            this.AddGrpBtn.TabIndex = 0;
            this.AddGrpBtn.Text = "New\r\nGroup";
            this.AddGrpBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddGrpBtn.UseVisualStyleBackColor = false;
            this.AddGrpBtn.Click += new System.EventHandler(this.AddGrpBtn_Click);
            // 
            // UCNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.Controls.Add(this.NContent);
            this.Controls.Add(this.TitleTxt);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(220, 99999);
            this.MinimumSize = new System.Drawing.Size(180, 150);
            this.Name = "UCNote";
            this.Size = new System.Drawing.Size(186, 150);
            this.Load += new System.EventHandler(this.UCNote_Load);
            this.NContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel NContent;
        private System.Windows.Forms.TextBox TitleTxt;
#pragma warning disable CS0436 // The type 'AddTask' in 'D:\Uni\OOP\sKez project\sKez\sKez\AddTask.cs' conflicts with the imported type 'AddTask' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\AddTask.cs'.
#pragma warning restore CS0436 // The type 'AddTask' in 'D:\Uni\OOP\sKez project\sKez\sKez\AddTask.cs' conflicts with the imported type 'AddTask' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\AddTask.cs'.
#pragma warning disable CS0436 // The type 'AddGroup' in 'D:\Uni\OOP\sKez project\sKez\sKez\AddGroup.cs' conflicts with the imported type 'AddGroup' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\AddGroup.cs'.
        private System.Windows.Forms.Button AddTskBtn;
        private System.Windows.Forms.Button AddGrpBtn;
#pragma warning restore CS0436 // The type 'AddGroup' in 'D:\Uni\OOP\sKez project\sKez\sKez\AddGroup.cs' conflicts with the imported type 'AddGroup' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\AddGroup.cs'.
    }
}
