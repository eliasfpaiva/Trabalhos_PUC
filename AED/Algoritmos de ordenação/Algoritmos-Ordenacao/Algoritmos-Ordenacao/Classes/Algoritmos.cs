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
