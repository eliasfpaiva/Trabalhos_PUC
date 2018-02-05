using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Patos.Interfaces;

namespace Atividade_Patos.Classes
{
    class WoodDuck : Duck, IQuack
    {
        public WoodDuck() { }

        public override void Display() { Console.WriteLine("Eu sou um pato de Madeira!"); }

        public void Quack() { Console.WriteLine("Toc, toc, toc!"); }
    }
}
