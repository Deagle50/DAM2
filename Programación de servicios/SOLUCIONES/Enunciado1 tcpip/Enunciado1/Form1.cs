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
namespace Enunciado1
{
    public partial class Form1 : Form
    {
        Cliente cli;
        public Form1()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //abre una conexión al servidor cuya IP sea la introducida en Servidor y por el puerto introducido en Puerto.'
            cli = new Cliente(txtIp.Text, int.Parse(txtSocket.Text));
            cli.Conectar();
            cli.OnDatosRecibidos += Cli_OnDatosRecibidos;
        }

        private void Cli_OnDatosRecibidos(string datos)
        {//•	Evento datos recibidos: al recibir datos del servidor simplemente se mostrarán en un msgbox. 
            //Dichos datos serán la respuesta a los datos enviados.
            MessageBox.Show(datos);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //•	Enviar: Al pulsar enviar se enviará al servidor la palabra introducida en la caja de texto.
            cli.EnviarDatos(txtPalabra.Text);
        }

        private void CmbComando_SelectedIndexChanged(object sender, EventArgs e)
        {
           /*Existen 3 comandos posibles: CONT?, CADENA?  y RESET?. Los comandos se enviarán al elegir un elemento de la lista y sucederá lo siguiente:
                o	Al enviar CONT?: el servidor nos devolverá cuántas palabras hemos enviado.
                o	 al elegir CADENA? el servidor nos devolverá la concatenación de las palabras  enviadas.
                o	 y al pulsar RESET? el servidor pondrá a 0  el contador y a vacío la concatenación de las palabras enviadas.
            */
            if (cmbComando.Text.CompareTo("")!=0)
            {
                cli.EnviarDatos(cmbComando.Text);
            }
        }
    }
}
