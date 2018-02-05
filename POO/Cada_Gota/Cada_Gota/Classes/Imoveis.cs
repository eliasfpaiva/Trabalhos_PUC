using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cada_Gota.Classes
{
    class Imoveis
    {
        int id, idProprietario, numero;
        string endereco, bairro, complemento, cidade, estado, cep, pais, tipoImovel, tipoServico;

        public Imoveis(int id, int idProprietario, int numero, string endereco, string bairro, string complemento,
           string cidade, string estado, string cep, string pais, string timpoImovel, string tipoServico)
        {
            this.id             = id;
            this.idProprietario = idProprietario;
            this.numero         = numero;
            this.endereco       = endereco;
            this.bairro         = bairro;
            this.complemento    = complemento;
            this.cidade         = cidade;
            this.estado         = estado;
            this.cep            = cep;
            this.pais           = pais;
            this.tipoImovel     = timpoImovel;
            this.tipoServico    = tipoServico;
        }

        public override string ToString()
        {
            string dadosImovel = id + "|" + idProprietario + "|" + numero + "|" + endereco + "|" + bairro + "|" + complemento + "|" + cidade + "|" + estado + "|" +
                cep + "|" + pais + "|" + tipoImovel + "|" + tipoServico;

            return dadosImovel;
        }
    }
}
