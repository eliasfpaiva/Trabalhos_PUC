using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_4_Parentesis.Classes
{
    public class Celula
    {
        private int Dado;
        public Celula prox { get; set; }

        public Celula(Celula prox, int dado)
        {
            this.Dado = dado;
            this.prox = prox;
        }
        public int getDado() { return Dado; }
    }
}
