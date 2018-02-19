using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]

        public static bool verificaVitoria(string[,] situalcaoJogo, string jogadorAtivo)
        {
            if(((situalcaoJogo[0, 0]== situalcaoJogo[0, 1])&& situalcaoJogo[0, 0]== situalcaoJogo[0, 2])|| 
                ((situalcaoJogo[1, 0] == situalcaoJogo[1, 1]) && situalcaoJogo[1, 0] == situalcaoJogo[1, 2]) || 
                ((situalcaoJogo[2, 0] == situalcaoJogo[2, 1]) && situalcaoJogo[2, 0] == situalcaoJogo[2, 2]) ||
                ((situalcaoJogo[0, 0] == situalcaoJogo[1, 0]) && situalcaoJogo[0, 0] == situalcaoJogo[2, 0]) ||
                ((situalcaoJogo[0, 1] == situalcaoJogo[1, 1]) && situalcaoJogo[0, 1] == situalcaoJogo[2, 1]) || 
                ((situalcaoJogo[0, 2] == situalcaoJogo[1, 2]) && situalcaoJogo[0, 2] == situalcaoJogo[2, 2]) ||
                ((situalcaoJogo[0, 0] == situalcaoJogo[1, 1]) && situalcaoJogo[0, 0] == situalcaoJogo[2, 2]) ||
                ((situalcaoJogo[0, 2] == situalcaoJogo[1, 1]) && situalcaoJogo[0, 2] == situalcaoJogo[2, 0]))
            {
                MessageBox.Show("Temos ganhador.\n Parabéns " + jogadorAtivo);
                return true;
            }
            return false;
        }

        public static string troca(string simbolo)
        {
            if (simbolo=="X")
                return "O";
            else if (simbolo == "O")
                return "X";
            else if (simbolo == "Jogador 1")
                return "Jogador 2";
            else
                return "Jogador 1";
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
