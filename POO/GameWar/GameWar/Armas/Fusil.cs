﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWar
{
    class Fusil
    {
        public double usarArma()
        {
            Random fator = new Random();
            return fator.Next(0, 250)/100;
        }
    }
}