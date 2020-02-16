using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesSocket;
namespace Servidor
{
  delegate void CambiarTexto(TextBox t, String c);
    public partial class Form1 : Form
    {
        String pal = "";
        int cont = 0;
        ClasesSocket.Servidor servidor = new ClasesSocket.Servidor(5555, "192.168.37.150");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            servidor.OnDatosRecibidos += AlRecibirDatos;
            servidor.OnServidorOcupado += Servidor_OnServidorOcupado;
            servidor.Start();
        }

        private void Servidor_OnServidorOcupado()
        {
            MessageBox.Show("Servidor ocupado");
        }

        private void AlRecibirDatos(string datos, int pos)
        {
            /*
                   si lo recibido es la palabra “CONT?” enviará un contador donde se lleva la cuenta de todas las cadenas que se han recibido
                	si lo recibido es la palabra “CADENA?” enviará la concatenación de todas las cadenas recibidas hasta el momento de los números recibidos.
                	Si lo recibido es la palabra “RESET?” vaciará la concatenación y pondrá a 0 el contador de datos recibidos.
                	Si lo recibido no es ninguno de los comandos anteriores enviará el mensaje “Cadena concatenada”. Además mostrará en la caja de texto 
                cadena la concatenación de lo recibido hasta el momento y en Contador el contador de cadenas recibidas hasta el momento.
            */
            switch (datos)
            {
               case "CONT?":
                    servidor.EnviarDatos(cont.ToString());
                    break;
                case "RESET?":
                    cont = 0;
                    pal = "";
                    break;
                case "CADENA?":
                    servidor.EnviarDatos(pal);
                    break;
                default:
                    pal += datos;
                    cont++;
                    /*Esto no se puede hacer desde un hilo
                    txtCadena.Text = pal;
                    txtContador.Text = cont.ToString();*/
                    CambiarTexto f = FuncionCambiarTexto;
                    txtCadena.BeginInvoke(f, new object[] { txtCadena, pal });
                    txtContador.BeginInvoke(f, new object[] { txtContador, cont.ToString() });
                    break;
            }
        }
        private void FuncionCambiarTexto(TextBox t, String c)
        {
            t.Text = c;
        }
    }
}
