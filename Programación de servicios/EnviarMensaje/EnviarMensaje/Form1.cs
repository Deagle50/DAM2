using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;
using Funciones;

namespace EnviarMensaje
{
    public partial class Form1 : Form
    {
        NamedPipeServerStream npss;
        StreamReader sr;
        Process p;
        ProcessStartInfo psi;
        //int WM_MENSAJE;

        public Form1()
        {
            InitializeComponent();
            //WM_MENSAJE = Funciones.Funciones.RegisterWindowMessage("WM_MENSAJE");
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            npss = new NamedPipeServerStream("MensajePipe", PipeDirection.In);            
            sr = new StreamReader(npss);
            p = new Process();
            psi = new ProcessStartInfo();

            psi.FileName = "..\\..\\..\\MensajesHijo\\bin\\debug\\MensajesHijo.exe";
            psi.CreateNoWindow=true;
            p.StartInfo = psi;
            p.Start();

            npss.WaitForConnection();
        }
        /*
        protected override void WndProc(ref Message m)
        {

            /if (m.Msg == WM_MENSAJE)
            {
                String pal = sr.ReadLine();
                if (pal.ToLower().CompareTo("Fin")!=0)
                {
                    lbx.Items.Add(pal);
                }
                else
                {
                    MessageBox.Show("Fin");
                    npss.Close();
                }
            }
            else
            {
                base.WndProc(ref m);
            }

        }*/
    }
}
