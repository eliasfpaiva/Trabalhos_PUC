using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAED2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rep = 0, empates = 0, opTime = 0, ok = 0, placar1, placar2, jogos = 0;
            Random random = new Random();
            int[] atletico = new int[7];
            int[] cruzeiro = new int[7];
            int[] america  = new int[7];
            int[] timeA    = new int[7];
            int[] timeB    = new int[7];

            atletico[0] = 1;
            america [0] = 2;
            cruzeiro[0] = 3;

            do
            {
                do
                {
                    Console.WriteLine("***********************************************************\n" +
                        "Informe os times que disputarão o jogo:\n1 Galo\n2 América\n3 Cruzeiro");
                    try
                    {
                        Console.Write("Indique o primeiro time: ");
                        opTime = int.Parse(Console.ReadLine());
                        switch (opTime)
                        {
                            case 1:
                                timeA = atletico;
                                break;
                            case 2:
                                timeA = america;
                                break;
                            case 3:
                                timeA = cruzeiro;
                                break;
                        }
                        if (opTime < 1 || opTime > 3) { throw new Exception(); }

                        Console.Write("Indique o segundo time: ");
                        opTime = int.Parse(Console.ReadLine());
                        switch (opTime)
                        {
                            case 1:
                                timeB = atletico;
                                break;
                            case 2:
                                timeB = america;
                                break;
                            case 3:
                                timeB = cruzeiro;
                                break;
                        }
                        if (opTime < 1 || opTime > 3 || timeA[0] == timeB[0]) { throw new Exception(); }
                        ok = 1;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nOpção inválida!\nApenas os valores listados podem ser utilizados e um time não pode jogar contra si mesmo!");
                        ok = 0;
                    }

                } while (ok != 1);

                //atribuição aleatória de número de gols e contagem de jogos
                placar1 = random.Next(0, 6);
                placar2 = random.Next(0, 6);
                jogos++;

                //contagem de empates e vitórias
                if (placar1 == placar2)
                {
                    Console.WriteLine("EMPATE!");
                    timeA[3]++;
                    timeB[3]++;
                    empates++;
                }
                else if (placar1 > placar2)
                {
                    timeA[1]++;
                    timeB[2]++;

                    switch (timeA[0])
                    {
                        case 1:
                            Console.WriteLine("Vitória do Atlético!");
                            break;
                        case 2:
                            Console.WriteLine("Vitória do América!");
                            break;
                        case 3:
                            Console.WriteLine("Vitória do Cruzeiro!");
                            break;
                    }
                }
                else if (placar1 < placar2)
                {
                    timeA[2]++;
                    timeB[1]++;

                    switch (timeB[0])
                    {
                        case 1:
                            Console.WriteLine("Vitória do Atlético!");
                            break;
                        case 2:
                            Console.WriteLine("Vitória do América!");
                            break;
                        case 3:
                            Console.WriteLine("Vitória do Cruzeiro!");
                            break;
                    }
                }

                timeA[4] += placar1;
                timeA[5] += placar2;
                timeA[6] = timeA[4] - timeA[5];
                timeB[4] += placar2;
                timeB[5] += placar1;
                timeB[6] = timeB[4] - timeB[5];

                switch (timeA[0])
                {
                    case 1:
                        atletico = timeA;
                        break;
                    case 2:
                        america = timeA;
                        break;
                    case 3:
                        cruzeiro = timeA;
                        break;
                }

                switch (timeB[0])
                {
                    case 1:
                        atletico = timeB;
                        break;
                    case 2:
                        america = timeB;
                        break;
                    case 3:
                        cruzeiro = timeB;
                        break;
                }

                //verificação do desejo de repetição
                do
                {
                    try
                    {
                        Console.WriteLine("Novo DUELO 1.Sim 2.Não?");
                        rep = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException Fe)
                    {
                        rep = 3;
                    }

                    if (rep != 1 && rep != 2)
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                } while (rep != 1 && rep != 2);
            } while (rep != 2);

            Console.WriteLine("\n\n###################################################################\n" +
                jogos + " jogos fizeram parte desta estatística!");

            //[codigo, vitorias, derrotas, empates, gols feitos, gols sofridos, saldo de gols]
            Console.WriteLine("Em primeiro Lugar Atlético com:\n" +
                    atletico[1] + " vitórias\n" +
                    atletico[2] + " derrotas\n" +
                    atletico[3] + " empates\n" +
                    atletico[4] + " gols feitos\n" +
                    atletico[5] + " gols sofridos\n" +
                    atletico[6] + " de saldo de gols");
            Console.WriteLine("\nAmérica com:\n" +
                    america[1] + " vitórias\n" +
                    america[2] + " derrotas\n" +
                    america[3] + " empates\n" +
                    america[4] + " gols feitos\n" +
                    america[5] + " gols sofridos\n" +
                    america[6] + " de saldo de gols");
            Console.WriteLine("\nCruzeiro com:\n" +
                     cruzeiro[1] + " vitórias\n" +
                     cruzeiro[2] + " derrotas\n" +
                     cruzeiro[3] + " empates\n" +
                     cruzeiro[4] + " gols feitos\n" +
                     cruzeiro[5] + " gols sofridos\n" +
                     cruzeiro[6] + " de saldo de gols");
            /*if (atletico[1]>america[1] && atletico[1] > cruzeiro[1])
            {
                Console.WriteLine("Em primeiro Lugar Atlético com:\n" +
                    atletico[1] + " vitórias\n" +
                    atletico[2] + " derrotas\n" +
                    atletico[3] + " empates\n" +
                    atletico[4] + " gols feitos\n" +
                    atletico[5] + " gols sofridos\n" +
                    atletico[6] + " de saldo de gols");
            }else if (america[1] > atletico[1] && america[1] > cruzeiro[1])
            {
                Console.WriteLine("Em primeiro Lugar América com:\n" +
                    america[1] + " vitórias\n" +
                    america[2] + " derrotas\n" +
                    america[3] + " empates\n" +
                    america[4] + " gols feitos\n" +
                    america[5] + " gols sofridos\n" +
                    america[6] + " de saldo de gols");
            }
            else if (cruzeiro[1] > america[1] && cruzeiro[1] > atletico[1])
            {
                Console.WriteLine("Em primeiro Lugar Cruzeiro com:\n" +
                    cruzeiro[1] + " vitórias\n" +
                    cruzeiro[2] + " derrotas\n" +
                    cruzeiro[3] + " empates\n" +
                    cruzeiro[4] + " gols feitos\n" +
                    cruzeiro[5] + " gols sofridos\n" +
                    cruzeiro[6] + " de saldo de gols");
            }

            if (atletico[1] > america[1] && atletico[1] < cruzeiro[1])
            {
                Console.WriteLine("Em segundo Lugar Atlético com:\n" +
                    atletico[1] + " vitórias\n" +
                    atletico[2] + " derrotas\n" +
                    atletico[3] + " empates\n" +
                    atletico[4] + " gols feitos\n" +
                    atletico[5] + " gols sofridos\n" +
                    atletico[6] + " de saldo de gols");
            }
            else if (america[1] > atletico[1] && america[1] < cruzeiro[1])
            {
                Console.WriteLine("Em segundo Lugar América com:\n" +
                    america[1] + " vitórias\n" +
                    america[2] + " derrotas\n" +
                    america[3] + " empates\n" +
                    america[4] + " gols feitos\n" +
                    america[5] + " gols sofridos\n" +
                    america[6] + " de saldo de gols");
            }
            else if (cruzeiro[1] > atletico[1] && cruzeiro[1] < america[1])
            {
                Console.WriteLine("Em segundo Lugar Cruzeiro com:\n" +
                    cruzeiro[1] + " vitórias\n" +
                    cruzeiro[2] + " derrotas\n" +
                    cruzeiro[3] + " empates\n" +
                    cruzeiro[4] + " gols feitos\n" +
                    cruzeiro[5] + " gols sofridos\n" +
                    cruzeiro[6] + " de saldo de gols");
            }

            if (atletico[1] < america[1] && atletico[1] < cruzeiro[1])
            {
                Console.WriteLine("Em terceiro Lugar Atlético com:\n" +
                    atletico[1] + " vitórias\n" +
                    atletico[2] + " derrotas\n" +
                    atletico[3] + " empates\n" +
                    atletico[4] + " gols feitos\n" +
                    atletico[5] + " gols sofridos\n" +
                    atletico[6] + " de saldo de gols");
            }
            else if (america[1] < atletico[1] && america[1] < cruzeiro[1])
            {
                Console.WriteLine("Em terceiro Lugar América com:\n" +
                    america[1] + " vitórias\n" +
                    america[2] + " derrotas\n" +
                    america[3] + " empates\n" +
                    america[4] + " gols feitos\n" +
                    america[5] + " gols sofridos\n" +
                    america[6] + " de saldo de gols");
            }
            else if (cruzeiro[1] < atletico[1] && cruzeiro[1] < america[1])
            {
                Console.WriteLine("Em terceiro Lugar Cruzeiro com:\n" +
                    cruzeiro[1] + " vitórias\n" +
                    cruzeiro[2] + " derrotas\n" +
                    cruzeiro[3] + " empates\n" +
                    cruzeiro[4] + " gols feitos\n" +
                    cruzeiro[5] + " gols sofridos\n" +
                    cruzeiro[6] + " de saldo de gols");
            }*/

            Console.WriteLine(empates + " jogos terminaram em empate!");

            Console.ReadKey();
        }
    }
}
