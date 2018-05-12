using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade_6_e_Funcao.Classes
{
    class Funcoes
    {
        public static int F(int num)
        {
            if (num == 1)
                return 1;
            if (num == 2)
                return 2;
            return ((2 * F(num - 1)) + (3 * F(num - 2)));
        }
    }
}
