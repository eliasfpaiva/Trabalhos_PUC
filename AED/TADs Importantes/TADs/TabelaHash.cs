using System;
using System.Collections.Generic;

namespace TADs_Importantes.TADs
{
    internal class TabelaHash
    {
        /*
         * Classe que representa a implementação de uma tabela Hash de endereçamenteo fechado
         */

        public List<int>[] tabela;
        public int tamanho;
        public int itens = 0;

        public TabelaHash(int tamanho)
        {
            tabela = new List<int>[tamanho];
            this.tamanho = tamanho;
            instanciaListas();
        }

        public void adicionar(int num)
        {
            tabela[hash(num)].Add(num);
            itens++;
        }

        public void remover(int num)
        {
            int indiceLista = hash(num);
            for (int i = 0; i < tabela[indiceLista].Count; i++)
            {
                if (tabela[indiceLista][i] == num)
                    tabela[indiceLista].RemoveAt(i);
            }
            itens--;
        }

        public void removerTodos()
        {
            instanciaListas();
        }

        public void imprimir()
        {
            for (int i = 0; i < tabela.Length; i++)
            {
                foreach (int num in tabela[i])
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine("#########");
            }
        }

        public bool pesquisar(int num)
        {
            foreach (int i in tabela[hash(num)])
                if (i == num) return true;

            return false;
        }

        public void instanciaListas()
        {
            for (int i = 0; i < tabela.Length; i++)
                tabela[i] = new List<int>();
            itens = 0;
        }

        public int hash(int num)
        {
            return num % tamanho;
        }
    }
}