using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Formas.Elias.Telas;

namespace Atividade_Formas.Elias.Codigos
{
    class Circulo : Forma
    {
        private double raio;
        public Circulo(double raio) { this.raio = raio; }
        public override double CalcularArea() { return 0; }
        public override double CalcularPerimetro() { return 0; }
        public double CalcularArea(double raio) { return Math.PI * (Math.Pow(raio, 2)); }
        public double CalcularPerimetro(double raio) { return (2 * Math.PI) * raio; }
        public override void Mostrar()
        {
            Visor saida = new Visor("Circulo", CalcularArea(raio), CalcularPerimetro(raio), "Circulo.png");
            saida.Show();
        }
    }
}
