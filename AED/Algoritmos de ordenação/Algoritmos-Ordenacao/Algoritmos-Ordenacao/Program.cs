using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos_Ordenacao.Classes;
using System.IO;

namespace Algoritmos_Ordenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream arquivo = new FileStream("Dados da ordenação vetor ordenado Decrescente.txt", FileMode.OpenOrCreate);
            StreamWriter registrador = new StreamWriter(arquivo);
            {
                int tamanho = 2000;
                for (int i = 2; i <= 128; i *= 2)
                {
                    int[] vet = Funcoes.criaVetorPeloArquivo(tamanho);
                    Algoritmos.bubbleSortInvert(vet);
                    registrador.WriteLine("\n\nOrdenação com vetor de " + tamanho + " elementos");
                    tamanho = i * 2000;

                    Console.WriteLine("INSERÇÃO");
                    registrador.Write("INSERÇÃO: ");
                    for (int j = 1; j <= 5; j++)
                    {                        
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Algoritmos.insertSort(Funcoes.copiaVetor(vet));
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                        registrador.Write(elapsedMs + "|");
                    }
                    registrador.WriteLine();
                    Console.WriteLine("SELEÇÃO");
                    registrador.Write("SELEÇÃO: ");
                    for (int j = 1; j <= 5; j++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Algoritmos.selectSort(Funcoes.copiaVetor(vet));
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                        registrador.Write(elapsedMs + "|");
                    }
                    registrador.WriteLine();
                    Console.WriteLine("BOLHA");
                    registrador.Write("BOLHA: ");
                    for (int j = 1; j <= 5; j++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Algoritmos.bubbleSort(Funcoes.copiaVetor(vet));
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                        registrador.Write(elapsedMs + "|");
                    }
                    registrador.WriteLine();
                    Console.WriteLine("MERGESORT");
                    registrador.Write("MERGESORT: ");
                    for (int j = 1; j <= 5; j++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Algoritmos.mergeSort(Funcoes.copiaVetor(vet));
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                        registrador.Write(elapsedMs + "|");
                    }
                    registrador.WriteLine();
                    Console.WriteLine("QUICKSORT");
                    registrador.Write("QUICKSORT: ");
                    for (int j = 1; j <= 5; j++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Algoritmos.quickSort(Funcoes.copiaVetor(vet));
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                        registrador.Write(elapsedMs + "|");
                    }
                    registrador.WriteLine();
                    Console.WriteLine("BOLHA COM SELEÇÃO");
                    registrador.Write("BOLHA COM SELEÇÃO: ");
                    for (int j = 1; j <= 5; j++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Algoritmos.bubbleSelectSort(Funcoes.copiaVetor(vet));
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                        registrador.Write(elapsedMs + "|");
                    }
                    Console.WriteLine();
                }
            }
            registrador.Close();
            Console.WriteLine("Ordenação Concluida");
            Console.ReadKey();
        }
    }
}
