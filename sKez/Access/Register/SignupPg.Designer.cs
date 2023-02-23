namespace sKez
{
    partial class SignupPg
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.header = new System.Windows.Forms.Panel();
            this.strongPwd = new System.Windows.Forms.Label();
            this.matchPwd = new System.Windows.Forms.Label();
            this.unavailableUsername = new System.Windows.Forms.Label();
            this.txt_pwdcfm = new System.Windows.Forms.TextBox();
            this.pwd_cfmLbl = new System.Windows.Forms.Label();
            this.confirmPnl = new System.Windows.Forms.Panel();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.pwdBx = new System.Windows.Forms.TextBox();
            this.txt_usrname = new System.Windows.Forms.TextBox();
            this.pwdLbl = new System.Windows.Forms.Label();
            this.usrnameLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cdtPwd = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.header.SuspendLayout();
            this.confirmPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Lavender;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.header, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 600);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // header
            // 
            this.header.Controls.Add(this.strongPwd);
            this.header.Controls.Add(this.matchPwd);
            this.header.Controls.Add(this.unavailableUsername);
            this.header.Controls.Add(this.txt_pwdcfm);
            this.header.Controls.Add(this.pwd_cfmLbl);
            this.header.Controls.Add(this.confirmPnl);
            this.header.Controls.Add(this.pwdBx);
            this.header.Controls.Add(this.txt_usrname);
            this.header.Controls.Add(this.pwdLbl);
            this.header.Controls.Add(this.usrnameLbl);
            this.header.Location = new System.Drawing.Point(108, 3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(484, 594);
            this.header.TabIndex = 0;
            // 
            // strongPwd
            // 
            this.strongPwd.AutoSize = true;
            this.strongPwd.BackColor = System.Drawing.Color.Transparent;
            this.strongPwd.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strongPwd.ForeColor = System.Drawing.Color.Red;
            this.strongPwd.Location = new System.Drawing.Point(32, 305);
            this.strongPwd.Name = "strongPwd";
            this.strongPwd.Size = new System.Drawing.Size(374, 25);
            this.strongPwd.TabIndex = 10;
            this.strongPwd.Text = "The password does not meet the conditions";
            this.strongPwd.Visible = false;
            // 
            // matchPwd
            // 
            this.matchPwd.AutoSize = true;
            this.matchPwd.BackColor = System.Drawing.Color.Transparent;
            this.matchPwd.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchPwd.ForeColor = System.Drawing.Color.Red;
            this.matchPwd.Location = new System.Drawing.Point(32, 384);
            this.matchPwd.Name = "matchPwd";
            this.matchPwd.Size = new System.Drawing.Size(250, 25);
            this.matchPwd.TabIndex = 9;
            this.matchPwd.Text = "The password doesn\'t match";
            this.matchPwd.Visible = false;
            // 
            // unavailableUsername
            // 
            this.unavailableUsername.AutoSize = true;
            this.unavailableUsername.BackColor = System.Drawing.Color.Transparent;
            this.unavailableUsername.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unavailableUsername.ForeColor = System.Drawing.Color.Red;
            this.unavailableUsername.Location = new System.Drawing.Point(32, 226);
            this.unavailableUsername.Name = "unavailableUsername";
            this.unavailableUsername.Size = new System.Drawing.Size(251, 25);
            this.unavailableUsername.TabIndex = 8;
            this.unavailableUsername.Text = "The username is unavailable";
            this.unavailableUsername.Visible = false;
            // 
            // txt_pwdcfm
            // 
            this.txt_pwdcfm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_pwdcfm.Font = new System.Drawing.Font("Meiryo", 9F);
            this.txt_pwdcfm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_pwdcfm.Location = new System.Drawing.Point(34, 352);
            this.txt_pwdcfm.Name = "txt_pwdcfm";
            this.txt_pwdcfm.PasswordChar = '●';
            this.txt_pwdcfm.Size = new System.Drawing.Size(420, 30);
            this.txt_pwdcfm.TabIndex = 3;
            this.txt_pwdcfm.UseSystemPasswordChar = true;
            this.txt_pwdcfm.WordWrap = false;
            this.txt_pwdcfm.Click += new System.EventHandler(this.txt_pwdcfm_Click);
            this.txt_pwdcfm.Leave += new System.EventHandler(this.txt_pwdcfm_Leave);
            // 
            // pwd_cfmLbl
            // 
            this.pwd_cfmLbl.AutoSize = true;
            this.pwd_cfmLbl.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.pwd_cfmLbl.Location = new System.Drawing.Point(30, 324);
            this.pwd_cfmLbl.Name = "pwd_cfmLbl";
            this.pwd_cfmLbl.Size = new System.Drawing.Size(188, 25);
            this.pwd_cfmLbl.TabIndex = 6;
            this.pwd_cfmLbl.Text = "Confirm password";
            this.pwd_cfmLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmPnl
            // 
            this.confirmPnl.BackColor = System.Drawing.Color.Transparent;
            this.confirmPnl.Controls.Add(this.confirmBtn);
            this.confirmPnl.Location = new System.Drawing.Point(139, 417);
            this.confirmPnl.Margin = new System.Windows.Forms.Padding(0);
            this.confirmPnl.Name = "confirmPnl";
            this.confirmPnl.Padding = new System.Windows.Forms.Padding(3);
            this.confirmPnl.Size = new System.Drawing.Size(180, 85);
            this.confirmPnl.TabIndex = 5;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Meiryo UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.confirmBtn.ImageIndex = 0;
            this.confirmBtn.Location = new System.Drawing.Point(3, 3);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(0);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Padding = new System.Windows.Forms.Padding(5);
            this.confirmBtn.Size = new System.Drawing.Size(174, 79);
            this.confirmBtn.TabIndex = 4;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            this.confirmBtn.MouseLeave += new System.EventHandler(this.confirmBtn_MouseLeave);
            this.confirmBtn.MouseHover += new System.EventHandler(this.confirmBtn_MouseHover);
            // 
            // pwdBx
            // 
            this.pwdBx.Font = new System.Drawing.Font("Meiryo", 9F);
            this.pwdBx.Location = new System.Drawing.Point(32, 273);
            this.pwdBx.Name = "pwdBx";
            this.pwdBx.PasswordChar = '●';
            this.pwdBx.Size = new System.Drawing.Size(420, 30);
            this.pwdBx.TabIndex = 2;
            this.pwdBx.UseSystemPasswordChar = true;
            this.pwdBx.Click += new System.EventHandler(this.pwdBx_Click);
            this.pwdBx.Leave += new System.EventHandler(this.pwdBx_Leave);
            // 
            // txt_usrname
            // 
            this.txt_usrname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_usrname.Font = new System.Drawing.Font("Meiryo", 9F);
            this.txt_usrname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_usrname.Location = new System.Drawing.Point(32, 194);
            this.txt_usrname.Name = "txt_usrname";
            this.txt_usrname.Size = new System.Drawing.Size(420, 30);
            this.txt_usrname.TabIndex = 1;
            this.txt_usrname.WordWrap = false;
            this.txt_usrname.Click += new System.EventHandler(this.txt_usrname_Click);
            this.txt_usrname.Leave += new System.EventHandler(this.txt_usrname_Leave);
            // 
            // pwdLbl
            // 
            this.pwdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pwdLbl.AutoSize = true;
            this.pwdLbl.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.pwdLbl.Location = new System.Drawing.Point(28, 245);
            this.pwdLbl.Name = "pwdLbl";
            this.pwdLbl.Size = new System.Drawing.Size(105, 25);
            this.pwdLbl.TabIndex = 0;
            this.pwdLbl.Text = "Password";
            this.pwdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usrnameLbl
            // 
            this.usrnameLbl.AutoSize = true;
            this.usrnameLbl.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.usrnameLbl.Location = new System.Drawing.Point(28, 166);
            this.usrnameLbl.Name = "usrnameLbl";
            this.usrnameLbl.Size = new System.Drawing.Size(112, 25);
            this.usrnameLbl.TabIndex = 0;
            this.usrnameLbl.Text = "Username";
            this.usrnameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cdtPwd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(598, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 594);
            this.panel1.TabIndex = 1;
            // 
            // cdtPwd
            // 
            this.cdtPwd.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdtPwd.Location = new System.Drawing.Point(3, 194);
            this.cdtPwd.Name = "cdtPwd";
            this.cdtPwd.Size = new System.Drawing.Size(102, 215);
            this.cdtPwd.TabIndex = 0;
            this.cdtPwd.Text = "Password must be at least \r\n8 characters long, \r\nwith at least 1 number, \r\n1 lowe" +
    "rcase &\r\n1 uppercase";
            this.cdtPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cdtPwd.Visible = false;
            // 
            // SignupPg
            // 
            this.AccessibleName = "signupPg";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SignupPg";
            this.Size = new System.Drawing.Size(700, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.confirmPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.TextBox txt_pwdcfm;
        private System.Windows.Forms.Label pwd_cfmLbl;
        private System.Windows.Forms.Panel confirmPnl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox pwdBx;
        private System.Windows.Forms.TextBox txt_usrname;
        private System.Windows.Forms.Label pwdLbl;
        private System.Windows.Forms.Label usrnameLbl;
        private System.Windows.Forms.Label strongPwd;
        private System.Windows.Forms.Label matchPwd;
        private System.Windows.Forms.Label unavailableUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cdtPwd;
    }
}
