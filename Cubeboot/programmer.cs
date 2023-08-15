using Cubeboot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Cubeboot
{
    public partial class programmer : Form
    {
        public programmer()
        {
            InitializeComponent();
        }

        private void closeprg_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
            Boot1 boot = new Boot1();
            boot.ShowDialog();
            


        }

        private void StartBtn_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
        }

        private void programmer_Load(object sender, EventArgs e)
        {

        }
    }
}
