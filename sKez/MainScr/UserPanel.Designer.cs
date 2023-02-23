namespace sKez
{
    partial class UserPanel
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
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.UserIcon = new System.Windows.Forms.Button();
            this.NameTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Meiryo UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.Lavender;
            this.LogoutBtn.Location = new System.Drawing.Point(33, 87);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(82, 36);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Log out";
            this.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // UserIcon
            // 
            this.UserIcon.BackgroundImage = global::sKez.Properties.Resources.user;
            this.UserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserIcon.FlatAppearance.BorderSize = 0;
            this.UserIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UserIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.UserIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserIcon.ImageKey = "(none)";
            this.UserIcon.Location = new System.Drawing.Point(1, 10);
            this.UserIcon.MaximumSize = new System.Drawing.Size(64, 64);
            this.UserIcon.MinimumSize = new System.Drawing.Size(40, 40);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(64, 64);
            this.UserIcon.TabIndex = 4;
            this.UserIcon.TabStop = false;
            this.UserIcon.UseVisualStyleBackColor = true;
            // 
            // NameTag
            // 
            this.NameTag.AutoEllipsis = true;
            this.NameTag.BackColor = System.Drawing.Color.Transparent;
            this.NameTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameTag.Font = new System.Drawing.Font("Meiryo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTag.Location = new System.Drawing.Point(67, 10);
            this.NameTag.Name = "NameTag";
            this.NameTag.Size = new System.Drawing.Size(93, 64);
            this.NameTag.TabIndex = 7;
            this.NameTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPnl
            // 
            this.AccessibleName = "userPnl";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.UserIcon);
            this.Controls.Add(this.NameTag);
            this.Name = "UserPnl";
            this.Size = new System.Drawing.Size(160, 126);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button UserIcon;
        private System.Windows.Forms.Label NameTag;
    }
}
