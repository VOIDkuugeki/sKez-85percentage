namespace sKez
{
    partial class VerifyPg
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
            this.codeBx = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.pwdLbl = new System.Windows.Forms.Label();
            this.mailLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.header = new System.Windows.Forms.Panel();
            this.invalidCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cd = new System.Windows.Forms.Label();
            this.incorrectMail = new System.Windows.Forms.Label();
            this.sendcodeBtn = new System.Windows.Forms.Button();
            this.confirmPnl = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.header.SuspendLayout();
            this.confirmPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeBx
            // 
            this.codeBx.AccessibleName = "codeBx";
            this.codeBx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.codeBx.Font = new System.Drawing.Font("Meiryo", 9F);
            this.codeBx.Location = new System.Drawing.Point(32, 273);
            this.codeBx.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.codeBx.Name = "codeBx";
            this.codeBx.Size = new System.Drawing.Size(348, 30);
            this.codeBx.TabIndex = 2;
            this.codeBx.TextChanged += new System.EventHandler(this.codeBx_TextChanged);
            // 
            // txt_mail
            // 
            this.txt_mail.AccessibleName = "mail";
            this.txt_mail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_mail.Font = new System.Drawing.Font("Meiryo", 9F);
            this.txt_mail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_mail.Location = new System.Drawing.Point(32, 194);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(420, 30);
            this.txt_mail.TabIndex = 1;
            this.txt_mail.WordWrap = false;
            this.txt_mail.Leave += new System.EventHandler(this.txt_mail_Leave);
            // 
            // pwdLbl
            // 
            this.pwdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pwdLbl.AutoSize = true;
            this.pwdLbl.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.pwdLbl.Location = new System.Drawing.Point(28, 245);
            this.pwdLbl.Name = "pwdLbl";
            this.pwdLbl.Size = new System.Drawing.Size(121, 25);
            this.pwdLbl.TabIndex = 0;
            this.pwdLbl.Text = "Verification";
            this.pwdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.mailLbl.Location = new System.Drawing.Point(28, 166);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(51, 25);
            this.mailLbl.TabIndex = 0;
            this.mailLbl.Text = "Mail";
            this.mailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.confirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
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
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            this.confirmBtn.MouseEnter += new System.EventHandler(this.confirmBtn_MouseHover);
            this.confirmBtn.MouseLeave += new System.EventHandler(this.confirmBtn_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Lavender;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.header, 1, 0);
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
            this.header.Controls.Add(this.invalidCode);
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.cd);
            this.header.Controls.Add(this.incorrectMail);
            this.header.Controls.Add(this.sendcodeBtn);
            this.header.Controls.Add(this.confirmPnl);
            this.header.Controls.Add(this.codeBx);
            this.header.Controls.Add(this.txt_mail);
            this.header.Controls.Add(this.pwdLbl);
            this.header.Controls.Add(this.mailLbl);
            this.header.Location = new System.Drawing.Point(108, 3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(484, 594);
            this.header.TabIndex = 0;
            // 
            // invalidCode
            // 
            this.invalidCode.AutoSize = true;
            this.invalidCode.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidCode.ForeColor = System.Drawing.Color.Red;
            this.invalidCode.Location = new System.Drawing.Point(32, 305);
            this.invalidCode.Name = "invalidCode";
            this.invalidCode.Size = new System.Drawing.Size(115, 25);
            this.invalidCode.TabIndex = 10;
            this.invalidCode.Text = "Invalid Code";
            this.invalidCode.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 9;
            this.label1.Visible = false;
            // 
            // cd
            // 
            this.cd.AutoSize = true;
            this.cd.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd.Location = new System.Drawing.Point(385, 308);
            this.cd.Name = "cd";
            this.cd.Size = new System.Drawing.Size(0, 25);
            this.cd.TabIndex = 8;
            this.cd.Visible = false;
            // 
            // incorrectMail
            // 
            this.incorrectMail.AutoSize = true;
            this.incorrectMail.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectMail.ForeColor = System.Drawing.Color.Red;
            this.incorrectMail.Location = new System.Drawing.Point(32, 226);
            this.incorrectMail.Name = "incorrectMail";
            this.incorrectMail.Size = new System.Drawing.Size(137, 25);
            this.incorrectMail.TabIndex = 7;
            this.incorrectMail.Text = "Unvailable mail\r\n";
            this.incorrectMail.Visible = false;
            // 
            // sendcodeBtn
            // 
            this.sendcodeBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.sendcodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendcodeBtn.FlatAppearance.BorderSize = 0;
            this.sendcodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendcodeBtn.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendcodeBtn.ForeColor = System.Drawing.Color.White;
            this.sendcodeBtn.Location = new System.Drawing.Point(380, 273);
            this.sendcodeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.sendcodeBtn.Name = "sendcodeBtn";
            this.sendcodeBtn.Size = new System.Drawing.Size(72, 30);
            this.sendcodeBtn.TabIndex = 3;
            this.sendcodeBtn.Text = "Send";
            this.sendcodeBtn.UseVisualStyleBackColor = false;
            this.sendcodeBtn.Click += new System.EventHandler(this.sendcodeBtn_Click);
            // 
            // confirmPnl
            // 
            this.confirmPnl.BackColor = System.Drawing.Color.Transparent;
            this.confirmPnl.Controls.Add(this.confirmBtn);
            this.confirmPnl.Location = new System.Drawing.Point(139, 376);
            this.confirmPnl.Margin = new System.Windows.Forms.Padding(0);
            this.confirmPnl.Name = "confirmPnl";
            this.confirmPnl.Padding = new System.Windows.Forms.Padding(3);
            this.confirmPnl.Size = new System.Drawing.Size(180, 85);
            this.confirmPnl.TabIndex = 5;
            // 
            // verifyPg
            // 
            this.AccessibleName = "verifyPg";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "verifyPg";
            this.Size = new System.Drawing.Size(700, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.confirmPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox codeBx;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label pwdLbl;
        private System.Windows.Forms.Label mailLbl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel confirmPnl;
        private System.Windows.Forms.Button sendcodeBtn;
        private System.Windows.Forms.Label incorrectMail;
        private System.Windows.Forms.Label cd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label invalidCode;
        private System.Windows.Forms.Label label1;
    }
}
