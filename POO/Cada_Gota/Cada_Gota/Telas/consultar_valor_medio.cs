using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cada_Gota.Classes;

namespace Cada_Gota.Telas
{
    public partial class consultar_valor_medio : Form
    {
        public consultar_valor_medio()
        {
            InitializeComponent();
        }

        private void consultar_valor_medio_Load(object sender, EventArgs e)
        {
            string[] consumidores;

            if (Funcoes.getNewId("Consumidores.txt") != 1)
            {
                consumidores = Funcoes.getIdNomeConsumidor();
                selectIdConsumidor.DataSource = consumidores;
            }
            else
            {
                selectIdConsumidor.Enabled = false;
                btn_consultar     .Enabled = false;

                MessageBox.Show("Não existe cadastro de Consumidor, favor cadastrar!");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string[] idConsumidor = selectIdConsumidor.Text.Split(':');
            string[] contas       = Funcoes.getContas(idConsumidor[0]);
            string[] dadosConta;

            double valorTotal = 0;

            for(int i = 0; i < contas.Length; i++)
            {
                dadosConta = contas[i].Split('|');
                valorTotal += double.Parse(dadosConta[9]);
            }

            valorTotal /= contas.Length;

            campoValorMedio.Text = valorTotal.ToString("N2");
        }

        private void consultar_valor_medio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.exibeMenu();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
