using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TADs_Importantes.TADs;

namespace TADs_Importantes.Prova
{
    class questao2
    {
        public static void rodar()
        {
            Arvore arvore = new Arvore();
            for (int i = 0; i < 10; i = i + 2)
            {
                arvore.Insere(i);
            }

            arvore.ImprimirEmOrdem(arvore.Raiz);
            Console.WriteLine("\n" + arvore.maior());
            for (int i = 11; i > 0; i = i - 2)
            {
                arvore.Insere(i);
            }

            arvore.ImprimirEmOrdem(arvore.Raiz);
            Console.WriteLine("\n" + arvore.maior());
        }


    }
}
