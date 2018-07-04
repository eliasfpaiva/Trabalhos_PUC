using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Ex2
{
    class Produtos
    {
        public string CodProduto { get; set; }
        public string Categoria { get; set; }
        public string NomeProduto { get; set; }
        public double PrecoUnit { get; set; }
    }

    class Categorias
    {
        public string CodCategoria { get; set; }
        public string DescCategoria { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Categorias> ListaCateg = new List<Categorias>();

            Categorias minhaCategoria;

            minhaCategoria = new Categorias();
            minhaCategoria.CodCategoria = "123";
            minhaCategoria.DescCategoria = "Limpeza";
            ListaCateg.Add(minhaCategoria);

            minhaCategoria = new Categorias();
            minhaCategoria.CodCategoria = "456";
            minhaCategoria.DescCategoria = "Padaria";
            ListaCateg.Add(minhaCategoria);

            minhaCategoria = new Categorias();
            minhaCategoria.CodCategoria = "789";
            minhaCategoria.DescCategoria = "Bebidas";
            ListaCateg.Add(minhaCategoria);

            List<Produtos> ListaProd = new List<Produtos>();
            Produtos MeuProduto;

            MeuProduto = new Produtos();
            MeuProduto.CodProduto = "P1";
            MeuProduto.Categoria = "456";
            MeuProduto.NomeProduto = "Ciabata Recheada";
            MeuProduto.PrecoUnit = 14.80;
            ListaProd.Add(MeuProduto);

            MeuProduto = new Produtos();
            MeuProduto.CodProduto = "P2";
            MeuProduto.Categoria = "123";
            MeuProduto.NomeProduto = "Sabão em Pó OMO";
            MeuProduto.PrecoUnit = 17.90;
            ListaProd.Add(MeuProduto);

            MeuProduto = new Produtos();
            MeuProduto.CodProduto = "P3";
            MeuProduto.Categoria = "456";
            MeuProduto.NomeProduto = "Pão de Queijo";
            MeuProduto.PrecoUnit = 3.20;
            ListaProd.Add(MeuProduto);

            MeuProduto = new Produtos();
            MeuProduto.CodProduto = "P4";
            MeuProduto.Categoria = "789";
            MeuProduto.NomeProduto = "Vodka Absolut";
            MeuProduto.PrecoUnit = 98.50;
            ListaProd.Add(MeuProduto);

            MeuProduto = new Produtos();
            MeuProduto.CodProduto = "P5";
            MeuProduto.Categoria = "123";
            MeuProduto.NomeProduto = "Veja Multiuso";
            MeuProduto.PrecoUnit = 6.20;
            ListaProd.Add(MeuProduto);

            MeuProduto = new Produtos();
            MeuProduto.CodProduto = "P6";
            MeuProduto.Categoria = "789";
            MeuProduto.NomeProduto = "Cachaça Salinas";
            MeuProduto.PrecoUnit = 37.20;
            ListaProd.Add(MeuProduto);

            MeuProduto = new Produtos();
            MeuProduto.CodProduto = "P7";
            MeuProduto.Categoria = "789";
            MeuProduto.NomeProduto = "Chivas Reagal 18";
            MeuProduto.PrecoUnit = 255.90;
            ListaProd.Add(MeuProduto);

            //var Consulta = from Cat in ListaCateg
            //               join Prod in ListaProd
            //               on Cat.CodCategoria equals Prod.Categoria
            //               orderby Prod.NomeProduto
            //               select new
            //               {
            //                   NomeProd = Prod.NomeProduto,
            //                   NomeCat = Cat.DescCategoria,
            //                   PrecoUnit = Prod.PrecoUnit
            //               };

            //foreach (var x in Consulta)
            //{
            //    Console.WriteLine("{0} ({1}) - R${2,6:F2}",
            //        x.NomeProd, x.NomeCat, x.PrecoUnit);
            //}

            var Consulta = from Cat in ListaCateg
                           join Prod in ListaProd
                           on Cat.CodCategoria equals Prod.Categoria
                           orderby Prod.NomeProduto
                           select new
                           {
                               NomeProd = Prod.NomeProduto,
                               NomeCat = Cat.DescCategoria,
                               PrecoUnit = Prod.PrecoUnit
                           };

            var GrupoConsulta = from P in Consulta
                                group P by P.NomeCat into G
                                select new { Cat = G.Key, Prod = G };

            foreach (var x in GrupoConsulta)
            {
                Console.WriteLine("\nCategoria: {0}", x.Cat);
                foreach (var y in x.Prod)
                {
                    Console.WriteLine("  => {0} - R${1,6:F2}", y.NomeProd, y.PrecoUnit);
                }
            }

            Console.ReadKey();
        }
    }
}