using System.Drawing;
using System.Windows.Forms;

namespace sKez
{
    partial class wpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wpScreen));
            this.narBar = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.quickPanel = new System.Windows.Forms.TableLayoutPanel();
            this.silentNvgBtn = new System.Windows.Forms.Button();
            this.narbarIcon = new System.Windows.Forms.ImageList(this.components);
            this.calendarNvgBtn = new System.Windows.Forms.Button();
            this.calendarBtn = new System.Windows.Forms.Button();
            this.settingNvgBtn = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.Panel();
            this.signupBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userIcon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameTag = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.controlIcon = new System.Windows.Forms.ImageList(this.components);
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pagesTable = new System.Windows.Forms.TableLayoutPanel();
            this.workspaceBtn = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.pageControl = new System.Windows.Forms.TabControl();
            this.wkspcPage = new System.Windows.Forms.TabPage();
            this.wkspacePanel = new System.Windows.Forms.TableLayoutPanel();
            this.newBrd = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.editIcon = new System.Windows.Forms.ImageList(this.components);
            this.dltBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.calendarPage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.calendarIcon = new System.Windows.Forms.ImageList(this.components);
            this.mthvwBtn = new System.Windows.Forms.Button();
            this.dayvwBtn = new System.Windows.Forms.Button();
            this.narBar.SuspendLayout();
            this.quickPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pagesTable.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.pageControl.SuspendLayout();
            this.wkspcPage.SuspendLayout();
            this.wkspacePanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.calendarPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // narBar
            // 
            this.narBar.BackColor = System.Drawing.Color.BlueViolet;
            this.narBar.Controls.Add(this.panel6);
            this.narBar.Controls.Add(this.quickPanel);
            this.narBar.Controls.Add(this.userPanel);
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
            this.silentNvgBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.silentNvgBtn.FlatAppearance.BorderSize = 0;
            this.silentNvgBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.silentNvgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            this.silentNvgBtn.Click += new System.EventHandler(this.silentBtn_Click);
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
            this.calendarNvgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            this.calendarNvgBtn.Size = this.calendarBtn.MinimumSize;
            this.calendarNvgBtn.TabIndex = 5;
            this.calendarNvgBtn.Text = "Calendar";
            this.calendarNvgBtn.UseCompatibleTextRendering = true;
            this.calendarNvgBtn.UseVisualStyleBackColor = true;
            this.calendarNvgBtn.Click += new System.EventHandler(this.calendarBtn_Click_1);
            // 
            // calendarBtn
            // 
            this.calendarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.calendarBtn.FlatAppearance.BorderSize = 0;
            this.calendarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.calendarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.calendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarBtn.Font = new System.Drawing.Font("Meiryo UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.calendarBtn.Location = new System.Drawing.Point(432, 3);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(170, 90);
            this.calendarBtn.TabIndex = 4;
            this.calendarBtn.Text = "Calendar";
            this.calendarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarBtn.UseVisualStyleBackColor = true;
            this.calendarBtn.Click += new System.EventHandler(this.calendarBtn_Click_1);
            // 
            // settingNvgBtn
            // 
            this.settingNvgBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.settingNvgBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingNvgBtn.FlatAppearance.BorderSize = 0;
            this.settingNvgBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingNvgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            this.settingNvgBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.signupBtn);
            this.userPanel.Controls.Add(this.loginBtn);
            this.userPanel.Controls.Add(this.userIcon);
            this.userPanel.Controls.Add(this.panel3);
            this.userPanel.Controls.Add(this.nameTag);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(160, 126);
            this.userPanel.TabIndex = 4;
            this.userPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.userPanel_Paint);
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.signupBtn.FlatAppearance.BorderSize = 0;
            this.signupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.signupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBtn.Font = new System.Drawing.Font("Meiryo UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.Lavender;
            this.signupBtn.Location = new System.Drawing.Point(74, 86);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(82, 36);
            this.signupBtn.TabIndex = 1;
            this.signupBtn.Text = "Sign up";
            this.signupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            this.signupBtn.MouseEnter += new System.EventHandler(this.signupBtn_MouseEnter);
            this.signupBtn.MouseLeave += new System.EventHandler(this.signupBtn_MouseLeave);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Meiryo UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(24, 86);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(57, 36);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Login";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.MouseEnter += new System.EventHandler(this.loginBtn_MouseEnter);
            this.loginBtn.MouseLeave += new System.EventHandler(this.loginBtn_MouseLeave);
            // 
            // userIcon
            // 
            this.userIcon.BackgroundImage = global::sKez.Properties.Resources.user;
            this.userIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIcon.FlatAppearance.BorderSize = 0;
            this.userIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.userIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.userIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIcon.ImageKey = "(none)";
            this.userIcon.Location = new System.Drawing.Point(1, 15);
            this.userIcon.MaximumSize = new System.Drawing.Size(64, 64);
            this.userIcon.MinimumSize = new System.Drawing.Size(40, 40);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(64, 64);
            this.userIcon.TabIndex = 0;
            this.userIcon.TabStop = false;
            this.userIcon.UseVisualStyleBackColor = true;
            this.userIcon.Click += new System.EventHandler(this.userIcon_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(180, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 135);
            this.panel3.TabIndex = 3;
            // 
            // nameTag
            // 
            this.nameTag.AutoEllipsis = true;
            this.nameTag.BackColor = System.Drawing.Color.Transparent;
            this.nameTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameTag.Font = new System.Drawing.Font("Meiryo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTag.Location = new System.Drawing.Point(67, 15);
            this.nameTag.Name = "nameTag";
            this.nameTag.Size = new System.Drawing.Size(93, 64);
            this.nameTag.TabIndex = 3;
            this.nameTag.Text = "Guest";
            this.nameTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameTag.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // header
            // 
            this.header.Controls.Add(this.panel2);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.header);
            this.panel4.Controls.Add(this.pagesTable);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(160, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(864, 126);
            this.panel4.TabIndex = 3;
            // 
            // pagesTable
            // 
            this.pagesTable.ColumnCount = 4;
            this.pagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.17062F));
            this.pagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59242F));
            this.pagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.8673F));
            this.pagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.36967F));
            this.pagesTable.Controls.Add(this.calendarBtn, 2, 0);
            this.pagesTable.Controls.Add(this.workspaceBtn, 1, 0);
            this.pagesTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagesTable.Location = new System.Drawing.Point(0, 30);
            this.pagesTable.Name = "pagesTable";
            this.pagesTable.RowCount = 1;
            this.pagesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pagesTable.Size = new System.Drawing.Size(864, 96);
            this.pagesTable.TabIndex = 4;
            // 
            // workspaceBtn
            // 
            this.workspaceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workspaceBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.workspaceBtn.FlatAppearance.BorderSize = 0;
            this.workspaceBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.workspaceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.workspaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workspaceBtn.Font = new System.Drawing.Font("Meiryo UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workspaceBtn.ForeColor = System.Drawing.Color.Black;
            this.workspaceBtn.Location = new System.Drawing.Point(224, 3);
            this.workspaceBtn.Name = "workspaceBtn";
            this.workspaceBtn.Size = new System.Drawing.Size(202, 90);
            this.workspaceBtn.TabIndex = 0;
            this.workspaceBtn.Text = "Workspace";
            this.workspaceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.workspaceBtn.UseVisualStyleBackColor = true;
            this.workspaceBtn.Click += new System.EventHandler(this.workspaceBtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.Controls.Add(this.pageControl);
            this.contentPanel.Location = new System.Drawing.Point(160, 126);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(864, 642);
            this.contentPanel.TabIndex = 4;
            // 
            // pageControl
            // 
            this.pageControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageControl.Controls.Add(this.wkspcPage);
            this.pageControl.Controls.Add(this.calendarPage);
            this.pageControl.Location = new System.Drawing.Point(-13, -26);
            this.pageControl.Name = "pageControl";
            this.pageControl.SelectedIndex = 0;
            this.pageControl.Size = new System.Drawing.Size(884, 679);
            this.pageControl.TabIndex = 2;
            // 
            // wkspcPage
            // 
            this.wkspcPage.BackColor = System.Drawing.Color.Lavender;
            this.wkspcPage.Controls.Add(this.wkspacePanel);
            this.wkspcPage.Controls.Add(this.panel7);
            this.wkspcPage.Location = new System.Drawing.Point(4, 25);
            this.wkspcPage.Name = "wkspcPage";
            this.wkspcPage.Padding = new System.Windows.Forms.Padding(3);
            this.wkspcPage.Size = new System.Drawing.Size(876, 650);
            this.wkspcPage.TabIndex = 0;
            this.wkspcPage.Text = "tabPage1";
            // 
            // wkspacePanel
            // 
            this.wkspacePanel.AutoScroll = true;
            this.wkspacePanel.ColumnCount = 6;
            this.wkspacePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.wkspacePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.wkspacePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.wkspacePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.wkspacePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.wkspacePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.wkspacePanel.Controls.Add(this.newBrd, 1, 0);
            this.wkspacePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.wkspacePanel.Location = new System.Drawing.Point(3, 42);
            this.wkspacePanel.Name = "wkspacePanel";
            this.wkspacePanel.RowCount = 4;
            this.wkspacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.wkspacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.wkspacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.wkspacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wkspacePanel.Size = new System.Drawing.Size(870, 603);
            this.wkspacePanel.TabIndex = 0;
            // 
            // newBrd
            // 
            this.newBrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newBrd.Font = new System.Drawing.Font("Meiryo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBrd.Location = new System.Drawing.Point(37, 12);
            this.newBrd.Margin = new System.Windows.Forms.Padding(12);
            this.newBrd.MaximumSize = new System.Drawing.Size(172, 172);
            this.newBrd.MinimumSize = new System.Drawing.Size(172, 172);
            this.newBrd.Name = "newBrd";
            this.newBrd.Size = new System.Drawing.Size(172, 172);
            this.newBrd.TabIndex = 0;
            this.newBrd.Text = "New Board";
            this.newBrd.UseVisualStyleBackColor = true;
            this.newBrd.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.editBtn);
            this.panel7.Controls.Add(this.dltBtn);
            this.panel7.Controls.Add(this.cancelBtn);
            this.panel7.Controls.Add(this.newBtn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(870, 39);
            this.panel7.TabIndex = 1;
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBtn.ImageKey = "pen-icon.png";
            this.editBtn.ImageList = this.editIcon;
            this.editBtn.Location = new System.Drawing.Point(759, 5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(72, 28);
            this.editBtn.TabIndex = 0;
            this.editBtn.Text = "Edit\r\n";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // editIcon
            // 
            this.editIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("editIcon.ImageStream")));
            this.editIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.editIcon.Images.SetKeyName(0, "pen-icon.png");
            this.editIcon.Images.SetKeyName(1, "add-icon.png");
            this.editIcon.Images.SetKeyName(2, "delete-icon.png");
            // 
            // dltBtn
            // 
            this.dltBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dltBtn.BackColor = System.Drawing.Color.Red;
            this.dltBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.dltBtn.FlatAppearance.BorderSize = 0;
            this.dltBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dltBtn.ImageKey = "delete-icon.png";
            this.dltBtn.ImageList = this.editIcon;
            this.dltBtn.Location = new System.Drawing.Point(838, 6);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(25, 25);
            this.dltBtn.TabIndex = 5;
            this.dltBtn.UseVisualStyleBackColor = false;
            this.dltBtn.Visible = false;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.ImageKey = "pen-icon.png";
            this.cancelBtn.Location = new System.Drawing.Point(676, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(78, 28);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newBtn.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newBtn.ImageKey = "add-icon.png";
            this.newBtn.ImageList = this.editIcon;
            this.newBtn.Location = new System.Drawing.Point(759, 5);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(72, 28);
            this.newBtn.TabIndex = 0;
            this.newBtn.Text = "New";
            this.newBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Visible = false;
            // 
            // calendarPage
            // 
            this.calendarPage.BackColor = System.Drawing.Color.Lavender;
            this.calendarPage.Controls.Add(this.button2);
            this.calendarPage.Controls.Add(this.mthvwBtn);
            this.calendarPage.Controls.Add(this.dayvwBtn);
            this.calendarPage.Location = new System.Drawing.Point(4, 25);
            this.calendarPage.Name = "calendarPage";
            this.calendarPage.Padding = new System.Windows.Forms.Padding(3);
            this.calendarPage.Size = new System.Drawing.Size(876, 650);
            this.calendarPage.TabIndex = 1;
            this.calendarPage.Text = "calendarPage";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "Month View.png";
            this.button2.ImageList = this.calendarIcon;
            this.button2.Location = new System.Drawing.Point(816, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // calendarIcon
            // 
            this.calendarIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("calendarIcon.ImageStream")));
            this.calendarIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.calendarIcon.Images.SetKeyName(0, "Day View.png");
            this.calendarIcon.Images.SetKeyName(1, "Week View.png");
            this.calendarIcon.Images.SetKeyName(2, "Month View.png");
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
            this.mthvwBtn.Location = new System.Drawing.Point(774, 19);
            this.mthvwBtn.Name = "mthvwBtn";
            this.mthvwBtn.Size = new System.Drawing.Size(36, 32);
            this.mthvwBtn.TabIndex = 0;
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
            this.dayvwBtn.Location = new System.Drawing.Point(732, 19);
            this.dayvwBtn.Name = "dayvwBtn";
            this.dayvwBtn.Size = new System.Drawing.Size(36, 32);
            this.dayvwBtn.TabIndex = 0;
            this.dayvwBtn.UseVisualStyleBackColor = true;
            // 
            // wpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.narBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "wpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.narBar.ResumeLayout(false);
            this.quickPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pagesTable.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.pageControl.ResumeLayout(false);
            this.wkspcPage.ResumeLayout(false);
            this.wkspacePanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.calendarPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel narBar;
        private System.Windows.Forms.ImageList narbarIcon;
        private Panel panel6;
        private Panel userPanel;
        private Button settingNvgBtn;
        private Button silentNvgBtn;
        private Button calendarNvgBtn;
        private Button loginBtn;
        private Label nameTag;
        private Button signupBtn;
        private Panel header;
        private Panel panel2;
        private Button minimizeBtn;
        private ImageList controlIcon;
        private Button closeBtn;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel pagesTable;
        private Button calendarBtn;
        private Button workspaceBtn;
        private Panel contentPanel;
        private TableLayoutPanel wkspacePanel;
        private Panel panel7;
        private Button newBrd;
        private ImageList editIcon;
        private Button dltBtn;
        private Button newBtn;
        private Button editBtn;
        private Button cancelBtn;
        private Button userIcon;
        private TableLayoutPanel quickPanel;
        private TabControl pageControl;
        private TabPage wkspcPage;
        private TabPage calendarPage;
        private Button dayvwBtn;
        private ImageList calendarIcon;
        private Button mthvwBtn;
        private Button button2;
    }
}

