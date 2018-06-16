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
            f.enfileirar(1);
            f.enfileirar(10);
            f.enfileirar(20);
            Console.WriteLine(f.desenfileirar());


            Lista l = new Lista();
            ArvoreBinaria ab = new ArvoreBinaria();
            TabelaHash th = new TabelaHash();

            Console.ReadKey();
        }
    }
}
