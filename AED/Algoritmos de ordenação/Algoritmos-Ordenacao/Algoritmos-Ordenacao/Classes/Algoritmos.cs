using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Ordenacao.Classes
{
    public static class Algoritmos
    {
        /*
         * Principal fonte para os códigos
         * Slides utiizados em aula pelo professor
         */ 
        public static int[] insertSort(int[] vet)
        {
            int i, j, x, tamanho=vet.Length;

            //Percorre o vetor a partir da segunda posição até a útima
            for (i=2; i < tamanho; i++)
            {
                //x recebe o valor que está sendo comparado
                x = vet[i];
                //j recebe o valor que indica a posição imediatamente à esquerda do valor que está sendo comparado
                j = i - 1;
                //Sentinela, indica fim do vetor, pois tem valor igual ao do item que está sendo comparado
                vet[0] = x;
                //Ao fazer esta comparação este laço percore o vetor até chegar ao sentinela, procurando a posição que o valor comparado deve ficar
                while (x < vet[j])
                {
                    //Toda vez que o valor for de vet[j] for maior que x ele deve ser delocado para a direita deixando espaço livre até chegar á posição em que x deve ficar
                    vet[j + 1] = vet[j];
                    //É decrementado para percorrer o vetor da direita para a esquerda
                    j--;
                }
                //Faz a atribuição do valor de x à posição em que deve ficar
                vet[j + 1] = x;
            }
            //Retorna o vetor ordenado
            return vet;
        }

        public static int[] selectSort(int[] vet)
        {
            int i, j, min, temp, tamanho = vet.Length;

            //Percorre todo o vetor a partir da posição de partida
            for (i = 1; i < tamanho; i++)
            {
                //Atribuição do indice da posição de partida para as comparações
                min = i;
                //Percorre todo o vetor a partir da posição imediatamente à direita da posição de partida, em busca de valores menores
                for (j = i + 1; j < tamanho; j++)
                {
                    //Caso seja encontrado um valor menor do que o que estava na posição min, min recebe o valor do índice da posição que o contém
                    if (vet[j] < vet[min])
                        min = j;
                }
                //Finalmente é realizada a troca, onde a variável temporária, recebe o menor valor encontrado na busca, que é o que está na posição de índice min
                temp = vet[min];
                //A posição que continha o menor valor recebe o valor da posição de partida
                vet[min] = vet[i];
                //A posição de partida recebe o menor valor encontrado, que estava armazenado na variavel temporária
                vet[i] = temp;
            }
            //Retorna o vetor ordenado
            return vet;
        }

        public static int[] bubbleSort(int[] vet)
        {
            int tamanho = vet.Length;

            //Percorre todo o vetor a partir da posição de partida
            for (int i = 1; i < tamanho - 1; i++)
            {
                //Percorre todo o vetor a partir da posição de partida, comparando elementos vizinhos 2 a 2
                for (int j = 1; j < tamanho - 1; j++)
                {
                    //Caso seja encontrado um par em que o valor da direita seja menor que o da esquerda, estes dois são trocados de lugar
                    //Fazendo essa troca por todo o vetor, o elemento de maior vai sendo "borbulhado para o fim do vetor"
                    if (vet[j] > vet[j+1])
                    {
                        int temp = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = temp;
                    }
                }
            }
            //Retorna o vetor ordenado
            return vet;
        }

        public static int[] mergeSort(int[] vet)
        {
            //Para possibilitar a chamada do algorítmo usando apenas o vetor
            //Preferí implementar desta forma, com este "Chamador" antes
            vet = merger(vet, 1, vet.Length - 1);
            return vet;
        }

        public static int[] merger(int[] vet, int inicio, int fim)
        {
            //Aqui acontece o MergeSort propriamente dito.
            if (inicio > fim)
            {
                int meio = (inicio + fim) / 2;
                merger(vet, inicio, meio);
                merger(vet, meio + 1, fim);
                merge(vet, inicio, meio, fim);
            }
            return vet;
        }

        public static void merge(int[] vet, int inicio, int  meio, int fim)
        {

        }
    }
}
