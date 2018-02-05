using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cada_Gota.Telas;

namespace Cada_Gota
{
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_consumidor_Click(object sender, EventArgs e)
        {
            cadastrar_novo_consumidor cadConsumidor = new cadastrar_novo_consumidor();
            cadConsumidor.Show();
            this.SetVisibleCore(false);
        }

        private void btn_cadastrar_conta_Click(object sender, EventArgs e)
        {
            cadastrar_conta cadConta = new cadastrar_conta();
            cadConta.Show();
            this.SetVisibleCore(false);
        }

        private void btnCadastraImovel_Click(object sender, EventArgs e)
        {
            cadastrar_imovel cadImovel = new cadastrar_imovel();
            cadImovel.Show();
            this.SetVisibleCore(false);
        }

        private void btn_consultar_conta_Click(object sender, EventArgs e)
        {
            consultar_conta consConta = new consultar_conta();
            consConta.Show();
            this.SetVisibleCore(false);
        }

        private void btn_consultar_variacao_Click(object sender, EventArgs e)
        {
            consultar_variacao consVariacao = new consultar_variacao();
            consVariacao.Show();
            this.SetVisibleCore(false);
        }

        private void btn_consultar_valor_medio_Click(object sender, EventArgs e)
        {
            consultar_valor_medio consValorMedio = new consultar_valor_medio();
            consValorMedio.Show();
            this.SetVisibleCore(false);
        }

        private void btn_consultar_maior_valor_Click(object sender, EventArgs e)
        {
            consultar_conta_mais_cara consContaMaisCara = new consultar_conta_mais_cara();
            consContaMaisCara.Show();
            this.SetVisibleCore(false);
        }

        private void menu_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
