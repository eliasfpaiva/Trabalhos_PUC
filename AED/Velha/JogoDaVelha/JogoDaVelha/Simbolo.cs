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
    public partial class Simbolo : Form
    {
        public Simbolo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (simbolo_X.Checked)
            {
                DialogResult = DialogResult.Yes;
                this.Close();
            }
            else if (simbolo_O.Checked)
            {
                DialogResult = DialogResult.No;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um símbolo para usar no jogo!");
            }
        }
    }
}
