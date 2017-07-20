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
    public partial class Form1 : Form
    {
        SQL sql = new SQL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_usuario.Text.Equals("") || txt_pass.Text.Equals(""))
                {
                    MessageBox.Show("Ingresa los datos solicitados", "Las prisas no son buenas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlDataReader usuario = sql.consulta("SELECT * FROM Usuario WHERE Nick ='" + txt_usuario.Text + "'");
                    if (usuario.Read())
                    {
                        if (usuario[2].ToString().Equals(txt_pass.Text))
                        {
                            Usuario.setNick(txt_usuario.Text);
                            Util.setF1(this);
                            MenuCentral mc = new MenuCentral();
                            mc.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta, por favor intenta nuevamente", "Uuuuh, ahora tienes un problema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no se encuentra regristrado", "¿Quizá lo escribiste mal?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ouch)
            {
                MessageBox.Show(ouch.Message, "Ha ocurrido algo inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
