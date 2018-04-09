using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas.Classes
{
    class Pilha
    {
        private Vaga vaga;//Vaga que contém o carro estacionado
        private int tamanho;//Tamanho da pilha até o momento
        private int limite;//Quantidade máxima de vagas que a pilha comporta

        public Pilha(int limite)//Construtor da pilha
        {
            this.vaga = null;//Define primeira vaga como nula para inicialização
            this.tamanho = 0;//Tamanho é 0, nenhum veículo foi estacionado ainda, acho que o cimento ainda deve estar fresco no chão kkkk
            this.limite = limite;//Recebe o tamanho máximo que esta pilha terá
        }
        public int getTamanho() { return this.tamanho; }//Retorna o tamnho da pilha no momento

        public bool vazia() { return getTamanho() == 0; }//Retorna se a pilha está vazia, true é sim e false é não

        public bool empilha(String placa)//Empilha usando uma placa apenas como parâmentro
        {
            return empilha(new Carro(placa));//Chama o método que empilha um carro
        }
        public bool empilha(Carro carro)//Empilha usando um carro como parâmentro
        {
            if (this.tamanho >= this.limite)//Testa se ainda é possível empilhar
                return false;//Retorna que o empilhamento falhou
            Vaga nova = new Vaga(carro, vaga);//Cria uma vaga para o carro que chegou e passa a vaga anterior como parâmentro para ligar a pilha
            vaga = nova;//Armazena a nova vaga
            tamanho++;//Incrementa o tamanho da pilha
            return true;//Retorna que o empilhamento foi um sucesso
        }

        public Carro desEmpilha()//Retira um carro da pilha e o retorna para quem chamou o método
        {
            if (vazia())//Testa se a pilha está vazia
                return null;//Se a pilha estiver vazia, não dá pra desempilhar, não é mesmo
            Carro carro = this.vaga.getCarro();//Guarda o carro desempilhado em uma variável
            carro.manobra();//Incrementa uma manobra neste carro
            vaga = vaga.getProxVaga();//Agora que esse carro saiu a próxima vaga é a ultima, aqui acontece a atribuição
            tamanho--;//Decrementa uma vaga na pilha
            return carro;//Retorna o carro retirado
        }

        public void imprime()//Imprime todas as vagas da pilha
        {
            Vaga temp = vaga;//Cria uma vaga temporária
            while (temp != null)//Enquanto tem vaga o loop continua
            {
                Console.WriteLine("Vaga: " + temp.ToString());//Imprime a vaga
                temp = temp.getProxVaga();//Pega a próxima vaga da pilha
            }
        }
    }
}
