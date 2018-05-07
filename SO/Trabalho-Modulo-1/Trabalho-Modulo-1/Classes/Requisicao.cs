using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trabalho_Modulo_1.Classes
{
    //Classe que representa uma requisição feita ao servidor
    public class Requisicao
    {
        //Declaração de objeto monitor
        static object locker = new object();
        //Variável de classe que garante que cada Thread possui um a Requisição com ID único
        private static int contador = 0;
        //Número de identificação da Requisição
        private int id;
        //Flag que indica se a Thread que controla esta requisição está ativa ou não
        private bool ativa;

        //Construtor, que atribui o valor do ID e Seta a flag ativa como true, pois
        //No momento da criação da thread ela sem pre está ativa
        public Requisicao() {

            //Início de região passível de condição de corrida
            Monitor.Enter(locker);
            Requisicao.contador++;
            this.id = Requisicao.contador;
            //Início de região passível de condição de corrida
            Monitor.Exit(locker);

            this.ativa = true;
        }
        //Recupera o ID de uma requisição
        public int  GetID() { return id; }
        //Altera o valor da flag ativa
        public void SetAtiva(bool estado) { this.ativa = estado; }
        //Recupera o valor da Thread ativa
        public bool GetAtiva() { return ativa; }
    }
}
