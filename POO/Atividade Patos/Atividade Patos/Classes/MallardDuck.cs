using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Patos.Interfaces;

namespace Atividade_Patos.Classes
{
    class MallardDuck : Duck, IFly, IQuack, ISwim
    {
        public MallardDuck() { }

        public override void Display() { Console.WriteLine("Eu sou um pato mau!"); }
        public void Fly() { Console.WriteLine("Eu vôo com raiva!"); }
        public void Swim() { Console.WriteLine("Eu nado com ira!"); }
        public void Quack() { Console.WriteLine("Grrrrrr, grrrrrrr!"); }
    }
}
