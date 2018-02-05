using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWar
{
    public partial class Selecao_Personagem_2 : Form
    {
        static string imagemselecao;
        public Selecao_Personagem_2()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            imagemselecao = "Dragao";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            imagemselecao = "General";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            imagemselecao = "Lutador";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            imagemselecao = "Mago";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imagemselecao = "Soldada";
        }

        private void BotaoConfirmacao_Click(object sender, EventArgs e)
        {
            Program.personagem2 = imagemselecao;
            Close();
        }
    }
}
