namespace sKez
{
    partial class UCVerify
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
            this.confirmPnl = new System.Windows.Forms.Panel();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.sendcodeBtn = new System.Windows.Forms.Button();
            this.codeBx = new System.Windows.Forms.TextBox();
            this.VerLbl = new System.Windows.Forms.Label();
            this.invalidCode = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.confirmPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmPnl
            // 
            this.confirmPnl.BackColor = System.Drawing.Color.Transparent;
            this.confirmPnl.Controls.Add(this.confirmBtn);
            this.confirmPnl.Location = new System.Drawing.Point(306, 208);
            this.confirmPnl.Margin = new System.Windows.Forms.Padding(0);
            this.confirmPnl.Name = "confirmPnl";
            this.confirmPnl.Padding = new System.Windows.Forms.Padding(3);
            this.confirmPnl.Size = new System.Drawing.Size(180, 85);
            this.confirmPnl.TabIndex = 11;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.confirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
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
            this.confirmBtn.MouseEnter += new System.EventHandler(this.ConfirmBtn_MouseHover);
            this.confirmBtn.MouseLeave += new System.EventHandler(this.ConfirmBtn_MouseLeave);
            // 
            // sendcodeBtn
            // 
            this.sendcodeBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.sendcodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendcodeBtn.FlatAppearance.BorderSize = 0;
            this.sendcodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendcodeBtn.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendcodeBtn.ForeColor = System.Drawing.Color.White;
            this.sendcodeBtn.Location = new System.Drawing.Point(426, 116);
            this.sendcodeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.sendcodeBtn.Name = "sendcodeBtn";
            this.sendcodeBtn.Size = new System.Drawing.Size(72, 30);
            this.sendcodeBtn.TabIndex = 10;
            this.sendcodeBtn.Text = "Send";
            this.sendcodeBtn.UseVisualStyleBackColor = false;
            this.sendcodeBtn.Click += new System.EventHandler(this.sendOTPBtn_Click);
            // 
            // codeBx
            // 
            this.codeBx.AccessibleName = "codeBx";
            this.codeBx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.codeBx.Font = new System.Drawing.Font("Meiryo", 9F);
            this.codeBx.Location = new System.Drawing.Point(78, 116);
            this.codeBx.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.codeBx.Name = "codeBx";
            this.codeBx.Size = new System.Drawing.Size(348, 30);
            this.codeBx.TabIndex = 9;
            this.codeBx.TextChanged += new System.EventHandler(this.codeBx_TextChanged);
            // 
            // VerLbl
            // 
            this.VerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VerLbl.AutoSize = true;
            this.VerLbl.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.VerLbl.Location = new System.Drawing.Point(52, 71);
            this.VerLbl.Name = "VerLbl";
            this.VerLbl.Size = new System.Drawing.Size(121, 25);
            this.VerLbl.TabIndex = 8;
            this.VerLbl.Text = "Verification";
            this.VerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // invalidCode
            // 
            this.invalidCode.AutoSize = true;
            this.invalidCode.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidCode.ForeColor = System.Drawing.Color.Red;
            this.invalidCode.Location = new System.Drawing.Point(73, 159);
            this.invalidCode.Name = "invalidCode";
            this.invalidCode.Size = new System.Drawing.Size(113, 25);
            this.invalidCode.TabIndex = 12;
            this.invalidCode.Text = "Invalid code";
            this.invalidCode.Visible = false;
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
            this.CancelBtn.Location = new System.Drawing.Point(88, 208);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(180, 85);
            this.CancelBtn.TabIndex = 20;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // UCVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.invalidCode);
            this.Controls.Add(this.confirmPnl);
            this.Controls.Add(this.sendcodeBtn);
            this.Controls.Add(this.codeBx);
            this.Controls.Add(this.VerLbl);
            this.Name = "UCVerify";
            this.Size = new System.Drawing.Size(576, 364);
            this.confirmPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel confirmPnl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button sendcodeBtn;
        private System.Windows.Forms.TextBox codeBx;
        private System.Windows.Forms.Label VerLbl;
        private System.Windows.Forms.Label invalidCode;
        private System.Windows.Forms.Button CancelBtn;
    }
}
