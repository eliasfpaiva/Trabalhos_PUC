using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pilha_4_Parentesis.Classes;

namespace Pilha_4_Parentesis.Testes
{
    class Teste1
    {

        public static void testar(Pilha pilha)
        {
            pilha.empilhar(1);
            pilha.empilhar(2);
            pilha.empilhar(3);
            pilha.empilhar(4);
            pilha.empilhar(5);

            pilha.imprimir();

            Console.WriteLine(pilha.desEmpilhar());

            pilha.imprimir();
        }
    }
}
