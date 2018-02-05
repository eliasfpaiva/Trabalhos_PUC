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
    public partial class Calculadora : Form
    {
        char operacao = ' ';
        double resultado, valor1;
        bool existeVirgula = false, limpaDisplay = false;
        int contDecimais = 0;

        //Calculadora
        public Calculadora()
        {
            InitializeComponent();
            CenterToScreen();
            display.Text = "0";
        }

        //Display
        private void display_TextChanged(object sender, EventArgs e){ }

        //Display que indica operação em andamento
        private void displayOp_TextChanged(object sender, EventArgs e){ }

        //Teste de estado, para decidir comportamento do display.text
        private void testeEstado(string digito)
        {
            if(limpaDisplay)
            {
                if(digito == ",") { display.Text = "0,"; }
                else { display.Text = digito; }
                limpaDisplay = false;
            }
            else
            {
                if (digito == "," && display.Text == "0") { display.Text = "0,"; }
                else if (display.Text == "0") { display.Text = digito; }
                else { display.Text += digito; }
            }
            contaDecimais();
        }

        //Função igual
        private void fucaoIgual()
        {
            switch (operacao)
            {
                case '=':
                    {
                        resultado = double.Parse(display.Text);
                        break;
                    }
                case '-':
                    {
                        resultado = valor1 - (double.Parse(display.Text));
                        display.Text = resultado.ToString();
                        break;
                    }
                case '+':
                    {
                        resultado = valor1 + (double.Parse(display.Text));
                        display.Text = resultado.ToString();
                        break;
                    }
                case '*':
                    {
                        resultado = valor1 * (double.Parse(display.Text));
                        display.Text = resultado.ToString();
                        break;
                    }
                case '/':
                    {
                        resultado = valor1 / (double.Parse(display.Text));
                        display.Text = resultado.ToString();
                        break;
                    }
            }
        }
        //Contador de decimais, para desativar a flag 'existeVirgula' quando se usa Backspace
        private void contaDecimais()
        {
            if (existeVirgula)
            {
                contDecimais++;
            }
        }
        //Botões numéricos
        private void btn_zero_Click(object sender, EventArgs e)
        {            
            testeEstado("0");
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            testeEstado("1");
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            testeEstado("2");
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            testeEstado("3");
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            testeEstado("4");
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            testeEstado("5");
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            testeEstado("6");
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            testeEstado("7");
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            testeEstado("8");
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            testeEstado("9");
        }
        //Virgula
        private void btn_virgula_Click(object sender, EventArgs e)
        {
            if (!existeVirgula)
            {
                testeEstado(",");
                contDecimais++;
                existeVirgula = true;
            }
            else
            {
                MessageBox.Show("Já existe uma virgula");
            }
        }
        //Operações
        private void btn_igual_Click(object sender, EventArgs e)
        {            
            fucaoIgual();
            operacao = '=';
            displayOp.Text = operacao.ToString();
            existeVirgula = false;
            valor1 = resultado;
            limpaDisplay = true;
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            fucaoIgual();
            valor1 = double.Parse(display.Text);
            operacao = '+';
            displayOp.Text = operacao.ToString();
            existeVirgula = false;
            limpaDisplay = true;
        }

        private void btn_subtrai_Click(object sender, EventArgs e)
        {
            fucaoIgual();
            valor1 = double.Parse(display.Text);
            operacao = '-';
            displayOp.Text = operacao.ToString();
            existeVirgula = false;
            limpaDisplay = true;
        }

        private void btn_multiplica_Click(object sender, EventArgs e)
        {
            fucaoIgual();
            valor1 = double.Parse(display.Text);
            operacao = '*';
            displayOp.Text = operacao.ToString();
            existeVirgula = false;
            limpaDisplay = true;
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            fucaoIgual();
            valor1 = double.Parse(display.Text);
            operacao = '/';
            displayOp.Text = operacao.ToString();
            existeVirgula = false;
            limpaDisplay = true;
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            int contaDigitos = display.Text.Length - 1;
            if (contaDigitos >= 1 && !limpaDisplay)
            {
                display.Text = display.Text.Substring(0,contaDigitos);
                if (existeVirgula)
                {
                    contDecimais--;
                    if(contDecimais == 0)
                    {
                        existeVirgula = false;
                        display.Text = display.Text.Substring(0, contaDigitos);
                    }
                }
            }
            else
            {
                display.Text = "0";
            }
        }

        private void btn_limpaTudo_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            existeVirgula = false;
            operacao = ' ';
            displayOp.Text = operacao.ToString();
            valor1 = 0;
            limpaDisplay = false;
        }
    }
}