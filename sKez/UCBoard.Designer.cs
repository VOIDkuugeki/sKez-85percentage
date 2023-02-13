namespace sKez
{
    partial class UCBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBoard));
            this.BrdBtn = new System.Windows.Forms.Button();
            this.SettingIcon = new System.Windows.Forms.ImageList(this.components);
            this.settingBtn = new System.Windows.Forms.Button();
            this.BoardMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoardMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrdBtn
            // 
            this.BrdBtn.AutoEllipsis = true;
            this.BrdBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BrdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrdBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrdBtn.FlatAppearance.BorderSize = 0;
            this.BrdBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.BrdBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BrdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrdBtn.Font = new System.Drawing.Font("Meiryo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrdBtn.Location = new System.Drawing.Point(0, 0);
            this.BrdBtn.Margin = new System.Windows.Forms.Padding(0);
            this.BrdBtn.MaximumSize = new System.Drawing.Size(172, 172);
            this.BrdBtn.MinimumSize = new System.Drawing.Size(172, 172);
            this.BrdBtn.Name = "BrdBtn";
            this.BrdBtn.Size = new System.Drawing.Size(172, 172);
            this.BrdBtn.TabIndex = 1;
            this.BrdBtn.UseVisualStyleBackColor = false;
            this.BrdBtn.MouseEnter += new System.EventHandler(this.BrdBtn_MouseEnter);
            this.BrdBtn.MouseLeave += new System.EventHandler(this.BrdBtn_MouseLeave);
            // 
            // SettingIcon
            // 
            this.SettingIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SettingIcon.ImageStream")));
            this.SettingIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.SettingIcon.Images.SetKeyName(0, "option-icon.png");
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.settingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.settingBtn.ImageIndex = 0;
            this.settingBtn.ImageList = this.SettingIcon;
            this.settingBtn.Location = new System.Drawing.Point(131, 3);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(36, 36);
            this.settingBtn.TabIndex = 2;
            this.settingBtn.TabStop = false;
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Visible = false;
            this.settingBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.settingBtn_MouseClick);
            // 
            // BoardMenu
            // 
            this.BoardMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BoardMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.BoardMenu.Name = "BoardMenu";
            this.BoardMenu.ShowImageMargin = false;
            this.BoardMenu.Size = new System.Drawing.Size(186, 80);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // UCBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.BoardMenu;
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.BrdBtn);
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "UCBoard";
            this.Size = new System.Drawing.Size(172, 172);
            this.BoardMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BrdBtn;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.ImageList SettingIcon;
        private System.Windows.Forms.ContextMenuStrip BoardMenu;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
