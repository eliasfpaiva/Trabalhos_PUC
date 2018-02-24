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

        public static Ponto maisProx(Ponto[] pontos, Ponto p)
        {
            Ponto res = pontos[0];
            double dist = distancia(pontos[0], p);
            Console.WriteLine("\nDistâncias:\n" + distancia(pontos[0], p));

            for (int i = 1; i < pontos.Length; i++)
            {
                Console.WriteLine(distancia(pontos[i], p));
                if (distancia(pontos[i], p) < dist)
                {
                    res = pontos[i];
                    dist = distancia(pontos[i], p);
                }
            }

            Console.WriteLine("\nA menor distâncias foi: " + dist + "\n");

            return res;
        }
    }
}
