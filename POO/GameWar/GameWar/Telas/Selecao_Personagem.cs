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
    public partial class Selecao_Personagem : Form
    {
        string imagemselecao;

        public Selecao_Personagem()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imagemselecao = "Soldada";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            imagemselecao = "Mago";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            imagemselecao = "Lutador";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            imagemselecao = "General";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            imagemselecao = "Dragao";
        }

        private void buttonConfirmacao_Click(object sender, EventArgs e)
        {
            Program.personagem1 = imagemselecao;
            Close();
        }

        private void Selecao_Personagem_Load(object sender, EventArgs e)
        {

        }
    }
}
