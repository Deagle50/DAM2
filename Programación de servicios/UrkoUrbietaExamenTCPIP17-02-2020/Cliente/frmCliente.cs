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

namespace Cliente
{
    public delegate void MostrarLista(ListView listView, String data);
    public partial class frmCliente : Form
    {
        int bufferSize = 5;
        ClasesSocket.Cliente cliente;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void ButtonConectar_Click(object sender, EventArgs e)
        {
            cliente = new ClasesSocket.Cliente(textBoxIP.Text.ToString(), int.Parse(textBoxSocket.Text), bufferSize);
            cliente.OnBufferLleno += comprobarBuffer;
            cliente.OnDatosRecibidos += datosRecibidos;
            cliente.Conectar();
        }

        private void datosRecibidos(string datos)
        {
            String[] datosrecibidos = datos.Split(';');
            float total = float.Parse(datosrecibidos[0]) * 100 / float.Parse(datosrecibidos[1]);
            MessageBox.Show("Palabras enviadas por el cliente: " + total.ToString() + " %");
        }

        private void comprobarBuffer()
        {
            //Vaciar listview al llenar buffer
            listViewDatos.Items.Clear();
        }

        private void ButtonEnviar_Click(object sender, EventArgs e)
        {            
            bufferSize--;
            labelCantidad.Text = "Quedan " + bufferSize.ToString() + "palabras para llenar el buffer";
            String palabra = textBoxPalabra.Text.ToString();
            cliente.EnviarDatos(palabra);
            MostrarLista mostrarLista = comprobarLista;
            listViewDatos.BeginInvoke(mostrarLista, new object[] { listViewDatos });
        }

        private void comprobarLista(ListView listView, string data)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.ToString().CompareTo(data) != 0)
                {
                    listView.Items.Add(data);
                }
            }
            
        }
    }
}
