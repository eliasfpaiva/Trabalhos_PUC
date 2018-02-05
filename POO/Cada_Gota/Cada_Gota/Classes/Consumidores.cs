using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cada_Gota.Classes
{
    class Consumidores
    {
        int id;
        string nome, cpf, identidade;

        public Consumidores(int id, string nome, string cpf, string identidade)
        {
            this.id         = id;
            this.nome       = nome;
            this.cpf        = cpf;
            this.identidade = identidade;
        }

        public override string ToString()
        {
            string dadosConsumidor = id + "|" + nome + "|" + cpf + "|" + identidade;

            return dadosConsumidor;
        }
    }
}
