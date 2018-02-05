using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWar
{
    public partial class Fase_1 : Form
    {
        public Fase_1()
        {
            InitializeComponent();
        }
        public Fase_1(string person1, string person2){
            InitializeComponent();
            pictureBox1.ImageLocation = @"C:\Users\1077333\Source\Repos\GameWar\GameWar\GameWar\Imagens\"+person1;
            pictureBox2.ImageLocation = @"C:\Users\1077333\Source\Repos\GameWar\GameWar\GameWar\Imagens\"+person2;


        }

        private void Fase_1_Load(object sender, EventArgs e)
        {

        }
    }
}
