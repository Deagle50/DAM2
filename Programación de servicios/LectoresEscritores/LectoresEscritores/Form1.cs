using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectoresEscritores
{
    public enum Estado { running, cancelling, canceled}
    public partial class Form1 : Form
    {
        
        Pizarra pizarra = new Pizarra(10);
        private int tam=10;
        Escritor escritor;

        public Form1()
        {
            escritor = new Escritor(pizarra);
            escritor.Start();
            LlenarLista();
        }

        private void LlenarLista()
        {
            for (int i = 0; i < tam; i++)
            {

            }
        }

        private void BtnEscribir_Click(object sender, EventArgs e)
        {
            escritor.hayDato(int.Parse(txtContenido.Text), int.Parse(txtPosicion.Text));
        }
    }
}
