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
        Usuario u = new Usuario();
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
            lbl_usuario.Text = Usuario.getNick();
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
            Pendientes p = new Pendientes();
            p.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas realmente cerrar sesion?", "Puede que hayas presionado por error...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Sigue disfrutando");
            }
            else
            {
                this.Dispose();
                Util.getF1().Show();
            }
        }

        private void pic_peliculas_Click(object sender, EventArgs e)
        {
            Peliculas sp = new Peliculas();
            sp.ShowDialog();
        }

        private void pic_juegos_Click(object sender, EventArgs e)
        {
            Juegos sj = new Juegos();
            sj.ShowDialog();
        }
    }
}
