using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Ordenacao.Classes
{
    class Funcoes
    {
        public static int[] criaVetor(int tamanho)
        //Cria um vetor com valores aleatórios a partir de um tamanho informado
        {
            Random random = new Random();
            int[] vet = new int[tamanho]; //Instância do vetor

            //Preenchimento do vetor
            for (int i = 1; i < tamanho; i++)
                vet[i] = random.Next(0, 10 * tamanho);

            //Retorna o vetor criado
            return vet;
        }

        public static void imprimeVetor(int[] vet)
        //Imprime um vetor passado por parâmetro
        {
            //Percorre o vetor imprimindo todos os seus elementos na tela
            for (int i = 1; i < vet.Length; i++)
                Console.Write(vet[i] + " | ");
        }

        public static int[] copiaVetor(int[] vet)
        //Copia um vetor em outro para criar referências diferentes na memória
        {
            int tamanho = vet.Length;
            int[] vet2 = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
                vet2[i] = vet[i];

            return vet2;
        }
    }
}
