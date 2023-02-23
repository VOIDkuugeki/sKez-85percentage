namespace sKez
{
    partial class ChangePwd
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
            this.strongPwd = new System.Windows.Forms.Label();
            this.matchPwd = new System.Windows.Forms.Label();
            this.txt_pwdcfm = new System.Windows.Forms.TextBox();
            this.pwd_cfmLbl = new System.Windows.Forms.Label();
            this.pwdBx = new System.Windows.Forms.TextBox();
            this.pwdLbl = new System.Windows.Forms.Label();
            this.cdtPwd = new System.Windows.Forms.Label();
            this.confirmPnl = new System.Windows.Forms.Panel();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.confirmPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // strongPwd
            // 
            this.strongPwd.AutoSize = true;
            this.strongPwd.BackColor = System.Drawing.Color.Transparent;
            this.strongPwd.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strongPwd.ForeColor = System.Drawing.Color.Red;
            this.strongPwd.Location = new System.Drawing.Point(43, 133);
            this.strongPwd.Name = "strongPwd";
            this.strongPwd.Size = new System.Drawing.Size(374, 25);
            this.strongPwd.TabIndex = 17;
            this.strongPwd.Text = "The password does not meet the conditions";
            this.strongPwd.Visible = false;
            // 
            // matchPwd
            // 
            this.matchPwd.AutoSize = true;
            this.matchPwd.BackColor = System.Drawing.Color.Transparent;
            this.matchPwd.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchPwd.ForeColor = System.Drawing.Color.Red;
            this.matchPwd.Location = new System.Drawing.Point(43, 212);
            this.matchPwd.Name = "matchPwd";
            this.matchPwd.Size = new System.Drawing.Size(250, 25);
            this.matchPwd.TabIndex = 16;
            this.matchPwd.Text = "The password doesn\'t match";
            this.matchPwd.Visible = false;
            // 
            // txt_pwdcfm
            // 
            this.txt_pwdcfm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_pwdcfm.Font = new System.Drawing.Font("Meiryo", 9F);
            this.txt_pwdcfm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_pwdcfm.Location = new System.Drawing.Point(45, 180);
            this.txt_pwdcfm.Name = "txt_pwdcfm";
            this.txt_pwdcfm.PasswordChar = '●';
            this.txt_pwdcfm.Size = new System.Drawing.Size(420, 30);
            this.txt_pwdcfm.TabIndex = 14;
            this.txt_pwdcfm.UseSystemPasswordChar = true;
            this.txt_pwdcfm.WordWrap = false;
            this.txt_pwdcfm.Click += new System.EventHandler(this.txt_pwdcfm_Click);
            this.txt_pwdcfm.Leave += new System.EventHandler(this.txt_pwdcfm_Leave);
            // 
            // pwd_cfmLbl
            // 
            this.pwd_cfmLbl.AutoSize = true;
            this.pwd_cfmLbl.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.pwd_cfmLbl.Location = new System.Drawing.Point(41, 152);
            this.pwd_cfmLbl.Name = "pwd_cfmLbl";
            this.pwd_cfmLbl.Size = new System.Drawing.Size(188, 25);
            this.pwd_cfmLbl.TabIndex = 15;
            this.pwd_cfmLbl.Text = "Confirm password";
            this.pwd_cfmLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwdBx
            // 
            this.pwdBx.Font = new System.Drawing.Font("Meiryo", 9F);
            this.pwdBx.Location = new System.Drawing.Point(43, 101);
            this.pwdBx.Name = "pwdBx";
            this.pwdBx.PasswordChar = '●';
            this.pwdBx.Size = new System.Drawing.Size(420, 30);
            this.pwdBx.TabIndex = 13;
            this.pwdBx.UseSystemPasswordChar = true;
            this.pwdBx.Click += new System.EventHandler(this.pwdBx_Click);
            this.pwdBx.Leave += new System.EventHandler(this.pwdBx_Leave);
            // 
            // pwdLbl
            // 
            this.pwdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pwdLbl.AutoSize = true;
            this.pwdLbl.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.pwdLbl.Location = new System.Drawing.Point(39, 73);
            this.pwdLbl.Name = "pwdLbl";
            this.pwdLbl.Size = new System.Drawing.Size(105, 25);
            this.pwdLbl.TabIndex = 11;
            this.pwdLbl.Text = "Password";
            this.pwdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdtPwd
            // 
            this.cdtPwd.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdtPwd.Location = new System.Drawing.Point(471, 51);
            this.cdtPwd.Name = "cdtPwd";
            this.cdtPwd.Size = new System.Drawing.Size(102, 215);
            this.cdtPwd.TabIndex = 12;
            this.cdtPwd.Text = "Password must be at least \r\n8 characters long, \r\nwith at least 1 number, \r\n1 lowe" +
    "rcase &\r\n1 uppercase";
            this.cdtPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cdtPwd.Visible = false;
            // 
            // confirmPnl
            // 
            this.confirmPnl.BackColor = System.Drawing.Color.Transparent;
            this.confirmPnl.Controls.Add(this.confirmBtn);
            this.confirmPnl.Location = new System.Drawing.Point(282, 260);
            this.confirmPnl.Margin = new System.Windows.Forms.Padding(0);
            this.confirmPnl.Name = "confirmPnl";
            this.confirmPnl.Padding = new System.Windows.Forms.Padding(3);
            this.confirmPnl.Size = new System.Drawing.Size(180, 85);
            this.confirmPnl.TabIndex = 18;
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
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Meiryo UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelBtn.Location = new System.Drawing.Point(68, 260);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(180, 85);
            this.CancelBtn.TabIndex = 19;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.confirmPnl);
            this.Controls.Add(this.strongPwd);
            this.Controls.Add(this.matchPwd);
            this.Controls.Add(this.txt_pwdcfm);
            this.Controls.Add(this.pwd_cfmLbl);
            this.Controls.Add(this.pwdBx);
            this.Controls.Add(this.pwdLbl);
            this.Controls.Add(this.cdtPwd);
            this.Name = "ChangePwd";
            this.Size = new System.Drawing.Size(576, 364);
            this.confirmPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label strongPwd;
        private System.Windows.Forms.Label matchPwd;
        private System.Windows.Forms.TextBox txt_pwdcfm;
        private System.Windows.Forms.Label pwd_cfmLbl;
        private System.Windows.Forms.TextBox pwdBx;
        private System.Windows.Forms.Label pwdLbl;
        private System.Windows.Forms.Label cdtPwd;
        private System.Windows.Forms.Panel confirmPnl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}
