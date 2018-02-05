using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cada_Gota.Classes
{
    class Contas
    {
        int id, idConsumidor, idImovel, ano, leituraInicial, leituraFinal, consumo;
        string mes;
        double valor, valorComImposto;

        public Contas(int id, int idConsumidor, int idImovel, string mes, int ano, int lileituraInicial, int leituraFinal, double valor, double valorComImposto)
        {
            this.id              = id;
            this.idConsumidor    = idConsumidor;
            this.idImovel        = idImovel;
            this.mes             = mes;
            this.ano             = ano;
            this.leituraInicial  = lileituraInicial;
            this.leituraFinal    = leituraFinal;
            this.consumo         = leituraFinal - leituraInicial;
            this.valor           = valor;
            this.valorComImposto = valorComImposto;
        }

        public override string ToString()
        {

            string registro = id + "|" + idConsumidor + "|" + idImovel + "|" + mes + "|" + ano + "|" + leituraInicial + "|" + leituraFinal + "|" + consumo + "|" + valor + "|" + valorComImposto;

            return registro;
        }

    }
}
