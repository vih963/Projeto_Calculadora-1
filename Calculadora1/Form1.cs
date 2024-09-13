using System;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        int valor1;
        int valor2;
        string operacao;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtValor.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtValor.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtValor.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtValor.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtValor.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtValor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtValor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtValor.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtValor.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtValor.Text += "0";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Apaga tudo
            // txtValor.Text = "";

            int tamanho = txtValor.Text.Length;

            if (tamanho > 0)
            {
                string texto = txtValor.Text.Remove(tamanho - 1);

                txtValor.Text = texto;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int numero;

            int.TryParse(txtValor.Text, out numero);

            if (numero <= 0)
            {
                MessageBox.Show("Informe um número válido");
            }
            else
            {
                valor1 = numero;

                lblCalculo.Text = txtValor.Text + " + ";
                txtValor.Text = "";
                operacao = "+";
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int numero;

            int.TryParse(txtValor.Text, out numero);

            if (numero <= 0)
            {
                MessageBox.Show("Informe um número válido");
            }
            else
            {
                valor1 = numero;
                lblCalculo.Text = txtValor.Text + " - ";
                txtValor.Text = "";
                operacao = "-";
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero;

            int.TryParse(txtValor.Text, out numero);

            if (numero <= 0)
            {
                MessageBox.Show("Informe um número válido");
            }
            else
            {
                valor1 = numero;
                lblCalculo.Text = txtValor.Text + " x ";
                txtValor.Text = "";
                operacao = "x";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numero;

            int.TryParse(txtValor.Text, out numero);

            if (numero <= 0)
            {
                MessageBox.Show("Informe um número válido");
            }
            else
            {
                valor1 = numero;
                lblCalculo.Text = txtValor.Text + " / ";
                txtValor.Text = "";
                operacao = "/";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            int numero;

            int.TryParse(txtValor.Text, out numero);

            if (numero <= 0)
            {
                MessageBox.Show("Informe um número válido");
            }
            else
            {
                valor2 = numero;

                string operadorSelecionado = operacao.ToLower().Replace(" ", "");

                int resultado = 0;

                // Usando Switch
                switch (operadorSelecionado)
                {
                    case "+":
                        resultado = valor1 + valor2;
                        break;

                    case "-":
                        resultado = valor1 - valor2;
                        break;

                    case "/":
                        resultado = valor1 / valor2;
                        break;

                    case "x":
                        resultado = valor1 * valor2;
                        break;

                    default:
                        break;
                }

                string texto1 = string.Format("{0} {1} = {2}", lblCalculo.Text, txtValor.Text, resultado);

                string text2 = $" { lblCalculo.Text } { txtValor.Text } = { resultado} ";

                lblCalculo.Text = text2;

                txtValor.Text = resultado.ToString();
            }
        }
    }
}
