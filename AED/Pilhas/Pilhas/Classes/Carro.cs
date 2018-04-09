using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas.Classes
{
    class Carro
    {
        private String placa;//Placa do carro
        private int manobras;//Número de manobras que ele teve enquanto esteve no estacionamento

        public Carro(String placa)//Cria um carro com a placa informada
        {
            this.placa = placa; ;//Atribui a placa
            manobras   = 0;//Atribui 0 manobras, afinal, ele acabou de chegar
        }

        public void manobra() { manobras++; }//Conta um manobra realizada

        public int getManobras() { return manobras; }//Retorna o número de manobras

        public override string ToString() { return this.placa; }//Retorna a placa do carro
    }
}
