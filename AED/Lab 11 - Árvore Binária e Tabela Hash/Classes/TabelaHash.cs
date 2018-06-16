using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11___Árvore_Binária_e_Tabela_Hash.Classes
{
    class TabelaHash
    {
        List<Contato>[] tabela;
        int tamanho;

        public TabelaHash(int tamanho)
        {
            this.tamanho = tamanho;
            this.tabela = new List<Contato>[tamanho];
            inicializaListas();
        }

        public TabelaHash(List<Contato> contatos )
        {
            tamanho = contatos.Count / 10;
            this.tabela = new List<Contato>[tamanho];
            inicializaListas();
            foreach (Contato c in contatos)
            {
                adicionarContato(c);
            }
        }

        private void inicializaListas()
        {
            for (int i = 0; i < tabela.Length; i++)
            {
                tabela[i] = new List<Contato>();
            }
        }

        public void adicionarContato(Contato contato)
        {
            tabela[contato.codigo % tamanho].Add(contato);
        }

        public int pesquisaIndice(int codigo)
        {
            Contato temporario = new Contato(codigo);
            return tabela[codigo % tamanho].IndexOf(temporario);
        }

        public Contato pesquisaContato(int codigo)
        {
            foreach (Contato c in tabela[codigo% tamanho])
            {
                if (c.codigo == codigo) return c;
            }

            return null;
        }

        public void remover(int codigo)
        {
            tabela[codigo % tamanho].RemoveAt(pesquisaIndice(codigo));
        }

        public void imprimeTabela()
        {
            for (int i = 0; i < tabela.Length; i++)
            {
                foreach (Contato c in tabela[i])
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            }
        }
    }
}
