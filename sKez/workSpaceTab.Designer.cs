namespace sKez
{
    partial class workSpaceTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workSpaceTab));
            this.wkspacePanel = new System.Windows.Forms.TableLayoutPanel();
            this.newBrd = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.editIcon = new System.Windows.Forms.ImageList(this.components);
            this.dltBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.wkspacePanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
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
            this.wkspacePanel.Location = new System.Drawing.Point(0, 39);
            this.wkspacePanel.Name = "wkspacePanel";
            this.wkspacePanel.RowCount = 4;
            this.wkspacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.wkspacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.wkspacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.wkspacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wkspacePanel.Size = new System.Drawing.Size(864, 602);
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
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.editBtn);
            this.panel7.Controls.Add(this.dltBtn);
            this.panel7.Controls.Add(this.cancelBtn);
            this.panel7.Controls.Add(this.newBtn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(864, 39);
            this.panel7.TabIndex = 1;
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBtn.ImageKey = "pen-icon.png";
            this.editBtn.ImageList = this.editIcon;
            this.editBtn.Location = new System.Drawing.Point(753, 5);
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
            this.dltBtn.Location = new System.Drawing.Point(832, 6);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(25, 25);
            this.dltBtn.TabIndex = 5;
            this.dltBtn.UseVisualStyleBackColor = false;
            this.dltBtn.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.ImageKey = "pen-icon.png";
            this.cancelBtn.Location = new System.Drawing.Point(670, 5);
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
            this.newBtn.Location = new System.Drawing.Point(753, 5);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(72, 28);
            this.newBtn.TabIndex = 0;
            this.newBtn.Text = "New";
            this.newBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Visible = false;
            // 
            // workSpaceTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.wkspacePanel);
            this.Controls.Add(this.panel7);
            this.Name = "workSpaceTab";
            this.Size = new System.Drawing.Size(864, 642);
            this.wkspacePanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel wkspacePanel;
        private System.Windows.Forms.Button newBrd;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button dltBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.ImageList editIcon;
    }
}
