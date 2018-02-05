using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Formas.Elias.Telas;

namespace Atividade_Formas.Elias.Codigos
{
    class Retangulo : Forma
    {
        private double ladoMaior;
        private double ladoMenor;
        public Retangulo(double ladomaior, double ladomenor)
        {
            this.ladoMaior = ladomaior;
            this.ladoMenor = ladomenor;
        }
        public override double CalcularArea() { return 0; }
        public override double CalcularPerimetro() { return 0; }
        public double CalcularArea(double ladoMaior, double ladoMenor) { return ladoMaior * ladoMenor; }
        public double CalcularPerimetro(double ladoMaior, double ladoMenor) { return 2*(ladoMaior + ladoMenor); }
        public override void Mostrar()
        {
            Visor saida = new Visor("Retângulo", CalcularArea(ladoMaior, ladoMenor), CalcularPerimetro(ladoMaior, ladoMenor), "Retangulo.png");
            saida.Show();
        }
    }
}
