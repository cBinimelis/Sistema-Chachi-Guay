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
            pic_imagen.ImageLocation = "./images/Libros/Dibujos/onepiece.jpg";
            sql.llenaCombo(comboEstado, "SELECT * FROM Estado");
        }

        //Esta funcion habilita los elementos para permitir la edicion o ingreso de nuevos datos
        private void Activar()
        {
            txt_nombre.Enabled = true;
            txt_sinopsis.Enabled = true;
            date_Lanzamiento.Enabled = true;
            txt_tomos.Enabled = true;
            txt_generos.Enabled = true;
            comboEstado.Enabled = true;
        }

        private void Desactivar()
        {
            txt_nombre.Enabled = false;
            txt_sinopsis.Enabled = false;
            date_Lanzamiento.Enabled = false;
            txt_tomos.Enabled = false;
            txt_generos.Enabled = false;
            comboEstado.Enabled = false;
        }

        private void Limpiar()
        {
            IdManga = 0;
            txt_nombre.Text = "";
            txt_sinopsis.Text = "";
            date_Lanzamiento.Value = System.DateTime.Now;
            txt_tomos.Text = "";
            txt_generos.Text = "";
            comboEstado.SelectedValue = 0;
        }
        private void grillaMangas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdManga = Convert.ToInt32(grillaMangas.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            txt_nombre.Text = grillaMangas.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            txt_sinopsis.Text = grillaMangas.CurrentRow.Cells[2].EditedFormattedValue.ToString();
            date_Lanzamiento.Value = Convert.ToDateTime(grillaMangas.CurrentRow.Cells[3].EditedFormattedValue.ToString());
            txt_tomos.Text = grillaMangas.CurrentRow.Cells[4].EditedFormattedValue.ToString();
            comboEstado.SelectedValue = Convert.ToInt32(grillaMangas.CurrentRow.Cells[6].EditedFormattedValue.ToString());
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

        //Funcion para devolver los botones a su texto por defecto
        private void ModoNormal()
        {
            btn_delete.Text = "Borrar";
            btn_edit.Text = "Editar";
            btn_new.Text = "Agregar Manga";
            btn_delete.Enabled = true;
            btn_edit.Enabled = true;
            btn_new.Enabled = true;
        }

        private void ModoAgregar()
        {
            btn_delete.Text = "Salir";
            btn_new.Text = "Confirmar";
            btn_edit.Enabled = false;
        }

        private void Editar()
        {

        }

        private void Nuevo()
        {
            if (txt_nombre.Text.Trim().Equals("") || txt_sinopsis.Text.Trim().Equals("") || txt_tomos.Text.Trim().Equals(""))
            {
                MessageBox.Show("No puedes dejar campos vacios", "¡Detengase ahí COMPAÑERO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
            Agregar = false;
            Limpiar();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                if (Agregar == true)
                {
                    Nuevo();
                    ModoNormal();
                    Desactivar();
                }
                else
                {
                    Agregar = true;
                    Limpiar();
                    Activar();
                    ModoAgregar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Se ha producido un problema");
            }
        }
    }
}
