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
            }
            catch (Exception ouch)
            {
                MessageBox.Show(ouch.Message, "Ha ocurrido algo inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de nuestro hermoso sitema?", "¿Realmente me traicionas así?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
