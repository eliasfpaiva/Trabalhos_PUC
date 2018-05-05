using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Prática.Classes
{
    public class Celula
    {
        public int dado;
        public Celula ant, prox;
        
        public Celula()
        {
            this.ant = this.prox = null;
        }
        public Celula(int dado)
        {
            this.dado = dado;
            this.ant = this.prox = null;
        }
    }
}
