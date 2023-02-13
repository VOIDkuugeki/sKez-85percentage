namespace sKez
{
    partial class BoardScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardScreen));
            this.editIcon = new System.Windows.Forms.ImageList(this.components);
            this.newBrd = new System.Windows.Forms.Button();
            this.taskPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.taskPage = new System.Windows.Forms.TabPage();
            this.progressPage = new System.Windows.Forms.TabPage();
            this.taskBtn = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.controlIcon = new System.Windows.Forms.ImageList(this.components);
            this.pagesTable = new System.Windows.Forms.TableLayoutPanel();
            this.progressBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.signinBtn = new System.Windows.Forms.Button();
            this.nameTag = new System.Windows.Forms.Label();
            this.narbarIcon = new System.Windows.Forms.ImageList(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.quickPanel = new System.Windows.Forms.TableLayoutPanel();
            this.narBar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.silentNvgBtn = new System.Windows.Forms.Button();
            this.calendarNvgBtn = new System.Windows.Forms.Button();
            this.settingNvgBtn = new System.Windows.Forms.Button();
            this.userIcon = new System.Windows.Forms.Button();
            this.taskPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.taskPage.SuspendLayout();
            this.top.SuspendLayout();
            this.header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pagesTable.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.quickPanel.SuspendLayout();
            this.narBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // editIcon
            // 
            this.editIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("editIcon.ImageStream")));
            this.editIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.editIcon.Images.SetKeyName(0, "pin-icon.png");
            this.editIcon.Images.SetKeyName(1, "add-icon.png");
            this.editIcon.Images.SetKeyName(2, "delete-icon.png");
            // 
            // newBrd
            // 
            this.newBrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newBrd.Font = new System.Drawing.Font("Meiryo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBrd.Location = new System.Drawing.Point(92, 169);
            this.newBrd.Margin = new System.Windows.Forms.Padding(12);
            this.newBrd.MaximumSize = new System.Drawing.Size(172, 172);
            this.newBrd.MinimumSize = new System.Drawing.Size(172, 172);
            this.newBrd.Name = "newBrd";
            this.newBrd.Size = new System.Drawing.Size(172, 172);
            this.newBrd.TabIndex = 0;
            this.newBrd.Text = "New Board";
            this.newBrd.UseVisualStyleBackColor = true;
            this.newBrd.Click += new System.EventHandler(this.newBrd_Click);
            // 
            // taskPanel
            // 
            this.taskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskPanel.Controls.Add(this.tabControl);
            this.taskPanel.Location = new System.Drawing.Point(160, 126);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(864, 642);
            this.taskPanel.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.taskPage);
            this.tabControl.Controls.Add(this.progressPage);
            this.tabControl.Location = new System.Drawing.Point(-10, -40);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(881, 691);
            this.tabControl.TabIndex = 8;
            // 
            // taskPage
            // 
            this.taskPage.BackColor = System.Drawing.Color.Lavender;
            this.taskPage.Controls.Add(this.newBrd);
            this.taskPage.Controls.Add(this.button2);
            this.taskPage.Location = new System.Drawing.Point(4, 25);
            this.taskPage.Name = "taskPage";
            this.taskPage.Padding = new System.Windows.Forms.Padding(3);
            this.taskPage.Size = new System.Drawing.Size(873, 662);
            this.taskPage.TabIndex = 0;
            this.taskPage.Text = "taskPage";
            // 
            // progressPage
            // 
            this.progressPage.BackColor = System.Drawing.Color.Lavender;
            this.progressPage.Location = new System.Drawing.Point(4, 25);
            this.progressPage.Name = "progressPage";
            this.progressPage.Padding = new System.Windows.Forms.Padding(3);
            this.progressPage.Size = new System.Drawing.Size(873, 662);
            this.progressPage.TabIndex = 1;
            this.progressPage.Text = "Progress";
            // 
            // taskBtn
            // 
            this.taskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.taskBtn.FlatAppearance.BorderSize = 0;
            this.taskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.taskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.taskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskBtn.Font = new System.Drawing.Font("Meiryo UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskBtn.Location = new System.Drawing.Point(323, 3);
            this.taskBtn.Name = "taskBtn";
            this.taskBtn.Size = new System.Drawing.Size(103, 90);
            this.taskBtn.TabIndex = 0;
            this.taskBtn.Text = "Task";
            this.taskBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taskBtn.UseVisualStyleBackColor = true;
            // 
            // top
            // 
            this.top.Controls.Add(this.header);
            this.top.Controls.Add(this.pagesTable);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(160, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(864, 126);
            this.top.TabIndex = 6;
            // 
            // header
            // 
            this.header.Controls.Add(this.panel2);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(864, 30);
            this.header.TabIndex = 2;
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
            // controlIcon
            // 
            this.controlIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("controlIcon.ImageStream")));
            this.controlIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.controlIcon.Images.SetKeyName(0, "close-icon.png");
            this.controlIcon.Images.SetKeyName(1, "minimize-icon.png");
            this.controlIcon.Images.SetKeyName(2, "leftArr-icon.png");
            // 
            // pagesTable
            // 
            this.pagesTable.ColumnCount = 4;
            this.pagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.17062F));
            this.pagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59242F));
            this.pagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.8673F));
            this.pagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.36967F));
            this.pagesTable.Controls.Add(this.progressBtn, 2, 0);
            this.pagesTable.Controls.Add(this.taskBtn, 1, 0);
            this.pagesTable.Controls.Add(this.backBtn, 0, 0);
            this.pagesTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagesTable.Location = new System.Drawing.Point(0, 30);
            this.pagesTable.Name = "pagesTable";
            this.pagesTable.RowCount = 1;
            this.pagesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pagesTable.Size = new System.Drawing.Size(864, 96);
            this.pagesTable.TabIndex = 4;
            // 
            // progressBtn
            // 
            this.progressBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBtn.FlatAppearance.BorderSize = 0;
            this.progressBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.progressBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.progressBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.progressBtn.Font = new System.Drawing.Font("Meiryo UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.progressBtn.Location = new System.Drawing.Point(432, 3);
            this.progressBtn.Name = "progressBtn";
            this.progressBtn.Size = new System.Drawing.Size(173, 90);
            this.progressBtn.TabIndex = 4;
            this.progressBtn.Text = "Progress";
            this.progressBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.progressBtn.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(180, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 135);
            this.panel3.TabIndex = 3;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.signinBtn);
            this.userPanel.Controls.Add(this.loginBtn);
            this.userPanel.Controls.Add(this.userIcon);
            this.userPanel.Controls.Add(this.panel3);
            this.userPanel.Controls.Add(this.nameTag);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(160, 126);
            this.userPanel.TabIndex = 4;
            // 
            // signinBtn
            // 
            this.signinBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.signinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signinBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.signinBtn.FlatAppearance.BorderSize = 0;
            this.signinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.signinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.signinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinBtn.Font = new System.Drawing.Font("Meiryo UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinBtn.ForeColor = System.Drawing.Color.Lavender;
            this.signinBtn.Location = new System.Drawing.Point(72, 86);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(69, 36);
            this.signinBtn.TabIndex = 4;
            this.signinBtn.Text = "Sign in";
            this.signinBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signinBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.signinBtn.UseVisualStyleBackColor = true;
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
            this.quickPanel.MaximumSize = new System.Drawing.Size(180, 196);
            this.quickPanel.MinimumSize = new System.Drawing.Size(40, 120);
            this.quickPanel.Name = "quickPanel";
            this.quickPanel.RowCount = 3;
            this.quickPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.quickPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.quickPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.quickPanel.Size = this.quickPanel.MinimumSize;
            this.quickPanel.TabIndex = 5;
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
            this.narBar.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.ImageKey = "pin-icon.png";
            this.button2.ImageList = this.editIcon;
            this.button2.Location = new System.Drawing.Point(799, 587);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 64);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
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
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.ImageKey = "leftArr-icon.png";
            this.backBtn.ImageList = this.controlIcon;
            this.backBtn.Location = new System.Drawing.Point(3, 29);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(76, 37);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Back";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // silentNvgBtn
            // 
            this.silentNvgBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.silentNvgBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.silentNvgBtn.FlatAppearance.BorderSize = 0;
            this.silentNvgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silentNvgBtn.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silentNvgBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.silentNvgBtn.ImageIndex = 0;
            this.silentNvgBtn.ImageList = this.narbarIcon;
            this.silentNvgBtn.Location = new System.Drawing.Point(3, 43);
            this.silentNvgBtn.MaximumSize = new System.Drawing.Size(174, 59);
            this.silentNvgBtn.MinimumSize = new System.Drawing.Size(40, 40);
            this.silentNvgBtn.Name = "silentNvgBtn";
            this.silentNvgBtn.Size = this.silentNvgBtn.MinimumSize;
            this.silentNvgBtn.TabIndex = 4;
            this.silentNvgBtn.Text = "Silent";
            this.silentNvgBtn.UseCompatibleTextRendering = true;
            this.silentNvgBtn.UseVisualStyleBackColor = false;
            // 
            // calendarNvgBtn
            // 
            this.calendarNvgBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarNvgBtn.FlatAppearance.BorderSize = 0;
            this.calendarNvgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarNvgBtn.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarNvgBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarNvgBtn.ImageIndex = 2;
            this.calendarNvgBtn.ImageList = this.narbarIcon;
            this.calendarNvgBtn.Location = new System.Drawing.Point(3, 3);
            this.calendarNvgBtn.MaximumSize = new System.Drawing.Size(174, 59);
            this.calendarNvgBtn.MinimumSize = new System.Drawing.Size(40, 40);
            this.calendarNvgBtn.Name = "calendarNvgBtn";
            this.calendarNvgBtn.Size = this.progressBtn.MinimumSize;
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
            // 
            // boardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.taskPanel);
            this.Controls.Add(this.top);
            this.Controls.Add(this.narBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "boardScreen";
            this.Text = "calendarScreen";
            this.Load += new System.EventHandler(this.calendarScreen_Load);
            this.taskPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.taskPage.ResumeLayout(false);
            this.top.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pagesTable.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.quickPanel.ResumeLayout(false);
            this.narBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList editIcon;
        private System.Windows.Forms.Button newBrd;
        private System.Windows.Forms.Panel taskPanel;
        private System.Windows.Forms.Button taskBtn;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.ImageList controlIcon;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TableLayoutPanel pagesTable;
        private System.Windows.Forms.Button progressBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button userIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Label nameTag;
        private System.Windows.Forms.Button settingNvgBtn;
        private System.Windows.Forms.ImageList narbarIcon;
        private System.Windows.Forms.Button calendarNvgBtn;
        private System.Windows.Forms.Button silentNvgBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel quickPanel;
        private System.Windows.Forms.Panel narBar;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage taskPage;
        private System.Windows.Forms.TabPage progressPage;
        private System.Windows.Forms.Button signinBtn;
    }
}