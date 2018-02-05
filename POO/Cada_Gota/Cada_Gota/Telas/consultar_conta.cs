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
    public partial class consultar_conta : Form
    {
        public consultar_conta()
        {
            InitializeComponent();
        }

        private void consultar_conta_Load(object sender, EventArgs e)
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
                selectContasConsumidor.Enabled = false;
                btnExibirDadosConta.Enabled = false;
                btn_ok.Enabled = false;

                MessageBox.Show("Não existe cadastro de Consumidor, favor cadastrar!");
            }
        }

        private void selectIdConsumidor_Leave(object sender, EventArgs e)
        {
            string[] contas = Funcoes.getContasConsumidor(selectIdConsumidor.Text);

            selectContasConsumidor.DataSource = contas;

            if (String.IsNullOrEmpty(selectContasConsumidor.Text) == true)
            {
                MessageBox.Show("Não existe conta cadastrada para este Consumidor!");
            }
        }

        private void btnExibirDadosConta_Click(object sender, EventArgs e)
        {
            try
            {
                string[] divisor = selectContasConsumidor.Text.Split('|');

                string conta = Funcoes.getRegistro("Contas.txt", divisor[0]);
                divisor = conta.Split('|');
                string idConsumidor = divisor[1];
                string idImovel = divisor[2];

                double valor = double.Parse(divisor[9]);
                double valorSemImposto = double.Parse(divisor[8]);

                campoPeriodo.Text = divisor[3] + "/" + divisor[4];
                campoLeituraInicial.Text = divisor[5];
                campoLeituraFinal.Text = divisor[6];
                campoConsumo.Text = divisor[7];
                campoValorTotal.Text = valor.ToString("N2");
                campoValorTotalSemImpostos.Text = valorSemImposto.ToString("N2");

                string Consumidor = Funcoes.getRegistro("Consumidores.txt", idConsumidor);
                divisor = Consumidor.Split('|');

                campoNomeConsumidor.Text = divisor[1];
                campoCpfConsumidor.Text = divisor[2];
                campoIdentidadeConsumidor.Text = divisor[3];

                string imovel = Funcoes.getRegistro("Imóveis.txt", idImovel);
                divisor = imovel.Split('|');

                campoEnderecoConsumidor.Text = divisor[3];
                campoBairroConsumidor.Text = divisor[4];
                campoNumeroConsumidor.Text = divisor[2];
                campoComplementoConsumidor.Text = divisor[5];
                campoCidadeConsumidor.Text = divisor[6];
                campoEstadoConsumidor.Text = divisor[7];
                campoCepConsumidor.Text = divisor[8];
                campoPaisConsumidor.Text = divisor[9];
                campoTipoImovel.Text = divisor[10];
                campoTipoServico.Text = divisor[11];

                if (divisor[11] == "FORNECIMENTO DE ÁGUA")
                {
                    campoUnidadeMedida_1.Text = "m³";
                    campoUnidadeMedida_2.Text = "m³";
                    campoUnidadeMedida_3.Text = "m³";
                }
                else if (divisor[11] == "FORNECIMENTO DE ENERGIA ELÉTRICA")
                {
                    campoUnidadeMedida_1.Text = "kW";
                    campoUnidadeMedida_2.Text = "kW";
                    campoUnidadeMedida_3.Text = "kW";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não existe conta cadastrada para este Consumidor!");
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { btn_ok_Click(this, e); }
        }

        private void consultar_conta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.exibeMenu();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
