using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelado_1_Mi_mercadito
{
    public partial class MiMercadito : Form
    {
        public MiMercadito()
        {
            InitializeComponent();
        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lavavajillasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bebésYNiñosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_escaner_Click(object sender, EventArgs e)
        {
            Form formulario = new Escaner();
            formulario.Show();
        }
    }
}
