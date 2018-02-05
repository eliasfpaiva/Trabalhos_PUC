using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atividade_Formas.Elias.Codigos;

namespace Atividade_Formas.Elias.Telas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            cbNome.Items.Add("Círculo");
            cbNome.Items.Add("Hexágono");
            cbNome.Items.Add("Octógono");
            cbNome.Items.Add("Pentágono");
            cbNome.Items.Add("Quadrado");
            cbNome.Items.Add("Retângulo");
            cbNome.Items.Add("Triangulo");
            cbNome.Items.Add(" ");
            lbLado.Visible = false;
            lbLadoMaior.Visible = false;
            lbLadoMenor.Visible = false;
            lbRaio.Visible = false;
            tfLado.Visible = false;
            tfLadoMaior.Visible = false;
            tfLadoMenor.Visible = false;
            tfRaio.Visible = false;
            btnEnviar.Visible = false;
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            //A cada seleção foi necessário apagar os campos que não seriam usados para que eles não fossem ficando em exibição desnecessáriamente
            if (cbNome.Text == "Círculo")
            {
                lbLado.Visible = false;
                lbLadoMaior.Visible = false;
                lbLadoMenor.Visible = false;
                tfLado.Visible = false;
                tfLadoMaior.Visible = false;
                tfLadoMenor.Visible = false;

                lbRaio.Visible = true;
                tfRaio.Visible = true;
                btnEnviar.Visible = true;
            }else if(cbNome.Text == "Hexágono" || cbNome.Text == "Octógono" || cbNome.Text == "Pentágono" || cbNome.Text == "Quadrado" || cbNome.Text == "Triangulo")
            {
                lbLadoMaior.Visible = false;
                lbLadoMenor.Visible = false;
                lbRaio.Visible = false;
                tfLadoMaior.Visible = false;
                tfLadoMenor.Visible = false;
                tfRaio.Visible = false;

                lbLado.Visible = true;
                tfLado.Visible = true;
                btnEnviar.Visible = true;
            } else if (cbNome.Text == "Retângulo")
            {
                lbLado.Visible = false;
                lbRaio.Visible = false;
                tfLado.Visible = false;
                tfRaio.Visible = false;

                lbLadoMaior.Visible = true;
                tfLadoMaior.Visible = true;
                lbLadoMenor.Visible = true;
                tfLadoMenor.Visible = true;
                btnEnviar.Visible = true;
            }else
            {
                lbLado.Visible = false;
                lbLadoMaior.Visible = false;
                lbLadoMenor.Visible = false;
                lbRaio.Visible = false;
                tfLado.Visible = false;
                tfLadoMaior.Visible = false;
                tfLadoMenor.Visible = false;
                tfRaio.Visible = false;
                btnEnviar.Visible = false;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (cbNome.Text == "Círculo")
            {
                try
                {
                    double teste;
                    teste = double.Parse(tfRaio.Text);
                    Circulo circulo = new Circulo(teste);
                    circulo.Mostrar();
                }
                catch (Exception ERRO) { MessageBox.Show("Favor informar os valores corretamente!"); }
            }
            else if (cbNome.Text == "Hexágono")
            {
                try
                {
                    double teste;
                    teste = double.Parse(tfLado.Text);
                    Hexagono hexagono = new Hexagono(teste);
                    hexagono.Mostrar();
                }
                catch (Exception ERRO) { MessageBox.Show("Favor informar os valores corretamente!"); }
            }
            else if (cbNome.Text == "Octógono")
            {
                try
                {
                    double teste;
                    teste = double.Parse(tfLado.Text);
                    Octogono octogono = new Octogono(teste);
                    octogono.Mostrar();
                }
                catch (Exception ERRO) { MessageBox.Show("Favor informar os valores corretamente!"); }
            }
            else if (cbNome.Text == "Retângulo")
            {
                try
                {
                    double testeMaior, testeMenor;
                    testeMaior = double.Parse(tfLadoMaior.Text);
                    testeMenor = double.Parse(tfLadoMenor.Text);
                    Retangulo retangulo = new Retangulo(testeMaior, testeMenor);
                    retangulo.Mostrar();
                }
                catch (Exception ERRO) { MessageBox.Show("Favor informar os valores corretamente!"); }
            }
            else if (cbNome.Text == "Pentágono")
            {
                try
                {
                    double teste;
                    teste = double.Parse(tfLado.Text);
                    Pentagono pentagono = new Pentagono(teste);
                    pentagono.Mostrar();
                }
                catch (Exception ERRO) { MessageBox.Show("Favor informar os valores corretamente!"); }
            }
            else if (cbNome.Text == "Quadrado")
            {
                try
                {
                    double teste;
                    teste = double.Parse(tfLado.Text);
                    Quadrado quadrado = new Quadrado(teste);
                    quadrado.Mostrar();
                }
                catch (Exception ERRO) { MessageBox.Show("Favor informar os valores corretamente!"); }
            }
            else if (cbNome.Text == "Triangulo")
            {
                try
                {
                    double teste;
                    teste = double.Parse(tfLado.Text);
                    Triangulo triangulo = new Triangulo(teste);
                    triangulo.Mostrar();
                }
                catch (Exception ERRO) { MessageBox.Show("Favor informar os valores corretamente!"); }
            }
        }
    }
}
