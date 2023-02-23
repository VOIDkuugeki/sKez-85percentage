namespace sKez
{
    partial class TaskBx
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
            this.Content = new System.Windows.Forms.TableLayoutPanel();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editMB = new System.Windows.Forms.ToolStripMenuItem();
            this.convertMB = new System.Windows.Forms.ToolStripMenuItem();
            this.delMB = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskLbl = new System.Windows.Forms.Label();
            this.Content.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.Transparent;
            this.Content.ColumnCount = 2;
            this.Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.Content.Controls.Add(this.MenuBtn, 1, 0);
            this.Content.Controls.Add(this.TaskLbl, 0, 0);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Content.Name = "Content";
            this.Content.RowCount = 1;
            this.Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Content.Size = new System.Drawing.Size(164, 54);
            this.Content.TabIndex = 0;
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.MenuBtn.ContextMenuStrip = this.contextMenuStrip1;
            this.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.MenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Location = new System.Drawing.Point(140, 3);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(21, 48);
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMB,
            this.convertMB,
            this.delMB});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 116);
            // 
            // editMB
            // 
            this.editMB.Name = "editMB";
            this.editMB.Size = new System.Drawing.Size(185, 28);
            this.editMB.Text = "Edit Note";
            this.editMB.Click += new System.EventHandler(this.editMB_Click);
            // 
            // convertMB
            // 
            this.convertMB.Name = "convertMB";
            this.convertMB.Size = new System.Drawing.Size(185, 28);
            this.convertMB.Text = "Convert to Group";
            // 
            // delMB
            // 
            this.delMB.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delMB.ForeColor = System.Drawing.Color.Red;
            this.delMB.Name = "delMB";
            this.delMB.Size = new System.Drawing.Size(185, 28);
            this.delMB.Text = "Delete";
            this.delMB.Click += new System.EventHandler(this.delMB_Click);
            // 
            // TaskLbl
            // 
            this.TaskLbl.AutoEllipsis = true;
            this.TaskLbl.BackColor = System.Drawing.Color.Lavender;
            this.TaskLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskLbl.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskLbl.Location = new System.Drawing.Point(3, 0);
            this.TaskLbl.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TaskLbl.Name = "TaskLbl";
            this.TaskLbl.Size = new System.Drawing.Size(137, 54);
            this.TaskLbl.TabIndex = 1;
            this.TaskLbl.Text = "New Task";
            this.TaskLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskBx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Content);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.MaximumSize = new System.Drawing.Size(164, 54);
            this.MinimumSize = new System.Drawing.Size(164, 54);
            this.Name = "TaskBx";
            this.Size = new System.Drawing.Size(164, 54);
            this.Load += new System.EventHandler(this.TaskBx_Load);
            this.Content.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Content;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Label TaskLbl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editMB;
        private System.Windows.Forms.ToolStripMenuItem convertMB;
        private System.Windows.Forms.ToolStripMenuItem delMB;
    }
}
