﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Prática.Classes
{
    class Lista
    {
        Celula frente, traz;
        int tamanho;

        public Lista()
        {
            frente = traz = new Celula();
            tamanho = 0;
        }

        public bool vazia() { return this.tamanho == 0; }
        public int getTamanho() { return this.tamanho; }
        public void imprime()
        {
            Celula temp = frente.prox;
            while (temp != null)
            {
                Console.Write(temp.dado + " ");
                temp = temp.prox;
            }
            Console.WriteLine();
        }
        public bool insere(int dado)
        {
            Celula nova = new Celula(dado);
            nova.prox = frente.prox;
            frente.prox = nova;
            nova.ant = frente;
            if (this.vazia())
                traz = nova;
            tamanho++;
            return true;
        }
        public bool insereNoIndice(int dado, int indice)
        {
            Celula nova = new Celula(dado);

            if (vazia()||indice==0)
                insere(dado);
            else if (indice >= getTamanho())
            {
                traz.prox = nova;
                nova.ant = traz;
                traz = nova;
                tamanho++;
                return true;
            }
            else
            {
                Celula temp = frente.prox;
                int posicao = 0;
                while (posicao < indice - 1)
                {
                    temp = temp.prox;
                    posicao++;
                }
                nova.prox = temp.prox;
                nova.ant = temp;
                nova.prox.ant = nova;
                nova.ant.prox = nova;
                tamanho++;
            }
            return true;
        }
        public int? remove()
        {
            if (!vazia() && getTamanho()!=1)
            {
                Celula removida = frente.prox;
                Celula temp = removida.prox;

                temp.ant = frente;
                frente.prox = temp;

                tamanho--;
                return removida.dado;
            }else if (getTamanho() == 1)
            {
                Celula removida = frente.prox;
                frente.prox = null;
                frente = traz;
                tamanho--;
                return removida.dado;
            }
            return null;
        }
        public int? removeNoIndice(int indice)
        {
            if (vazia() || indice >= getTamanho())
                return null;
            else
            {
                Celula temp = frente.prox;
                int posicao = 0;
                while (posicao < indice - 1)
                {
                    temp = temp.prox;
                    posicao++;
                }
                Celula removida = temp.prox;
                temp.prox = removida.prox;
                temp.prox.ant = temp;
                tamanho--;
                return removida.dado;
            }
        }
    }
}
