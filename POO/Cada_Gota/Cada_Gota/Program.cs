using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cada_Gota.Telas;

namespace Cada_Gota
{
    static class Program
    {
        public static menu_principal menuPrincipal;

        public static void exibeMenu() { menuPrincipal.Show(); }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            menuPrincipal = new menu_principal();
            exibeMenu();
            Application.Run();
        }
    }
}
