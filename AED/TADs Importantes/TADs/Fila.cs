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
            primeira.prox = ultima;
        }

        public void enfileirar(int dado)
        {
            Celula celulaNova = new Celula(dado, ultima);
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

        public bool vazia() { return tamanho == 0; }
        public int getTamanho() { return tamanho; }
    }
}