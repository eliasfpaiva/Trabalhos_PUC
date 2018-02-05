using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAED1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rep = 1, contGalo = 0, contRaposa = 0, contEmpates = 0, atletico, cruzeiro, jogos = 0;
            Random random = new Random();
            string mensagemEmpates;
            //rep opção de repetição
            //contGalo e contRaposa conta vitórias dos respectivos times
            //contEmpates conta empates
            //atletico e cruzeiro recebem número de gols dos respectivos times
            //random gera valores aleatórios
            //jogos número de jogos
            //mensagemEmpates é uma variável para melhorar a concordância da mensagem sobre o número de empates

            do
            {
                //atribuição aleatória de número de gols e contagem de jogos
                cruzeiro = random.Next(0, 6);
                atletico = random.Next(0, 6);
                jogos++;

                //contagem de empates e vitórias
                if (cruzeiro == atletico)
                {
                    Console.WriteLine("EMPATE!");
                    contEmpates++;
                }
                else if (cruzeiro > atletico)
                {
                    Console.WriteLine("Vitória do Cruzeiro!");
                    contRaposa++;
                }
                else if (cruzeiro < atletico)
                {
                    Console.WriteLine("Vitória do Atlético!");
                    contGalo++;
                }

                //Apresentação de placar
                Console.WriteLine("\nPLACAR\n" +
                    "Cruzeiro: " + cruzeiro +
                    "\nAtlético: " + atletico + "\n");

                //verificação do desejo de repetição
                do
                {
                    try
                    {
                        Console.WriteLine("Novo DUELO 1.Sim 2.Não?");
                        rep = int.Parse(Console.ReadLine());
                    }
                    catch(FormatException Fe)
                    {
                        rep = 3;
                    }
                    
                    if (rep != 1 && rep != 2)
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                } while (rep != 1 && rep != 2);
            } while (rep == 1);

            //Apresentação de resultados
            Console.WriteLine("\n\nRESULTADOS");

            if (contEmpates == 0) { mensagemEmpates = "Nenhum jogo terminou em EMPATE!"; }
            else if (contEmpates == 1) { mensagemEmpates = contEmpates + " jogo apenas terminou em EMPATE!"; }
            else { mensagemEmpates = contEmpates + " jogos terminaram em EMPATE"; }

            Console.WriteLine("\n Foram contabilizados: " + jogos + "\n" +
                "O Atlético venceu: " + contGalo + " jogos\n" +
                "O Cruzeiro venceu: " + contRaposa + " jogos\n" + mensagemEmpates);
            if (contGalo > contRaposa) { Console.WriteLine("O Atlético obteve o maior número de vitórias."); }
            else if (contGalo < contRaposa) { Console.WriteLine("O Cruzeiro obteve o maior número de vitórias."); }
            else { Console.WriteLine("Os times obtivéram o mesmo número de vitórias."); }

            Console.ReadKey();
        }
    }
}
