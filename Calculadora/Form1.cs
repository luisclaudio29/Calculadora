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
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// Botão 1 é o número 7
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)// botão 2 é o número 8
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)// botão 3 é o número 9
        {
            txtResultado.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)// botão 4 é o sinal de mais +
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
                MessageBox.Show("Informe um valor para efetuar a soma.");
            }
        }

        private void button5_Click(object sender, EventArgs e)// botão 5 é a função CE
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)// botão 6 é o número 4
        {
            txtResultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)// botão 7 é o número 5
        {
            txtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)// botão 8 é o número 6
        {
            txtResultado.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)// botão 9 é o sinal de menos -
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Subtração");
            }
        }

        private void button10_Click(object sender, EventArgs e)// botão 10 é a função C limpar
        {
            if (txtResultado.Text != "")
            {
                valor1 = 0;
                valor2 = 0;
                lblOperacao.Text = "";
            }
      }

        private void button11_Click(object sender, EventArgs e)// botão 11 é o número 1
        {
            txtResultado.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)// botão 12 é o número 2
        {
            txtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)// botão 13 é o número 3
        {
            txtResultado.Text += "3";
        }

        private void button14_Click(object sender, EventArgs e)// botão 14 é a função vezez (X)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTIPLICACAO";
                lblOperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Multiplicação");
            }
        }

        private void button15_Click(object sender, EventArgs e)// botão 15 é a função igual (=)
        {
            if (txtResultado.Text != "")
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            }
           
            
            
            if(operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            } 
            
            
            
            else if (operacao == "SUBTRACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            } 
            
            else if (operacao == "MULTIPLICACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            } 
           
            
            else
           
            { 
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button16_Click(object sender, EventArgs e)// botão 16 é o número 0
        {
            txtResultado.Text += "0";
        }

        private void button17_Click(object sender, EventArgs e)// botão 17 é o sinal de ponto
        {
            txtResultado.Text += ".";
        }

        private void button18_Click(object sender, EventArgs e)// botão 18 é o sinal de divisão
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIVISAO";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Divisão");
            }    
        }
    }
}
