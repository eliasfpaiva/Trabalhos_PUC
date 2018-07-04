using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;//Para usar Excel
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace LendoExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeArq = @"C:\temp\Funcionários.xlsx";

            OleDbConnection ConexaoExcel = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + nomeArq + ";Extended Properties='Excel 12.0;HDR = NO;IMEX = 1'");
            OleDbDataAdapter MeuDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", ConexaoExcel);

            DataSet MeuDataSet = new DataSet();

            MeuDataAdapter.Fill(MeuDataSet, "ExcelInfo");

            DataTable MeuDataTable = MeuDataSet.Tables["ExcelInfo"];

            var Consulta = from Dados in MeuDataTable.AsEnumerable()
                           select new
                           {
                               Nome = (string)Dados.ItemArray.GetValue(0),
                               Departamento = (string)Dados.ItemArray.GetValue(1),
                               Cargo = (string)Dados.ItemArray.GetValue(2),
                               DataAdmissao = Dados.ItemArray.GetValue(3),
                               Salario = Dados.ItemArray.GetValue(4)
                           };

            bool PrimeiraLinha = true;

            foreach (var item in Consulta)
            {
                if (!PrimeiraLinha)
                {
                    Console.WriteLine("{0} - {1}", item.Nome, item.Cargo);
                    Console.WriteLine("Departamento: {0}", item.Departamento);
                    Console.WriteLine("Admissão: {0}", item.DataAdmissao);
                    Console.WriteLine("Salário: R${0}", item.Salario);
                }
                else
                {
                    PrimeiraLinha = false;
                }
            }


            Console.ReadKey();
        }
    }
}
