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
    public partial class cadastrar_novo_consumidor : Form
    {
        public cadastrar_novo_consumidor()
        {
            InitializeComponent();
        }

        private void btn_salvar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) { btn_salvar_Click(this, e); }
        }

        private void cadastrar_novo_consumidor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.exibeMenu();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(campoNome.Text))
            {
                MessageBox.Show("Por favor, insira o nome do consumidor que está sendo cadastrado");
            }
            else if (String.IsNullOrEmpty(campoCpf.Text))
            {
                MessageBox.Show("Por favor, insira o CPF do consumidor que está sendo cadastrado");
            }
            else if (String.IsNullOrEmpty(campoIdentidade.Text))
            {
                MessageBox.Show("Por favor, insira a Identidade do consumidor que está sendo cadastrado");
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
                    int    idConsumidor = Funcoes         .getNewId("Consumidores.txt");
                    string nome         = campoNome       .Text.ToUpper();
                    string cpf          = campoCpf        .Text.ToUpper();
                    string identidade   = campoIdentidade .Text.ToUpper();
                    int    idImovel     = Funcoes         .getNewId("Imóveis.txt");
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

                    Consumidores consumidor = new Consumidores(idConsumidor, nome, cpf, identidade);
                    Imoveis imovel = new Imoveis(idImovel, idConsumidor, numero, endereco, bairro, complemento,
                                                            cidade, estado, cep, pais, timpoImovel, tipoServico);

                    Funcoes.salvarRegistro("Consumidores.txt", consumidor.ToString());
                    Funcoes.salvarRegistro("Imóveis.txt", imovel.ToString());

                    MessageBox.Show("Consumidor cadastrado com sucesso!");

                    Close();
                }
                catch (FormatException fn)
                {
                    MessageBox.Show("O campo número deve ser preenchido com números apenas!");
                }
            }
        }
    }
}
