using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Estado_Click(object sender, EventArgs e)
        {
            Form nuevaVentana = new Form2();
            nuevaVentana.Show();
        }

        private void Cambio_Click(object sender, EventArgs e)
        {
            Form nuevaVentana = new Form();
            nuevaVentana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
