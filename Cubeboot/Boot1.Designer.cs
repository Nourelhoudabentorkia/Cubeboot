﻿namespace Cubeboot
{
    partial class Boot1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boot1));
            this.close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEff = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnProg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.X = new System.Windows.Forms.Label();
            this.cmbCon = new System.Windows.Forms.ComboBox();
            this.checkErase = new System.Windows.Forms.CheckBox();
            this.checkprog = new System.Windows.Forms.CheckBox();
            this.checkVerify = new System.Windows.Forms.CheckBox();
            this.RunBtn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Crimson;
            this.close.Location = new System.Drawing.Point(1302, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 37);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(252, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(426, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "CubeBootLoader";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEff
            // 
            this.btnEff.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEff.Font = new System.Drawing.Font("3ds", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEff.Location = new System.Drawing.Point(72, 288);
            this.btnEff.Name = "btnEff";
            this.btnEff.Size = new System.Drawing.Size(152, 31);
            this.btnEff.TabIndex = 4;
            this.btnEff.Text = "Erase";
            this.btnEff.UseVisualStyleBackColor = false;
            this.btnEff.Click += new System.EventHandler(this.btnEff_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("3ds", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(72, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "verifier";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btnProg
            // 
            this.btnProg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProg.Font = new System.Drawing.Font("3ds", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProg.Location = new System.Drawing.Point(72, 337);
            this.btnProg.Name = "btnProg";
            this.btnProg.Size = new System.Drawing.Size(152, 31);
            this.btnProg.TabIndex = 6;
            this.btnProg.Text = "Programmer";
            this.btnProg.UseVisualStyleBackColor = false;
            this.btnProg.Click += new System.EventHandler(this.btnProg_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("3ds", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1124, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(792, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 46);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1054, 446);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(235, 151);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // X
            // 
            this.X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.Red;
            this.X.Location = new System.Drawing.Point(1238, 9);
            this.X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(39, 37);
            this.X.TabIndex = 11;
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // cmbCon
            // 
            this.cmbCon.FormattingEnabled = true;
            this.cmbCon.ItemHeight = 20;
            this.cmbCon.Location = new System.Drawing.Point(848, 101);
            this.cmbCon.Name = "cmbCon";
            this.cmbCon.Size = new System.Drawing.Size(268, 28);
            this.cmbCon.TabIndex = 8;
            this.cmbCon.SelectedIndexChanged += new System.EventHandler(this.cmbCon_SelectedIndexChanged);
            // 
            // checkErase
            // 
            this.checkErase.AutoSize = true;
            this.checkErase.Location = new System.Drawing.Point(44, 295);
            this.checkErase.Name = "checkErase";
            this.checkErase.Size = new System.Drawing.Size(22, 21);
            this.checkErase.TabIndex = 12;
            this.checkErase.UseVisualStyleBackColor = true;
            // 
            // checkprog
            // 
            this.checkprog.AutoSize = true;
            this.checkprog.Location = new System.Drawing.Point(44, 344);
            this.checkprog.Name = "checkprog";
            this.checkprog.Size = new System.Drawing.Size(22, 21);
            this.checkprog.TabIndex = 13;
            this.checkprog.UseVisualStyleBackColor = true;
            // 
            // checkVerify
            // 
            this.checkVerify.AutoSize = true;
            this.checkVerify.Location = new System.Drawing.Point(44, 394);
            this.checkVerify.Name = "checkVerify";
            this.checkVerify.Size = new System.Drawing.Size(22, 21);
            this.checkVerify.TabIndex = 14;
            this.checkVerify.UseVisualStyleBackColor = true;
            // 
            // RunBtn
            // 
            this.RunBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.RunBtn.Font = new System.Drawing.Font("3ds", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBtn.Location = new System.Drawing.Point(487, 528);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(147, 46);
            this.RunBtn.TabIndex = 15;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = false;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(362, 209);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(455, 291);
            this.result.TabIndex = 16;
            this.result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Boot1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1290, 609);
            this.Controls.Add(this.result);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.checkVerify);
            this.Controls.Add(this.checkprog);
            this.Controls.Add(this.checkErase);
            this.Controls.Add(this.X);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbCon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Boot1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boot1";
            this.Load += new System.EventHandler(this.Boot1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnProg;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbCon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.CheckBox checkErase;
        private System.Windows.Forms.CheckBox checkprog;
        private System.Windows.Forms.CheckBox checkVerify;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.TextBox result;
    }
}