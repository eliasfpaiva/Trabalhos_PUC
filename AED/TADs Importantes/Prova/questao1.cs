using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TADs_Importantes.TADs;

namespace TADs_Importantes.Prova
{
    public static class questao1
    {
        public static void rodar()
        {
            Fila fila = new Fila();

            for (int i = 0; i < 15; i++)
            {
                fila.enfileirar(i);
            }


            Console.WriteLine("Fila Original!");
            fila.imprimir();

            Fila filaInvertida = inverter(fila);

            Console.WriteLine("\nFila Invertida!");
            filaInvertida.imprimir();
        }

        private static Fila inverter(Fila fila)
        {
            Fila filaInvertida = new Fila();
            Pilha pilha = new Pilha();
            int tamanhoFila = fila.getTamanho();

            for (int i = 0; i < tamanhoFila; i++)
            {
                pilha.empilhar(fila.desenfileirar());
            }

            for (int i = 0; i < tamanhoFila; i++)
            {
                filaInvertida.enfileirar(pilha.desempilhar());
            }

            return filaInvertida;
        }
    }
}
