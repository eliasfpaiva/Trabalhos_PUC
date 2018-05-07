using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Trabalho_Modulo_1.Classes;

namespace Trabalho_Modulo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitação de que o usuário selecione o que deseja visualizar no console durante a execução
            Console.Write("Se você deseja que o console apresente as ações das Threads, digite 1\n" +
                "se deseja ver o estado do vetor de Threads, digite outro caracter: ");
            //Recebimento e atribuição do valor lido
            Servidor.acaoConsole = Console.ReadLine();
            
            //Rotina de chamadas ao servidor, executa 60 chamadas em intervalos de 1 segundo
            for (int i = 0; i < 60; i++)
            {
                Servidor.NovaRequisicao();
                //Garante o intervalo de 1 segundo
                Thread.Sleep(1000);
            }

            //Para garantir que todas as Treads tenham terminado sua execução antes da apresentação de resultados,
            //a execução desta Thread é interrompida pelo intervalo superior à duração máxima de uma Thread
            Thread.Sleep(8000);

            //Apresenta os resultados referentes à execução do simulador
            Console.WriteLine("\n\nThreads solicidadas: 60");
            Console.WriteLine("Threads atendidas  : " + Servidor.threadsAtendidas);
            Console.WriteLine("Threads iniciadas  : " + Servidor.threadsIniciadas);
            Console.WriteLine("Threads Concluidas : " + Servidor.threadsConcluidas);
            Console.WriteLine("Threads negadas    : " + Servidor.threadsNegadas);

            //Indica que o procesamento terminou
            Console.WriteLine("Concluido!");

            //Aguarda interação do usuário para garantir que este tenha a oportunidade de ver a execução
            Console.ReadKey();
        }
    }
}
