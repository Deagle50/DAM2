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
            switch(datos)
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
