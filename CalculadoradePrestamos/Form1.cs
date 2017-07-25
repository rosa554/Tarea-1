using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoradePrestamos
{
    public partial class Form1 : Form
    {
        private object txtInteres;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double vrPrestamo, vrInteres, anios, monto;
            string cadena = "";

            vrPrestamo = Convert.ToDouble(txtPrestamo.Text);
            vrInteres = Convert.ToDouble(txtInteres);
            anios = Convert.ToDouble(nmAnios.Value);

            for (int i = 1; i <= anios; i++)
            {
                monto = (vrPrestamo * (1 + (vrInteres / 100))) * i;
                cadena += (i + "\t" + string.Format("{0:c}", monto + "\r\n"));
            }
            txtResultado.Text = cadena;

        }

        private void Form1_Load(object sender, EventArgs e)
        {









        }
    }
}
