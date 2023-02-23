using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sKez
{
    public partial class UserAccess : Form
    {
        public UserAccess()
        {
            InitializeComponent();
        }

        //Dragable
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Events
        private void userAccess_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void userAccess_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openUControls(UserControl u)
        {
            mainContainter.Controls.Clear();
            mainContainter.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }
        private void pagesBtn_Click(object sender, EventArgs e)
        {
            //Reset status of Buttons
            foreach (var pnl in pagePnl.Controls.OfType<Panel>())
            {
                pnl.BackColor = System.Drawing.Color.Transparent;
            }

            Button btn = (Button)sender;
            switch (btn.AccessibleName)
            {
                case "loginBtn":
                    openUControls(new LoginPage());
                    loginPnl.BackColor = System.Drawing.Color.Gold;
                    break;
                case "signupBtn":
                    openUControls(new VerifyPg());
                    signupPnl.BackColor = System.Drawing.Color.Gold;
                    break;
                default:
                    break;
            }
        }

        private void userAccess_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccess));
            this.mainContainter = new System.Windows.Forms.Panel();
            this.pagePnl = new System.Windows.Forms.TableLayoutPanel();
            this.signupPnl = new System.Windows.Forms.Panel();
            this.signupBtn = new System.Windows.Forms.Button();
            this.loginPnl = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.loginPg2 = new sKez.LoginPage();
            this.mainContainter.SuspendLayout();
            this.pagePnl.SuspendLayout();
            this.signupPnl.SuspendLayout();
            this.loginPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainter
            // 
            this.mainContainter.BackColor = System.Drawing.Color.Lavender;
            this.mainContainter.Controls.Add(this.loginPg2);
            this.mainContainter.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainContainter.Location = new System.Drawing.Point(0, 0);
            this.mainContainter.Name = "mainContainter";
            this.mainContainter.Size = new System.Drawing.Size(700, 600);
            this.mainContainter.TabIndex = 0;
            // 
            // pagePnl
            // 
            this.pagePnl.BackColor = System.Drawing.Color.BlueViolet;
            this.pagePnl.ColumnCount = 1;
            this.pagePnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagePnl.Controls.Add(this.signupPnl, 0, 1);
            this.pagePnl.Controls.Add(this.loginPnl, 0, 0);
            this.pagePnl.Controls.Add(this.cancelBtn, 0, 2);
            this.pagePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePnl.Location = new System.Drawing.Point(700, 0);
            this.pagePnl.Name = "pagePnl";
            this.pagePnl.RowCount = 3;
            this.pagePnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.pagePnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.pagePnl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pagePnl.Size = new System.Drawing.Size(100, 600);
            this.pagePnl.TabIndex = 1;
            // 
            // signupPnl
            // 
            this.signupPnl.BackColor = System.Drawing.Color.Transparent;
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
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.pagesBtn_Click);
            // 
            // loginPnl
            // 
            this.loginPnl.BackColor = System.Drawing.Color.Gold;
            this.loginPnl.Controls.Add(this.loginBtn);
            this.loginPnl.ForeColor = System.Drawing.Color.Transparent;
            this.loginPnl.Location = new System.Drawing.Point(5, 5);
            this.loginPnl.Margin = new System.Windows.Forms.Padding(5);
            this.loginPnl.Name = "loginPnl";
            this.loginPnl.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.loginPnl.Size = new System.Drawing.Size(90, 230);
            this.loginPnl.TabIndex = 0;
            // 
            // loginBtn
            // 
            this.loginBtn.AccessibleName = "loginBtn";
            this.loginBtn.BackColor = System.Drawing.Color.BlueViolet;
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
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cancelBtn.ImageIndex = 0;
            this.cancelBtn.ImageList = this.imageList1;
            this.cancelBtn.Location = new System.Drawing.Point(0, 480);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 120);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close-icon.png");
            // 
            // loginPg2
            // 
            this.loginPg2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPg2.Location = new System.Drawing.Point(0, 0);
            this.loginPg2.Name = "loginPg2";
            this.loginPg2.Size = new System.Drawing.Size(700, 600);
            this.loginPg2.TabIndex = 0;
            // 
            // UserAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pagePnl);
            this.Controls.Add(this.mainContainter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sKez";
            this.Activated += new System.EventHandler(this.userAccess_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.userAccess_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userAccess_MouseDown);
            this.mainContainter.ResumeLayout(false);
            this.pagePnl.ResumeLayout(false);
            this.signupPnl.ResumeLayout(false);
            this.loginPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
