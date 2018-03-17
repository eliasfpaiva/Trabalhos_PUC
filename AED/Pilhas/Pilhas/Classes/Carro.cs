using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas.Classes
{
    class Carro
    {
        private String placa;
        private int manobras;

        public Carro(String placa)
        {
            this.placa = placa;
            manobras   = 0;
        }

        public void manobra() { manobras++; }

        public int getManobras() { return manobras; }

        public override string ToString() { return this.placa; }
    }
}
