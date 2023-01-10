using System.Drawing;
using System.Windows.Forms;

namespace sKez
{
    partial class mainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainScreen));
            this.narBar = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.quickPanel = new System.Windows.Forms.TableLayoutPanel();
            this.silentNvgBtn = new System.Windows.Forms.Button();
            this.narbarIcon = new System.Windows.Forms.ImageList(this.components);
            this.calendarNvgBtn = new System.Windows.Forms.Button();
            this.settingNvgBtn = new System.Windows.Forms.Button();
            this.userPnl1 = new sKez.userPnl();
            this.header = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.controlIcon = new System.Windows.Forms.ImageList(this.components);
            this.closeBtn = new System.Windows.Forms.Button();
            this.editIcon = new System.Windows.Forms.ImageList(this.components);
            this.content = new System.Windows.Forms.Panel();
            this.mainPg1 = new sKez.mainPg();
            this.narBar.SuspendLayout();
            this.quickPanel.SuspendLayout();
            this.header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // narBar
            // 
            this.narBar.BackColor = System.Drawing.Color.BlueViolet;
            this.narBar.Controls.Add(this.panel6);
            this.narBar.Controls.Add(this.quickPanel);
            this.narBar.Controls.Add(this.userPnl1);
            this.narBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.narBar.Location = new System.Drawing.Point(0, 0);
            this.narBar.Margin = new System.Windows.Forms.Padding(0);
            this.narBar.MaximumSize = new System.Drawing.Size(160, 768);
            this.narBar.MinimumSize = new System.Drawing.Size(160, 768);
            this.narBar.Name = "narBar";
            this.narBar.Size = new System.Drawing.Size(160, 768);
            this.narBar.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 126);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 522);
            this.panel6.TabIndex = 1;
            // 
            // quickPanel
            // 
            this.quickPanel.ColumnCount = 1;
            this.quickPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.quickPanel.Controls.Add(this.silentNvgBtn, 0, 1);
            this.quickPanel.Controls.Add(this.calendarNvgBtn, 0, 0);
            this.quickPanel.Controls.Add(this.settingNvgBtn, 0, 2);
            this.quickPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.quickPanel.Location = new System.Drawing.Point(0, 648);
            this.quickPanel.Margin = new System.Windows.Forms.Padding(0);
            this.quickPanel.MaximumSize = new System.Drawing.Size(160, 120);
            this.quickPanel.MinimumSize = new System.Drawing.Size(160, 120);
            this.quickPanel.Name = "quickPanel";
            this.quickPanel.RowCount = 3;
            this.quickPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.quickPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.quickPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.quickPanel.Size = this.quickPanel.MinimumSize;
            this.quickPanel.TabIndex = 5;
            // 
            // silentNvgBtn
            // 
            this.silentNvgBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.silentNvgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.silentNvgBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.silentNvgBtn.FlatAppearance.BorderSize = 0;
            this.silentNvgBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.silentNvgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.silentNvgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silentNvgBtn.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silentNvgBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.silentNvgBtn.ImageIndex = 0;
            this.silentNvgBtn.ImageList = this.narbarIcon;
            this.silentNvgBtn.Location = new System.Drawing.Point(0, 40);
            this.silentNvgBtn.Margin = new System.Windows.Forms.Padding(0);
            this.silentNvgBtn.MaximumSize = new System.Drawing.Size(174, 59);
            this.silentNvgBtn.MinimumSize = new System.Drawing.Size(40, 40);
            this.silentNvgBtn.Name = "silentNvgBtn";
            this.silentNvgBtn.Size = this.silentNvgBtn.MinimumSize;
            this.silentNvgBtn.TabIndex = 4;
            this.silentNvgBtn.Text = "Silent";
            this.silentNvgBtn.UseCompatibleTextRendering = true;
            this.silentNvgBtn.UseVisualStyleBackColor = false;
            // 
            // narbarIcon
            // 
            this.narbarIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("narbarIcon.ImageStream")));
            this.narbarIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.narbarIcon.Images.SetKeyName(0, "bell-icon.png");
            this.narbarIcon.Images.SetKeyName(1, "setting-icon.png");
            this.narbarIcon.Images.SetKeyName(2, "calendarIcon.png");
            this.narbarIcon.Images.SetKeyName(3, "user.png");
            // 
            // calendarNvgBtn
            // 
            this.calendarNvgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarNvgBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarNvgBtn.FlatAppearance.BorderSize = 0;
            this.calendarNvgBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.calendarNvgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.calendarNvgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarNvgBtn.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarNvgBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarNvgBtn.ImageIndex = 2;
            this.calendarNvgBtn.ImageList = this.narbarIcon;
            this.calendarNvgBtn.Location = new System.Drawing.Point(0, 0);
            this.calendarNvgBtn.Margin = new System.Windows.Forms.Padding(0);
            this.calendarNvgBtn.MaximumSize = new System.Drawing.Size(174, 59);
            this.calendarNvgBtn.MinimumSize = new System.Drawing.Size(40, 40);
            this.calendarNvgBtn.Name = "calendarNvgBtn";
            this.calendarNvgBtn.Size = new System.Drawing.Size(160, 40);
            this.calendarNvgBtn.TabIndex = 5;
            this.calendarNvgBtn.Text = "Calendar";
            this.calendarNvgBtn.UseCompatibleTextRendering = true;
            this.calendarNvgBtn.UseVisualStyleBackColor = true;
            // 
            // settingNvgBtn
            // 
            this.settingNvgBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.settingNvgBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingNvgBtn.FlatAppearance.BorderSize = 0;
            this.settingNvgBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingNvgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.settingNvgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingNvgBtn.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingNvgBtn.ForeColor = System.Drawing.Color.Black;
            this.settingNvgBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingNvgBtn.ImageIndex = 1;
            this.settingNvgBtn.ImageList = this.narbarIcon;
            this.settingNvgBtn.Location = new System.Drawing.Point(0, 80);
            this.settingNvgBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingNvgBtn.MaximumSize = new System.Drawing.Size(174, 59);
            this.settingNvgBtn.MinimumSize = new System.Drawing.Size(40, 40);
            this.settingNvgBtn.Name = "settingNvgBtn";
            this.settingNvgBtn.Size = this.settingNvgBtn.MinimumSize;
            this.settingNvgBtn.TabIndex = 0;
            this.settingNvgBtn.Text = "Setting";
            this.settingNvgBtn.UseCompatibleTextRendering = true;
            this.settingNvgBtn.UseVisualStyleBackColor = false;
            // 
            // userPnl1
            // 
            this.userPnl1.AccessibleName = "userPnl";
            this.userPnl1.BackColor = System.Drawing.Color.BlueViolet;
            this.userPnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPnl1.Location = new System.Drawing.Point(0, 0);
            this.userPnl1.Name = "userPnl1";
            this.userPnl1.Size = new System.Drawing.Size(160, 126);
            this.userPnl1.TabIndex = 0;
            // 
            // header
            // 
            this.header.Controls.Add(this.panel2);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(160, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(864, 30);
            this.header.TabIndex = 2;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.minimizeBtn);
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(797, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 30);
            this.panel2.TabIndex = 3;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ImageKey = "minimize-icon.png";
            this.minimizeBtn.ImageList = this.controlIcon;
            this.minimizeBtn.Location = new System.Drawing.Point(13, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(24, 24);
            this.minimizeBtn.TabIndex = 0;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // controlIcon
            // 
            this.controlIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("controlIcon.ImageStream")));
            this.controlIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.controlIcon.Images.SetKeyName(0, "close-icon.png");
            this.controlIcon.Images.SetKeyName(1, "minimize-icon.png");
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ImageKey = "close-icon.png";
            this.closeBtn.ImageList = this.controlIcon;
            this.closeBtn.Location = new System.Drawing.Point(43, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(24, 24);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // editIcon
            // 
            this.editIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("editIcon.ImageStream")));
            this.editIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.editIcon.Images.SetKeyName(0, "pen-icon.png");
            this.editIcon.Images.SetKeyName(1, "add-icon.png");
            this.editIcon.Images.SetKeyName(2, "delete-icon.png");
            // 
            // content
            // 
            this.content.Controls.Add(this.mainPg1);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(160, 30);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(864, 738);
            this.content.TabIndex = 3;
            // 
            // mainPg1
            // 
            this.mainPg1.BackColor = System.Drawing.Color.Lavender;
            this.mainPg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPg1.Location = new System.Drawing.Point(0, 0);
            this.mainPg1.Name = "mainPg1";
            this.mainPg1.Size = new System.Drawing.Size(864, 738);
            this.mainPg1.TabIndex = 0;
            // 
            // mainScreen
            // 
            this.AccessibleName = "mscr";
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.content);
            this.Controls.Add(this.header);
            this.Controls.Add(this.narBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "mainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainScreen_FormClosed);
            this.narBar.ResumeLayout(false);
            this.quickPanel.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel narBar;
        private System.Windows.Forms.ImageList narbarIcon;
        private Panel panel6;
        private Button settingNvgBtn;
        private Button silentNvgBtn;
        private Button calendarNvgBtn;
        private Panel header;
        private Panel panel2;
        private Button minimizeBtn;
        private ImageList controlIcon;
        private Button closeBtn;
        private ImageList editIcon;
        private TableLayoutPanel quickPanel;
        private userPnl userPnl1;
        private Panel content;
        private mainPg mainPg1;
    }
}

