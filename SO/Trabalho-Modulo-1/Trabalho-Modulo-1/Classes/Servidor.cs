using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Trabalho_Modulo_1.Classes
{
    //Classe que simula o servidor conforme solicitado
    public static class Servidor
    {
        //Variável que recebe o que o usuário deseja ver no console
        public static string acaoConsole;
        
        //Declaração dos contadores necessários para contabilizar as informações solicitadas
        public static int threadsIniciadas = 0, threadsConcluidas = 0, threadsAtendidas = 0, threadsNegadas = 0;

        //Declaração de um vetor de Requisições com capacidade para 15 Requisições
        //Cada Requisição é mantida por uma Thread ativa
        //Quando a Thread conclui seu processamento sinaliza que a Requisição pode ser substituida
        static Requisicao[] pool = new Requisicao[15];
        
        //Decalaração de variável randómica utilizada para sortear a duração do processamento de uma Thread
        public static Random random = new Random();

        //Declaração de objeto monitor
        static object locker = new object();
        
        //Método que recebe a chamadas vindas do for da classe Program e instancia novas Threads
        public static void NovaRequisicao()
        {
            //Declaração da instância de uma nova Thread com o método GestorDeRequisicoes
            Thread thread = new Thread(GestorDeRequisicoes);
            //Dando início à execução da Thread instanciada
            thread.Start();
        }

        //Método responsável por verificar que há, no pool (Vetor de requisições)
        public static void GestorDeRequisicoes()
        {
            //Variável que indica se a Thread em questão já foi atendida ou não
            bool threadAtendida = false;

            //Laço de repetição que percorre o pool buscando espaços vazios ou threads que não estejam mais ativas
            for (int i = 0; i < 15; i++)
            {
                //Estrutura condicional que testa se a posição do vetor esta vazia ou se contem uma Thread que não esteja ativa
                if ((pool[i] == null) || (!pool[i].GetAtiva()))
                {
                    //Encontrando uma posição que atenda as condições esta flag recebe valor veradeiro para indicar que o for pode 
                    //Interromper sua buscar
                    threadAtendida = true;

                    //Início de região passível de condição de corrida
                    Monitor.Enter(locker);
                    //Incrementado o contador de Threads ativas
                    threadsIniciadas++;
                    //Fim de região passível de condição de corrida
                    Monitor.Exit(locker);

                    //Sorteada a duração desta Thread entre 3 e 7 segundos, o método recebe valores mínimo e máximo em milisegundos
                    //Utilizamos 7001 para o máximo pois o rando utiliza o valor mínimo incluso e o máximo excluso 
                    //Caso usássemos 7000 o valor máximo possível seria 6999 milisegundos
                    int duracao = random.Next(3000, 7001);
                    
                    //O pool armazena na posição selecionada uma requisição
                    pool[i] = new Requisicao();

                    //Chamada de método que anota os dados desta Requisição no arquivo de dados conforme solicitado
                    EscreveArquivo("T" + pool[i].GetID() + ",iniciando," + threadsIniciadas + "," + Decimal.Round(duracao / 1000));
                    //Para simular o tempo de CPU conforme solicitado a execução desta Thread é paralizada pela duração sorteada
                    Thread.Sleep(duracao);
                    //Chamada de método que anota os dados desta Requisição no arquivo de dados conforme solicitado
                    EscreveArquivo("T" + pool[i].GetID() + ",concluindo," + threadsConcluidas + "," + Decimal.Round(duracao/1000));

                    //Início de região passível de condição de corrida
                    Monitor.Enter(locker);
                    //Incrementado o contador de Threads Concluidas
                    threadsConcluidas++;
                    threadsAtendidas++;
                    //Fim de região passível de condição de corrida
                    Monitor.Exit(locker);

                    //Esta Requisição é marcada como inativa deixando disponível sua posição para alocação de uma nova Thread
                    pool[i].SetAtiva(false);
                    //Para a repetição do laço, tendo em vista que a posição solicitada foi encontrada
                    break;
                }
            }
            //Condicional que testa se após o laço de repetição a Thread foi atendida ou não
            //Caso não tenha sido atendida entra na extrutura
            if (!threadAtendida)
            {
                //Início de região passível de condição de corrida
                Monitor.Enter(locker);
                //Incrementado o contador de Threads negadas
                threadsNegadas++;
                //Fim de região passível de condição de corrida
                Monitor.Exit(locker);
                //Chamada de método que anota que a Thread foi negada
                EscreveArquivo("negada");
            }
        }

        //Método que imprime o estado do pool de Threads
        public static void ImprimeVetor(Requisicao[] vet)
        {
            //Laço de repetição que percorre o vetor e imprime seus o estado dos seus elementos
            for (int i = 0; i < vet.Length; i++)
            {
                //Condicional que verifica se a posição é nula
                if (vet[i] == null)
                    //Caso a posição seja nula imprimi null
                    Console.Write("null | ");
                else
                    //Caso tenha uma Requisição armazenada, imprime se estado
                    Console.Write(vet[i].GetID() + ": " + vet[i].GetAtiva() + " | ");
            }
            //Quebra de linha
            Console.WriteLine();
        }

        //Método que recebe a informação e anota no arquivo de saida e no Console
        public static void EscreveArquivo(string registro)
        {
            //Início de região passível de condição de corrida
            Monitor.Enter(locker);
            //Criação do Stream para o arquivo de saida
            FileStream fileStream = new FileStream("out.txt", FileMode.Append);
            //Criação do Writer para o arquivo de saida
            StreamWriter streamWriter = new StreamWriter(fileStream);

            //Anotação da informação recebida na string registro no arquivo de saida
            streamWriter.WriteLine(registro);

            //Condicional que verifica se o usuário selecionou visualizar os dados que estão sendo gravados no arquivo
            //Ou se deseja ver o estado do vetor pool
            if (acaoConsole == "1")
                //Apresenta no console os dados que estão sendo gravados no arquivo
                Console.WriteLine(registro);
            else
                //Apresenta no console o estado do vetor pool
                ImprimeVetor(pool);

            //Encerra a execução do Writer
            streamWriter.Close();
            //Encerra a execução do Stream
            fileStream.Close();
            //Fim de região passível de condição de corrida
            Monitor.Exit(locker);
        }
    }
}
