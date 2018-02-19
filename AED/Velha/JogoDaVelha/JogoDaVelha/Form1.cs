using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        string jogador1 = "Jogador 1", jogador2, simbJogador1, simbJogador2, simbEmUso = "O", jogadorAtivo = "Jogador 1";
        string[,] malhaJogo = new string[3, 3];
        int contjogadas = 0;//conta jogadas, se chegar a nove sem vitória encerra o jogo

        private void campo_a1_Click(object sender, EventArgs e)
        {
            campo_a1.Text = simbEmUso;
            campo_a1.Enabled = false;
            malhaJogo[0, 0] = simbEmUso;
            if (Program.verificaVitoria(malhaJogo, jogadorAtivo) == true)
                Close();
            if (++contjogadas == 9)
            {
                MessageBox.Show("Empate!\nOs dois perderam!\nObrigado por jogar.");
                Close();
            }
            simbEmUso = Program.troca(simbEmUso);
            jogadorAtivo = Program.troca(jogadorAtivo);
            Campo_jogador_ativo.Text = jogadorAtivo;
        }

        private void campo_a2_Click(object sender, EventArgs e)
        {
            campo_a2.Text = simbEmUso;
            campo_a2.Enabled = false;
            malhaJogo[0, 1] = simbEmUso;
            if (Program.verificaVitoria(malhaJogo, jogadorAtivo) == true)
                Close();
            if (++contjogadas == 9)
            {
                MessageBox.Show("Empate!\nOs dois perderam!\nObrigado por jogar.");
                Close();
            }
            simbEmUso = Program.troca(simbEmUso);
            jogadorAtivo = Program.troca(jogadorAtivo);
            Campo_jogador_ativo.Text = jogadorAtivo;
        }

        private void campo_a3_Click(object sender, EventArgs e)
        {
            campo_a3.Text = simbEmUso;
            campo_a3.Enabled = false;
            malhaJogo[0, 2] = simbEmUso;
            if (Program.verificaVitoria(malhaJogo, jogadorAtivo) == true)
                Close();
            if (++contjogadas == 9)
            {
                MessageBox.Show("Empate!\nOs dois perderam!\nObrigado por jogar.");
                Close();
            }
            simbEmUso = Program.troca(simbEmUso);
            jogadorAtivo = Program.troca(jogadorAtivo);
            Campo_jogador_ativo.Text = jogadorAtivo;
        }

        private void campo_b1_Click(object sender, EventArgs e)
        {
            campo_b1.Text = simbEmUso;
            campo_b1.Enabled = false;
            malhaJogo[1, 0] = simbEmUso;
            if (Program.verificaVitoria(malhaJogo, jogadorAtivo) == true)
                Close();
            if (++contjogadas == 9)
            {
                MessageBox.Show("Empate!\nOs dois perderam!\nObrigado por jogar.");
                Close();
            }
            simbEmUso = Program.troca(simbEmUso);
            jogadorAtivo = Program.troca(jogadorAtivo);
            Campo_jogador_ativo.Text = jogadorAtivo;
        }

        private void campo_b2_Click(object sender, EventArgs e)
        {
            campo_b2.Text = simbEmUso;
            campo_b2.Enabled = false;
            malhaJogo[1, 1] = simbEmUso;
            if (Program.verificaVitoria(malhaJogo, jogadorAtivo) == true)
                Close();
            if (++contjogadas == 9)
            {
                MessageBox.Show("Empate!\nOs dois perderam!\nObrigado por jogar.");
                Close();
            }
            simbEmUso = Program.troca(simbEmUso);
            jogadorAtivo = Program.troca(jogadorAtivo);
            Campo_jogador_ativo.Text = jogadorAtivo;
        }

        private void campo_b3_Click(object sender, EventArgs e)
        {
            campo_b3.Text = simbEmUso;
            campo_b3.Enabled = false;
            malhaJogo[1, 2] = simbEmUso;
            if (Program.verificaVitoria(malhaJogo, jogadorAtivo) == true)
                Close();
            if (++contjogadas == 9)
            {
                MessageBox.Show("Empate!\nOs dois perderam!\nObrigado por jogar.");
                Close();
            }
            simbEmUso = Program.troca(simbEmUso);
            jogadorAtivo = Program.troca(jogadorAtivo);
            Campo_jogador_ativo.Text = jogadorAtivo;
        }

        private void campo_c1_Click(object sender, EventArgs e)
        {
            campo_c1.Text = simbEmUso;
            campo_c1.Enabled = false;
            malhaJogo[2, 0] = simbEmUso;
            if (Program.verificaVitoria(malhaJogo, jogadorAtivo) == true)
                Close();
            if (++contjogadas == 9)
            {
                MessageBox.Show("Empate!\nOs dois perderam!\nObrigado por jogar.");
                Close();
            }
            simbEmUso = Program.troca(simbEmUso);
            jogadorAtivo = Program.troca(jogadorAtivo);
            Campo_jogador_ativo.Text = jogadorAtivo;
        }

        private void campo_c2_Click(object sender, EventArgs e)
        {
            campo_c2.Text = simbEmUso;
            campo_c2.Enabled = false;
            malhaJogo[2, 1] = simbEmUso;
            if (Program.verificaVitoria(malhaJogo, jogadorAtivo) == true)
                Close();
            if (++contjogadas == 9)
            {
                MessageBox.Show("Empate!\nOs dois perderam!\nObrigado por jogar.");
                Close();
            }
            simbEmUso = Program.troca(simbEmUso);
            jogadorAtivo = Program.troca(jogadorAtivo);
            Campo_jogador_ativo.Text = jogadorAtivo;
        }

        private void campo_c3_Click(object sender, EventArgs e)
        {
            campo_c3.Text = simbEmUso;
            campo_c3.Enabled = false;
            malhaJogo[2, 2] = simbEmUso;
            if (Program.verificaVitoria(malhaJogo, jogadorAtivo) == true)
                Close();
            if (++contjogadas == 9)
            {
                MessageBox.Show("Empate!\nOs dois perderam!\nObrigado por jogar.");
                Close();
            }
            simbEmUso = Program.troca(simbEmUso);
            jogadorAtivo = Program.troca(jogadorAtivo);
            Campo_jogador_ativo.Text = jogadorAtivo;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            malhaJogo[0, 0] = "0";
            malhaJogo[0, 1] = "1";
            malhaJogo[0, 2] = "2";
            malhaJogo[1, 0] = "3";
            malhaJogo[1, 1] = "4";
            malhaJogo[1, 2] = "5";
            malhaJogo[2, 0] = "6";
            malhaJogo[2, 1] = "7";
            malhaJogo[2, 2] = "8";
            /*selectOp select = new selectOp();
            select.ShowDialog();

            if (select.DialogResult == DialogResult.Yes)
                jogador2 = "Jogador 2";
            else
                jogador2 = "Computador";*/
            jogador2 = "Jogador 2";

            Simbolo simbolo  = new Simbolo();
            simbolo.ShowDialog();

            if (simbolo.DialogResult == DialogResult.Yes)
            {
                simbJogador1 = "X";
                simbJogador2 = "O";
            }
            else
            {
                simbJogador1 = "O";
                simbJogador2 = "X";
            }

            simbEmUso = simbJogador1;
            Campo_jogador_ativo.Text = jogadorAtivo;
        }
    }
}
