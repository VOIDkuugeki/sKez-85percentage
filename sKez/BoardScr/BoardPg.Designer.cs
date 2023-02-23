namespace sKez
{
    partial class BoardPg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardPg));
            this.PagesTable = new System.Windows.Forms.TableLayoutPanel();
            this.backBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ProgressBtn = new System.Windows.Forms.Button();
            this.TaskBtn = new System.Windows.Forms.Button();
            this.Tab = new System.Windows.Forms.Panel();
            this.BoardContent = new System.Windows.Forms.Panel();
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
            this.PagesTable.Controls.Add(this.backBtn, 0, 0);
            this.PagesTable.Controls.Add(this.ProgressBtn, 2, 0);
            this.PagesTable.Controls.Add(this.TaskBtn, 1, 0);
            this.PagesTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.PagesTable.Location = new System.Drawing.Point(0, 0);
            this.PagesTable.Name = "PagesTable";
            this.PagesTable.RowCount = 1;
            this.PagesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PagesTable.Size = new System.Drawing.Size(864, 96);
            this.PagesTable.TabIndex = 8;
            // 
            // backBtn
            // 
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.ImageKey = "single_arrow.png";
            this.backBtn.ImageList = this.imageList1;
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 36);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "single_arrow.png");
            // 
            // ProgressBtn
            // 
            this.ProgressBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProgressBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProgressBtn.FlatAppearance.BorderSize = 0;
            this.ProgressBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ProgressBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ProgressBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProgressBtn.Font = new System.Drawing.Font("Meiryo UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.ProgressBtn.Location = new System.Drawing.Point(432, 3);
            this.ProgressBtn.Name = "ProgressBtn";
            this.ProgressBtn.Size = new System.Drawing.Size(170, 90);
            this.ProgressBtn.TabIndex = 4;
            this.ProgressBtn.Text = "Progress";
            this.ProgressBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProgressBtn.UseVisualStyleBackColor = true;
            this.ProgressBtn.Click += new System.EventHandler(this.progressBtn_Click);
            // 
            // TaskBtn
            // 
            this.TaskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaskBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.TaskBtn.FlatAppearance.BorderSize = 0;
            this.TaskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TaskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskBtn.Font = new System.Drawing.Font("Meiryo UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskBtn.ForeColor = System.Drawing.Color.Black;
            this.TaskBtn.Location = new System.Drawing.Point(224, 3);
            this.TaskBtn.Name = "TaskBtn";
            this.TaskBtn.Size = new System.Drawing.Size(202, 90);
            this.TaskBtn.TabIndex = 0;
            this.TaskBtn.Text = "Task";
            this.TaskBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TaskBtn.UseVisualStyleBackColor = true;
            this.TaskBtn.Click += new System.EventHandler(this.TaskBtn_Click);
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.BoardContent);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 96);
            this.Tab.Name = "Tab";
            this.Tab.Size = new System.Drawing.Size(864, 642);
            this.Tab.TabIndex = 9;
            // 
            // BoardContent
            // 
            this.BoardContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardContent.Location = new System.Drawing.Point(0, 0);
            this.BoardContent.Name = "BoardContent";
            this.BoardContent.Size = new System.Drawing.Size(864, 642);
            this.BoardContent.TabIndex = 1;
            // 
            // BoardPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.PagesTable);
            this.Name = "BoardPg";
            this.Size = new System.Drawing.Size(864, 738);
            this.PagesTable.ResumeLayout(false);
            this.Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PagesTable;
        private System.Windows.Forms.Button ProgressBtn;
        private System.Windows.Forms.Button TaskBtn;
        private System.Windows.Forms.Panel Tab;
        private System.Windows.Forms.Panel BoardContent;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ImageList imageList1;
    }
}
