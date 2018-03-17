using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas.Classes
{
    class Celula
    {
        private Carro carro;
        private Celula proxCelula;

        public Celula(Carro carro, Celula proxCelula)
        {
            this.carro = carro;
            this.proxCelula = proxCelula;
        }
        
        public Carro GetCarro() { return this.carro; }
        public Celula GetProxCelula() { return this.proxCelula; }
        public override string ToString() { return this.carro.ToString(); }
    }
}
