using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova_Prática.Classes;

namespace Prova_Prática
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista listaComandos = new Lista();
            string comando;
            string[] linhaComando;

            do
            {
                Console.Clear();
                Console.Write("Digite o comando: ");
                comando = Console.ReadLine();
                linhaComando = comando.Split(' ');

                if (linhaComando[0] == "q")
                    comando = "q";
                if (linhaComando[0] == "f")
                    listaComandos.insere(int.Parse(linhaComando[1]));
                //if(linhaComando[0] == )

            } while (comando != "q");

            listaComandos.imprime();

            Console.ReadKey();
        }
    }
}
