using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Distância_entre_pontos_1.Classes;
using System.IO;

namespace Distância_entre_pontos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int j = 0; j < 5; j++)
            {
                FileStream arq = new FileStream("Análise do 1º algorítimo.txt", FileMode.OpenOrCreate);
                StreamWriter escrever = new StreamWriter(arq);

                for (int i = 1000; i < 100000; i = i + 1000)
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    Funcoes.pontoMaisProx(i);
                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                    Console.WriteLine("Tempo Gasto: " + elapsedMs + " segundos");
                    escrever.WriteLine(elapsedMs);

                    var ramUsage = System.Diagnostics.Process.GetCurrentProcess().PeakWorkingSet64;
                    var allocationInMB = ramUsage / (1024 * 1024);
                    Console.WriteLine("Memória utilizada: " + allocationInMB + "MB");
                    escrever.WriteLine(allocationInMB);
                }

                escrever.Close();

                FileStream arq2 = new FileStream("Análise do 2º algorítimo.txt", FileMode.OpenOrCreate);
                StreamWriter escrever2 = new StreamWriter(arq2);

                for (int i = 1000; i < 100000; i = i + 1000)
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    Funcoes.doisPontoMaisProx(i);
                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                    Console.WriteLine("Tempo Gasto: " + elapsedMs + " segundos");
                    escrever2.WriteLine(elapsedMs);

                    var ramUsage = System.Diagnostics.Process.GetCurrentProcess().PeakWorkingSet64;
                    var allocationInMB = ramUsage / (1024 * 1024);
                    Console.WriteLine("Memória utilizada: " + allocationInMB + "MB");
                    escrever2.WriteLine(allocationInMB);
                }

                escrever2.Close();
            }            
        }
    }
}
