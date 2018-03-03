using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela_Verdade
{
    class Program
    {
        public static void imprimeVetor(int i, int[] vet)
        {
            if (i == vet.Length)
            {
                Console.Write("\n|");
                for (int j = 0; j < vet.Length; j++)
                    Console.Write(vet[j] + "|");
            }
            else
            {
                vet[i] = 0;
                imprimeVetor(i + 1, vet);
                vet[i] = 1;
                imprimeVetor(i + 1, vet);
            }                            
        }

        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de variáveis você deseja: ");
            int n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            imprimeVetor(0, vet);

            Console.ReadKey();
        }
    }
}
