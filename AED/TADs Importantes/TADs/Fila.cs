using System;

namespace TADs_Importantes.TADs
{
    internal class Fila
    {
        Celula primeira;
        Celula ultima;
        int tamanho;

        public Fila()
        {
            tamanho = 0;
            primeira = ultima = new Celula();
        }

        public void enfileirar(int dado)
        {
            Celula celulaNova = new Celula(dado, null);
            ultima.prox = celulaNova;
            ultima = celulaNova;
            tamanho++;
        }

        public int desenfileirar()
        {
            if(vazia()) return -1;

            Celula temp = primeira.prox;
            primeira.prox = primeira.prox.prox;
            tamanho--;
            return temp.dado;
        }

        public void desenfileirarTudo()
        {
            Celula temp = primeira.prox;
            while (temp != null)
            {
                this.desenfileirar();
                temp = temp.prox;
            }
        }

        public void imprimir()
        {
            if (vazia()) { Console.WriteLine("Fila vazia!"); }

            Celula temp = primeira.prox;
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