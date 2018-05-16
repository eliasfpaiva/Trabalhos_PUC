using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pilha_4_Parentesis.Classes;
using Pilha_4_Parentesis.Testes;

namespace Pilha_4_Parentesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            Console.Write("Digite a expressão que deseja avaliar: ");
            string exp = Console.ReadLine();
            bool valida = true;

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i].Equals('('))
                {
                    pilha.empilhar(1);
                }
                else if (exp[i].Equals(')'))
                {
                    if (pilha.vazia())
                    {
                        valida = false;
                        break;
                    }
                    else
                    {
                        pilha.desEmpilhar();
                    }
                }
            }

            if (!pilha.vazia())
                valida = false;

            if (valida)
                Console.WriteLine("Expressão Matemática Correta!");
            else
                Console.WriteLine("Expressão Matemática Incorreta!");

            Console.ReadKey();
        }
    }
}
