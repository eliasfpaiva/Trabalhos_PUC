using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWar
{
    class Personagem
    {
        public int ataque;
        public int defesa;
        public int life;
        public IArma arma;

        public int atacar()
        {
            double golpe = ataque * arma.usarArma();
            return (int) golpe;
        }
    }
}
