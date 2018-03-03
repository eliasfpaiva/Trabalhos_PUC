using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distância_entre_pontos_1.Classes
{
    public static class Funcoes
    {
        public static double distancia(Ponto p, Ponto q)
        {
            return Math.Sqrt((Math.Pow((p.x - q.x), 2) + Math.Pow((p.y - q.y), 2)));
        }

        public static Ponto[] criaVetor(int tamanho)
        {
            Random random = new Random();
            Ponto[] pontos = new Ponto[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                pontos[i] = new Ponto(random.Next(0, tamanho), random.Next(0, tamanho));
                //Console.WriteLine(i);
            }

            return pontos;
        }

        public static Ponto maisProx(Ponto[] pontos, Ponto p)
        {
            Ponto res = pontos[0];
            double dist = distancia(pontos[0], p);

            for (int i = 1; i < pontos.Length; i++)
            {
                if (distancia(pontos[i], p) < dist)
                {
                    res = pontos[i];
                    dist = distancia(pontos[i], p);
                }
            }

            //Console.WriteLine("\nA menor distâncias foi: " + dist + "\n");

            return res;
        }

        public static void pontoMaisProx(int tamanho)
        {
            Random random = new Random();
            Ponto q = new Ponto(random.Next(0, tamanho), random.Next(0, tamanho));

            //Console.WriteLine("O ponto foi: " + q.ToString());

            Ponto pontoProximo = Funcoes.maisProx(criaVetor(tamanho), q);

            //Console.WriteLine("O ponto mais próximo do selecionado é o de coordenadas: " +
              //  pontoProximo.ToString());
        }
        public static void doisPontoMaisProx(int tamanho)
        {
            Random random = new Random();
            Ponto[] pontosprox = new Ponto[2];
            double menorDistancia=(2*(tamanho*tamanho))+1;

            Ponto[] pontos = criaVetor(tamanho);

            for (int j = 0; j < tamanho; j++)
            {
                for (int i = 0; i < tamanho; i++)
                {
                    double distanciaAtual = distancia(pontos[j], pontos[i]);
                    if (distanciaAtual < menorDistancia)
                    {
                        if (i==j)
                        {
                            continue;
                        }
                        pontosprox[0] = pontos[j];
                        pontosprox[1] = pontos[i];
                        menorDistancia = distanciaAtual;
                    }
                }
            }

           // Console.WriteLine("Os pontos mais próximos entre sí são os de coordenadas: \n" +
             //   pontosprox[0].ToString() + "\n" + pontosprox[1].ToString() +
               // "\nE a distância entre eles é:" + menorDistancia);
        }
    }
}
