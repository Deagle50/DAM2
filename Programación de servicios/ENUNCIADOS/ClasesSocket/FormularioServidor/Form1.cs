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
namespace FormularioServidor
{
    public delegate void CambiarLista(ListView l, String s);
    public partial class Form1 : Form
    {
        Servidor s=new Servidor(5555,"192.168.37.150");
        public Form1()
        {
            InitializeComponent();
            s.OnNuevaConexion += AlConectar;
            s.OnDatosRecibidos += AlRecibirDatos;
        }

        private void AlRecibirDatos(string datos, int pos)
        {
            s.EnviarDatos(datos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Start();
        }

        private void AlConectar( string h,int i)
        {
            CambiarLista f=FCambiarLista;
            listView1.BeginInvoke(f, new object[] { listView1, h });
        }

       private void FCambiarLista(ListView l, String s)
        {
            l.Items.Add(s).SubItems.Add(DateTime.Now.ToString()); ;
        }
    }
}
