using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIB;

namespace BIB_Uso
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, x = 3, y = 4;

            Console.WriteLine("O Fatorial de {0} é {1}", n, MyMath.CalcFat(n));
            Console.WriteLine("{0} elevado a {1} é {2}", x, y, MyMath.CalcPot(x, y));

            Stack<int> pilha = new Stack<int>();

            pilha.Push(16);
            pilha.Push(17);
            pilha.Push(11);
            pilha.Push(19);
            pilha.Push(18);
            pilha.Push(15);

            var consulta = from e in pilha
                           orderby e
                           select e;

            foreach (var E in consulta)
                Console.WriteLine(E);

            Console.ReadKey();
        }
    }
}
