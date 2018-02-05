using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Formas.Elias.Telas;

namespace Atividade_Formas.Elias.Codigos
{
    class Hexagono : Forma
    {
        private double lado;
        public Hexagono(double lado) { this.lado = lado; }
        public override double CalcularArea() { return 0; }
        public override double CalcularPerimetro() { return 0; }
        public double CalcularArea(double lado) { return 3*(Math.Pow(lado,2))*(Math.Sqrt(3)); }
        public double CalcularPerimetro(double lado) { return lado * 6; }
        public override void Mostrar()
        {
            Visor saida = new Visor("Hexágono", CalcularArea(lado), CalcularPerimetro(lado), "Hexagono.png");
            saida.Show();
        }
    }
}
