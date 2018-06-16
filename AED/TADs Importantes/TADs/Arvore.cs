using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADs_Importantes.TADs
{
    class Arvore
    {
        public CelulaTripla Raiz { get; set; }
        public int tamanho { get; set; }
        public Arvore()
        {
            Raiz = null;
            tamanho = 0;
        }

        public bool Vazia()
        {
            return Raiz == null;
        }


        public bool Insere(int dado)
        {
            CelulaTripla novo = new CelulaTripla();
            novo.dado = dado;
            novo.filhoEsquerdo = null;
            novo.filhoDireito = null;
            novo.pai = null;

            if (Raiz == null)
            {
                Raiz = novo;
                tamanho++;
                return true;
            }
            else
            {
                CelulaTripla temp = Raiz;
                while (temp != null)
                {
                    if (dado == temp.dado)
                        return false;

                    if (dado < temp.dado)
                    {
                        if (temp.filhoEsquerdo == null)
                        {
                            temp.filhoEsquerdo = novo;
                            novo.pai = temp;
                            tamanho++;
                            return true;
                        }
                        else
                            temp = temp.filhoEsquerdo;
                    }
                    else
                    {
                        if (temp.filhoDireito == null)
                        {
                            temp.filhoDireito = novo;
                            novo.pai = temp;
                            tamanho++;
                            return true;
                        }
                        else
                            temp = temp.filhoDireito;
                    }
                }
            }
            return false;
        }

        public void ImprimirEmOrdem(CelulaTripla no)
        {
            if (no != null)
            {
                Console.Write(no.dado + " ");
                ImprimirEmOrdem(no.filhoEsquerdo);
                ImprimirEmOrdem(no.filhoDireito);
            }
        }


        public void ImprimirPreOrdem(CelulaTripla no)
        {
            if (no != null)
            {
                ImprimirPreOrdem(no.filhoEsquerdo);
                Console.Write(no.dado + " ");
                ImprimirPreOrdem(no.filhoDireito);
            }
        }

        public int Pesquisa(int chave, ref int cont)
        {
            CelulaTripla temp = Raiz;
            cont = 0;

            while (temp != null)
            {
                cont++;
                if (chave == temp.dado)
                    return temp.dado;

                if (chave < temp.dado)
                    temp = temp.filhoEsquerdo;
                else
                    temp = temp.filhoDireito;
            }
            return -1;
        }

        public int Pesquisa(CelulaTripla no, int chave)
        {
            if (no == null)
                return -1;

            if (chave == no.dado)
                return no.dado;

            if (chave < no.dado)
                return Pesquisa(no.filhoEsquerdo, chave);
            else
                return Pesquisa(no.filhoDireito, chave);
        }

        public int Altura(CelulaTripla no)
        {
            if (no == null)
                return 0;

            return 1 + Math.Max(Altura(no.filhoEsquerdo), Altura(no.filhoDireito));
        }

        private int Antecessor(CelulaTripla no)
        {
            if (no.filhoDireito == null)
                return no.dado;

            return Antecessor(no.filhoDireito);
        }

        public int maior()
        {
            CelulaTripla temp = Raiz;
            while (temp.filhoDireito != null)
            {
                temp = temp.filhoDireito;
            }
            return temp.dado;
        }

        public void imprimeDecrescente()
        {
            if (Raiz == null)
                Console.WriteLine("Esta árvore não possui elementos");
            else
                impressor(Raiz);
        }
        private void impressor(CelulaTripla no)
        {
            if (no != null)
            {
                impressor(no.filhoDireito);
                Console.WriteLine(no.dado);
                impressor(no.filhoEsquerdo);
            }
        }


        public bool Remover(int chave)
        {
            CelulaTripla no = Raiz;

            while (no != null)
            {
                if (chave == no.dado)
                    break;

                if (chave < no.dado)
                    no = no.filhoEsquerdo;
                else
                    no = no.filhoDireito;
            }

            if (no == null)
                return false;
            else
            {
                if (no.filhoEsquerdo == null && no.filhoDireito == null)
                {
                    CelulaTripla pai = no.pai;

                    if (pai == null)
                        Raiz = null;
                    else
                        if (chave < pai.dado)
                        pai.filhoEsquerdo = null;
                    else
                        pai.filhoDireito = null;
                }
                else if (no.filhoEsquerdo == null || no.filhoDireito == null)
                {
                    CelulaTripla pai = no.pai;

                    if (no.filhoEsquerdo != null)
                    {
                        if (pai == null)
                        {
                            Raiz = no.filhoEsquerdo;
                            no.pai = null;
                        }
                        else
                        if (chave < pai.dado)
                        {
                            pai.filhoEsquerdo = no.filhoEsquerdo;
                            no.filhoEsquerdo.pai = pai;
                        }
                        else
                        {
                            pai.filhoDireito = no.filhoEsquerdo;
                            no.filhoEsquerdo.pai = pai;
                        }
                    }
                    else
                    {
                        if (pai == null)
                        {
                            Raiz = no.filhoDireito;
                            no.pai = null;
                        }
                        else
                        if (chave < pai.dado)
                        {
                            pai.filhoEsquerdo = no.filhoDireito;
                            no.filhoDireito.pai = pai;
                        }
                        else
                        {
                            pai.filhoDireito = no.filhoDireito;
                            no.filhoDireito.pai = pai;
                        }
                    }
                }
                else
                {
                    //int Ant = Antecessor(no.filhoEsquerdo);
                    //Remover(Ant);

                    //no.filhoEsquerdo = Ant;
                }
                return true;
            }
        }
    }
}
