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

        public void enfileirar(Pessoa pessoa)
        {
            Console.WriteLine("Pessoa entrou na fila de espera!");
            Celula nova = new Celula(pessoa, null);
            if (vazia()) { primeira = ultima = nova; }
            else
            {
                //Celula temp = primeira;
                //while (temp != null)
                //{
                //    if (temp.pessoa.idade <= nova.pessoa.idade)
                //    {
                //        Pessoa temporario = temp.pessoa;
                //        temp.pessoa = nova.pessoa;
                //        nova.pessoa = temporario;
                //    }
                //    temp = temp.prox;
                //}
                ultima.prox = nova;
                ultima = nova;
            }
            tamanho++;
        }

        public Pessoa desEnfileirar()
        {
            if (vazia()) { return null; }
            Pessoa aviao = primeira.pessoa;
            Console.WriteLine("Pessoa decolagem altorizada!");
            tamanho--;
            return aviao;
        }

        public void listarTodasPessoas()
        {
            Celula celula = primeira;
            while (celula != null)
            {
                Console.WriteLine(celula.pessoa.ToString());
                celula = celula.prox;
            }
        }

        public void mostrarPrimeiroAviao()
        {
            Console.WriteLine("O primeiro avião da fila é o de nome: " + primeira.pessoa.getNome()
                + " e número: " + primeira.pessoa.idade);
        }
    }
}
