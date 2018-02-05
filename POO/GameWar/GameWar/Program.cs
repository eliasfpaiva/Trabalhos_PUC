using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameWar;

namespace GameWar
{
    static class Program
    {
        public static string personagem1;
        public static string personagem2;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Selecao_Personagem());
            Application.Run(new Selecao_Personagem_2());
            Fase_1 PrimeiraFase = new Fase_1(personagem1, personagem2);
            Application.Run(PrimeiraFase);

        }
    }
}
