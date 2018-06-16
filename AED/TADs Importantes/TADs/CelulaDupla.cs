using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADs_Importantes.TADs
{
    class CelulaDupla
    {
        public int dado;
        public CelulaDupla prox;
        public CelulaDupla ant;

        public CelulaDupla()
        {
            this.dado = -1;
            this.prox = null;
            this.ant = null;
        }

        public CelulaDupla(CelulaDupla ant, int dado, CelulaDupla prox)
        {
            this.dado = dado;
            this.prox = prox;
            this.ant = ant;
        }

        public override string ToString()
        {
            return "Dado: " + dado;
        }
    }
}
