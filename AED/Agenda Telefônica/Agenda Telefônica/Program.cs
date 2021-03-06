﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda_Telefônica.Classes;

namespace Agenda_Telefônica
{
    class Program
    {
        public static int Menu()
        {
            string aux;
            int opcao = -1;

            do
            {

                Console.WriteLine("###  AGENDA ###");
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Inserir um novo contato");
                Console.WriteLine("2 - Listar Contatos por Código"); ;
                Console.WriteLine("3 - Listar Contatos por Nome"); ;
                Console.WriteLine("4 - Listar Contatos por Data de Nascimento");
                Console.WriteLine("5 - Pesquisar por Codigo");
                Console.WriteLine("6 - Remover um contato");
                Console.WriteLine("0 - Sair");
                aux = Console.ReadLine();

                if (!int.TryParse(aux, out opcao))
                    Console.WriteLine("Você digitou uma opção inválida! Tente Novamente!");

            } while (!int.TryParse(aux, out opcao));

            return opcao;
        }

        public static void PreencherContatos(Contato[] agenda,
            ref int numContatos, int N)
        {
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                Contato novo = new Contato();

                novo.Codigo = random.Next(0, 100);
                novo.Nome = "Contato - " + novo.Codigo;
                novo.Telefone = "0000-0000";
                novo.Email = "email@email.br";
                novo.DataNascimento = DateTime.Now;

                agenda[numContatos] = novo;
                numContatos++;

            }
        }

        public static void InserirContato(Contato[] agenda, ref int numContatos)
        {
            Contato novo = new Contato();

            novo.Codigo = numContatos + 1;
            novo.Nome = "Kleber";
            novo.Telefone = "0000-0000";
            novo.Email = "klebersouza@pucminas.br";
            novo.DataNascimento = DateTime.Now;

            agenda[numContatos] = novo;
            numContatos++;
        }

        private static void RemoverContato(Contato[] agenda, ref int numContatos)
        {
            int Codigo;
            Console.Clear();
            Console.Write("Informe o código do contato que deseja excluir: ");
            int.TryParse(Console.ReadLine(), out Codigo);

            int posicaoRemover = -1;

            for (int i = 0; i < numContatos; i++)
            {
                if (agenda[i].Codigo == Codigo)
                {
                    posicaoRemover = i;
                    numContatos--;
                }
            }

            if (posicaoRemover != -1)
                for (int i = posicaoRemover; i < numContatos; i++)
                    agenda[i] = agenda[i + 1];
            else
                Console.WriteLine("Contato não encontrado!");
        }

        public static void ListarContatos(Contato[] agenda, int numContatos)
        {
            for (int i = 0; i < numContatos; i++)
            {
                Console.WriteLine(agenda[i].Codigo + " - " +
                    agenda[i].Nome);
            }
        }


        public static void OrdenarPorNome(Contato[] agenda, int numContatos)
        {
            for (int i = 0; i < numContatos - 1; i++)
                for (int j = 0; j < numContatos - i - 1; j++)
                    if (agenda[j].Nome.CompareTo(agenda[j + 1].Nome) > 0)
                    {
                        Contato aux = agenda[j];
                        agenda[j] = agenda[j + 1];
                        agenda[j + 1] = aux;
                    }
        }

        public static void OrdenarPorCodigo(Contato[] agenda, int numContatos)
        {
            for (int i = 0; i < numContatos - 1; i++)
                for (int j = 0; j < numContatos - i - 1; j++)
                    if (agenda[j].Codigo > agenda[j + 1].Codigo)
                    {
                        Contato aux = agenda[j];
                        agenda[j] = agenda[j + 1];
                        agenda[j + 1] = aux;
                    }
        }
        public static void OrdenarPorData(Contato[] agenda, int numContatos)
        {
            for (int i = 0; i < numContatos - 1; i++)
                for (int j = 0; j < numContatos - i - 1; j++)
                    if (agenda[j].DataNascimento.CompareTo(agenda[j + 1].DataNascimento) > 0)
                    {
                        Contato aux = agenda[j];
                        agenda[j] = agenda[j + 1];
                        agenda[j + 1] = aux;
                    }
        }

        public static Contato PesquisaPorCodigo(Contato[] agenda,
            int numContatos, int codigo)
        {
            int inicio = 0;
            int fim = numContatos - 1;

            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;

                if (codigo == agenda[meio].Codigo)
                    return agenda[meio];

                if (codigo < agenda[meio].Codigo)
                    fim = meio - 1;
                else
                    inicio = meio + 1;
            }

            return null;
        }



        static void Main(string[] args)
        {
            int MAX = 100, opcao = 0;
            int numContatos = 0;
            Contato[] agenda = new Contato[MAX];

            do
            {
                opcao = Menu();

                switch (opcao)
                {
                    case 1:
                        InserirContato(agenda, ref numContatos);
                        break;

                    case 2:
                        OrdenarPorCodigo(agenda, numContatos);
                        ListarContatos(agenda, numContatos);
                        break;

                    case 3:
                        OrdenarPorNome(agenda, numContatos);
                        ListarContatos(agenda, numContatos);
                        break;

                    case 4:
                        OrdenarPorData(agenda, numContatos);
                        ListarContatos(agenda, numContatos);
                        break;

                    case 5:
                        OrdenarPorCodigo(agenda, numContatos);
                        Contato query = PesquisaPorCodigo(agenda,
                            numContatos,
                            13);
                        if (query == null)
                            Console.WriteLine("Contato não encontrado!");
                        else
                            Console.WriteLine(query.Nome);

                        break;

                    case 6:
                        RemoverContato(agenda, ref numContatos);
                        break;
                }

            } while (opcao != 0);
        }
    }
}
