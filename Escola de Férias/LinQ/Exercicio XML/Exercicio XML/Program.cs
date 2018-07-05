using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Linq;

namespace Exercicio_XML
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Mail { get; set; }
        public string TelCel { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            XElement Raiz = XElement.Load(@"C:\Temp\ArquivoAlunos.xml");

            lerListar(Raiz);

            Console.WriteLine("Leitura");
            Console.ReadKey();

            //Inserir
            Aluno MeuAluno = new Aluno();

            MeuAluno.Nome = "Sandro Pinto de Almeida Silva";
            MeuAluno.Mail = "spas@yahoo.com";
            MeuAluno.TelCel = "99876.5432";

            XElement NovoAluno = new XElement("Aluno",
                new XElement("Nome", MeuAluno.Nome),
                new XElement("Mail", MeuAluno.Mail),
                new XElement("TelCel", MeuAluno.TelCel));

            Raiz.Add(NovoAluno);
            Raiz.Save(@"C:\temp\ArquivoAlunos.xml");

            lerListar(Raiz);
            
            Console.WriteLine("Inclusão");
            Console.ReadKey();

            var AlunoAlterar = from A in Raiz.Elements("Aluno")
                               where ((string)A.Element("Nome")).Equals("Sandro Pinto de Almeida Silva")
                               select A;
            foreach(XElement xe in AlunoAlterar)
            {
                xe.SetElementValue("Nome", "Sandro Almeida");
                xe.SetElementValue("Mail", "Salmeida@gmail.com");
                xe.SetElementValue("TelCel", "98765.1234");
            }

            Raiz.Save(@"C:\temp\ArquivoAlunos.xml");

            lerListar(Raiz);

            Console.WriteLine("Alteração");
            Console.ReadKey();

            var AlunoRemover = from A in Raiz.Elements("Aluno")
                               where ((string)A.Element("Nome")).Equals("Sandro Almeida")
                               select A;
            foreach (XElement xe in AlunoAlterar)
            {
                xe.Element("Nome").Parent.Remove();
            }
            
            Raiz.Save(@"C:\temp\ArquivoAlunos.xml");

            lerListar(Raiz);

            Console.WriteLine("Exclusão");
            Console.WriteLine("Fim");
            Console.ReadKey();
        }

        private static void lerListar(XElement Raiz)
        {

            Console.Clear();
            var consulta = from p in Raiz.Elements("Aluno")
                           select new
                           {
                               Nome = (string)p.Element("Nome"),
                               Mail = (string)p.Element("Mail"),
                               Telefone = (string)p.Element("TelCel")
                           };

            foreach (var x in consulta)
            {
                Console.WriteLine("{0} - Telefone: {1}", x.Nome, x.Telefone);
                Console.WriteLine("Mail: {0}\n", x.Mail);
            }
        }
    }
}
