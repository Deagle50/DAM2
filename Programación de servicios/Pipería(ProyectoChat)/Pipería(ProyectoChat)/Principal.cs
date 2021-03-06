﻿using System;
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

        StreamReader sr;
        StreamWriter sw;
        int WM_MENSAJE;

        public frmPrincipal()
        {
            InitializeComponent();
            WM_MENSAJE = LibreriaFunciones.Funciones.RegisterWindowMessage("Auricular");
            
            //sr = new StreamReader(npss);
            //sw = new StreamWriter(npss);
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            btnEnviar.Enabled = true;            
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            npss = new NamedPipeServerStream("form", PipeDirection.Out);
            
            npss.WaitForConnection();
            sw = new StreamWriter(npss);
            sw.AutoFlush = true;
            string texto;                      
            texto = txtMensaje.Text;
            sw.WriteLine(texto);
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {   
            //Recibir mensaje de auricular
            npss = new NamedPipeServerStream("form2", PipeDirection.In);
            sr = new StreamReader(npss);

            btnDesconectar.Enabled = true;
            btnEnviar.Enabled = true;
            btnConectar.Enabled = false;

            Process.Start("..\\..\\..\\Auricular\\bin\\debug\\Auricular.exe");
            Process.Start("..\\..\\..\\Microfono\\bin\\debug\\Microfono.exe");

            npss.WaitForConnection();
        }

        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            npss.Close();

            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            btnEnviar.Enabled = false;

            //pmicrofono.Kill();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_MENSAJE)
            {
                String pal = sr.ReadLine();
                lbxMensajesRecibidos.Items.Add(pal);
            }
            else
                base.WndProc(ref m);
        }
    }
}
