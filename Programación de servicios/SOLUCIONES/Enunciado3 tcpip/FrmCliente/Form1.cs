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
            cli.EnviarDatos(txtNombre.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cli = new Cliente(txtHost.Text);
            cli.Conectar();
            cli.OnDatosRecibidos += Cli_OnDatosRecibidos;
        }

        private void Cli_OnDatosRecibidos(string datos)
        {
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
