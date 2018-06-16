using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADs_Importantes.TADs
{
    class Celula
    {
        public int dado;
        public Celula prox;

        public Celula()
        {
            prox = null;
        }

        public Celula(int dado, Celula prox)
        {
            this.dado = dado;
            this.prox = prox;
        }

        public override string ToString()
        {
            return "Dado: " + dado;
        }
    }
}
