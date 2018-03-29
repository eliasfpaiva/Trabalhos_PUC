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

            int[] vet  = Funcoes.criaVetor(tamanho); //Crio um vetor do tamanho solicitado + 1, com valores aleatórios entre 0 e 10 vezes o tamanho informado
            int[] vet1 = Funcoes.copiaVetor(vet);
            int[] vet2 = Funcoes.copiaVetor(vet);
            int[] vet3 = Funcoes.copiaVetor(vet);
            int[] vet4 = Funcoes.copiaVetor(vet);
            int[] vet5 = Funcoes.copiaVetor(vet);

            Console.WriteLine("\nVetor Original: ");
            Funcoes.imprimeVetor(vet); //Imprimo o vetor original para visualização

            Console.WriteLine("\n\nVetor 1 antes da ordenação por inserção: ");
            Funcoes.imprimeVetor(vet1);
            Console.WriteLine("\nVetor Ordenado por inserção: ");
            Funcoes.imprimeVetor(Algoritmos.insertSort(vet1));

            Console.WriteLine("\n\nVetor 2 antes da ordenação por seleção: ");
            Funcoes.imprimeVetor(vet2);
            Console.WriteLine("\nVetor Ordenado por seleção: ");
            Funcoes.imprimeVetor(Algoritmos.selectSort(vet2));
            
            Console.WriteLine("\n\nVetor 3 antes da ordenação por bolha: ");
            Funcoes.imprimeVetor(vet3);
            Console.WriteLine("\nVetor Ordenado por bolha: ");
            Funcoes.imprimeVetor(Algoritmos.bubbleSort(vet3));
            
            Console.WriteLine("\n\nVetor 4 antes da ordenação por merge: ");
            Funcoes.imprimeVetor(vet4);
            Console.WriteLine("\nVetor Ordenado por merge: ");
            Funcoes.imprimeVetor(Algoritmos.mergeSort(vet4));
            /*
            Console.WriteLine("\n\nVetor 5 antes da ordenação por quick: ");
            Funcoes.imprimeVetor(vet5);
            Console.WriteLine("\nVetor Ordenado por quick: ");
            Funcoes.imprimeVetor(Algoritmos.quickSort(vet5));
            */
            Console.ReadKey();
        }
    }
}
