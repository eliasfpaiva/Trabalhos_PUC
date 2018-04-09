using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas.Classes
{
    class Estacionamento
    {
        private Pilha vagas;//Pilha que representa o estacionamento

        public Estacionamento() { this.vagas = new Pilha(10); }//Constroe um estacionamento do tamanho 10 por padrão caso não seja informado

        public Estacionamento(int tamanho) { this.vagas = new Pilha(tamanho); }//Constroe um estacionamento do tamanho informado

        public void estaciona(String placa)//Insere um carro no estacionamento
        {
            if (vagas.empilha(placa))//Verifica se foi possivel estacionar
                Console.WriteLine("Carro de placa: " + placa + " estacionado!");//Informa o sucesso no estacionamento do carro
            else
                Console.WriteLine("Estacionamento lotado!");//Informa que não foi possivel estacionar, por não haver vagas
        }

        public void desEstaciona(String placa)//Retira um carro do estacionamento
        {
            if (vagas.getTamanho() != 0)//Verifica se tem algum carro no estacionamento
            {
                Pilha aux = new Pilha(vagas.getTamanho());//Cria uma pilha auxiliar para receber os carros que precisam ser manobrados para as retiradas
                Carro carroRetirado;//Recebe cada carro retirado
                bool achou = false;//Flag que indica se o carro solicitado foi encontrado
                while (!achou)//Enquanto tiver carro no estacionamento e não achar o solicitado retira mais um carro
                {
                    carroRetirado = vagas.desEmpilha();//Atribuição de cada carro retirado
                    if (carroRetirado == null)//Caso seja nulo o estacionamento já está vazio, o carro solicitado não está aqui
                    {
                        Console.WriteLine("Não exite carro com placa " + placa + " neste estacionamento!");//Informa que não foi encontrado
                        break;//Para o laço
                    }
                    if (carroRetirado.ToString() == placa)//Verifica se o carro retirado é o desejado
                    {
                        achou = true;//Informa que sim, é o carro desejado
                        Console.WriteLine("Carro de placa " + placa + " retirado!\nEle passou por "
                            + carroRetirado.getManobras() + " manobras enquanto esteve estacionado");//Informa a situação do carro ao usuário
                    }
                    else
                        aux.empilha(carroRetirado);//Se ainda tem carro no estacionamento, mas, ainda não achamos o desejado, o que foi retirado
                                                    //Aguarda fora até terminar a busca e fica na pilha auxiliar
                }
                while (!aux.vazia())//Depois de concluida a busca, enquanto a pilha auxiliar não estiver vazia esse laço é executado
                    vagas.empilha(aux.desEmpilha());//Retira cada carro da pilha auxiliar e coloca de volta no estacionamento
            }
            else { Console.WriteLine("Estacionamento vazio!"); }//Se não tiver nenhum carro no estacionamento informa ao usuário
            
        }

        public void tiraTudo()//Retira todos os carros do estacionamento de uma vez
        {
            for (int i = 0; i < vagas.getTamanho(); i++)//Percorre toda o estacionamento
            {
                Carro carro = vagas.desEmpilha();//Retira um carro da pilha
                Console.WriteLine("Carro de placa " + carro.ToString() + " retirado!\nEle passou por "
                            + carro.getManobras() + " manobras enquanto esteve estacionado");//Informa a situação do carro ao usuário
            }
                
        }

        public void listarCarros() { vagas.imprime(); }//Exibe todos os carros estacionados
    }
}
