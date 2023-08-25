using Cubeboot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Cubeboot
{
    public partial class Boot1 : Form

    {
        programmer prog = new programmer();
        verifier verifierForm = new verifier();
        SerialPort ComPort = new SerialPort();

        public string[] AvailablePorts;//
        //SerialPort serialPort = new SerialPort();


        private static string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private static string directory = Path.GetDirectoryName(exePath);

        private string srec_cat_path = $"{directory}\\Tools\\STM32ProgrammerCLI\\STM32_Programmer_CLI.exe";

        private Process _process;

        char[] buffer = new char[4096];


        public Boot1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void Boot1_Load(object sender, EventArgs e)
        {
            
        }





        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {


        }






        private void button1_Click(object sender, EventArgs e)
        {

        }









        private void RefreshComPorts()
        {
            string[] availablePorts = SerialPort.GetPortNames();

            cmbCon.Items.Clear();

            if (availablePorts.Length > 0)
            {
                cmbCon.Items.AddRange(availablePorts);
                cmbCon.SelectedIndex = 0;
            }
            else
            {
                cmbCon.Text = "No COM  available";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private async void cmbCon_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
            
        }


            private void button3_Click(object sender, EventArgs e)
            {
              
            }

            private void pictureBox3_Click(object sender, EventArgs e)
            {

            }

            private void X_Click(object sender, EventArgs e)
            {
                
            }



            private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }


            private async void RunBtn_Click(object sender, EventArgs e)
        {
            

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
                        result.Invoke(new Action(() =>
                        {
                            result.Text += new string(buffer, 0, bytesRead);
                            result.SelectionStart = result.TextLength;
                            result.ScrollToCaret();
                            RunBtn.Enabled = true;
                            manual.Enabled = true;
                            Application.UseWaitCursor = false;
                            //MessageBox.Show("Valid", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }));
                        

                    }
                }
                }
            }



            public void StartCLICommand(string ComPort, bool verif, bool erase, bool up, bool down, bool blank, bool manually)
            {
                string arguemnts = $"-c port={ComPort} br=115200 ";
                if (checkErase.Checked)
                {
                    arguemnts += "-e all";
                }
            if (checkwrite.Checked)
            {
                //btnBrowse.Visible = true;
                //Browseread.Visible = false;
                //richTextread.Visible = false;
                //richTextBox1.Visible = true;
                
                
                    arguemnts += $"-w {richTextBox1.Text} 0x08000000 ";
                
                
            }
            if (checkverify.Checked)
                {
                arguemnts += "-v";
                }
           
            if (checkread.Checked)
            {
                //btnBrowse.Visible = false;
                //Browseread.Visible = true;
                //richTextread.Visible = true;
                //richTextBox1.Visible = false;
                
                string regexPattern = @"^0x[0-9A-Fa-f]{8}$";
                string regexPattern1 = @"^\d{3}$";
                Regex regex = new Regex(regexPattern);
                Regex regex1 = new Regex(regexPattern1);
                if (regex.IsMatch(richTextBox2.Text) && regex1.IsMatch(richTextBox3.Text))
                {
                    arguemnts += $"-r {richTextBox2.Text} {richTextBox3.Text} {richTextread.Text}";
                }
                

            }
           
            if (checkBlank.Checked)
            {
                arguemnts += "-blankcheck";
            }
            if(manual.Enabled)
            {
                arguemnts = $" { richTextBox4.Text} ";
            }
            _process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = srec_cat_path,
                        Arguments = arguemnts,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                    },
                    EnableRaisingEvents = true
                };

                _process.Start();
                Task.Run(ReadOutputAsync);
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void btnbrowse_Click(object sender, EventArgs e)
            {
                



            }

        private void richTxtbrowse_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBlank_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void cmbCon_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCon.SelectedItem != null)
            {
                ComPort.BaudRate = 9600;
                ComPort.PortName = cmbCon.SelectedItem.ToString(); ;
                verifierForm.test = ComPort;



            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            RefreshComPorts();
        }

        private void Boot1_Load_1(object sender, EventArgs e)
        {
            try
            {
                btnBrowse.Visible = false;
                Browseread.Visible = false;
                richTextread.Visible = false;
                richTextBox1.Visible = false;
                string[] ports = SerialPort.GetPortNames();
                cmbCon.Items.AddRange(ports);
                RefreshComPorts();
                Application.UseWaitCursor = false;
                result.ReadOnly = true;
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void RunBtn_Click_1(object sender, EventArgs e)
        {
            try
            {

                string regexPattern = @"^COM\d+$";
                Regex regex = new Regex(regexPattern);

                if (!regex.IsMatch(cmbCon.Text) || (!checkErase.Checked && !checkverify.Checked && !checkread.Checked && !checkwrite.Checked && !checkBlank.Checked))
                {
                    MessageBox.Show("check Input ", "Erreur de port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                result.Clear();
                RunBtn.Enabled = false;
                // label2.Visible = true;
                Application.UseWaitCursor = true;


                StartCLICommand(ComPort.PortName, checkErase.Checked, checkverify.Checked, checkread.Checked, checkwrite.Checked, checkBlank.Checked ,manual.Enabled);
               

                //

                //else
                //{
                //    MessageBox.Show("Please connect to the port first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }

        }

        private void X_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {

                file.InitialDirectory = "c:\\";
                file.Filter = "Hex Files (*.hex)|*.hex|All Files (*.*)|*.*";
                file.FilterIndex = 2;
                file.RestoreDirectory = true;
                richTextBox1.Text = file.FileName;
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkverify_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkwrite_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkwrite.Checked)
            {
                btnBrowse.Visible = true;
                richTextBox1.Visible = true;
            }
            else
            {
                
                btnBrowse.Visible = false;
                richTextBox1.Visible = false;
            }
            if (!checkwrite.Checked)
            {
                richTextBox3.Clear();
            }


        }

        private void checkread_CheckedChanged(object sender, EventArgs e)
        {
            if (checkread.Checked)
            {
                Browseread.Visible = true;
                richTextread.Visible = true;
            }
            else
            {
                Browseread.Visible = false;
                richTextread.Visible = false;
            }
            if (!checkread.Checked)
            {
                richTextread.Clear();
            }
        }

        private void Browseread_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    richTextread.Text = fbd.SelectedPath+"\\dboot.hex";
                }
            }
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void manual_Click(object sender, EventArgs e)
        {
            RunBtn.Enabled = false;
            manual.Enabled = false;
            result.Clear();
            _process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = srec_cat_path,
                    Arguments = richTextBox4.Text,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                },
                EnableRaisingEvents = true
            };

            _process.Start();
            Task.Run(ReadOutputAsync);

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}

