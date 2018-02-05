using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Patos.Classes;

namespace Atividade_Patos
{
    class Program
    {
        static void Main(string[] args)
        {
            IronDuck patoFerro = new IronDuck();
            MallardDuck patoMau = new MallardDuck();
            RedHeadDuck patoVermelho = new RedHeadDuck();
            RubberDuck patoBorracha = new RubberDuck();
            WoodDuck patoMadeira = new WoodDuck();

            Console.WriteLine("\nTeste do pato de ferro:");
            patoFerro.Display();
            patoFerro.MostrarClan("Minerador", "Explosivo");
            patoFerro.Quack();

            Console.WriteLine("\nTeste do pato mau:");
            patoMau.Display();
            patoMau.Fly();
            patoMau.MostrarClan("Raivosos", "Irado");
            patoMau.Quack();
            patoMau.Swim();

            Console.WriteLine("\nTeste do pato vermelho:");
            patoVermelho.Display();
            patoVermelho.Fly();
            patoVermelho.MostrarClan("Ruivos", "Bonitão");
            patoVermelho.Quack();
            patoVermelho.Swim();

            Console.WriteLine("\nTeste do pato de borracha:");
            patoBorracha.Display();
            patoBorracha.Fly();
            patoBorracha.MostrarClan("Brinquedos", "Amado");
            patoBorracha.Quack();
            patoBorracha.Swim();

            Console.WriteLine("\nTeste do pato de madeira:");
            patoMadeira.Display();
            patoMadeira.MostrarClan("Enfeites", "Caro");
            patoMadeira.Quack();
            Console.ReadKey();
        }
    }
}
