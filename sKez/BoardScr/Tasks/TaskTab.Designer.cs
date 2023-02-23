namespace sKez
{
    partial class TaskTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskTab));
            this.ImageBtn = new System.Windows.Forms.ImageList(this.components);
            this.BoardContent = new System.Windows.Forms.FlowLayoutPanel();
            this.AddNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImageBtn
            // 
            this.ImageBtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageBtn.ImageStream")));
            this.ImageBtn.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageBtn.Images.SetKeyName(0, "pin-icon.png");
            this.ImageBtn.Images.SetKeyName(1, "close-icon.png");
            // 
            // BoardContent
            // 
            this.BoardContent.AutoScroll = true;
            this.BoardContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoardContent.Location = new System.Drawing.Point(0, 0);
            this.BoardContent.Name = "BoardContent";
            this.BoardContent.Padding = new System.Windows.Forms.Padding(12);
            this.BoardContent.Size = new System.Drawing.Size(864, 607);
            this.BoardContent.TabIndex = 8;
            // 
            // AddNote
            // 
            this.AddNote.ImageIndex = 0;
            this.AddNote.ImageList = this.ImageBtn;
            this.AddNote.Location = new System.Drawing.Point(792, 571);
            this.AddNote.Name = "AddNote";
            this.AddNote.Size = new System.Drawing.Size(64, 64);
            this.AddNote.TabIndex = 7;
            this.AddNote.TabStop = false;
            this.AddNote.UseVisualStyleBackColor = true;
            this.AddNote.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // TaskTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.AddNote);
            this.Controls.Add(this.BoardContent);
            this.Name = "TaskTab";
            this.Size = new System.Drawing.Size(864, 642);
            this.Load += new System.EventHandler(this.TaskTab_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNote;
        private System.Windows.Forms.ImageList ImageBtn;
        private System.Windows.Forms.FlowLayoutPanel BoardContent;
    }
}
