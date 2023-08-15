namespace Cubeboot
{
    partial class programmer
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
            this.LblProg = new System.Windows.Forms.Label();
            this.closeprg = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.TxtRun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblProg
            // 
            this.LblProg.AutoSize = true;
            this.LblProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblProg.Location = new System.Drawing.Point(0, -1);
            this.LblProg.Name = "LblProg";
            this.LblProg.Size = new System.Drawing.Size(206, 37);
            this.LblProg.TabIndex = 0;
            this.LblProg.Text = "Programmer";
            // 
            // closeprg
            // 
            this.closeprg.AutoSize = true;
            this.closeprg.BackColor = System.Drawing.Color.White;
            this.closeprg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.closeprg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeprg.ForeColor = System.Drawing.Color.Red;
            this.closeprg.Location = new System.Drawing.Point(562, -1);
            this.closeprg.Name = "closeprg";
            this.closeprg.Size = new System.Drawing.Size(41, 39);
            this.closeprg.TabIndex = 9;
            this.closeprg.Text = "X";
            this.closeprg.Click += new System.EventHandler(this.closeprg_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.Red;
            this.btnRun.Location = new System.Drawing.Point(48, 56);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(107, 45);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // TxtRun
            // 
            this.TxtRun.Location = new System.Drawing.Point(29, 135);
            this.TxtRun.Multiline = true;
            this.TxtRun.Name = "TxtRun";
            this.TxtRun.Size = new System.Drawing.Size(550, 288);
            this.TxtRun.TabIndex = 11;
            this.TxtRun.TextChanged += new System.EventHandler(this.TxtRun_TextChanged);
            // 
            // programmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.TxtRun);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.closeprg);
            this.Controls.Add(this.LblProg);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "programmer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programmer";
            this.Load += new System.EventHandler(this.programmer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProg;
        private System.Windows.Forms.Label closeprg;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox TxtRun;
    }
}