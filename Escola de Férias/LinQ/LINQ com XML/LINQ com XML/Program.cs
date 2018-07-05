using System;
using System.Collections;                                  // Para ArrayList
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;                                          // Para XML
using System.Xml.Linq;                                     // Para XML com LinQ

namespace LINQ_com_XML
{
    public class Aluno                                     // Definição da Classe
    {
        public string Nome { get; set; }
        public string Mail { get; set; }
        public string TelCel { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            XElement Raiz = XElement.Load(@"..\..\..\ArquivoAlunos.xml");       // Abre XML

            var Consulta = from p in Raiz.Elements("Aluno")                     // Faz a consulta - Elemento Raíz Aluno
                           select new                                           // Cria os Objetos
                           {
                               Nome = (string)p.Element("Nome"),
                               Mail = (string)p.Element("Mail"),
                               Telefone = (string)p.Element("TelCel"),
                           };

            Console.Clear();                                                    // Vamos mostrar...

            foreach (var x in Consulta)
            {
                Console.WriteLine("{0} - Telefone: {1}", x.Nome, x.Telefone);
                Console.WriteLine("Mail: {0}\n", x.Mail);
            }

            Console.ReadKey();

            Aluno MeuAlunoNovo = new Aluno();                                   // Inserir um Novo Aluno

            Console.Write("Nome do Aluno: ");
            MeuAlunoNovo.Nome = Console.ReadLine();

            Console.Write("Mail: ");
            MeuAlunoNovo.Mail = Console.ReadLine();

            Console.Write("Telefone: ");
            MeuAlunoNovo.TelCel = Console.ReadLine();

            XElement NovoAluno = new XElement("Aluno",                          // Novo XElement Aluno
                                     new XElement("Nome", MeuAlunoNovo.Nome),
                                     new XElement("Mail", MeuAlunoNovo.Mail),
                                     new XElement("TelCel", MeuAlunoNovo.TelCel));

            Raiz.Add(NovoAluno);                                            // Adiciona

            Raiz.Save(@"..\..\..\ArquivoAlunos.xml");                       // e Salva

            Consulta = from p in Raiz.Elements("Aluno")                     // Faz a consulta novamente...
                       orderby (string)p.Element("Nome")                    // agora ordenando por Nome
                       select new
                       {
                           Nome = (string)p.Element("Nome"),
                           Mail = (string)p.Element("Mail"),
                           Telefone = (string)p.Element("TelCel"),
                       };

            Console.Clear();

            foreach (var x in Consulta)                                     // e mostra
            {
                Console.WriteLine("{0} - Telefone: {1}", x.Nome, x.Telefone);
                Console.WriteLine("Mail: {0}\n", x.Mail);
            }

            Console.ReadKey();


            // Alterar - Registro "Luiz Cláudio Pena"
            IEnumerable<XElement> AlunoAlterar = from E in Raiz.Elements("Aluno")
                                                 where ((string)E.Element("Nome")).Equals("Luiz Cláudio Pena")
                                                 select E;

            foreach (XElement xe in AlunoAlterar)
            {
                xe.SetElementValue("Nome", "Luiz Cláudio Pena Soares");
                xe.SetElementValue("Mail", "lucapena@yahoo.com.br");
                xe.SetElementValue("TelCel", "99855.1212");
            }

            Raiz.Save(@"..\..\..\ArquivoAlunos.xml");                       // e Salva

            Consulta = from p in Raiz.Elements("Aluno")                     // Faz a consulta novamente...
                       orderby (string)p.Element("Nome")
                       select new
                       {
                           Nome = (string)p.Element("Nome"),
                           Mail = (string)p.Element("Mail"),
                           Telefone = (string)p.Element("TelCel"),
                       };

            Console.Clear();

            foreach (var x in Consulta)                                     // e mostra
            {
                Console.WriteLine("{0} - Telefone: {1}", x.Nome, x.Telefone);
                Console.WriteLine("Mail: {0}\n", x.Mail);
            }

            Console.ReadKey();


            //Remover - Registro "Rodrigo Henrique de Assis"
            IEnumerable<XElement> AlunoRemover = from E in Raiz.Elements("Aluno")
                                                 where ((string)E.Element("Nome")).Equals("Rodrigo Henrique de Assis")
                                                 select E;

            foreach (XElement xe in AlunoRemover)
            {
                xe.Element("Nome").Parent.Remove();
            }

            Raiz.Save(@"..\..\..\ArquivoAlunos.xml");                       // e Salva

            Consulta = from p in Raiz.Elements("Aluno")                     // Faz a consulta novamente...
                       orderby (string)p.Element("Nome")
                       select new
                       {
                           Nome = (string)p.Element("Nome"),
                           Mail = (string)p.Element("Mail"),
                           Telefone = (string)p.Element("TelCel"),
                       };

            Console.Clear();

            foreach (var x in Consulta)                                     // e mostra
            {
                Console.WriteLine("{0} - Telefone: {1}", x.Nome, x.Telefone);
                Console.WriteLine("Mail: {0}\n", x.Mail);
            }

            Console.ReadKey();
        }
    }
}

