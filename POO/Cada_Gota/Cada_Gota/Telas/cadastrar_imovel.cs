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
    public partial class cadastrar_imovel : Form
    {
        public cadastrar_imovel()
        {
            InitializeComponent();
        }

        private void cadastrar_imovel_Load(object sender, EventArgs e)
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
                campoEndereco     .Enabled = false;
                campoBairro       .Enabled = false;
                campoNumero       .Enabled = false;
                campoComplemento  .Enabled = false;
                campoCidade       .Enabled = false;
                campoEstado       .Enabled = false;
                campoCep          .Enabled = false;
                campoPais         .Enabled = false;
                campoTipoImovel   .Enabled = false;
                campoTipoServico  .Enabled = false;
                btn_salvar        .Enabled = false;

                MessageBox.Show("Não existe cadastro de Consumidor, favor cadastrar!");
            }
        }

        private void cadastrar_imovel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.exibeMenu();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(selectIdConsumidor.Text))
            {
                MessageBox.Show("Por favor, selecione um consumidor para ser associado a este imóvel!");
            }
            else if (String.IsNullOrEmpty(campoEndereco.Text) || String.IsNullOrEmpty(campoNumero.Text) || String.IsNullOrEmpty(campoBairro.Text) ||
                String.IsNullOrEmpty(campoCidade.Text) || String.IsNullOrEmpty(campoEstado.Text) || String.IsNullOrEmpty(campoCep.Text) ||
                String.IsNullOrEmpty(campoPais.Text) || String.IsNullOrEmpty(campoComplemento.Text))
            {
                MessageBox.Show("O endereço deve ser preenchido completamente!");
            }
            else if (String.IsNullOrEmpty(campoTipoImovel.Text))
            {
                MessageBox.Show("Por favor, selecione o tipo deste imóvel!");
            }
            else if (String.IsNullOrEmpty(campoTipoServico.Text))
            {
                MessageBox.Show("Por favor, selecione o tipo de serviço prestado a este imóvel!");
            }
            else
            {
                try
                {
                    string[] dadosConsumidor = selectIdConsumidor.Text.Split(':');

                    int    idImovel     = Funcoes         .getNewId("Imóveis.txt");
                    int    idConsumidor = int             .Parse(dadosConsumidor[0]);
                    int    numero       = int             .Parse(campoNumero.Text);
                    string endereco     = campoEndereco   .Text.ToUpper();
                    string bairro       = campoBairro     .Text.ToUpper();
                    string complemento  = campoComplemento.Text.ToUpper();
                    string cidade       = campoCidade     .Text.ToUpper();
                    string estado       = campoEstado     .Text.ToUpper();
                    string cep          = campoCep        .Text.ToUpper();
                    string pais         = campoPais       .Text.ToUpper();
                    string timpoImovel  = campoTipoImovel .Text.ToUpper();
                    string tipoServico  = campoTipoServico.Text.ToUpper();


                    Imoveis imovel = new Imoveis(idImovel, idConsumidor, numero, endereco, bairro, complemento,
                                                            cidade, estado, cep, pais, timpoImovel, tipoServico);

                    Funcoes.salvarRegistro("Imóveis.txt", imovel.ToString());

                    MessageBox.Show("Imóvel cadastrado com sucesso!");

                    Close();
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("O campo número deve ser preenchido com números apenas!");
                }
            }
        }
    }
}
