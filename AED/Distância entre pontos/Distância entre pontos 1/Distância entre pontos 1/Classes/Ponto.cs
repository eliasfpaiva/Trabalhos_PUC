using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Distância_entre_pontos_1.Classes;

namespace Distância_entre_pontos_1.Classes
{
    public class Ponto
    {
        public int x { get; set; }
        public int y { get; set; }
        public Ponto(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }
    }
}
