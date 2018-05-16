using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_4_Parentesis.Classes
{
    class Pilha
    {
        Celula topo;
        int tam = 0;

        public Pilha() { this.topo = null; }

        public void empilhar(int dado)
        {
            Celula nova = new Celula(topo, dado);
            topo = nova;
            tam++;
        }
        public int? desEmpilhar()
        {
            Celula nova = topo;
            if (nova != null)
            {
                topo = topo.prox;
                tam--;
                return nova.Dado;
            }
            return null;
        }
        public void imprimir()
        {
            Celula temp = topo;
            while (temp != null)
            {
                Console.Write(temp.Dado + " | ");
                temp = temp.prox;
            }
            Console.WriteLine();
        }
        public bool vazia() { return tam == 0; }
        public int tamanho() { return tam; }
    }
}
