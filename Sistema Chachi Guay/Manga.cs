using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Chachi_Guay
{
    public partial class Manga : Form
    {
        SQL sql = new SQL();
        OpenFileDialog op = new OpenFileDialog();
        public Manga()
        {
            InitializeComponent();
        }
        
        //Variables
        int IdManga = 0;
        bool Agregar = false;

        private void Manga_Load(object sender, EventArgs e)
        {
            this.mangaTableAdapter.Fill(this.bd_bibliotecaDataSet.Manga);
            pic_imagen.ImageLocation ="./images/Libros/Dibujos/onepiece.jpg"; 
        }

        //Esta funcion habilita los elementos para permitir la edicion o ingreso de nuevos datos
        private void Activar()
        {
            txt_nombre.Enabled = true;
            txt_sinopsis.Enabled = true;
            txt_tomos.Enabled = true;
            txt_generos.Enabled = true;
            comboEstado.Enabled = true;
            txt_nota.Enabled = true;
        }

        private void Limpiar()
        {
            txt_nombre.Text = "";
            txt_sinopsis.Text = "";
            txt_tomos.Text = "";
            txt_generos.Text = "";
            comboEstado.SelectedValue = 0;
            txt_nota.Text = "";
        }
        private void grillaMangas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdManga = Convert.ToInt32(grillaMangas.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            txt_nombre.Text = grillaMangas.CurrentRow.Cells[1].EditedFormattedValue.ToString();
        }

        private void pic_imagen_Click(object sender, EventArgs e)
        {
            DialogResult result = op.ShowDialog();
            op.Title = "Busqueda de Imagen";
            op.Filter = "jpg files (*.jpg) | *.jpg";
            {
                pic_imagen.Image = new Bitmap(op.FileName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
