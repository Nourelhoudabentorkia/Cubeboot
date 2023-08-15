using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cubeboot;

namespace Cubeboot
{
    public partial class verifier : Form
    {
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

        }
    }
}
