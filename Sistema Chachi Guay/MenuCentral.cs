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
    public partial class MenuCentral : Form
    {
        public MenuCentral()
        {
            InitializeComponent();
        }

        private void MenuCentral_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de nuestro hermoso sitema?", "¿Realmente me traicionas así?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Util.getF1().Close();
            }
        }

        private void MenuCentral_Load(object sender, EventArgs e)
        {

        }

        private void pic_libros_Click(object sender, EventArgs e)
        {
            SeleccionLibros sl = new SeleccionLibros();
            sl.ShowDialog();
        }

        private void pic_series_Click(object sender, EventArgs e)
        {
            SeleccionSerie ss = new SeleccionSerie();
            ss.ShowDialog();
        }

        private void btn_ajustes_Click(object sender, EventArgs e)
        {
            Ajustes aj = new Ajustes();
            aj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }Avance

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
