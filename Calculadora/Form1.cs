using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal numero1 = 0, numero2 = 0;
        string operador = "";
        decimal resultado = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Numero7Button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void Numero8Button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void Numero9Button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void Numero4Button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void Numero5Button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void Numero6Button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void Numero1Button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void Numero2Button_Click(object sender, EventArgs e)
        {

            textBox1.Text += "2";
        }

        private void Numero3Button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Numero0Button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void CBotao_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void ACBotao_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numero1 = 0;
            numero2 = 0;
            operador = "";
        }

        private void MaisBotao_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "") {
                numero1 = decimal.Parse(textBox1.Text);

                textBox1.Text = "";
                operador = "+";
            } else {
                MessageBox.Show("Informe um valor");
            }
        }

        private void MenosBotao_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                numero1 = decimal.Parse(textBox1.Text);

                textBox1.Text = "";
                operador = "-";
            } else {
                MessageBox.Show("Informe um valor");
            }
        }

        private void MultiplicacaoBotao_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                numero1 = decimal.Parse(textBox1.Text);

                textBox1.Text = "";
                operador = "X";
            } else {
                MessageBox.Show("Informe um valor");
            }
        }

        private void DividirBotao_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                numero1 = decimal.Parse(textBox1.Text);

                textBox1.Text = "";
                operador = "/";
            } else {
                MessageBox.Show("Informe um valor");
            }
        }

        private void ResultadoBotao_Click(object sender, EventArgs e)
        {
            numero2 = decimal.Parse(textBox1.Text);

            if (operador == "+") resultado = numero1 + numero2;
            if (operador == "-") resultado = numero1 - numero2;
            if (operador == "X") resultado = numero1 * numero2;
            if (operador == "/") resultado = numero1 / numero2;

            textBox1.Text = resultado.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
