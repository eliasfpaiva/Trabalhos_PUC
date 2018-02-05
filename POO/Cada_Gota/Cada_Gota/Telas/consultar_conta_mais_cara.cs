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
    public partial class consultar_conta_mais_cara : Form
    {
        public consultar_conta_mais_cara()
        {
            InitializeComponent();
        }

        private void consultar_conta_mais_cara_Load(object sender, EventArgs e)
        {
            string[] consumidores;

            if (Funcoes.getNewId("Consumidores.txt") != 1)
            {
                consumidores = Funcoes.getIdNomeConsumidor();
                selectIdConsumidor.DataSource = consumidores;
            }
            else
            {
                btn_consultar.Enabled = false;

                MessageBox.Show("Não existe cadastro de Consumidor, favor cadastrar!");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string[] idConsumidor = selectIdConsumidor.Text.Split(':');

            string[] dadosConta = Funcoes.getContaMaisCara(idConsumidor[0]);

            campoValor.Text    = dadosConta[0];
            campoMesAno.Text   = dadosConta[1];
            campoEndereco.Text = dadosConta[2];
        }

        private void consultar_conta_mais_cara_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.exibeMenu();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
