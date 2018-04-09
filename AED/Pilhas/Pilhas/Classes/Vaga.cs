using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas.Classes
{
    class Vaga
    {
        /*
         * Essa classe só tem nome diferente, porque eu quis associar mais ao estacionamento, mas, é o mesmo que uma célula
         */ 
        private Carro carro;//Carro que está nesta vaga, seria o DADO dela
        private Vaga proxVaga;//Vaga que está logo à frente

        public Vaga(Carro carro, Vaga vaga)//Cria uma vaga com um carro e 'anota' qual é a próxima vaga depois dela
        {
            carro.manobra();//Pra colocar o carro na vaga já é uma manobra
            this.carro = carro;//Atribui o carro
            this.proxVaga = vaga;//Atribui a próxima vaga
        }
        
        public Carro getCarro() { return this.carro; }//Retorna o carro que está nesta vaga, eu não quis deixar com acesso direto, por isso o get

        public override string ToString() { return carro.ToString(); }//Pra uma vaga só é interessante mostraro carro que tem nela

        public Vaga getProxVaga() { return proxVaga; }//Retorna qual é a próxima vaga, eu não quis deixar com acesso direto, por isso o get
    }
}
