using Pilhas.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pilhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha estacionamento = new Pilha(10);

            for (int i = 1; i <= 10; i++)
                estacionamento.empilha("DBZ-18" + (i + 10));

            estacionamento.imprime();

            Console.ReadKey();
        }
    }
}
