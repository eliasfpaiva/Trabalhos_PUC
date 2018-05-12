using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade_1MDC.Classes
{
    class Funcoes
    {
        public static int mdc(int x, int y)
        {
            if (x == y)
                return x;

            if (x > y)
                return mdc(x - y, y);
            return mdc(y - x, x);
        }
    }
}