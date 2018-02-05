using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Patos.Interfaces;

namespace Atividade_Patos.Classes
{
    class IronDuck : Duck, IQuack
    {
        public IronDuck() { }

        public override void Display() { Console.WriteLine("Eu sou um pato de Ferro!"); }

        public void Quack() { Console.WriteLine("Tim, tim, tim"); }
    }
}
