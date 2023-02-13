namespace sKez
{
    partial class UCDays_month
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
            this.numLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numLbl
            // 
            this.numLbl.AutoSize = true;
            this.numLbl.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLbl.Location = new System.Drawing.Point(4, 4);
            this.numLbl.Name = "numLbl";
            this.numLbl.Size = new System.Drawing.Size(34, 25);
            this.numLbl.TabIndex = 0;
            this.numLbl.Text = "00";
            this.numLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.numLbl);
            this.Name = "UCDays";
            this.Size = new System.Drawing.Size(116, 84);
            this.Load += new System.EventHandler(this.ucDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numLbl;
    }
}
