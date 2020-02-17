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

namespace UrkoUrbietaExamenTCPIP17_02_2020
{
    public delegate void MostrarLista(ListView listView, String datos, int pos);
    public partial class frmServidor : Form
    {
        Servidor servidor;        
        public frmServidor()
        {
            InitializeComponent();
        }

        private void ButtonConectar_Click(object sender, EventArgs e)
        {
            //Instanciar servidor
            servidor = new Servidor(int.Parse(textBoxSocket.Text), textBoxIP.Text.ToString());
            servidor.OnDatosRecibidos += recibirDatos;
            servidor.Start();
        }
        private void recibirDatos(string datos, int pos)
        {
            MostrarLista mostrarLista = funcionMostrarLista;
            listViewDatos.BeginInvoke(mostrarLista, new object[] { listViewDatos, datos, pos});
        }

        private void funcionMostrarLista(ListView listView, string data, int pos)
        {
            int palabras=0, totales=0, cliente = 0;
            //Agregar datos a lista
            listView.Items.Add(pos.ToString()).SubItems.Add(data);
            
            //Calcular cliente con más datos enviados
            foreach (ListViewItem item in listView.Items)
            {
                
            }

            labelCliente.Text = "El cliente que más nombres ha mandado es :" + cliente.ToString();
            //Enviar datos al cliente
            servidor.EnviarDatos(palabras.ToString()+";"+ totales.ToString());
        }
    }
}
