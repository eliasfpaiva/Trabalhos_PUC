using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filas.Classes;

namespace Filas.Classes
{
    class Fila
    {
        Celula primeira, ultima;
        int tamanho;

        public Fila()
        {
            primeira = null;
            ultima = null;
            tamanho = 0;
        }

        public bool vazia() { return tamanho == 0; }

        public int getTamanho() { return tamanho; }

        public void enfileirar(Aviao aviao)
        {
            Console.WriteLine("Avião " + aviao.ToString() + ", entrou na fila de espera!");
            Celula nova = new Celula(aviao, null);
            if (vazia()) { primeira = ultima = nova; }
            else
            {
                Celula temp = primeira;
                while (temp != null)
                {
                    if (temp.aviao.getPrioridade() <= nova.aviao.getPrioridade())
                    {
                        Aviao temporario = temp.aviao;
                        temp.aviao = nova.aviao;
                        nova.aviao = temporario;
                    }
                    temp = temp.prox;
                }
                ultima.prox = nova;
                ultima = nova;
            }
            tamanho++;
        }

        public Aviao desEnfileirar()
        {
            if (vazia()) { return null; }
            Aviao aviao = primeira.aviao;
            Console.WriteLine("Avião " + aviao.ToString() + ", decolagem altorizada!");
            tamanho--;
            return aviao;
        }

        public void listarTodosAvioes()
        {
            Celula celula = primeira;
            while (celula != null)
            {
                Console.WriteLine(celula.aviao.ToString());
                celula = celula.prox;
            }
        }

        public void mostrarPrimeiroAviao()
        {
            Console.WriteLine("O primeiro avião da fila é o de nome: " + primeira.aviao.getNome()
                + " e número: " + primeira.aviao.getNumero());
        }
    }
}
