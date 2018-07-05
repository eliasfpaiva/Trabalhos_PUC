using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIB
{
    public static class MyMath
    {
        public static int CalcFat(int n)
        {
            int Fat = 1;
            for (int i = 1; i <= n; Fat *= i++) ;

            return Fat;
        }

        public static int CalcPot(int x, int y)
        {
            int Pot = 1;
            for (int i = 0; i <= y; i++)
                Pot *= x;

            return Pot;
        }
    }
}
