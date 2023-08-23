namespace Cubeboot
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
            this.result = new System.Windows.Forms.TextBox();
            this.RunBtn = new System.Windows.Forms.Button();
            this.checkErase = new System.Windows.Forms.CheckBox();
            this.checkverify = new System.Windows.Forms.CheckBox();
            this.checkwrite = new System.Windows.Forms.CheckBox();
            this.checkBlank = new System.Windows.Forms.CheckBox();
            this.cmbCon = new System.Windows.Forms.ComboBox();
            this.X = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkread = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.InfoText;
            this.result.Location = new System.Drawing.Point(653, 151);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(455, 291);
            this.result.TabIndex = 0;
            // 
            // RunBtn
            // 
            this.RunBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.RunBtn.Font = new System.Drawing.Font("3ds", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.RunBtn.Location = new System.Drawing.Point(12, 260);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(128, 46);
            this.RunBtn.TabIndex = 1;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = false;
            // 
            // checkErase
            // 
            this.checkErase.AutoSize = true;
            this.checkErase.Font = new System.Drawing.Font("3ds", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkErase.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkErase.Location = new System.Drawing.Point(12, 109);
            this.checkErase.Name = "checkErase";
            this.checkErase.Size = new System.Drawing.Size(69, 23);
            this.checkErase.TabIndex = 2;
            this.checkErase.Text = "Erase";
            this.checkErase.UseVisualStyleBackColor = true;
            // 
            // checkverify
            // 
            this.checkverify.AutoSize = true;
            this.checkverify.Font = new System.Drawing.Font("3ds", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkverify.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkverify.Location = new System.Drawing.Point(12, 142);
            this.checkverify.Name = "checkverify";
            this.checkverify.Size = new System.Drawing.Size(75, 23);
            this.checkverify.TabIndex = 3;
            this.checkverify.Text = "Verify";
            this.checkverify.UseVisualStyleBackColor = true;
            // 
            // checkwrite
            // 
            this.checkwrite.AutoSize = true;
            this.checkwrite.Font = new System.Drawing.Font("3ds", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkwrite.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkwrite.Location = new System.Drawing.Point(12, 174);
            this.checkwrite.Name = "checkwrite";
            this.checkwrite.Size = new System.Drawing.Size(108, 23);
            this.checkwrite.TabIndex = 4;
            this.checkwrite.Text = "Download";
            this.checkwrite.UseVisualStyleBackColor = true;
            // 
            // checkBlank
            // 
            this.checkBlank.AutoSize = true;
            this.checkBlank.Font = new System.Drawing.Font("3ds", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBlank.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBlank.Location = new System.Drawing.Point(12, 231);
            this.checkBlank.Name = "checkBlank";
            this.checkBlank.Size = new System.Drawing.Size(115, 23);
            this.checkBlank.TabIndex = 5;
            this.checkBlank.Text = "BlankCheck";
            this.checkBlank.UseVisualStyleBackColor = true;
            // 
            // cmbCon
            // 
            this.cmbCon.FormattingEnabled = true;
            this.cmbCon.Location = new System.Drawing.Point(54, 78);
            this.cmbCon.Name = "cmbCon";
            this.cmbCon.Size = new System.Drawing.Size(146, 21);
            this.cmbCon.TabIndex = 6;
            this.cmbCon.SelectedIndexChanged += new System.EventHandler(this.cmbCon_SelectedIndexChanged_1);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.BackColor = System.Drawing.Color.AliceBlue;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.Red;
            this.X.Location = new System.Drawing.Point(1246, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(27, 25);
            this.X.TabIndex = 7;
            this.X.Text = "X";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cubeboot.Properties.Resources.Hutchinson__Unternehmen__logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(12, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 31);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("3ds", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowse.Location = new System.Drawing.Point(999, 107);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(99, 38);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(653, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(340, 42);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // checkread
            // 
            this.checkread.AutoSize = true;
            this.checkread.Font = new System.Drawing.Font("3ds", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkread.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkread.Location = new System.Drawing.Point(12, 202);
            this.checkread.Name = "checkread";
            this.checkread.Size = new System.Drawing.Size(83, 23);
            this.checkread.TabIndex = 14;
            this.checkread.Text = "Upload";
            this.checkread.UseVisualStyleBackColor = true;
            // 
            // Boot1
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1274, 570);
            this.Controls.Add(this.checkread);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.X);
            this.Controls.Add(this.cmbCon);
            this.Controls.Add(this.checkBlank);
            this.Controls.Add(this.checkwrite);
            this.Controls.Add(this.checkverify);
            this.Controls.Add(this.checkErase);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Boot1";
            this.Load += new System.EventHandler(this.Boot1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.CheckBox checkErase;
        private System.Windows.Forms.CheckBox checkverify;
        private System.Windows.Forms.CheckBox checkwrite;
        private System.Windows.Forms.CheckBox checkBlank;
        private System.Windows.Forms.ComboBox cmbCon;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkread;
    }
}