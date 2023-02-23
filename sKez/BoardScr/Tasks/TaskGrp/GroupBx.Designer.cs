namespace sKez
{
    partial class GroupBx
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
            this.GContent = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.TableLayoutPanel();
            this.MenuGroup = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.header.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GContent
            // 
            this.GContent.AutoSize = true;
            this.GContent.BackColor = System.Drawing.Color.LavenderBlush;
            this.GContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GContent.ForeColor = System.Drawing.Color.Black;
            this.GContent.Location = new System.Drawing.Point(0, 40);
            this.GContent.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.GContent.MaximumSize = new System.Drawing.Size(172, 99999);
            this.GContent.MinimumSize = new System.Drawing.Size(172, 105);
            this.GContent.Name = "GContent";
            this.GContent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.GContent.Size = new System.Drawing.Size(172, 105);
            this.GContent.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 40);
            this.panel1.TabIndex = 2;
            // 
            // header
            // 
            this.header.ColumnCount = 2;
            this.header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.header.Controls.Add(this.MenuGroup, 1, 0);
            this.header.Controls.Add(this.GroupLbl, 0, 0);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.RowCount = 1;
            this.header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.header.Size = new System.Drawing.Size(172, 40);
            this.header.TabIndex = 2;
            // 
            // MenuGroup
            // 
            this.MenuGroup.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.MenuGroup.ContextMenuStrip = this.contextMenuStrip1;
            this.MenuGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuGroup.FlatAppearance.BorderSize = 0;
            this.MenuGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.MenuGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.MenuGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuGroup.Location = new System.Drawing.Point(137, 3);
            this.MenuGroup.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.MenuGroup.Name = "MenuGroup";
            this.MenuGroup.Padding = new System.Windows.Forms.Padding(3);
            this.MenuGroup.Size = new System.Drawing.Size(32, 34);
            this.MenuGroup.TabIndex = 0;
            this.MenuGroup.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTaskToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.convertToTasksToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 144);
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.addTaskToolStripMenuItem.Text = "Add Task";
            this.addTaskToolStripMenuItem.Click += new System.EventHandler(this.addTaskToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.renameToolStripMenuItem.Text = "Rename Group";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // convertToTasksToolStripMenuItem
            // 
            this.convertToTasksToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.convertToTasksToolStripMenuItem.Name = "convertToTasksToolStripMenuItem";
            this.convertToTasksToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.convertToTasksToolStripMenuItem.Text = "Ungroup";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // GroupLbl
            // 
            this.GroupLbl.AutoEllipsis = true;
            this.GroupLbl.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.GroupLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupLbl.Font = new System.Drawing.Font("Meiryo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GroupLbl.Location = new System.Drawing.Point(0, 3);
            this.GroupLbl.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.GroupLbl.Name = "GroupLbl";
            this.GroupLbl.Size = new System.Drawing.Size(137, 37);
            this.GroupLbl.TabIndex = 1;
            this.GroupLbl.Text = "New group\r\n\r\n";
            // 
            // GroupBx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.GContent);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(172, 99999);
            this.MinimumSize = new System.Drawing.Size(172, 54);
            this.Name = "GroupBx";
            this.Size = new System.Drawing.Size(172, 145);
            this.Load += new System.EventHandler(this.GroupBx_Load);
            this.panel1.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel GContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel header;
        private System.Windows.Forms.Label GroupLbl;
        private System.Windows.Forms.Button MenuGroup;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    }
}
