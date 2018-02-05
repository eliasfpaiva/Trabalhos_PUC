using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Patos.Interfaces;

namespace Atividade_Patos.Classes
{
    class RubberDuck : Duck, IFly, IQuack, ISwim
    {
        public RubberDuck() { }

        public void Quack() { Console.WriteLine("Bip! Bip! Bip!"); }
        public void Swim() { Console.WriteLine("Eu estou flutuando!"); }
        public override void Display() { Console.WriteLine("Eu sou um pato de borracha!"); }
        public void Fly() { Console.WriteLine("Eu não posso voar!"); }
    }
}
