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
    public partial class consultar_variacao : Form
    {
        public consultar_variacao()
        {
            InitializeComponent();
        }

        private void consultar_variacao_Load(object sender, EventArgs e)
        {
            string[] consumidores;

            if (Funcoes.getNewId("Consumidores.txt") != 1)
            {
                consumidores = Funcoes.getIdNomeConsumidor();
                selectIdConsumidor.DataSource = consumidores;
            }
            else
            {
                selectIdConsumidor       .Enabled = false;
                campoConsumoPrimeiraConta.Enabled = false;
                campoConsumoSegundaConta .Enabled = false;
                btnCompararContas        .Enabled = false;

                MessageBox.Show("Não existe cadastro de Consumidor, favor cadastrar!");
            }
        }


        private void selectIdConsumidor_Leave(object sender, EventArgs e)
        {
            string[] idConsumidor = selectIdConsumidor.Text.Split(':');

            string[] contas1 = Funcoes.getContasConsumidor(idConsumidor[0]);
            string[] contas2 = Funcoes.getContasConsumidor(idConsumidor[0]);

            selectPrimeiraConta.DataSource = contas1;
            selectSegundaConta .DataSource = contas2;
        }

        private void btnCompararContas_Click(object sender, EventArgs e)
        {
            campoConsumoPrimeiraConta.Enabled = true;
            campoConsumoSegundaConta .Enabled = true;
            campoVariacaoConsumo     .Enabled = true;
            labelConsumo1            .Enabled = true;
            labelConsumo2            .Enabled = true;
            labelVariacaoConsumo     .Enabled = true;
            campoUnidadeMedida_1     .Enabled = true;
            campoUnidadeMedida_2     .Enabled = true;
            campoUnidadeMedida_3     .Enabled = true;

            string[] idConta              = selectPrimeiraConta.Text.Split('|');
            string[] primeiraConta        = Funcoes.getRegistro("Contas.txt", idConta[0]).Split('|');
            string   servicoPrimeiraConta = idConta[7];

                     idConta             = selectSegundaConta.Text.Split('|');
            string[] segundaConta        = Funcoes.getRegistro("Contas.txt", idConta[0]).Split('|');
            string   servicoSegundaConta = idConta[7];

            double valorPrimeiraConta = double.Parse(primeiraConta[9]);
            double valorSegundaConta  = double.Parse(segundaConta[9]);
            double variacaoValor      = valorPrimeiraConta - valorSegundaConta;

            campoValorPrimeiraConta.Text = valorPrimeiraConta.ToString("N2");
            campoValorSegundaConta .Text = valorSegundaConta .ToString("N2");
            campoVariacaoValor     .Text = variacaoValor     .ToString("N2");

            if (servicoPrimeiraConta != servicoSegundaConta)
            {
                MessageBox.Show("Essas contas não fazem referência ao mesmo tipo de serviço.\nSó é possível comparar os seus valores");
                labelConsumo1            .Enabled = false;
                labelConsumo2            .Enabled = false;
                labelVariacaoConsumo     .Enabled = false;
                campoConsumoPrimeiraConta.Text = null;
                campoConsumoSegundaConta .Text = null;
                campoVariacaoConsumo     .Text = null;
                campoUnidadeMedida_1     .Text    = null;
                campoUnidadeMedida_2     .Text    = null;
                campoUnidadeMedida_3     .Text    = null;
                campoConsumoPrimeiraConta.Text    = null;
                campoConsumoSegundaConta .Text    = null;
                campoVariacaoConsumo     .Text    = null;
            }
            else
            {
                int variacaoConsumo = int.Parse(primeiraConta[7]) - int.Parse(segundaConta[7]);

                campoConsumoPrimeiraConta.Text = primeiraConta[7];
                campoConsumoSegundaConta .Text = segundaConta[7];
                campoVariacaoConsumo     .Text = variacaoConsumo.ToString();
                
                if (servicoPrimeiraConta == "FORNECIMENTO DE ENERGIA ELÉTRICA")
                {
                    campoUnidadeMedida_1.Text = "kW";
                    campoUnidadeMedida_2.Text = "kW";
                    campoUnidadeMedida_3.Text = "kW";
                }
                else
                {
                    campoUnidadeMedida_1.Text = "m³";
                    campoUnidadeMedida_2.Text = "m³";
                    campoUnidadeMedida_3.Text = "m³";
                }
            }            
        }

        private void consultar_variacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.exibeMenu();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
