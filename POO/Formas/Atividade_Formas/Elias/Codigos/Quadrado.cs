using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Formas.Elias.Telas;

namespace Atividade_Formas.Elias.Codigos
{
    class Quadrado : Forma
    {
        private double lado;
        public Quadrado(double lado) { this.lado = lado; }
        public override double CalcularArea() { return 0; }
        public override double CalcularPerimetro() { return 0; }
        public double CalcularArea(double lado) { return lado * lado; }
        public double CalcularPerimetro(double lado) { return lado * 4; }
        public override void Mostrar()
        {
            Visor saida = new Visor("Quadrado", CalcularArea(lado), CalcularPerimetro(lado), "Quadrado.png");
            saida.Show();
        }
    }
}
