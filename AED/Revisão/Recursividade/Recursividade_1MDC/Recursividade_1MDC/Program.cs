using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recursividade_1MDC.Classes;

namespace Recursividade_1MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MDC entre 10,6: " + Funcoes.mdc(10,6));
            Console.WriteLine("MDC entre 4, 6: " + Funcoes.mdc(4, 6));
            Console.WriteLine("MDC entre 6, 4: " + Funcoes.mdc(6, 4));
            Console.WriteLine("MDC entre 2, 4: " + Funcoes.mdc(2, 4));
            Console.WriteLine("MDC entre 4, 2: " + Funcoes.mdc(4, 2));
            Console.WriteLine("MDC entre 2, 2: " + Funcoes.mdc(2, 2));

            Console.ReadKey();
        }
    }
}
