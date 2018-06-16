using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11___Árvore_Binária_e_Tabela_Hash.Classes
{
    class Contato
    {
        public int codigo;
        public string nome;
        public DateTime dataNascimento;
        public string telefone;
        public string email;

        public Contato()
        {
        }

        public Contato(int codigo)
        {
            this.codigo = codigo;
        }

        public Contato(int codigo, string nome, DateTime dataNascimento, string telefone, string email)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.telefone = telefone;
            this.email = email;
        }

        public override string ToString()
        {
            return "CONTATO [Código: " + codigo + " Nome: " + nome + " Data de Nascimento: " + dataNascimento + " Telefone: " + telefone + " E-mail: " + email + "]";
        }

        public override bool Equals(object obj)
        {
            Contato outro = (Contato)obj;
            return this.codigo==outro.codigo;
        }
    }
}
