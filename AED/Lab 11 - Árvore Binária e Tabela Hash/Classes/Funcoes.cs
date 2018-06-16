using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_11___Árvore_Binária_e_Tabela_Hash.Classes
{
    class Funcoes
    {
        public static List<Contato> criaListaArquivo()
        {
            List<Contato> listaContatos = new List<Contato>();
            string linha;
            string[] registro;

            FileStream arq = new FileStream(@"Agenda.txt", FileMode.OpenOrCreate);
            StreamReader leitor = new StreamReader(arq);
            {
                do
                {
                    linha = leitor.ReadLine();
                    if (linha != null)
                    {
                        linha = linha.ToLower();
                        registro = linha.Split('|');
                        String[] registroData = registro[2].Split('/');
                        DateTime data = new DateTime(int.Parse(registroData[2]), int.Parse(registroData[1]), int.Parse(registroData[0]));

                        Contato contato = new Contato(int.Parse(registro[0]), registro[1], data, registro[3], registro[4]);
                        listaContatos.Add(contato);
                    }
                } while (linha != null);

            }
            leitor.Close();
            arq.Close();

            return listaContatos;
        }

        public static void imprimiPorNome(List<Contato> listaContatos)
        {
            Contato[] contatos = new Contato[listaContatos.Count];

            for (int i = 0; i < contatos.Length; i++)
            {
                contatos[i] = listaContatos[i];
            }

            for (int i = 0; i < contatos.Length; i++)
            {
                for (int j = i+1; j < contatos.Length; j++)
                {
                    if (contatos[i].nome.CompareTo(contatos[j].nome) > 0)
                    {
                        Contato temp = contatos[i];
                        contatos[i] = contatos[j];
                        contatos[j] = temp;
                    }
                }
            }

            for (int i = 0; i < contatos.Length; i++)
            {
                Console.WriteLine(contatos[i]);
            }
        }


        public static void imprimiPorData(List<Contato> listaContatos)
        {
            Contato[] contatos = new Contato[listaContatos.Count];

            for (int i = 0; i < contatos.Length; i++)
            {
                contatos[i] = listaContatos[i];
            }

            for (int i = 0; i < contatos.Length; i++)
            {
                for (int j = i + 1; j < contatos.Length; j++)
                {
                    if (contatos[i].dataNascimento.CompareTo(contatos[j].dataNascimento) > 0)
                    {
                        Contato temp = contatos[i];
                        contatos[i] = contatos[j];
                        contatos[j] = temp;
                    }
                }
            }

            for (int i = 0; i < contatos.Length; i++)
            {
                Console.WriteLine(contatos[i]);
            }
        }
    }
}
