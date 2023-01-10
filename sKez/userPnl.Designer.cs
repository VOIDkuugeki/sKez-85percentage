namespace sKez
{
    partial class userPnl
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.userIcon = new System.Windows.Forms.Button();
            this.nameTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Meiryo UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Lavender;
            this.logoutBtn.Location = new System.Drawing.Point(74, 81);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(82, 36);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.Transparent;
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.profileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Meiryo UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.Black;
            this.profileBtn.Location = new System.Drawing.Point(3, 81);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(77, 36);
            this.profileBtn.TabIndex = 6;
            this.profileBtn.TabStop = false;
            this.profileBtn.Text = "Profile";
            this.profileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.profileBtn.UseVisualStyleBackColor = true;
            // 
            // userIcon
            // 
            this.userIcon.BackgroundImage = global::sKez.Properties.Resources.user;
            this.userIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIcon.FlatAppearance.BorderSize = 0;
            this.userIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.userIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.userIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIcon.ImageKey = "(none)";
            this.userIcon.Location = new System.Drawing.Point(1, 10);
            this.userIcon.MaximumSize = new System.Drawing.Size(64, 64);
            this.userIcon.MinimumSize = new System.Drawing.Size(40, 40);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(64, 64);
            this.userIcon.TabIndex = 4;
            this.userIcon.TabStop = false;
            this.userIcon.UseVisualStyleBackColor = true;
            // 
            // nameTag
            // 
            this.nameTag.AutoEllipsis = true;
            this.nameTag.BackColor = System.Drawing.Color.Transparent;
            this.nameTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameTag.Font = new System.Drawing.Font("Meiryo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTag.Location = new System.Drawing.Point(67, 10);
            this.nameTag.Name = "nameTag";
            this.nameTag.Size = new System.Drawing.Size(93, 64);
            this.nameTag.TabIndex = 7;
            this.nameTag.Text = User.username;
            this.nameTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userPnl
            // 
            this.AccessibleName = "userPnl";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.nameTag);
            this.Name = "userPnl";
            this.Size = new System.Drawing.Size(160, 126);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button userIcon;
        private System.Windows.Forms.Label nameTag;
    }
}
