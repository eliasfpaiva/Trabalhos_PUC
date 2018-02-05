using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Patos.Classes
{
    class Cla
    {
        private string Nome;
        private string Reputacao;

        public Cla() { }

        public Cla(string Nome, string Reputacao)
        {
            this.Nome = Nome;
            this.Reputacao = Reputacao;
        }

        public void SetNome(string Nome) { this.Nome = Nome; }
        public string GetNome() { return Nome; }
        public void SetReputacao(string Reputacao) { this.Reputacao = Reputacao; }
        public string GetReputacao() { return Reputacao; }

        public override string ToString()
        {
            //Console.WriteLine("Clã: " + Nome + "\nReputação: " + Reputacao + "\n");
            return "Clã: " + Nome + "\nReputação: " + Reputacao;
        }
    }
}
