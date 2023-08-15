namespace Cubeboot
{
    partial class verifier
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblVerifier = new System.Windows.Forms.Label();
            this.Lblver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblVerifier
            // 
            this.LblVerifier.AutoSize = true;
            this.LblVerifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVerifier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblVerifier.Location = new System.Drawing.Point(12, 9);
            this.LblVerifier.Name = "LblVerifier";
            this.LblVerifier.Size = new System.Drawing.Size(118, 37);
            this.LblVerifier.TabIndex = 0;
            this.LblVerifier.Text = "Verifier";
            // 
            // Lblver
            // 
            this.Lblver.AutoSize = true;
            this.Lblver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lblver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblver.ForeColor = System.Drawing.Color.Red;
            this.Lblver.Location = new System.Drawing.Point(562, -1);
            this.Lblver.Name = "Lblver";
            this.Lblver.Size = new System.Drawing.Size(39, 37);
            this.Lblver.TabIndex = 1;
            this.Lblver.Text = "X";
            this.Lblver.Click += new System.EventHandler(this.label1_Click);
            // 
            // verifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.Lblver);
            this.Controls.Add(this.LblVerifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "verifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.verifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVerifier;
        private System.Windows.Forms.Label Lblver;
    }
}