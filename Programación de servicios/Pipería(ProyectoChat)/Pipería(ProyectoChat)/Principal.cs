using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Pipes;
using System.IO;

namespace Pipería_ProyectoChat_
{
    public partial class frmPrincipal : Form
    {
        NamedPipeServerStream npss;
        Process pauricular, pmicrofono;
        ProcessStartInfo psiAuricular, psiMicrofono;
        StreamReader sr;
        StreamWriter sw;

        public frmPrincipal()
        {
            InitializeComponent();

            npss = new NamedPipeServerStream("server", PipeDirection.Out);
            //sr = new StreamReader(npss);
            //sw = new StreamWriter(npss);
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            btnEnviar.Enabled = false;            
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            string texto;

            sw = new StreamWriter(npss);            
            texto = txtMensaje.Text.ToString();

            sw.WriteLine(texto);
        }

        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            npss.Close();

            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            btnEnviar.Enabled = false;

            pmicrofono.Kill();
        }




        private void BtnConectar_Click(object sender, EventArgs e)
        {
            btnDesconectar.Enabled = true;
            btnEnviar.Enabled = true;
            btnConectar.Enabled = false;
            
            pauricular = new Process();
            pmicrofono = new Process();
            psiMicrofono = new ProcessStartInfo();
            psiAuricular = new ProcessStartInfo();

            //npss.WaitForConnection();

            psiAuricular.FileName = "..\\..\\..\\Auricular\\bin\\debug\\Auricular.exe";
            psiMicrofono.FileName = "..\\..\\..\\Microfono\\bin\\debug\\Microfono.exe";
            
            pauricular.StartInfo = psiAuricular;
            pmicrofono.StartInfo = psiMicrofono;

            //pauricular.Start();
            pmicrofono.Start();

            
        }
    }
}
