using Cubeboot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cubeboot
{
    public partial class Boot1 : Form

    {

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

        

        private void Effacer_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            verifier ver = new verifier();
            ver.Show();
            this.Hide();
        }

        private void btnProg_Click_1(object sender, EventArgs e)
        {

            programmer prog = new programmer();
            prog.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string[] ArrayComPortsNames = null;
                int index = -1;
                string ComPortName = null;

                ArrayComPortsNames = SerialPort.GetPortNames();
                do
                {
                    index += 1;
                    //rtbIncoming.Text += ArrayComPortsNames[index] + "\n";
                }
                while (!((ArrayComPortsNames[index] == ComPortName) ||
                                    (index == ArrayComPortsNames.GetUpperBound(0))));
            
        }
    }
}
