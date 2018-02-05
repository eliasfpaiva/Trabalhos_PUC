using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Formas.Elias.Telas
{
    public partial class Visor : Form
    {
        public Visor(string nome, double area, double perimetro, string figura)
        {
            InitializeComponent();
            TfNome.Text = nome;
            TfArea.Text = area.ToString();
            TfPerimetro.Text = perimetro.ToString();
            Imagem.SizeMode = PictureBoxSizeMode.StretchImage;
            Imagem.Image = Image.FromFile (figura);
        }
    }
}
