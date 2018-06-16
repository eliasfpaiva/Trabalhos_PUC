using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TADs_Importantes.TADs;

namespace TADs_Importantes.Prova
{
    class questao3
    {
        public static void rodar()
        {
            Arvore arvore = new Arvore();
            Random r = new Random();
            for (int i = 0; i < 50; i = i + 2)
            {
                arvore.Insere(r.Next(0,200));
            }

            arvore.ImprimirPreOrdem(arvore.Raiz);
            Console.ReadKey();
            Console.Clear();
            arvore.imprimeDecrescente();
        }
    }
}
