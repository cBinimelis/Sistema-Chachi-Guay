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
    }
}
