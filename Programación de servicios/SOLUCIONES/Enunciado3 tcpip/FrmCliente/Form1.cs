using ClasesSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCliente
{
    public delegate void ActualizarLista(ListView lv, String datos);
    public partial class Form1 : Form
    {
        Cliente cli;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //b.	Al pulsar enviar envíe el nombre al servidor.
            cli.EnviarDatos(txtNombre.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //a.	Al pulsar conectar instancie el cliente modificado en 1 y conecte con el servidor.
            cli = new Cliente(txtHost.Text);
            cli.Conectar();
            cli.OnDatosRecibidos += Cli_OnDatosRecibidos;
        }

        private void Cli_OnDatosRecibidos(string datos)
        {
            /*
            c.	Programar el evento necesario para que al recibir un dato:
            •	Lo divida mediante la función Split para extraer la ip y el nombre que han llegado.
            •	Busque en la listview si ya hay un nombre para esa ip:
            •	Si la ip ya está añadida, cambiará el nombre existente por el recibido.
            •	Si no añadirá un ítem nuevo con la ip y el nombre recibidos.
*/
            ActualizarLista f = MostrarDatosLista;
            listView1.BeginInvoke(f, new object[] { listView1, datos });
        }

        private void MostrarDatosLista(ListView lv, String datos)
        {
            String []datosrecibidos = datos.Split(new char[] {';'});
            foreach(ListViewItem it in lv.Items)
            {
                if (it.Text.CompareTo(datosrecibidos[0])==0)
                {
                    it.SubItems[1].Text = datosrecibidos[1];
                    return;
                }
            }
            lv.Items.Add(datosrecibidos[0]).SubItems.Add(datosrecibidos[1]);
        }
    }
}
