using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_11___Árvore_Binária_e_Tabela_Hash.Classes;

namespace Lab_11___Árvore_Binária_e_Tabela_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contato> listaContatos = Funcoes.criaListaArquivo();
            TabelaHash tabelaHash = new TabelaHash(listaContatos);
            //tabelaHash.imprimeTabela();
            //Console.ReadKey();
            //Console.Clear();

            //tabelaHash.adicionarContato(new Contato(99, "Manuel", "11/11/1111", "(21)3243-5465", "manuel@manuel"));
            //tabelaHash.imprimeTabela();
            //tabelaHash.remover(99);
            //Console.ReadKey();
            //Console.Clear();

            //tabelaHash.imprimeTabela();
            //Console.ReadKey();
            //Console.Clear();
            //Funcoes.imprimiPorNome(listaContatos);


            //Console.ReadKey();
            //Console.Clear();
            Funcoes.imprimiPorData(listaContatos);

            Console.ReadKey();
        }
    }
}
