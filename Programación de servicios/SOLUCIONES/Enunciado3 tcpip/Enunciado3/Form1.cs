using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesSocket;
namespace Enunciado3
{
    public partial class Form1 : Form
    {
        StreamWriter sw ;
        Servidor srv;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*
             a.	Al pulsar conectar instanciará un objeto de la clase servidor, 
             modificada anteriormente y creará un archivo con la siguiente cabecera:
             */
            sw = new StreamWriter("Salida.txt",true);
            sw.AutoFlush = true;
            sw.WriteLine("{0,7}   {1,12}   {2,5}", "CLIENTE", "NUEVO NOMBRE", "FECHA");
            sw.WriteLine("{0,7}   {1,12}   {2,5}", "=======", "============", "=====");
            
            srv = new Servidor(txtHost.Text);
            srv.OnCambiarNombre += Srv_OnCambiarNombre;
            srv.OnDatosRecibidos += Srv_OnDatosRecibidos;
            srv.Start();
        }

        private void Srv_OnDatosRecibidos(string datos, int pos)
        {
            /*
                a.	Cambie el nombre de la conversación del cliente de la que proceden los datos por la palabra recibida, mediante el método correspondiente.
                b.	Agregue una línea al fichero creado anteriormente y (recordar que hay que hacer flush para que se guarden los datos).
                c.	Reenvíe una cadena formada por la ip del cliente que se ha cambiado el nombre y el nuevo nombre a todas las conversaciones activas. El formato será “ip;nuevonombre”.
            */
            srv.SetNombre(pos, datos);
            sw.WriteLine("{0,7}   {1,12}   {2,5}",pos.ToString(), datos, DateTime.Now.ToString());
            srv.EnviarDatos(String.Format("{0};{1}",srv.GetClientIp(pos), datos));
        }

        private void Srv_OnCambiarNombre(string nombre, DateTime Fecha)
        {

            /*
             * c.	Programar la función asociada al evento OnCambiarNombre para que muestre un msgbox diciendo “[nuevoNombre]:[fechaCambio]”
             */
            MessageBox.Show(String.Format("{0}:{1}", nombre, Fecha.ToString()));

        }
    }
}
