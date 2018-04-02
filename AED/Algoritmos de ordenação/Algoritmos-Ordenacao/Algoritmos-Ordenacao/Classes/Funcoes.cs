using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        
        public static int[] criaVetorPeloArquivo(int tamanho)
        {
            int[] vet = new int[tamanho];
            string linha;
            string[] registro;
            int i = 0;

            FileStream arq = new FileStream("dados_airbnb.txt", FileMode.Open);
            StreamReader leitor = new StreamReader(arq);

            do
            {
                linha = leitor.ReadLine();
                if (linha != null && i != 0)
                {
                    registro = linha.Split('\t');
                    vet[i] = int.Parse(registro[0]);
                }
                i++;
            } while (linha != null && i < tamanho);

            leitor.Close();

            return vet;
        }

        public static void demontracao()
        {
            Console.Write("Digite o tamanho do vetor desejado: "); //Solicito o tamanho do vetor que eu desejo
            int tamanho = int.Parse(Console.ReadLine()) + 1; //Somo 1 ao tamanho informado, pois farei uso de sentinela

            int[] vet = Funcoes.criaVetor(tamanho); //Crio um vetor do tamanho solicitado + 1, com valores aleatórios entre 0 e 10 vezes o tamanho informado
            //Copio o vetor original para outros para garantir que cada um faça referência a um endereço de memória particular
            int[] vet1 = copiaVetor(vet);
            int[] vet2 = copiaVetor(vet);
            int[] vet3 = copiaVetor(vet);
            int[] vet4 = copiaVetor(vet);
            int[] vet5 = copiaVetor(vet);
            int[] vet6 = copiaVetor(vet);
            
            Console.WriteLine("\nVetor Original: ");
            imprimeVetor(vet); //Imprimo o vetor original para visualização

            Console.WriteLine("\n\nVetor 1 antes da ordenação por inserção: ");
            imprimeVetor(vet1);
            Console.WriteLine("\nVetor Ordenado por inserção: ");
            imprimeVetor(Algoritmos.insertSort(vet1));

            Console.WriteLine("\n\nVetor 2 antes da ordenação por seleção: ");
            imprimeVetor(vet2);
            Console.WriteLine("\nVetor Ordenado por seleção: ");
            imprimeVetor(Algoritmos.selectSort(vet2));

            Console.WriteLine("\n\nVetor 3 antes da ordenação por bolha: ");
            imprimeVetor(vet3);
            Console.WriteLine("\nVetor Ordenado por bolha: ");
            imprimeVetor(Algoritmos.bubbleSort(vet3));

            Console.WriteLine("\n\nVetor 4 antes da ordenação por merge: ");
            imprimeVetor(vet4);
            Console.WriteLine("\nVetor Ordenado por merge: ");
            imprimeVetor(Algoritmos.mergeSort(vet4));

            Console.WriteLine("\n\nVetor 5 antes da ordenação por quick: ");
            imprimeVetor(vet5);
            Console.WriteLine("\nVetor Ordenado por quick: ");
            imprimeVetor(Algoritmos.quickSort(vet5));

            Console.WriteLine("\n\nVetor 6 antes da ordenação por SelectBubbleSort: ");
            imprimeVetor(vet6);
            Console.WriteLine("\nVetor Ordenado por SelectBubbleSort: ");
            imprimeVetor(Algoritmos.bubbleSelectSort(vet6));
        }
    }
}
