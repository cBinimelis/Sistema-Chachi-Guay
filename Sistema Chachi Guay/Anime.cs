using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Chachi_Guay
{
    public partial class Anime : Form
    {
        SQL sql = new SQL();
        OpenFileDialog op = new OpenFileDialog();
        public Anime()
        {
            InitializeComponent();
        }

        private void Anime_Load(object sender, EventArgs e)
        {

        }

        //Variables
        int IdAnime = 0;
        int IdUsuario = 0;
        bool Agregar = false;
        bool Editar = false;
        MemoryStream ms = new MemoryStream();
        byte[] MyImg = new byte[0];

        //Esta funcion habilita los elementos para permitir la edicion o ingreso de nuevos datos
        private void Activar()
        {
            txt_nombre.Enabled = true;
            txt_sinopsis.Enabled = true;
            date_Lanzamiento.Enabled = true;
            txt_temporadas.Enabled = true;
            txt_capitulos.Enabled = true;
            comboGeneros.Enabled = true;
            txt_generos.Enabled = true;
            comboEstado.Enabled = true;
        }

        private void Desactivar()
        {
            txt_nombre.Enabled = false;
            txt_sinopsis.Enabled = false;
            date_Lanzamiento.Enabled = false;
            txt_temporadas.Enabled = false;
            txt_capitulos.Enabled = false;
            comboGeneros.Enabled = false;
            txt_generos.Enabled = false;
            comboEstado.Enabled = false;
        }

        private void Limpiar()
        {
            IdAnime = 0;
            txt_nombre.Text = "";
            txt_sinopsis.Text = "";
            date_Lanzamiento.Value = System.DateTime.Now;
            txt_temporadas.Text = "";
            txt_capitulos.Text = "";
            comboGeneros.SelectedValue = 0;
            txt_generos.Text = "";
            comboEstado.SelectedValue = 0;
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
            if (txt_nombre.Text.Trim().Equals("") || txt_sinopsis.Text.Trim().Equals("") || txt_temporadas.Text.Trim().Equals(""))
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
                    Image img = pic_imagen.Image;
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                    int Guardar = sql.ejecutar("UPDATE Manga SET" +
                        " Nombre = '" + txt_nombre.Text + "', Sinopsis = '" + txt_sinopsis.Text + "', Lanzamiento = '" + date_Lanzamiento.Value + "', Tomos = '" + txt_temporadas.Text + "' , Imagen = '" + arr + "', id_GeneroManga = '" + (comboGeneros.SelectedIndex + 1) + "', Otros_Generos = '" + txt_generos.Text + "', id_estado = '" + (comboEstado.SelectedIndex + 1) + "'" +
                        "WHERE id_Manga = " + IdAnime);
                    if (Guardar > 0)
                    {
                        MessageBox.Show("Se ha actualizado exitosamente el manga", "Felicidades por el vicio");
                        Editar = false;
                        Limpiar();
                        ModoNormal();
                        Desactivar();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido actualizar el manga", "Se pudrio todo");
                    }
                }
            }
        }

        private void Nuevo()
        {
            if (txt_nombre.Text.Trim().Equals("") || txt_sinopsis.Text.Trim().Equals("") || txt_temporadas.Text.Trim().Equals("") || txt_capitulos.Text.Trim().Equals(""))
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
                        int Guardar = sql.ejecutar("INSERT INTO Anime (Nombre, Sinopsis, Lanzamiento, Tomos, Imagen, id_GeneroManga, Otros_Generos, id_estado, id_Usuario) VALUES " +
                            "('" + txt_nombre.Text + "','" + txt_sinopsis.Text + "','" + date_Lanzamiento.Value + "','" + txt_temporadas.Text + "','" + txt_capitulos.Text + "','" + img + "','" + (comboGeneros.SelectedIndex + 1) + "','" + txt_generos.Text + "','" + (comboEstado.SelectedIndex + 1) + "','" + Usuario.getId() + "')");
                        if (Guardar > 0)
                        {
                            MessageBox.Show("Se ha agregado exitosamente el Anime", "Felicidades por el vicio");
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
                    if (Editar == true)
                    {
                        Modificar();
                    }
                    else
                    {
                        Agregar = true;
                        Limpiar();
                        Activar();
                        ModoAgregar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Se ha producido un problema");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Editar = true;
            Activar();
            ModoAgregar();
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
