namespace sKez
{
    partial class MainPg
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
            this.PagesTable = new System.Windows.Forms.TableLayoutPanel();
            this.CalendarBtn = new System.Windows.Forms.Button();
            this.WorkspaceBtn = new System.Windows.Forms.Button();
            this.Tab = new System.Windows.Forms.Panel();
            this.Content = new System.Windows.Forms.Panel();
            this.PagesTable.SuspendLayout();
            this.Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagesTable
            // 
            this.PagesTable.ColumnCount = 4;
            this.PagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.17062F));
            this.PagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59242F));
            this.PagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.8673F));
            this.PagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.36967F));
            this.PagesTable.Controls.Add(this.CalendarBtn, 2, 0);
            this.PagesTable.Controls.Add(this.WorkspaceBtn, 1, 0);
            this.PagesTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.PagesTable.Location = new System.Drawing.Point(0, 0);
            this.PagesTable.Name = "PagesTable";
            this.PagesTable.RowCount = 1;
            this.PagesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PagesTable.Size = new System.Drawing.Size(864, 96);
            this.PagesTable.TabIndex = 6;
            // 
            // CalendarBtn
            // 
            this.CalendarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalendarBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.CalendarBtn.FlatAppearance.BorderSize = 0;
            this.CalendarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CalendarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CalendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalendarBtn.Font = new System.Drawing.Font("Meiryo UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.CalendarBtn.Location = new System.Drawing.Point(432, 3);
            this.CalendarBtn.Name = "CalendarBtn";
            this.CalendarBtn.Size = new System.Drawing.Size(170, 90);
            this.CalendarBtn.TabIndex = 4;
            this.CalendarBtn.Text = "Calendar";
            this.CalendarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalendarBtn.UseVisualStyleBackColor = true;
            this.CalendarBtn.Click += new System.EventHandler(this.calendarBtn_Click);
            // 
            // WorkspaceBtn
            // 
            this.WorkspaceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkspaceBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.WorkspaceBtn.FlatAppearance.BorderSize = 0;
            this.WorkspaceBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.WorkspaceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.WorkspaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkspaceBtn.Font = new System.Drawing.Font("Meiryo UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkspaceBtn.ForeColor = System.Drawing.Color.Black;
            this.WorkspaceBtn.Location = new System.Drawing.Point(224, 3);
            this.WorkspaceBtn.Name = "WorkspaceBtn";
            this.WorkspaceBtn.Size = new System.Drawing.Size(202, 90);
            this.WorkspaceBtn.TabIndex = 0;
            this.WorkspaceBtn.Text = "Workspace";
            this.WorkspaceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorkspaceBtn.UseVisualStyleBackColor = true;
            this.WorkspaceBtn.Click += new System.EventHandler(this.workspaceBtn_Click);
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Content);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 96);
            this.Tab.Name = "Tab";
            this.Tab.Size = new System.Drawing.Size(864, 642);
            this.Tab.TabIndex = 7;
            // 
            // Content
            // 
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(864, 642);
            this.Content.TabIndex = 1;
            // 
            // MainPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.PagesTable);
            this.Name = "MainPg";
            this.Size = new System.Drawing.Size(864, 738);
            this.PagesTable.ResumeLayout(false);
            this.Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel PagesTable;
        private System.Windows.Forms.Button CalendarBtn;
        private System.Windows.Forms.Button WorkspaceBtn;
        private System.Windows.Forms.Panel Tab;
        private System.Windows.Forms.Panel Content;
    }
}
