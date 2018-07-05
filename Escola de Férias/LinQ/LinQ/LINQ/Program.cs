using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ                                          // Exemplos de Seleções via LINQ - Introdução
{
    class Produtos                                      // Duas Classes para exemplo do JOIN
    {
        public string CódProduto { get; set; }
        public string Categoria { get; set; }
        public string NomeProduto { get; set; }
        public float PreçoUnit { get; set; }
    }

    class Categorias
    {
        public string CódCategoria { get; set; }
        public string DescCategoria { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis e Estruturas de Trabalho
            int[] VetorIntA = { 98, 45, 67, 23, 18, 90, 58, 30, 26, 72 };
            int[] VetorIntB = { 35, 48, 97, 65, 17, 49, 93, 50, 32, 71 };

            string[] VetorStringA = { "FiAT", "CheVROleT", "ToYOTa", "MitSUBiShI", "VoLKSwAgEN" };
            string[] VetorStringB = { "Banana", "Abacate", "Melancia", "Amora", "Caju", "Abacaxi", "Maça" };

            // Mostrando os Dados de um Vetor da Forma Tradicional 
            Console.WriteLine("Conteúdo do Vetor (10 Elementos): \n");
            foreach (int x in VetorIntA)
            {
                Console.Write(x + "   ");
            }
            Console.ReadKey();

            Console.Clear();

            // Exemplos - Diversos
            // ======================================================================================================================================

            var Consulta = from Valor in VetorIntA                  // Seleção Simples
                           select Valor;

            // O LINQ retorna um IEnumerable
            //
            // var será substituído por um IEnumerable<int>, que permite a interação via um foreach, por exemplo...
            // Declarar "IEnumerable<int> Consulta" é o mesmo que "var Consulta"

            Console.WriteLine("Conteúdo do Vetor (10 Elementos) - Via LINQ: \n");
            foreach (int x in Consulta)
            {
                Console.Write(x + "   ");
            }
            Console.ReadKey();

            Console.Clear();

            // ======================================================================================================================================

            var Filtro = from Valor in VetorIntA                    // Ordenação e Filtragem
                         where Valor >= 50
                         orderby Valor
                         select Valor;

            Console.WriteLine("Conteúdo do Vetor (Elementos >= 50) - Ordenado: \n");
            foreach (int x in Filtro)
            {
                Console.Write(x + "   ");
            }
            Console.ReadKey();

            Console.Clear();

            // ======================================================================================================================================

            int QtdeFiltro = (from Valor in VetorIntA               // Expressão com Função Agregada (Count, Max, Min...) - Métodos de Extensão
                              where Valor >= 50
                              select Valor).Count();                // Poderia tirar o Count daqui e colocar depois: QtdeFiltro.Count()

            Console.WriteLine("Quantidade de Elementos no Vetor - Filtro >= 50: {0}\n", QtdeFiltro);

            Console.ReadKey();

            Console.Clear();

            // ======================================================================================================================================

            var Compara = from Valor1 in VetorIntA                  // Consulta conjunta a duas estruturas
                          from Valor2 in VetorIntB
                          where Valor1 <= Valor2                    // Filtro
                          select new { Valor1, Valor2 };            // Seleção de dois valores quando o filtro for atendido
                                                                    // new: Tipo Anônimo - Valor1 e Valor2: Objetos Inicializados

            Console.WriteLine("Comparação de Elementos dos Vetores: \n");           
            foreach (var x in Compara)
            {
                Console.WriteLine(x.Valor1 + " é menor que " + x.Valor2);       // Lista todas as ocorrêcias...
            }
            Console.ReadKey();

            Console.Clear();

            // ======================================================================================================================================

            var Palavras = from Valor in VetorStringA
                           select new { Maiúsculas = Valor.ToUpper(), Minúsculas = Valor.ToLower() };      // Duas Palavras - Maiúsculas e Minúsculas 

            Console.WriteLine("Conteúdo do Vetor de Palavras - Transformação\n");
            foreach (var x in Palavras)
            {
                Console.WriteLine(x.Maiúsculas + "/" + x.Minúsculas);
            }
            Console.ReadKey();

            Console.Clear();

            // ======================================================================================================================================

            var FrutasLetraA = from Frutas in VetorStringB          // Agrupamentos com a Primeira Letra da Palavra    
                               orderby Frutas
                               group Frutas by Frutas[0];
                              
            foreach (var GrupoFruta in FrutasLetraA)                // Para cada Grupo
            {
                Console.WriteLine("\nFrutas que começam com a Letra '{0}': ", GrupoFruta.Key);        // Mostra a Chave
                foreach (var x in GrupoFruta)                       // Para cada Fruta dentro daquele grupo formado...
                {
                    Console.WriteLine("  - " + x);                  // Lista
                }
            }
            Console.ReadKey();

            Console.Clear();

            // ======================================================================================================================================

            List<Categorias> ListaCategorias = new List<Categorias>();           // Lista de Categorias de Produtos

            Categorias xCategoria;

            xCategoria = new Categorias();                  // Criação do Objeto
            xCategoria.CódCategoria = "123";                // Dados de Exemplo
            xCategoria.DescCategoria = "Limpeza";
            ListaCategorias.Add(xCategoria);

            xCategoria = new Categorias();                           
            xCategoria.CódCategoria = "456";
            xCategoria.DescCategoria = "Padaria";
            ListaCategorias.Add(xCategoria);

            xCategoria = new Categorias();
            xCategoria.CódCategoria = "789";
            xCategoria.DescCategoria = "Bebidas";
            ListaCategorias.Add(xCategoria);

            List<Produtos> ListaProdutos = new List<Produtos>();

            Produtos xProduto;

            xProduto = new Produtos();                      // Criação do Objeto
            xProduto.CódProduto = "P1";                     // Dados de Exemplo
            xProduto.Categoria = "456";
            xProduto.NomeProduto = "Ciabata Recheada";
            xProduto.PreçoUnit = 8.90F;
            ListaProdutos.Add(xProduto);

            xProduto = new Produtos();                                          
            xProduto.CódProduto = "P2";                                         
            xProduto.Categoria = "123";
            xProduto.NomeProduto = "Sabão em Pó OMO";
            xProduto.PreçoUnit = 13.50F;
            ListaProdutos.Add(xProduto);

            xProduto = new Produtos();
            xProduto.CódProduto = "P3";
            xProduto.Categoria = "456";
            xProduto.NomeProduto = "Pão de Queijo";
            xProduto.PreçoUnit = 3.20F;
            ListaProdutos.Add(xProduto);
            
            xProduto = new Produtos();
            xProduto.CódProduto = "P4";
            xProduto.Categoria = "789";
            xProduto.NomeProduto = "Vodka Absolut";
            xProduto.PreçoUnit = 89.90F;
            ListaProdutos.Add(xProduto);

            xProduto = new Produtos();
            xProduto.CódProduto = "P5";
            xProduto.Categoria = "123";
            xProduto.NomeProduto = "Veja Multiuso";
            xProduto.PreçoUnit = 8.20F;
            ListaProdutos.Add(xProduto);

            xProduto = new Produtos();
            xProduto.CódProduto = "P6";
            xProduto.Categoria = "789";
            xProduto.NomeProduto = "Cachaça Salinas";
            xProduto.PreçoUnit = 37.20F;
            ListaProdutos.Add(xProduto);

            xProduto = new Produtos();
            xProduto.CódProduto = "P7";
            xProduto.Categoria = "789";
            xProduto.NomeProduto = "Chivas Regal 18";
            xProduto.PreçoUnit = 122.80F;
            ListaProdutos.Add(xProduto);

            Console.WriteLine("Lista de Categorias:\n ");   

            foreach (var x in ListaCategorias)               // Lista de Categorias
            {
                Console.WriteLine("{0} - {1}", x.CódCategoria, x.DescCategoria);   
            }
            Console.ReadKey();

            Console.Write("\n\n");

            Console.WriteLine("Lista de Produtos:\n ");

            foreach (var x in ListaProdutos)               // Lista de Produtos
            {
                Console.WriteLine("{0} (Categoria {1}) - {2} \t\tR$ {3,6:F2}", x.CódProduto, x.Categoria, x.NomeProduto, x.PreçoUnit);
            }
            Console.ReadKey();

            Console.Clear();

            var ProdCateg = from Cat in ListaCategorias
                            join Prod in ListaProdutos on Cat.CódCategoria equals Prod.Categoria
                            orderby Prod.NomeProduto
                            select new { NomeProduto = Prod.NomeProduto, NomeCateg = Cat.DescCategoria, PreçoProduto = Prod.PreçoUnit };

            Console.WriteLine("Lista de Produtos e Categorias:\n ");

            foreach (var x in ProdCateg)               
            {
                Console.WriteLine("{0} ({1}) \t\tR$ {2,6:F2}", x.NomeProduto, x.NomeCateg, x.PreçoProduto);
            }
            Console.ReadKey();

            Console.Clear();

            var GrupoProdutos = from P in ProdCateg                                 // Uma derivação da consulta anterior...
                                group P by P.NomeCateg into G
                                select new {Cat=G.Key, Prod=G};

            Console.WriteLine("Lista de Produtos e Categorias - Agrupado:\n ");

            foreach (var Grupo in GrupoProdutos)
            {
                Console.WriteLine("\nCategoria {0}",Grupo.Cat);

                foreach(var GrupoProd in Grupo.Prod)
                {
                    Console.WriteLine("   => {0} - R$ {1,6:F2}", GrupoProd.NomeProduto, GrupoProd.PreçoProduto);
                }
            }
            Console.ReadKey();
        


        }
    }
}


