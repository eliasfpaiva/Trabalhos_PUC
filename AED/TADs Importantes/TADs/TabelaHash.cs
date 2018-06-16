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
        public bool usarHash2 = false;
        public int[] contadorColisões;

        public TabelaHash(int tamanho)
        {
            tabela = new List<int>[tamanho];
            this.tamanho = tamanho;
            instanciaListas();
            contadorColisões = new int[tamanho];
        }

        public void adicionar(int num)
        {
            int indiceTabela;
            if (usarHash2)
                indiceTabela = hash2(num);
            else
                indiceTabela = hash(num);

            if (tabela[indiceTabela].Count > 0)
                contadorColisões[indiceTabela]++;

            tabela[indiceTabela].Add(num);
            itens++;
        }

        public void remover(int num)
        {
            int indiceTabela;
            if (usarHash2)
                indiceTabela = hash2(num);
            else
                indiceTabela = hash(num);

            for (int i = 0; i < tabela[indiceTabela].Count; i++)
            {
                if (tabela[indiceTabela][i] == num)
                    tabela[indiceTabela].RemoveAt(i);
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
            int indiceTabela;
            if (usarHash2)
                indiceTabela = hash2(num);
            else
                indiceTabela = hash(num);

            foreach (int i in tabela[indiceTabela])
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

        public int hash2(int num)
        {
            return num % 13;
        }
    }
}