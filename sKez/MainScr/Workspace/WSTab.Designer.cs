namespace sKez
{
    partial class WSTab
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
#pragma warning disable CS0436 // The type 'WSTab' in 'D:\Uni\OOP\sKez project\sKez\sKez\WSTab.cs' conflicts with the imported type 'WSTab' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\WSTab.cs'.
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WSTab));
#pragma warning restore CS0436 // The type 'WSTab' in 'D:\Uni\OOP\sKez project\sKez\sKez\WSTab.cs' conflicts with the imported type 'WSTab' in 'sKez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'D:\Uni\OOP\sKez project\sKez\sKez\WSTab.cs'.
            this.panel7 = new System.Windows.Forms.Panel();
            this.newBtn = new System.Windows.Forms.Button();
            this.editIcon = new System.Windows.Forms.ImageList(this.components);
            this.BrdCtn = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.newBtn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(864, 39);
            this.panel7.TabIndex = 1;
            // 
            // newBtn
            // 
            this.newBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newBtn.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newBtn.ImageKey = "add-icon.png";
            this.newBtn.ImageList = this.editIcon;
            this.newBtn.Location = new System.Drawing.Point(778, 5);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(72, 28);
            this.newBtn.TabIndex = 0;
            this.newBtn.Text = "New";
            this.newBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // editIcon
            // 
            this.editIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("editIcon.ImageStream")));
            this.editIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.editIcon.Images.SetKeyName(0, "pen-icon.png");
            this.editIcon.Images.SetKeyName(1, "add-icon.png");
            this.editIcon.Images.SetKeyName(2, "delete-icon.png");
            // 
            // BrdCtn
            // 
            this.BrdCtn.AutoScroll = true;
            this.BrdCtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrdCtn.Location = new System.Drawing.Point(0, 39);
            this.BrdCtn.Name = "BrdCtn";
            this.BrdCtn.Size = new System.Drawing.Size(864, 603);
            this.BrdCtn.TabIndex = 2;
            // 
            // WSTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.BrdCtn);
            this.Controls.Add(this.panel7);
            this.Name = "WSTab";
            this.Size = new System.Drawing.Size(864, 642);
            this.Load += new System.EventHandler(this.WSTab_Load);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.ImageList editIcon;
        private System.Windows.Forms.FlowLayoutPanel BrdCtn;
    }
}
