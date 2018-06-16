using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADs_Importantes.TADs
{
    class CelulaTripla
    {
        public int dado;
        public CelulaTripla pai;
        public CelulaTripla filhoEsquerdo;
        public CelulaTripla filhoDireito;
        
        public override string ToString()
        {
            return "Dado: " + dado;
        }
    }
}
