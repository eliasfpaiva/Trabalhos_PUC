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
        public Pessoa pessoa;
        public Celula prox;

        public Celula(Pessoa pessoa, Celula prox)
        {
            this.pessoa = pessoa;
            this.prox = prox;
        }
        
        public override string ToString()
        {
            return pessoa.ToString();
        }
    }
}
