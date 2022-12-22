namespace sKez
{
    partial class loginPg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPg));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.header = new System.Windows.Forms.Panel();
            this.confirmPnl = new System.Windows.Forms.Panel();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pwdBx = new System.Windows.Forms.TextBox();
            this.txt_usrname = new System.Windows.Forms.TextBox();
            this.pwdLbl = new System.Windows.Forms.Label();
            this.usrnameLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.header.SuspendLayout();
            this.confirmPnl.SuspendLayout();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // header
            // 
            this.header.Controls.Add(this.confirmPnl);
            this.header.Controls.Add(this.checkBox1);
            this.header.Controls.Add(this.pwdBx);
            this.header.Controls.Add(this.txt_usrname);
            this.header.Controls.Add(this.pwdLbl);
            this.header.Controls.Add(this.usrnameLbl);
            this.header.Location = new System.Drawing.Point(108, 3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(484, 594);
            this.header.TabIndex = 0;
            // 
            // confirmPnl
            // 
            this.confirmPnl.BackColor = System.Drawing.Color.Transparent;
            this.confirmPnl.Controls.Add(this.confirmBtn);
            this.confirmPnl.Location = new System.Drawing.Point(139, 414);
            this.confirmPnl.Margin = new System.Windows.Forms.Padding(0);
            this.confirmPnl.Name = "confirmPnl";
            this.confirmPnl.Padding = new System.Windows.Forms.Padding(3);
            this.confirmPnl.Size = new System.Drawing.Size(180, 85);
            this.confirmPnl.TabIndex = 5;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.confirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Meiryo UI", 15F);
            this.confirmBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.confirmBtn.ImageIndex = 0;
            this.confirmBtn.ImageList = this.imageList1;
            this.confirmBtn.Location = new System.Drawing.Point(3, 3);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(0);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Padding = new System.Windows.Forms.Padding(5);
            this.confirmBtn.Size = new System.Drawing.Size(174, 79);
            this.confirmBtn.TabIndex = 4;
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.MouseLeave += new System.EventHandler(this.confirmBtn_MouseLeave);
            this.confirmBtn.MouseHover += new System.EventHandler(this.confirmBtn_MouseHover);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arrow-icon.png");
            this.imageList1.Images.SetKeyName(1, "gold_arrow-icon.png");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.checkBox1.Location = new System.Drawing.Point(32, 328);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 26);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Rememeber me";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // pwdBx
            // 
            this.pwdBx.Font = new System.Drawing.Font("Meiryo", 9F);
            this.pwdBx.Location = new System.Drawing.Point(32, 273);
            this.pwdBx.Name = "pwdBx";
            this.pwdBx.Size = new System.Drawing.Size(420, 30);
            this.pwdBx.TabIndex = 1;
            // 
            // txt_usrname
            // 
            this.txt_usrname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_usrname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_usrname.Font = new System.Drawing.Font("Meiryo", 9F);
            this.txt_usrname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_usrname.Location = new System.Drawing.Point(32, 194);
            this.txt_usrname.Name = "txt_usrname";
            this.txt_usrname.Size = new System.Drawing.Size(420, 30);
            this.txt_usrname.TabIndex = 1;
            this.txt_usrname.WordWrap = false;
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
            // loginPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "loginPg";
            this.Size = new System.Drawing.Size(700, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.confirmPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox pwdBx;
        private System.Windows.Forms.TextBox txt_usrname;
        private System.Windows.Forms.Label pwdLbl;
        private System.Windows.Forms.Label usrnameLbl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel confirmPnl;
    }
}
