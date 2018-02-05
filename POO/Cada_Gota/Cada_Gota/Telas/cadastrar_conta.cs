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
    public partial class cadastrar_conta : Form
    {
        public cadastrar_conta()
        {
            InitializeComponent();
        }

        private void btn_salvar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { btn_salvar_Click(this, e); }
        }

        private void cadastrar_conta_Load(object sender, EventArgs e)
        {
            string[] consumidores;

            if ((Funcoes.getNewId("Consumidores.txt") != 1) && (Funcoes.getNewId("Imóveis.txt") != 1))
            {
                consumidores = Funcoes.getIdNomeConsumidor();
                selectIdConsumidor.DataSource = consumidores;
            }
            else
            {
                selectIdConsumidor   .Enabled = false;
                campoMesLeitura      .Enabled = false;
                campoAnoLeitura      .Enabled = false;
                selectImovel         .Enabled = false;
                campoLeituraInicial_1.Enabled = false;
                campoLeituraInicial_2.Enabled = false;
                campoLeituraInicial_3.Enabled = false;
                campoLeituraInicial_4.Enabled = false;
                campoLeituraInicial_5.Enabled = false;
                campoLeituraFinal_1  .Enabled = false;
                campoLeituraFinal_2  .Enabled = false;
                campoLeituraFinal_3  .Enabled = false;
                campoLeituraFinal_4  .Enabled = false;
                campoLeituraFinal_5  .Enabled = false;
                btn_salvar           .Enabled = false;

                MessageBox.Show("Não existe cadastro de Consumidor, favor cadastrar!");
            }
        }

        private void selectIdConsumidor_Leave(object sender, EventArgs e)
        {
            string[] consumidor = Funcoes.getNomeCpfConsumidor(selectIdConsumidor.Text);

            campoNomeConsumidor.Text = consumidor[0];
            campoCpfConsumidor .Text = consumidor[1];

            string[] imoveis        = Funcoes.getImoveisConsumidor(selectIdConsumidor.Text);
            selectImovel.DataSource = imoveis;

            if (String.IsNullOrEmpty(selectImovel.Text) == true)
            {
                MessageBox.Show("Não existe imóvel cadastrado para este Consumidor, favor cadastrar!");
            }
        }

        private void cadastrar_conta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.exibeMenu();
        }

        private void btn_votar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            

            if (String.IsNullOrEmpty(selectImovel.Text) == true)
            {
                MessageBox.Show("Não existe imóvel cadastrado para este Consumidor, favor cadastrar!");
            }
            else if (String.IsNullOrEmpty(campoMesLeitura.Text) == true)
            {
                MessageBox.Show("Favor informar o mês a que essa leitura se refere!");
            }
            else if (String.IsNullOrEmpty(campoAnoLeitura.Text) == true)
            {
                MessageBox.Show("Favor informar o ano a que essa leitura se refere!");
            }
            else if(String.IsNullOrEmpty(campoLeituraInicial_1.Text) == true || String.IsNullOrEmpty(campoLeituraInicial_2.Text) == true || String.IsNullOrEmpty(campoLeituraInicial_3.Text) == true ||
                String.IsNullOrEmpty(campoLeituraInicial_4.Text) == true || String.IsNullOrEmpty(campoLeituraInicial_5.Text) == true || String.IsNullOrEmpty(campoLeituraFinal_1.Text) == true ||
                String.IsNullOrEmpty(campoLeituraFinal_2.Text) == true || String.IsNullOrEmpty(campoLeituraFinal_3.Text) == true || String.IsNullOrEmpty(campoLeituraFinal_4.Text) == true ||
                String.IsNullOrEmpty(campoLeituraFinal_5.Text) == true)
            {
                MessageBox.Show("Os dados de leitura devem ser completamente preenchidos!");
            }
            else if ((campoLeituraInicial_1.Text.Length > 1) || (campoLeituraInicial_2.Text.Length > 1) || (campoLeituraInicial_3.Text.Length > 1) || (campoLeituraInicial_4.Text.Length > 1) || (campoLeituraInicial_5.Text.Length > 1) ||
                (campoLeituraFinal_1.Text.Length > 1) || (campoLeituraFinal_2.Text.Length > 1) || (campoLeituraFinal_3.Text.Length > 1) || (campoLeituraFinal_4.Text.Length > 1) || (campoLeituraFinal_5.Text.Length > 1))
            {
                MessageBox.Show("Os campos de leitura devem conter apenas um dígito cada.");
            }
            else
            {
                try
                {
                    int id = Funcoes.getNewId("Contas.txt");
                    string[] consumidor = selectIdConsumidor.Text.Split(':');
                    int idConsumidor = int.Parse(consumidor[0]);
                    string[] imovel = selectImovel.Text.Split('|');
                    int idImovel = int.Parse(imovel[0]);
                    string mes = campoMesLeitura.Text.ToUpper();
                    int ano = int.Parse(campoAnoLeitura.Text);
                    int leituraInicial = int.Parse(campoLeituraInicial_1.Text + campoLeituraInicial_2.Text + campoLeituraInicial_3.Text + campoLeituraInicial_4.Text + campoLeituraInicial_5.Text);
                    int leituraFinal = int.Parse(campoLeituraFinal_1.Text + campoLeituraFinal_2.Text + campoLeituraFinal_3.Text + campoLeituraFinal_4.Text + campoLeituraFinal_5.Text);
                    double[] valores = new double[2];

                    if (leituraFinal < leituraInicial)
                    {
                        LeituraInvalidaException leituraInvalida = new LeituraInvalidaException();
                        throw leituraInvalida;
                    }

                    if (imovel[5].ToUpper() == "FORNECIMENTO DE ÁGUA")
                    {
                        valores = Funcoes.calculaAgua(leituraInicial, leituraFinal, imovel[4].ToUpper());
                    }
                    else if (imovel[5].ToUpper() == "FORNECIMENTO DE ENERGIA ELÉTRICA")
                    {
                        valores = Funcoes.calculaEnergia(leituraInicial, leituraFinal, imovel[4].ToUpper());
                    }

                    Contas conta = new Contas(id, idConsumidor, idImovel, mes, ano, leituraInicial, leituraFinal, valores[0], valores[1]);

                    Funcoes.salvarRegistro("Contas.txt", conta.ToString());

                    MessageBox.Show("Conta cadastrada com sucesso!");

                    Close();
                }
                catch(FormatException fe)
                {
                    MessageBox.Show("Os campos de Ano da leitura, Leitura inicial e Leitura Final\nDevem ser preenchidos com números inteiros\nOutros caracteres não são permitidos.");
                }
                catch(LeituraInvalidaException li)
                {
                    MessageBox.Show(li.ToString() + "A Leitura Final não pode ser menor que a Leitura Inicial.");
                }
            }
        }
    }
}
