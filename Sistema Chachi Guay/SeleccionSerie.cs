using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Chachi_Guay
{
    public partial class SeleccionSerie : Form
    {
        public SeleccionSerie()
        {
            InitializeComponent();
        }

        private void pic_anime_Click(object sender, EventArgs e)
        {
            Anime a = new Anime();
            a.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Humanos h = new Humanos();
            h.ShowDialog();
        }
    }
}
