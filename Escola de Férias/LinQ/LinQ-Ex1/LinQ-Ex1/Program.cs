using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] Vetor = { 98, 45, 67, 23, 18, 90, 58, 30, 26, 72 };

            //foreach (int n in Vetor)
            //{
            //    Console.Write("{0} ", n);
            //}

            //var Consulta = from Valor in Vetor
            //               select Valor;

            //foreach (int n in Consulta)
            //{
            //    Console.Write("{0} ", n);
            //}

            //var Consulta = from Valor in Vetor
            //               orderby Valor select Valor;

            //foreach (int n in Consulta)
            //{
            //    Console.Write("{0} ", n);
            //}

            //var Consulta = from Valor in Vetor
            //               orderby Valor
            //               where Valor >= 50
            //               select Valor;

            //foreach (int n in Consulta)
            //{
            //    Console.Write("{0} ", n);
            //}

            //var Consulta = (from Valor in Vetor
            //               orderby Valor
            //               where Valor >= 50
            //               select Valor).Count();
            //Console.WriteLine("Quantidade: {0} ", Consulta);


            //var Consulta = (from Valor in Vetor
            //                select Valor).Average();
            //Console.WriteLine("Média: {0} ", Consulta);

            //var Consulta = (from Valor in Vetor
            //                select Valor).Sum();
            //Console.WriteLine("Média: {0} ", Consulta);

            //var Consulta = (from Valor in Vetor
            //                select Valor).Max();
            //Console.WriteLine("Máximo: {0} ", Consulta);

            //var Consulta = (from Valor in Vetor
            //                select Valor).Min();
            //Console.WriteLine("Mínimo: {0} ", Consulta);

            //int[] VetorA = { 98, 45, 67, 23, 18, 90, 58, 30, 26, 72 };
            //int[] VetorB = { 35, 48, 97, 65, 17, 49, 93, 50, 32, 71 };

            //var Consulta = from Valor1 in VetorA
            //               from Valor2 in VetorB
            //               where Valor1 < Valor2
            //               select new { Valor1, Valor2 };

            //foreach (var x in Consulta)
            //{
            //    Console.WriteLine("{0} é menor que {1}", x.Valor1, x.Valor2);
            //}

            //var Consulta = from Valor1 in VetorA
            //               from Valor2 in VetorB
            //               where Valor1 < Valor2
            //               select new { Valor1, Valor2 };

            //foreach (var x in Consulta)
            //{
            //    Console.WriteLine("{0} é menor que {1}", x.Valor1, x.Valor2);
            //}

            //string[] Vetor = { "FiAT", "CheVROleT", "ToYOta", "MitSUBishI", "VolkKSwagEN" };

            //var Consulta = from Valor in Vetor
            //               select new
            //               {
            //                   Maiusculas = Valor.ToUpper(),
            //                   Minusculas = Valor.ToLower()
            //               };

            //foreach (var x in Consulta)
            //{
            //    Console.WriteLine("{0} / {1}", x.Maiusculas, x.Minusculas);
            //}

            //string[] Vetor = { "Banana", "Abacate", "Melancia", "Amora", "Caju", "Abacaxi", "Maça" };

            //var FrutaLetra = from Fruta in Vetor
            //                 orderby Fruta
            //                 group Fruta by Fruta[0];

            //foreach (var GrupoFruta in FrutaLetra)
            //{
            //    Console.WriteLine("\nFrutas que começam com '{0}'", GrupoFruta.Key);

            //    foreach (var x in GrupoFruta)
            //    {
            //        Console.WriteLine("\t{0}", x);
            //    }
            //}



            Console.ReadKey();
        }
    }
}
