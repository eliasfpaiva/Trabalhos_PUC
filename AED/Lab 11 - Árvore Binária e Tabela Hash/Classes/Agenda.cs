using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11___Árvore_Binária_e_Tabela_Hash.Classes
{
    class Agenda
    {
        TabelaHash tabelaContatos;

        public Agenda(TabelaHash tabelaContatos)
        {
            tabelaContatos = new TabelaHash(13);
        }
    }
}
