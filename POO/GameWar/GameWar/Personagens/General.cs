using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWar
{
    class General : Personagem
    {
        public General()
        {
            this.ataque = 800;
            this.defesa = 500;
            this.life = 8000;
        }
    }
}
