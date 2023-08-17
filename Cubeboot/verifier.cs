using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cubeboot;

namespace Cubeboot
{
    public partial class verifier : Form

    {
        public string[] AvailablePorts;//
        public SerialPort test;//

        private static string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private static string directory = Path.GetDirectoryName(exePath);

        private string srec_cat_path = $"{directory}\\Tools\\STM32ProgrammerCLI\\STM32_Programmer_CLI.exe";

        private Process _process;

        char[] buffer = new char[4096];
        public verifier()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Boot1 boot = new Boot1();
            boot.ShowDialog();
        }

        private void verifier_Load(object sender, EventArgs e)
        {
            if (test.IsOpen)
            {
                test.Close();
            }
            Task.Delay(1000);

            StartCLICommand(test.PortName);

        }

        private async Task ReadOutputAsync()
        {

            using (StreamReader reader = _process.StandardOutput)
            {
                while (!_process.HasExited)
                {
                    int bytesRead = await reader.ReadAsync(buffer, 0, buffer.Length);


                    if (bytesRead > 0)
                    {
                        txtVer.Invoke(new Action(() =>
                        {
                            txtVer.Text += new string(buffer, 0, bytesRead);

                        }));
                        
                       
                    }
                }
            }
        }



        public void StartCLICommand(string ComPort)
        {
            string arguemnts = $"-c {ComPort} -v"; 
            _process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = srec_cat_path,
                    Arguments = arguemnts,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = false,
                    WindowStyle = ProcessWindowStyle.Hidden
                },
                EnableRaisingEvents = true
            };

            _process.Start();
            Task.Run(ReadOutputAsync);
        }

        private void txtVer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
