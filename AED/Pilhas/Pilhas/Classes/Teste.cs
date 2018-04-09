using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Pilhas.Classes;

namespace Pilhas.Classes
{
    public static class Teste
    {
        //Esta classe faz o teste do sistema buscando de um arquivo os dados da movimentação

        public static void testar()
        {
            string linha;//Recebe uma linha do arquivo que esta sendo lido
            string[] comando;//Recebe o comando representado na linha
            int tamanhoEstacionamento = 0;//Variável usada para saber o tamanho do estacionamento necessário para as movimentações do arquivo
            /*
             * Criei desta forma para evitar erros, e entradas com estacionamento lotado, mas, pode testar valores fixos que irá funcionar
             */

            FileStream entrada = new FileStream("entrada.txt", FileMode.OpenOrCreate);//Cria o fluxo para o arquivo
            StreamReader leitor = new StreamReader(entrada);//Lê o arquivo
            {                
                do
                {
                    linha = leitor.ReadLine();//Atribui à variável linha uma linha lida do arquivo
                    if (linha != null)//Testa se a linha contém informação ou não
                    {
                        comando = linha.Split(' ');//Divide a linha com informação em comando e placa informada
                        if (comando[0].ToUpper() == "E")//Verifica se é uma entrada, pois saidas não demandam novas vagas
                            tamanhoEstacionamento++;//Conta quantas vagas são necessárias para esta situação
                    }
                } while (linha != null);//Testa se é necessário repetir a leitura ou não
            }
            leitor.Close();//Fecha o leitor

            Estacionamento estacionamento = new Estacionamento(tamanhoEstacionamento);//Declara um estacionamento do tamanho necessário

            FileStream entrada2 = new FileStream("entrada.txt", FileMode.Open);//Cria o fluxo para o arquivo
            StreamReader leitor2 = new StreamReader(entrada2);//Lê o arquivo
            {
                do
                {
                    linha = leitor2.ReadLine();//Atribui à variável linha uma linha lida do arquivo
                    if (linha != null)//Testa se a linha contém informação ou não
                    {
                        comando = linha.Split(' ');//Divide a linha com informação em comando e placa informada
                        if (comando[0].ToUpper() == "E")//Verifica se é uma entrada
                            estacionamento.estaciona(comando[1]);//Chama método que coloca um carro no estacionamento
                        else if (comando[0].ToUpper() == "S")//Verifica se é uma saida
                            estacionamento.desEstaciona(comando[1]);//Chama método que retira um carro no estacionamento
                        else
                            Console.WriteLine("Comando inválido!");//Informa que o comando é inválido
                    }
                } while (linha != null);//Testa se é necessário repetir a leitura ou não
            }
            leitor2.Close();//Fecha o segundo leitor
        }
    }
}