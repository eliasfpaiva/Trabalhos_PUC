using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Formas.Elias.Telas;

namespace Atividade_Formas.Elias.Codigos
{
    class Octogono : Forma
    {
        private double lado;
        public Octogono(double lado) { this.lado = lado; }
        public override double CalcularArea() { return 0; }
        public override double CalcularPerimetro() { return 0; }
        public double CalcularArea(double lado)
        {
            //não achei forma melhor de calcular então criei um quadrado circunscrito ao octógono para poder descobrir a área
            //verifique exemplo em https://youtu.be/uzIJ1EyJvY8
            double ladoQuadrado = 3 * lado;
            double areaQuadrado = ladoQuadrado * ladoQuadrado;
            double areaTriangulosCantos = (lado * lado) / 2;

            return areaQuadrado - areaTriangulosCantos;
        }
        public double CalcularPerimetro(double lado) { return lado * 8; }
        public override void Mostrar()
        {
            Visor saida = new Visor("Octógono", CalcularArea(lado), CalcularPerimetro(lado), "Octogono.png");
            saida.Show();
        }
    }
}
