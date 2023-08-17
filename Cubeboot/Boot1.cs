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

namespace Cubeboot
{
    public partial class Boot1 : Form

    {
        programmer prog = new programmer();
        verifier verifierForm = new verifier();
        SerialPort ComPort = new SerialPort();
        public string[] AvailablePorts;//

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
            string[] ports = SerialPort.GetPortNames();
            cmbCon.Items.AddRange(ports);
            RefreshComPorts();
           



        }

        

        private void Effacer_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click_2(object sender, EventArgs e)
        { if (button1.Text == "Disconnect")
           { 
                 verifierForm.Show();
                    this.Hide();
           }
            
        }

        private void btnProg_Click_1(object sender, EventArgs e)
        {
            if(button1.Text== "Disconnect")
            {
              prog.Show();
              this.Hide();
            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            if (button1.Text == "Connect")
            {
                



                if (cmbCon.SelectedItem != null)
                {
                    ComPort.BaudRate = 9600;
                    ComPort.PortName = cmbCon.SelectedItem.ToString(); ;
                    ComPort.Open();
                    verifierForm.test = ComPort; // Pass the list of ports to the verifier form
                    button1.Text = "Disconnect";
                    button1.BackColor = Color.Red;
                    
                }
                else
                {
                    Label l = new Label();
                    l.AutoSize = true;
                    l.Text = "Please connect to the port first";
                    l.Location = new Point(322, 145);
                    l.Font = new Font("Cooper Black", 10);
                    this.Controls.Add(l);

                    //Button Mybutton = new Button();
                    //Mybutton.Location = new Point(325, 198);
                    //Mybutton.Text = "Submit";
                    //Mybutton.AutoSize = true;
                    //Mybutton.BackColor = Color.LightBlue;
                    //Mybutton.Padding = new Padding(6);
                    //Mybutton.Font = new Font("Cooper Black", 10);
                    //this.Controls.Add(Mybutton);

                    //Task.Delay(1000);
                    //Mybutton.Visible = false;
                    // l.Visible = false;

                } 
                
            }
            else
            {   
                ComPort.Close();
                button1.Text = "Connect";
                button1.BackColor = Color.Green;
               

            }





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

        private void cmbCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       
        
        private void button3_Click(object sender, EventArgs e)
        {
            RefreshComPorts();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEff_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            if (checkVerify.Checked)
            {
                StartCLICommand(ComPort.PortName);
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
