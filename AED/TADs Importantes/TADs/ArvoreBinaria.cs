using System;

namespace TADs_Importantes.TADs
{
    internal class ArvoreBinaria
    {
        CelulaDupla frente;
        CelulaDupla tras;
        int tamanho;

        public ArvoreBinaria()
        {
            tamanho = 0;
            frente = tras = new CelulaDupla();
        }

        public void adcionarAtras(int dado)
        {
            CelulaDupla celulaNova = new CelulaDupla(tras, dado, null);
            tras.prox = celulaNova;
            tras = celulaNova;
            tamanho++;
        }

        public void adcionarFrente(int dado)
        {
            if (vazia()) adcionarAtras(dado);
            else
            {
                CelulaDupla celulaNova = new CelulaDupla(frente, dado, frente.prox);
                frente.prox.ant = celulaNova;
                frente.prox = celulaNova;
                tamanho++;
            }
        }

        public void adcionarPosicao(int dado, int posicao)
        {
            if (posicao < 1 || posicao == tamanho)
            {
                adcionarAtras(dado);
            }
            else
            {
                CelulaDupla celulaAnterior = frente;

                for (int i = 0; i < posicao; i++)
                {
                    celulaAnterior = celulaAnterior.prox;
                }

                CelulaDupla celulaNova = new CelulaDupla(celulaAnterior, dado, celulaAnterior.prox);
                celulaAnterior.prox.ant = celulaNova;
                celulaAnterior.prox = celulaNova;

                tamanho++;
            }
        }

        public int removerAtras()
        {
            if (vazia()) return -1;

            CelulaDupla temp = tras;
            tras = tras.ant;
            tras.prox = null;
            tamanho--;
            return temp.dado;
        }

        public int removerFrente()
        {
            if (vazia()) return -1;

            CelulaDupla temp = frente.prox;
            frente.prox = frente.prox.prox;
            tamanho--;
            return temp.dado;
        }

        public int removerPosicao(int posicao)
        {
            if (posicao < 1 || posicao > tamanho)
            {
                Console.WriteLine("Posição inválida para esta Lista");
                return -1;
            }

            if (posicao == tamanho)
            {
                return removerAtras();
            }
            CelulaDupla celulaRemover = frente;

            for (int i = 0; i != posicao; i++)
            {
                celulaRemover = celulaRemover.prox;
            }

            CelulaDupla temp = celulaRemover;
            temp.ant.prox = temp.prox;
            temp.prox.ant = temp.ant;

            tamanho++;

            return temp.dado;
        }

        public void removerTudo()
        {
            CelulaDupla temp = frente.prox;
            while (temp != null)
            {
                this.removerFrente();
                temp = temp.prox;
            }
        }

        public void imprimir()
        {
            if (vazia()) { Console.WriteLine("Lista vazia!"); }

            CelulaDupla temp = frente.prox;
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