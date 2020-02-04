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
namespace WindowsFormsApp1
{
    public delegate void CambiarLista(ListView l, String s);
    public partial class Form1 : Form
    {
        Cliente c = new Cliente("192.168.37.150", 5555);
        public Form1()
        {
            InitializeComponent();
            c.OnDatosRecibidos += AlRecibirDatos;
        }

        private void AlRecibirDatos(string datos)
        {
            listView1.BeginInvoke(new CambiarLista(AlCambiarLista), new object[] {listView1, datos });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Conectar();
        }
        private void AlCambiarLista(ListView l, String s)
        {
            l.Items.Add(DateTime.Now.ToString()).SubItems.Add(s);
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            c.EnviarDatos(txtMensaje.Text);
        }
    }
}
