namespace sKez
{
    partial class mainPg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPg));
            this.pagesTable = new System.Windows.Forms.TableLayoutPanel();
            this.calendarBtn = new System.Windows.Forms.Button();
            this.workspaceBtn = new System.Windows.Forms.Button();
            this.editIcon = new System.Windows.Forms.ImageList(this.components);
            this.tab = new System.Windows.Forms.Panel();
            this.workSpaceTab1 = new sKez.workSpaceTab();
            this.pagesTable.SuspendLayout();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pagesTable
            // 
            this.pagesTable.ColumnCount = 4;
            this.pagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.17062F));
            this.pagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59242F));
            this.pagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.8673F));
            this.pagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.36967F));
            this.pagesTable.Controls.Add(this.calendarBtn, 2, 0);
            this.pagesTable.Controls.Add(this.workspaceBtn, 1, 0);
            this.pagesTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.pagesTable.Location = new System.Drawing.Point(0, 0);
            this.pagesTable.Name = "pagesTable";
            this.pagesTable.RowCount = 1;
            this.pagesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pagesTable.Size = new System.Drawing.Size(864, 96);
            this.pagesTable.TabIndex = 6;
            // 
            // calendarBtn
            // 
            this.calendarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.calendarBtn.FlatAppearance.BorderSize = 0;
            this.calendarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.calendarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.calendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarBtn.Font = new System.Drawing.Font("Meiryo UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.calendarBtn.Location = new System.Drawing.Point(432, 3);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(170, 90);
            this.calendarBtn.TabIndex = 4;
            this.calendarBtn.Text = "Calendar";
            this.calendarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarBtn.UseVisualStyleBackColor = true;
            this.calendarBtn.Click += new System.EventHandler(this.calendarBtn_Click);
            // 
            // workspaceBtn
            // 
            this.workspaceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workspaceBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.workspaceBtn.FlatAppearance.BorderSize = 0;
            this.workspaceBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.workspaceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.workspaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workspaceBtn.Font = new System.Drawing.Font("Meiryo UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workspaceBtn.ForeColor = System.Drawing.Color.Black;
            this.workspaceBtn.Location = new System.Drawing.Point(224, 3);
            this.workspaceBtn.Name = "workspaceBtn";
            this.workspaceBtn.Size = new System.Drawing.Size(202, 90);
            this.workspaceBtn.TabIndex = 0;
            this.workspaceBtn.Text = "Workspace";
            this.workspaceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.workspaceBtn.UseVisualStyleBackColor = true;
            this.workspaceBtn.Click += new System.EventHandler(this.workspaceBtn_Click);
            // 
            // editIcon
            // 
            this.editIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("editIcon.ImageStream")));
            this.editIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.editIcon.Images.SetKeyName(0, "pen-icon.png");
            this.editIcon.Images.SetKeyName(1, "add-icon.png");
            this.editIcon.Images.SetKeyName(2, "delete-icon.png");
            // 
            // tab
            // 
            this.tab.Controls.Add(this.workSpaceTab1);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 96);
            this.tab.Name = "tab";
            this.tab.Size = new System.Drawing.Size(864, 642);
            this.tab.TabIndex = 7;
            // 
            // workSpaceTab1
            // 
            this.workSpaceTab1.BackColor = System.Drawing.Color.Lavender;
            this.workSpaceTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workSpaceTab1.Location = new System.Drawing.Point(0, 0);
            this.workSpaceTab1.Name = "workSpaceTab1";
            this.workSpaceTab1.Size = new System.Drawing.Size(864, 642);
            this.workSpaceTab1.TabIndex = 0;
            // 
            // mainPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.tab);
            this.Controls.Add(this.pagesTable);
            this.Name = "mainPg";
            this.Size = new System.Drawing.Size(864, 738);
            this.pagesTable.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel pagesTable;
        private System.Windows.Forms.Button calendarBtn;
        private System.Windows.Forms.Button workspaceBtn;
        private System.Windows.Forms.ImageList editIcon;
        private System.Windows.Forms.Panel tab;
        private workSpaceTab workSpaceTab1;
    }
}
