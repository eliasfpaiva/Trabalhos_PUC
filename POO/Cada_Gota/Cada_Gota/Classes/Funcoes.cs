using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Cada_Gota.Classes
{
    static class Funcoes
    {
        public static int getNewId(string arquivo)
        {
            int id, contLinhas = 0;
            string linha;

            FileStream arq = new FileStream(arquivo, FileMode.OpenOrCreate);
            StreamReader ler = new StreamReader(arq);

            do
            {
                linha = ler.ReadLine();
                if (linha != null) { contLinhas++; }
            } while (linha != null);

            ler.Close();

            id = contLinhas + 1;

            return id;
        }

        public static void salvarRegistro(string arquivo, string registro)
        {
            FileStream arq = new FileStream(arquivo, FileMode.Append);
            StreamWriter escrever = new StreamWriter(arq);

            escrever.WriteLine(registro);

            escrever.Close();
        }

        public static string getRegistro(string arquivo, string id)
        {
            string linha;
            string[] dado;
            string registro = null;

            FileStream arq = new FileStream(arquivo, FileMode.Open);
            StreamReader ler = new StreamReader(arq);

            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    dado = linha.Split('|');
                    if (dado[0] == id)
                    {
                        registro = linha;
                        linha = null;
                    }
                }
            } while (linha != null);

            ler.Close();

            return registro;
        }

        public static string[] getIdNomeConsumidor()
        {
            string linha;
            string[] Registro;
            string[] Registros;
            List<string> listaRegistros = new List<string>();

            FileStream arq = new FileStream("Consumidores.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq);

            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    Registro = linha.Split('|');
                    listaRegistros.Add(Registro[0] + ": " + Registro[1]);
                }
            } while (linha != null);

            ler.Close();

            int i = listaRegistros.Count();
            int j = 0;

            Registros = new string[i];

            foreach (string dado in listaRegistros)
            {
                Registros[j] = dado;
                j++;
            }

            return Registros;
        }

        public static string[] getNomeCpfConsumidor(string idConsumidor)
        {
            string[] consumidor = idConsumidor.Split(':');
            string[] registro;
            string linha;

            FileStream arq = new FileStream("Consumidores.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq);

            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    registro = linha.Split('|');
                    if (consumidor[0] == registro[0])
                    {
                        consumidor[0] = registro[1];
                        consumidor[1] = registro[2];
                        linha = null;
                    }
                }
            } while (linha != null);

            ler.Close();

            return consumidor;
        }

        public static string[] getImoveisConsumidor(string idConsumidor)
        {
            string[] consumidor = idConsumidor.Split(':');
            string[] registro;
            List<string> listaImoveis = new List<string>();
            string linha;

            FileStream arq = new FileStream("Imóveis.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq);

            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    registro = linha.Split('|');
                    if (consumidor[0] == registro[1])
                    {
                        listaImoveis.Add(registro[0] + "|" + registro[3] + "|" + registro[2] + "|" + registro[4] + "|" + registro[10] + "|" + registro[11]);
                    }
                }
            } while (linha != null);

            ler.Close();

            string[] imoveisConsumidor = new string[listaImoveis.Count];

            int i = 0;

            foreach (string imovel in listaImoveis)
            {
                imoveisConsumidor[i] = imovel;
                i++;
            }

            return imoveisConsumidor;
        }

        public static string getImovel(string idImovel)
        {
            string[] registro;
            string linha;
            string imovel = null;

            FileStream arq = new FileStream("Imóveis.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq);

            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    registro = linha.Split('|');
                    if (registro[0] == idImovel)
                    {
                        imovel = registro[3] + "|" + registro[4] + "|" + registro[2] + "|" + registro[5] + "|" + registro[6] + "|" + registro[10] + "|" + registro[11];
                        linha = null;
                    }
                }
            } while (linha != null);

            ler.Close();

            return imovel;
        }

        public static string[] getContasConsumidor(string idConsumidor)
        {
            string[] consumidor = idConsumidor.Split(':');
            string[] registro;
            List<string> listaContas = new List<string>();
            string linha;

            FileStream arq = new FileStream("Contas.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq);

            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    registro = linha.Split('|');
                    if (consumidor[0] == registro[1])
                    {
                        listaContas.Add(registro[0] + "|" + getImovel(registro[2]) + "|" + registro[3] + "|" + registro[4]);
                    }
                }
            } while (linha != null);

            ler.Close();

            string[] contasConsumidor = new string[listaContas.Count];

            int i = 0;

            foreach (string conta in listaContas)
            {
                contasConsumidor[i] = conta;
                i++;
            }

            return contasConsumidor;
        }

        public static double[] calculaAgua(int inicial, int final, string tipoImovel)
        {
            double[] valores = new double[2];
            int consumo = final - inicial;
            double valorFinal = 0;
            double valorComImposto = 0;

            if (tipoImovel == "RESIDENCIAL")
            {
                if ((consumo >= 0) && (consumo <= 6))
                {
                    valorFinal = 10.08 + 5.05;
                }
                else if ((consumo > 6) && (consumo <= 10))
                {
                    valorFinal = consumo * 2.241 + consumo * 1.122;
                }
                else if ((consumo > 10) && (consumo <= 15))
                {
                    valorFinal = consumo * 5.447 + consumo * 2.724;
                }
                else if ((consumo > 15) && (consumo <= 20))
                {
                    valorFinal = consumo * 5.461 + consumo * 2.731;
                }
                else if ((consumo > 20) && (consumo <= 40))
                {
                    valorFinal = consumo * 5.487 + consumo * 2.744;
                }
                else if (consumo > 40)
                {
                    valorFinal = consumo * 10.066 + consumo * 5.035;
                }
            }
            else
            {
                if ((consumo >= 0) && (consumo <= 6))
                {
                    valorFinal = 25.79 + 12.90;
                }
                else if ((consumo > 6) && (consumo <= 10))
                {
                    valorFinal = consumo * 4.299 + consumo * 2.149;
                }
                else if ((consumo > 10) && (consumo <= 40))
                {
                    valorFinal = consumo * 8.221 + consumo * 4.111;
                }
                else if ((consumo > 40) && (consumo <= 100))
                {
                    valorFinal = consumo * 8.288 + consumo * 4.144;
                }
                else if (consumo > 100)
                {
                    valorFinal = consumo * 8.329 + consumo * 4.165;
                }
            }

            valorComImposto = valorFinal * 1.03;

            valores[0] = valorFinal;
            valores[1] = valorComImposto;

            return valores;
        }

        public static double[] calculaEnergia(int inicial, int final, string tipoImovel)
        {
            double[] valores = new double[2];
            int consumo = final - inicial;
            double valorFinal;
            double valorComImposto;

            if (tipoImovel == "RESIDENCIAL")
            {
                valorFinal = consumo * 0.46 + 13.25;
                if (consumo < 90) { valorComImposto = valorFinal; }
                else { valorComImposto = valorFinal * 1.4285; }
            }
            else
            {
                valorFinal = consumo * 0.41 + 13.25;
                valorComImposto = valorFinal * 1.2195;
            }

            valores[0] = valorFinal;
            valores[1] = valorComImposto;

            return valores;
        }

        public static string[] getContaMaisCara(string idConsumidor)
        {
            string[] contas     = getContas(idConsumidor);
            string[] contaCara  = new string[10];
            string[] dadosConta = new string[3];
            string[] divisor;

            contaCara[9] = "0";

            for (int i = 0; i < contas.Length; i++)
            {
                divisor = contas[i].Split('|');
                if (double.Parse(contaCara[9]) < double.Parse(divisor[9]))
                {
                    contaCara = divisor;
                }
            }

            divisor = getImovel(contaCara[2]).Split('|');

            double valor = double.Parse(contaCara[9]);

            dadosConta[0] = valor.ToString("N2");
            dadosConta[1] = contaCara[3] + "/" + contaCara[4];
            dadosConta[2] = divisor[0] + ", " + divisor[1] + ", " + divisor[2] + ", " + divisor[3] + ", " + divisor[4] + " >> " + divisor[5] + ", " + divisor[6];
            
            return dadosConta;
        }

        public static string[] getContas(string idConsumidor)
        {
            List<string> listaContas = new List<string>();
            string   linha;
            string[] registro;

            FileStream arq = new FileStream("Contas.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq);

            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    registro = linha.Split('|');
                    if (registro[1] == idConsumidor)
                    {
                        listaContas.Add(linha);
                    }
                }
            } while (linha != null);

            ler.Close();

            string[] contas = new string[listaContas.Count];

            int i = 0;

            foreach(string conta in listaContas)
            {
                contas[i] = conta;
                i++;
            }
            
            return contas;
        }
    }
}
