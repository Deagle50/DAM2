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
        public AbrirArchivo()
        {
            InitializeComponent();
        }


        private void TxtSeleccionarArchivo_TextChanged(object sender, EventArgs e)
        {
            string[] lineas; 
            OpenFileDialog dialogo = new OpenFileDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
