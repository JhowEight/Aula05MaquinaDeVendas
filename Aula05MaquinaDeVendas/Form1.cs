using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05MaquinaDeVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            double total = int.Parse(lblTotalValor.Text);

            int pagar;
            pagar = int.Parse(txtDinheiro.Text); ;
            if(pagar >= total)
            {
                MessageBox.Show("Compra finalizada!");
            }
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            double valor = 2.5;
            double total = double.Parse(lblTotalValor.Text);
            double soma = valor + total;
            lblTotalValor.Text = soma.ToString();
        }

        private void btnSuco_Click(object sender, EventArgs e)
        {
            double valor = 7;
            double total = double.Parse(lblTotalValor.Text);
            double soma = valor + total;
            lblTotalValor.Text = soma.ToString();
        }

        private void btnSalgadinho_Click(object sender, EventArgs e)
        {
            double valor = 5;
            double total = double.Parse(lblTotalValor.Text);
            double soma = valor + total;
            lblTotalValor.Text = soma.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblTotalValor.Text = Convert.ToString("0");
        }
    }
}
