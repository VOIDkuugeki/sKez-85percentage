namespace sKez
{
    partial class registerInfo
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
            this.lname_txt = new System.Windows.Forms.TextBox();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.lstnmLbl = new System.Windows.Forms.Label();
            this.firstnmLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.header = new System.Windows.Forms.Panel();
            this.skipBtn = new System.Windows.Forms.Button();
            this.confirmPnl = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.header.SuspendLayout();
            this.confirmPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lname_txt
            // 
            this.lname_txt.AccessibleName = "lname";
            this.lname_txt.Font = new System.Drawing.Font("Meiryo", 9F);
            this.lname_txt.Location = new System.Drawing.Point(32, 273);
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Size = new System.Drawing.Size(420, 30);
            this.lname_txt.TabIndex = 2;
            // 
            // fname_txt
            // 
            this.fname_txt.AccessibleName = "fname";
            this.fname_txt.BackColor = System.Drawing.SystemColors.Window;
            this.fname_txt.Font = new System.Drawing.Font("Meiryo", 9F);
            this.fname_txt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fname_txt.Location = new System.Drawing.Point(32, 194);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(420, 30);
            this.fname_txt.TabIndex = 1;
            this.fname_txt.WordWrap = false;
            // 
            // lstnmLbl
            // 
            this.lstnmLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstnmLbl.AutoSize = true;
            this.lstnmLbl.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lstnmLbl.Location = new System.Drawing.Point(28, 245);
            this.lstnmLbl.Name = "lstnmLbl";
            this.lstnmLbl.Size = new System.Drawing.Size(115, 25);
            this.lstnmLbl.TabIndex = 0;
            this.lstnmLbl.Text = "Last name";
            this.lstnmLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstnmLbl
            // 
            this.firstnmLbl.AutoSize = true;
            this.firstnmLbl.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.firstnmLbl.Location = new System.Drawing.Point(28, 166);
            this.firstnmLbl.Name = "firstnmLbl";
            this.firstnmLbl.Size = new System.Drawing.Size(116, 25);
            this.firstnmLbl.TabIndex = 0;
            this.firstnmLbl.Text = "First name";
            this.firstnmLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.confirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmBtn.Font = new System.Drawing.Font("Meiryo UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.confirmBtn.ImageIndex = 0;
            this.confirmBtn.Location = new System.Drawing.Point(3, 3);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(0);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Padding = new System.Windows.Forms.Padding(5);
            this.confirmBtn.Size = new System.Drawing.Size(174, 79);
            this.confirmBtn.TabIndex = 4;
            this.confirmBtn.Tag = "";
            this.confirmBtn.Text = "Done";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            this.confirmBtn.MouseLeave += new System.EventHandler(this.confirmBtn_MouseLeave);
            this.confirmBtn.MouseHover += new System.EventHandler(this.confirmBtn_MouseHover);
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
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // header
            // 
            this.header.Controls.Add(this.skipBtn);
            this.header.Controls.Add(this.confirmPnl);
            this.header.Controls.Add(this.lname_txt);
            this.header.Controls.Add(this.fname_txt);
            this.header.Controls.Add(this.lstnmLbl);
            this.header.Controls.Add(this.firstnmLbl);
            this.header.Location = new System.Drawing.Point(108, 3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(484, 594);
            this.header.TabIndex = 0;
            // 
            // skipBtn
            // 
            this.skipBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipBtn.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipBtn.Location = new System.Drawing.Point(91, 376);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(112, 85);
            this.skipBtn.TabIndex = 3;
            this.skipBtn.Text = "Later";
            this.skipBtn.UseVisualStyleBackColor = true;
            this.skipBtn.Click += new System.EventHandler(this.skipBtn_Click);
            // 
            // confirmPnl
            // 
            this.confirmPnl.BackColor = System.Drawing.Color.Transparent;
            this.confirmPnl.Controls.Add(this.confirmBtn);
            this.confirmPnl.Location = new System.Drawing.Point(237, 376);
            this.confirmPnl.Margin = new System.Windows.Forms.Padding(0);
            this.confirmPnl.Name = "confirmPnl";
            this.confirmPnl.Padding = new System.Windows.Forms.Padding(3);
            this.confirmPnl.Size = new System.Drawing.Size(180, 85);
            this.confirmPnl.TabIndex = 5;
            // 
            // registerInfo
            // 
            this.AccessibleDescription = "registerInfo";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "registerInfo";
            this.Size = new System.Drawing.Size(700, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.confirmPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox lname_txt;
        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.Label lstnmLbl;
        private System.Windows.Forms.Label firstnmLbl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button skipBtn;
        private System.Windows.Forms.Panel confirmPnl;
    }
}
