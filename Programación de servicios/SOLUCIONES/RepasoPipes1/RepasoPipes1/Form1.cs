using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensajes;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
namespace RepasoPipes1
{
    public partial class Form1 : Form
    {
        NamedPipeClientStream npcs;
        string STR_WM_INFO = "WM_INFO";
        StreamReader sr;
        int WM_INFO;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("..\\..\\..\\Servidor\\Bin\\debug\\Servidor.exe");
            npcs = new NamedPipeClientStream(".", "srvfrm", PipeDirection.In);
            npcs.Connect();
            sr = new StreamReader(npcs);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WM_INFO = Funciones.RegisterWindowMessage(STR_WM_INFO);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_INFO)
            {
                string nombre = sr.ReadLine();
                int caracteres = int.Parse(sr.ReadLine());
                float longitud = float.Parse(sr.ReadLine());
                txtCaracteres.Text = caracteres.ToString();
                txtLongitud.Text = longitud.ToString();
                txtNombre.Text = nombre;
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
