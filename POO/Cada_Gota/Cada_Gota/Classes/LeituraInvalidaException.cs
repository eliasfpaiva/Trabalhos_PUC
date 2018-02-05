using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cada_Gota.Classes
{
    public class LeituraInvalidaException : Exception
    {
        public override string ToString()
        {
            return "Valor inválido inserido!\n";
        }
    }
}
