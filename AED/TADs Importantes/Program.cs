using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TADs_Importantes.TADs;


namespace TADs_Importantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha();
            Fila f = new Fila();
            Lista l = new Lista();
            TabelaHash th = new TabelaHash(3);

            for (int i = 0; i < 10; i++)
            {
                th.adicionar(i);
            }
            
            ArvoreBinaria ab = new ArvoreBinaria();

            Console.ReadKey();
        }
    }
}
