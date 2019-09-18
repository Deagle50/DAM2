using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbrirArchivo
{
    public partial class AbrirArchivo : Form
    {
        string ruta;
        public AbrirArchivo()
        {
            InitializeComponent();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
                OpenFileDialog dialogo = new OpenFileDialog();
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                   dialogo.
                }
        }
    }
}
