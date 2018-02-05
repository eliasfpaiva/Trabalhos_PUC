using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Patos.Interfaces;

namespace Atividade_Patos.Classes
{
    class Duck
    {
        public Duck() { }

        private Cla cla;
        
        public virtual void Display() { Console.WriteLine("Eu sou um pato!"); }

        //Este métdo cria e atribui um Clã ao pato e imprime na tela qual foi
        public virtual void MostrarClan(string nome, string reputacao)
        {
            this.cla = new Cla(nome, reputacao);
            Console.WriteLine(this.cla.ToString());
        }
    }
}
