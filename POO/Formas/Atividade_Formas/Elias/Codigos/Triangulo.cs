using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Formas.Elias.Telas;

namespace Atividade_Formas.Elias.Codigos
{
    class Triangulo : Forma
    {
        private double lado;
        public Triangulo(double lado) { this.lado = lado; }
        public override double CalcularArea() { return 0; }
        public override double CalcularPerimetro() { return 0; }
        public double CalcularArea(double lado)
        {
            double alturaTriangulo = (lado / 2) / Math.Tan(30);
            double area = (lado / 2) * alturaTriangulo;
            return area;
        }
        public double CalcularPerimetro(double lado) { return lado * 3; }
        public override void Mostrar()
        {
            Visor saida = new Visor("Triângulo", CalcularArea(lado), CalcularPerimetro(lado), "Triangulo.png");
            saida.Show();
        }
    }
}
