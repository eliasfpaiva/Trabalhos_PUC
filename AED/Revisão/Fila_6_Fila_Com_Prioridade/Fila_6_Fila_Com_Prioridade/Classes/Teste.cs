using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filas.Classes;

namespace Filas.Classes
{
    static class Teste
    {
        public static void testar()
        {
            Fila fila = new Fila();

            fila.enfileirar(new Aviao("Teste", 1, 1));

            for (int i = 2; i <= 5; i++)
            {
                fila.enfileirar(new Aviao("Teste", i));
            }


            fila.enfileirar(new Aviao("Teste", 6, 1));

            fila.enfileirar(new Aviao("Teste", 7, 0));

            fila.enfileirar(new Aviao("Teste", 8, 0));

            fila.enfileirar(new Aviao("Teste", 9, 2));

            fila.listarTodosAvioes();
        }
    }
}
