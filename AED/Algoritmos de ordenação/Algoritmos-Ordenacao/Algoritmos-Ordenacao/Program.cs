using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos_Ordenacao.Classes;

namespace Algoritmos_Ordenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do vetor desejado: "); //Solicito o tamanho do vetor que eu desejo
            int tamanho = int.Parse(Console.ReadLine()) + 1; //Somo 1 ao tamanho informado, pois farei uso de sentinela

            int[] vet  = Algoritmos.criaVetor(tamanho); //Crio um vetor do tamanho solicitado + 1, com valores aleatórios entre 0 e 10 vezes o tamanho informado
            int[] vet1 = Algoritmos.copiaVetor(vet);
            int[] vet2 = Algoritmos.copiaVetor(vet);
            int[] vet3 = Algoritmos.copiaVetor(vet);
            int[] vet4 = Algoritmos.copiaVetor(vet);
            int[] vet5 = Algoritmos.copiaVetor(vet);

            Console.WriteLine("\nVetor Original: ");
            Algoritmos.imprimeVetor(vet); //Imprimo o vetor original para visualização

            Console.WriteLine("\n\nVetor 1 antes da ordenação por inserção: ");
            Algoritmos.imprimeVetor(vet1);
            Console.WriteLine("\nVetor Ordenado por inserção: ");
            Algoritmos.imprimeVetor(Algoritmos.insertSort(vet1));

            Console.WriteLine("\n\nVetor 2 antes da ordenação por seleção: ");
            Algoritmos.imprimeVetor(vet2);
            Console.WriteLine("\nVetor Ordenado por seleção: ");
            Algoritmos.imprimeVetor(Algoritmos.selectSort(vet2));

            Console.ReadKey();
        }
    }
}
