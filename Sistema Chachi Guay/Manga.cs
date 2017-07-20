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
    public partial class Manga : Form
    {
        OpenFileDialog op = new OpenFileDialog();
        public Manga()
        {
            InitializeComponent();
        }

        private void Manga_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_bibliotecaDataSet.Manga' Puede moverla o quitarla según sea necesario.
            this.mangaTableAdapter.Fill(this.bd_bibliotecaDataSet.Manga);

        }

        private void pic_imagen_Click(object sender, EventArgs e)
        {
            DialogResult result = op.ShowDialog();
            op.Title = "Busqueda de Imagen";
            op.Filter = "jpg files (*.jpg) | *.jpg";
            if (result == DialogResult.OK) // Test result.
            {
                pic_imagen.Image = new Bitmap(op.FileName);
            }
        }
    }
}
