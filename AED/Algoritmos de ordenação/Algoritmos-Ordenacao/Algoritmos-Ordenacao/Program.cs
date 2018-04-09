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
            FileStream arquivo = new FileStream("Dados da ordenação.txt", FileMode.OpenOrCreate);
            StreamWriter registrador = new StreamWriter(arquivo);
            {
                int tamanho = 2000;
                for (int i = 1; i <= 128; i *= 2)
                {
                    int[] vet = Funcoes.criaVetorPeloArquivo(tamanho);
                    registrador.WriteLine("Ordenação com vetor de " + tamanho + " elementos");
                    tamanho = i * 2000;

                    Console.WriteLine("\nINSERÇÃO");
                    for (int j = 1; j <= 5; j++)
                    {                        
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Algoritmos.insertSort(Funcoes.copiaVetor(vet));
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                        registrador.Write(elapsedMs + "|");


                        var ramUsage = System.Diagnostics.Process.GetCurrentProcess().PeakWorkingSet64;
                        var allocationInMB = ramUsage / (1024 * 1024);
                        registrador.WriteLine(allocationInMB);
                    }
                    Console.WriteLine("\nSELEÇÃO");
                    for (int j = 1; j <= 5; j++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Algoritmos.selectSort(Funcoes.copiaVetor(vet));
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                        registrador.Write(elapsedMs + "|");


                        var ramUsage = System.Diagnostics.Process.GetCurrentProcess().PeakWorkingSet64;
                        var allocationInMB = ramUsage / (1024 * 1024);
                        registrador.WriteLine(allocationInMB);
                    }
                    Console.WriteLine("\nBOLHA");
                    for (int j = 1; j <= 5; j++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Algoritmos.bubbleSort(Funcoes.copiaVetor(vet));
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                        registrador.Write(elapsedMs + "|");


                        var ramUsage = System.Diagnostics.Process.GetCurrentProcess().PeakWorkingSet64;
                        var allocationInMB = ramUsage / (1024 * 1024);
                        registrador.WriteLine(allocationInMB);
                    }
                    Console.WriteLine("\nMERGESORT");
                    for (int j = 1; j <= 5; j++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Algoritmos.mergeSort(Funcoes.copiaVetor(vet));
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                        registrador.Write(elapsedMs + "|");

                        var ramUsage = System.Diagnostics.Process.GetCurrentProcess().PeakWorkingSet64;
                        var allocationInMB = ramUsage / (1024 * 1024);
                        registrador.WriteLine(allocationInMB);
                    }
                    Console.WriteLine("\nQUICKSORT");
                    for (int j = 1; j <= 5; j++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Algoritmos.quickSort(Funcoes.copiaVetor(vet));
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                        registrador.Write(elapsedMs + "|");

                        var ramUsage = System.Diagnostics.Process.GetCurrentProcess().PeakWorkingSet64;
                        var allocationInMB = ramUsage / (1024 * 1024);
                        registrador.WriteLine(allocationInMB);
                    }
                    Console.WriteLine("\nBOLHA COM SELEÇÃO");
                    for (int j = 1; j <= 5; j++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Algoritmos.bubbleSelectSort(Funcoes.copiaVetor(vet));
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                        registrador.Write(elapsedMs + "|");

                        var ramUsage = System.Diagnostics.Process.GetCurrentProcess().PeakWorkingSet64;
                        var allocationInMB = ramUsage / (1024 * 1024);
                        registrador.WriteLine(allocationInMB);
                    }
                    Console.WriteLine("\n");
                }
            }
            registrador.Close();
            Console.WriteLine("Ordenação Concluida");
            Console.ReadKey();
        }
    }
}
