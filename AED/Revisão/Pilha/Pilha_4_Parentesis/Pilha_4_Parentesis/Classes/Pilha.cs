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

        public Pilha() { this.topo = null; }

        public void empilhar(int dado)
        {
            Celula nova = new Celula(topo, dado);
            topo = nova;
            topo.
        }
    }
}
