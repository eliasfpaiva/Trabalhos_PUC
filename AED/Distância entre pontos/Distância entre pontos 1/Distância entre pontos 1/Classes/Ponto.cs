using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Distância_entre_pontos_1.Classes;

namespace Distância_entre_pontos_1.Classes
{
    public class Ponto
    {
        public int x { get; set; }
        public int y { get; set; }
        public Ponto(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }
        public static void pontoMaisProx(int tamanho)
        {
            Random random = new Random();
            Ponto[] pontos = new Ponto[tamanho];
            for (int i = 0; i < tamanho; i++)
                pontos[i] = new Ponto(random.Next(0, tamanho), random.Next(0, tamanho));

            foreach (Ponto p in pontos)
                Console.WriteLine(p.ToString());

            Ponto q = new Ponto(tamanho/2, tamanho/2);

            Console.WriteLine("O ponto mais próximo do selecionado é o de coordenadas: "
                + Funcoes.maisProx(pontos, q).ToString());
        }
    }
}
