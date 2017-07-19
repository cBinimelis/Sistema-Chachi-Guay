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
    public partial class SeleccionLibros : Form
    {
        public SeleccionLibros()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Manga m = new Manga();
            m.ShowDialog();
            this.Close();
        }

        private void pic_libros_Click(object sender, EventArgs e)
        {
            Libros l = new Libros();
            l.ShowDialog();
            this.Close();
        }
    }
}
