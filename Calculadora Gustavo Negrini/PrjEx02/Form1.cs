using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEx02
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(txtNumero1.Text);
            valor2 = double.Parse(txtNumero2.Text);

            resultado = valor1 + valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(txtNumero1.Text);
            valor2 = double.Parse(txtNumero2.Text);

            resultado = valor1 - valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(txtNumero1.Text);
            valor2 = double.Parse(txtNumero2.Text);

            resultado = valor1 * valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(txtNumero1.Text);
            valor2 = double.Parse(txtNumero2.Text);

            resultado = valor1 / valor2;

            lblResultado.Text = resultado.ToString();
        }
    }
}
