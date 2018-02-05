using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWar
{
    class Canhao
    {
        public double usarArma()
        {
            Random fator = new Random();
            return fator.Next(0, 300)/100;
        }
    }
}
