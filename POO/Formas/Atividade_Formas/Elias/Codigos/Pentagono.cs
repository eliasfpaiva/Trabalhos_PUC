using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Formas.Elias.Telas;

namespace Atividade_Formas.Elias.Codigos
{
    class Pentagono : Forma
    {
        private double lado;
        public Pentagono(double lado) { this.lado = lado; }
        public override double CalcularArea() { return 0; }
        public override double CalcularPerimetro() { return 0; }
        public double CalcularArea(double lado)
        {
            double alturaTriangulo = (lado / 2) / Math.Tan(36);
            double areaTriangulo = (lado / 2) * alturaTriangulo;
            double area = 10 * areaTriangulo;
            return area;
        }
        public double CalcularPerimetro(double lado) { return lado * 5; }
        public override void Mostrar()
        {
            Visor saida = new Visor("Pentágono", CalcularArea(lado), CalcularPerimetro(lado), "Pentagono.png");
            saida.Show();
        }
    }
}
