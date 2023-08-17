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
            this.txtVer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblVerifier
            // 
            this.LblVerifier.AutoSize = true;
            this.LblVerifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVerifier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblVerifier.Location = new System.Drawing.Point(8, 6);
            this.LblVerifier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblVerifier.Name = "LblVerifier";
            this.LblVerifier.Size = new System.Drawing.Size(81, 26);
            this.LblVerifier.TabIndex = 0;
            this.LblVerifier.Text = "Verifier";
            // 
            // Lblver
            // 
            this.Lblver.AutoSize = true;
            this.Lblver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lblver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblver.ForeColor = System.Drawing.Color.Red;
            this.Lblver.Location = new System.Drawing.Point(375, -1);
            this.Lblver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lblver.Name = "Lblver";
            this.Lblver.Size = new System.Drawing.Size(28, 26);
            this.Lblver.TabIndex = 1;
            this.Lblver.Text = "X";
            this.Lblver.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtVer
            // 
            this.txtVer.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtVer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtVer.Location = new System.Drawing.Point(13, 57);
            this.txtVer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVer.Multiline = true;
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(371, 187);
            this.txtVer.TabIndex = 2;
            this.txtVer.TextChanged += new System.EventHandler(this.txtVer_TextChanged);
            // 
            // verifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(400, 292);
            this.Controls.Add(this.txtVer);
            this.Controls.Add(this.Lblver);
            this.Controls.Add(this.LblVerifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox txtVer;
    }
}