using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0; //variaveis para operações
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            txtResultado.Text += '0'; // button Zero
        }

        private void button23_Click(object sender, EventArgs e)
        {
            txtResultado.Text += '.'; // button ponto
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text += '1'; // button 1
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text += '2'; // button 2
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += '3'; // button 3
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += '4'; // button 4
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += '5'; // button 5
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += '6'; // button 6
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += '7'; // button 7
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += '8'; // button 8
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += '9'; // button 9
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text != "") 
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(valor1 + valor2);

                }
                else if (operacao == "SUB")
                {
                    txtResultado.Text = Convert.ToString(valor1 - valor2);

                }
                else if (operacao == "MULT")
                {
                    txtResultado.Text = Convert.ToString(valor1 * valor2);

                }
                else
                {
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
            else
            {
                MessageBox.Show("Realize uma operação para exibir o resultado!");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma!");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração!");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação!");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1, 1); ;
            lblOperacao.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }
        
    }
}
