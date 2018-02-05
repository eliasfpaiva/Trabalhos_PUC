using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Formas.Elias.Codigos
{
    abstract class Forma
    {
        public Forma() { }
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
        public virtual void Mostrar() { MessageBox.Show("É necessário preencher as informações para que a forma correta seja exibida jovem gafanhoto!"); }
    }
}
