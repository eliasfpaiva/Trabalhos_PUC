using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class selectOp : Form
    {
        public selectOp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (campo_jogador2.Checked)
            {
                DialogResult = DialogResult.Yes;
                this.Close();
            }
            else if (campo_computador.Checked)
            {
                DialogResult = DialogResult.No;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um oponente!");
            }                
        }
    }
}
