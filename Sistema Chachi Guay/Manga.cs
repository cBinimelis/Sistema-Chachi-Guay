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
using System.IO;

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
        bool Editar = false;
        MemoryStream ms = new MemoryStream();
        byte[] MyImg = new byte[0];

        private void Manga_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_bibliotecaDataSet1.vManga' Puede moverla o quitarla según sea necesario.
            this.vMangaTableAdapter.Fill(this.bd_bibliotecaDataSet1.vManga);
            pic_imagen = null;
            sql.llenaCombo(comboEstado, "SELECT * FROM Estado");
            sql.llenaCombo(comboGeneros, "SELECT * FROM Genero_Mangas");
        }

        //Esta funcion habilita los elementos para permitir la edicion o ingreso de nuevos datos
        private void Activar()
        {
            txt_nombre.Enabled = true;
            txt_sinopsis.Enabled = true;
            date_Lanzamiento.Enabled = true;
            txt_tomos.Enabled = true;
            comboGeneros.Enabled = true;
            txt_generos.Enabled = true;
            comboEstado.Enabled = true;
        }

        private void Desactivar()
        {
            txt_nombre.Enabled = false;
            txt_sinopsis.Enabled = false;
            date_Lanzamiento.Enabled = false;
            txt_tomos.Enabled = false;
            comboGeneros.Enabled = false;
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
            comboGeneros.SelectedValue = 0;
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
            sql.llenaImagen(pic_imagen, "SELECT Imagen FROM Manga Where id_Manga = '" + IdManga + "'");
            comboGeneros.SelectedIndex = Convert.ToInt32(grillaMangas.CurrentRow.Cells[6].EditedFormattedValue.ToString()) - 1;
            txt_generos.Text = grillaMangas.CurrentRow.Cells[7].EditedFormattedValue.ToString();
            comboEstado.SelectedIndex = Convert.ToInt32(grillaMangas.CurrentRow.Cells[8].EditedFormattedValue.ToString()) - 1;

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

        private void Modificar()
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
                if (pic_imagen == null)
                {
                    MessageBox.Show("Debes seleccionar una imagen", "No sea tacaño");
                }
                else
                {
                    pic_imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] img = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(img, 0, img.Length);
                    if (sql.verificar("SELECT * FROM Manga WHERE Nombre ='" + txt_nombre.Text + "'"))
                    {
                        MessageBox.Show("Ya existe un Manga registrado con ese nombre", "No se aceptan clones de sombra");
                    }
                    else
                    {
                        int Guardar = sql.ejecutar("INSERT INTO Manga (Nombre, Sinopsis, Lanzamiento, Tomos, Imagen, id_GeneroManga, Otros_Generos, id_estado, id_Usuario) VALUES " +
                            "('" + txt_nombre.Text + "','" + txt_sinopsis.Text + "','" + date_Lanzamiento.Value + "','" + txt_tomos.Text + "','" + img + "','" + (comboGeneros.SelectedIndex + 1) + "','" + txt_generos.Text + "','" + (comboEstado.SelectedIndex + 1) + "','" + Usuario.getId() + "')");
                        if (Guardar > 0)
                        {
                            MessageBox.Show("Se ha agregado exitosamente el manga", "Felicidades por el vicio");
                            Agregar = false;
                            Limpiar();
                            ModoNormal();
                            Desactivar();
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido agregar el manga", "Se pudrio todo");
                        }
                    }
                }
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                if (Agregar == true)
                {
                    Nuevo();
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Editar == true)
                {
                    Modificar();
                    ModoNormal();
                    Desactivar();
                }
                else
                {
                    Editar = true;
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Agregar == true || Editar == true)
                {
                    Limpiar();
                    ModoNormal();
                    Desactivar();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Se ha producido un error");
            }
        }
    }
}
