using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas.Classes
{
    class Pilha
    {
        private Celula vaga;
        private int tamanho;
        private int limite;

        public Pilha(int limite)
        {
            this.vaga = null;
            this.tamanho = 0;
            this.limite = limite;
        }
        public int getTamanho() { return this.tamanho; }
        public bool vazia() { return getTamanho() == 0; }
        public void empilha(String placa)
        {
            vaga = new Celula(new Carro(placa), vaga);
            Console.WriteLine("Entrou carro: " + vaga.ToString());
        }
        public void imprime()
        {
            Celula temp = vaga;
            while (temp != null)
            {
                Console.WriteLine("Vaga: " + temp.ToString());
                temp = temp.GetProxCelula();
            }
        }
    }
}
