using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;                                          // Para o DataSet
using System.Data.OleDb;                                    // Para Excel
using Excel = Microsoft.Office.Interop.Excel;               // Referência: Microsoft Excel 14.0 Object Library


namespace LINQ_com_Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            string NomeArq = @"D:\Lixo\Funcionários.xlsx";

            OleDbConnection ConexãoExcel = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + NomeArq + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1'");
            OleDbDataAdapter MeuDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", ConexãoExcel);
            DataSet MeuDataSet = new DataSet();

            MeuDataAdapter.Fill(MeuDataSet, "ExcelInfo");
            DataTable MeuDataTable = MeuDataSet.Tables["ExcelInfo"];

            var Consulta = from Dados in MeuDataTable.AsEnumerable()
                           select new
                           {
                               Nome = Dados.ItemArray.GetValue(0),
                               Departamento = Dados.ItemArray.GetValue(1),
                               Cargo = Dados.ItemArray.GetValue(2),
                               DataAdmissão = Dados.ItemArray.GetValue(3),
                               Salário = Dados.ItemArray.GetValue(4),
                           };

            foreach (var Item in Consulta)
            {
                Console.WriteLine(Item.Nome + " - " + Item.Cargo);
                Console.WriteLine("Departamento: " + Item.Departamento);
                Console.WriteLine("Admissão: " + Item.DataAdmissão);
                Console.WriteLine("Salário: R$ " + Item.Salário + "\n");
            }

            Console.ReadKey();
        }
    }
}



