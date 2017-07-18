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
    public partial class Ajustes : Form
    {
        public Ajustes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AjusteUsuario au = new AjusteUsuario();
            au.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AjusteTipo at = new AjusteTipo();
            at.ShowDialog(); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AjusteExtra ae = new AjusteExtra();
            ae.ShowDialog();
        }
    }
}
