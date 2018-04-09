using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filas.Classes;

namespace Filas.Classes
{
    public class Aviao
    {
        string nome;
        int numero, prioridade;

        public Aviao(string nome, int numero)
        {
            this.nome = nome;
            this.numero = numero;
            this.prioridade = 0;
        }

        public Aviao(string nome, int numero, int prioridade)
        {
            this.nome = nome;
            this.numero = numero;
            this.prioridade = prioridade;
        }

        public override string ToString()
        {
            return "Nome: " + nome + " Número: " + numero + " Prioridade: " + prioridade;
        }

        public string getNome() { return nome; }
        public int getNumero() { return numero; }
        public int getPrioridade() { return prioridade; }
    }
}
