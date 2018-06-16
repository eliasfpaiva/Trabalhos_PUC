using System;

namespace TADs_Importantes.TADs
{
    internal class Pilha
    {
        Celula topo;
        int tamanho;

        public Pilha() { tamanho = 0; }

        public void empilhar(int dado)
        {
            Celula celulaNova = new Celula(dado, topo);
            topo = celulaNova;
            tamanho++;
        }

        public int desempilhar()
        {
            if (vazia()) return -1;

            Celula temp = new Celula(topo.dado, topo.prox);
            topo = topo.prox;
            tamanho--;
            return temp.dado;
        }

        public void desempilharTudo()
        {
            Celula temp = topo;
            while (temp != null)
            {
                this.desempilhar();
                temp = temp.prox;
            }
        }

        public void imprimir()
        {
            if (vazia()) { Console.WriteLine("Pilha vazia!"); }

            Celula temp = topo;
            while (temp != null)
            {
                Console.WriteLine(temp);
                temp = temp.prox;
            }
        }
        
        public bool vazia() { return tamanho == 0; }
        public int getTamanho() { return tamanho; }
    }
}