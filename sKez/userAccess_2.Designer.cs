namespace sKez
{
    partial class userAccess_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userAccess_2));
            this.loginBtn = new System.Windows.Forms.Button();
            this.pagePnl = new System.Windows.Forms.TableLayoutPanel();
            this.signupPnl = new System.Windows.Forms.Panel();
            this.signupBtn = new System.Windows.Forms.Button();
            this.loginPnl = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainContainter = new System.Windows.Forms.Panel();
            this.verifyPg1 = new sKez.verifyPg();
            this.pagePnl.SuspendLayout();
            this.signupPnl.SuspendLayout();
            this.loginPnl.SuspendLayout();
            this.mainContainter.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.AccessibleName = "loginBtn";
            this.loginBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Meiryo UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(5, 0);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.loginBtn.Size = new System.Drawing.Size(85, 230);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "L\r\nO\r\nG\r\nI\r\nN";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.pagesBtn_Click);
            // 
            // pagePnl
            // 
            this.pagePnl.BackColor = System.Drawing.Color.BlueViolet;
            this.pagePnl.ColumnCount = 1;
            this.pagePnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagePnl.Controls.Add(this.signupPnl, 0, 1);
            this.pagePnl.Controls.Add(this.loginPnl, 0, 0);
            this.pagePnl.Controls.Add(this.button2, 0, 2);
            this.pagePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePnl.Location = new System.Drawing.Point(700, 0);
            this.pagePnl.Name = "pagePnl";
            this.pagePnl.RowCount = 3;
            this.pagePnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.pagePnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.pagePnl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pagePnl.Size = new System.Drawing.Size(100, 600);
            this.pagePnl.TabIndex = 3;
            // 
            // signupPnl
            // 
            this.signupPnl.BackColor = System.Drawing.Color.Gold;
            this.signupPnl.Controls.Add(this.signupBtn);
            this.signupPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signupPnl.Location = new System.Drawing.Point(5, 245);
            this.signupPnl.Margin = new System.Windows.Forms.Padding(5);
            this.signupPnl.Name = "signupPnl";
            this.signupPnl.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.signupPnl.Size = new System.Drawing.Size(90, 230);
            this.signupPnl.TabIndex = 1;
            // 
            // signupBtn
            // 
            this.signupBtn.AccessibleName = "signupBtn";
            this.signupBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signupBtn.FlatAppearance.BorderSize = 0;
            this.signupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.signupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBtn.Font = new System.Drawing.Font("Meiryo UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(5, 0);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.signupBtn.Size = new System.Drawing.Size(85, 230);
            this.signupBtn.TabIndex = 0;
            this.signupBtn.Text = "S\r\nI\r\nG\r\nN\r\n\r\nU\r\nP";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.pagesBtn_Click);
            // 
            // loginPnl
            // 
            this.loginPnl.BackColor = System.Drawing.Color.Transparent;
            this.loginPnl.Controls.Add(this.loginBtn);
            this.loginPnl.ForeColor = System.Drawing.Color.Transparent;
            this.loginPnl.Location = new System.Drawing.Point(5, 5);
            this.loginPnl.Margin = new System.Windows.Forms.Padding(5);
            this.loginPnl.Name = "loginPnl";
            this.loginPnl.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.loginPnl.Size = new System.Drawing.Size(90, 230);
            this.loginPnl.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(0, 480);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 120);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close-icon.png");
            // 
            // mainContainter
            // 
            this.mainContainter.BackColor = System.Drawing.Color.Lavender;
            this.mainContainter.Controls.Add(this.verifyPg1);
            this.mainContainter.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainContainter.Location = new System.Drawing.Point(0, 0);
            this.mainContainter.Name = "mainContainter";
            this.mainContainter.Size = new System.Drawing.Size(700, 600);
            this.mainContainter.TabIndex = 2;
            // 
            // verifyPg1
            // 
            this.verifyPg1.AccessibleName = "verifyPg";
            this.verifyPg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verifyPg1.Location = new System.Drawing.Point(0, 0);
            this.verifyPg1.Name = "verifyPg1";
            this.verifyPg1.Size = new System.Drawing.Size(700, 600);
            this.verifyPg1.TabIndex = 0;
            // 
            // userAccess_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pagePnl);
            this.Controls.Add(this.mainContainter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userAccess_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userAccess_2";
            this.pagePnl.ResumeLayout(false);
            this.signupPnl.ResumeLayout(false);
            this.loginPnl.ResumeLayout(false);
            this.mainContainter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TableLayoutPanel pagePnl;
        private System.Windows.Forms.Panel signupPnl;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Panel loginPnl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel mainContainter;
        private verifyPg verifyPg1;
    }
}