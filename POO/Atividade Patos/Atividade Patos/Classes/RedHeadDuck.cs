using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Patos.Interfaces;

namespace Atividade_Patos.Classes
{
    class RedHeadDuck : Duck, IFly, IQuack, ISwim
    {
        public RedHeadDuck() { }

        public override void Display() { Console.WriteLine("Eu sou um pato vermelho!"); }
        public void Fly() { Console.WriteLine("Eu vôo e continuo vermelho!"); }
        public void Swim() { Console.WriteLine("Eu nado e lavo as vermelhas penas!"); }
        public void Quack() { Console.WriteLine("Quack, red, quack!"); }
    }
}
