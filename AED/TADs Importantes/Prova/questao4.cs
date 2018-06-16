using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TADs_Importantes.TADs;

namespace TADs_Importantes.Prova
{
    class questao4
    {
        public static void rodar()
        {
            TabelaHash tabelaHash = new TabelaHash(31);

            for (int i = 1; i <= 1000; i++)
            {
                if (ePrimo(i)) tabelaHash.adicionar(i);
            }
            
            int piorCasoHash = tabelaHash.contadorColisões.Max();
            int melhorCasoHash = menor(tabelaHash.contadorColisões);

            tabelaHash.removerTodos();

            tabelaHash.usarHash2 = true;
            for (int i = 1; i <= 1000; i++)
            {
                if (ePrimo(i)) tabelaHash.adicionar(i);
            }

            int piorCasoHash2 = tabelaHash.contadorColisões.Max();
            int melhorCasoHash2 = menor(tabelaHash.contadorColisões);

            Console.WriteLine(
                "Pior caso Hash 1: " + piorCasoHash +
                "\nPior caso Hash 2: " + piorCasoHash2 +
                "\nMelhor caso Hash 1: " + melhorCasoHash +
                "\nMelhor caso Hash 2: " + melhorCasoHash2
                );

            melhor(melhorCasoHash, melhorCasoHash2, piorCasoHash, piorCasoHash2);
        }
        private static bool ePrimo(int num)
        {
            if (num == 1) return false;

            if (num == 2) return true;

            for (int i = 2; i < Math.Sqrt(num)+1; i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        private static int menor(int[] vet)
        {
            int menor = vet.Max();

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i]!=0 && vet[i]<menor)
                {
                    menor = vet[i];
                }
            }

            return menor;
        }

        private static void melhor(int melhor1, int melhor2, int pior1, int pior2)
        {
            if (melhor1 < melhor2 && pior1 < pior2)
                Console.WriteLine("A função 1 é melhor em todos os casos!");

            if (melhor1 > melhor2 && pior1 > pior2)
                Console.WriteLine("A função 2 é melhor em todos os casos!");

            if (melhor1 < melhor2 && pior1 > pior2)
                Console.WriteLine("A função 1 é melhor no melhor caso e a função 2 é melhor no pior caso!");

            if (melhor1 > melhor2 && pior1 < pior2)
                Console.WriteLine("A função 1 é pior no melhor caso e a função 2 é pior no pior caso!");

            if (melhor1 == melhor2 && pior1 > pior2)
                Console.WriteLine("As funções são iguais no melhor caso e a função 2 é melhor no pior caso!");

            if (melhor1 == melhor2 && pior1 < pior2)
                Console.WriteLine("As funções são iguais no melhor caso e a função 2 é pior no pior caso!");

            if (melhor1 > melhor2 && pior1 == pior2)
                Console.WriteLine("As funções são iguais no pior caso e a função 2 é melhor no melhor caso!");

            if (melhor1 < melhor2 && pior1 == pior2)
                Console.WriteLine("As funções são iguais no pior caso e a função 2 é pior no melhor caso!");
        }
    }
}
