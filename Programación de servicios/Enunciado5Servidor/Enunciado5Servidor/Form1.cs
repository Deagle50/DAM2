using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado5Servidor
{
    public partial class Form1 : Form
    {
        String cadena="";
        int cont=0;
        Servidor servidor = new Servidor(5555, "192.168.37.158");
        public Form1()
        {
            InitializeComponent();
            servidor.OnNuevaConexion += AlConectar;
            servidor.OnDatosRecibidos += AlRecibirDatos;
        }

        private void AlConectar(string h, int i)
        {
            
        }

        private void AlRecibirDatos(string datos, int pos)
        {
            if (datos.Equals("CONT?"))
            {
                servidor.EnviarDatos(txtContador.Text);
            }
            else if (datos.Equals("CADENA?"))
            {

                cadena += datos;
                cont++;
                servidor.EnviarDatos(cadena);

            }
            else if (datos.Equals("RESET?"))
            {
                cadena = "";
                cont = 0;
            }
            else {
                servidor.EnviarDatos("Cadena concatenada");
                txtCadena.Text = cadena;
                txtContador.Text = cont.ToString();
            }
        }
    }

}
