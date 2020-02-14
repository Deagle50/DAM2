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
            srv.SetNombre(pos, datos);
            sw.WriteLine("{0,7}   {1,12}   {2,5}",pos.ToString(), datos, DateTime.Now.ToString());
            srv.EnviarDatos(String.Format("{0};{1}",srv.GetClientIp(pos), datos));
        }

        private void Srv_OnCambiarNombre(string nombre, DateTime Fecha)
        {
            MessageBox.Show(String.Format("{0}:{1}", nombre, Fecha.ToString()));

        }
    }
}
