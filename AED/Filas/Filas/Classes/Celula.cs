using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filas.Classes;

namespace Filas.Classes
{
    public class Celula
    {
        public Aviao aviao;
        public Celula prox;

        public Celula(Aviao aviao, Celula prox)
        {
            this.aviao = aviao;
            this.prox = prox;
        }

        public override string ToString()
        {
            return aviao.ToString();
        }
    }
}
