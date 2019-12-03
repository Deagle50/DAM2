using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Pipes;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SpaDeLujo
{
    public partial class Form1 : Form
    {
        int idmensajeEntra, idmensajeCogeToalla, idmensajeDejaToalla, idmensajeDuchaIn, idmensajeDuchaOut;
        
        int usuarios = 0;
        int contLV = 2;

        Semaphore sem;

        List<String> log = new List<String>();
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);
        [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam, IntPtr lparam);        
        

        public Form1()
        {
            InitializeComponent();
            sem = new Semaphore(3, 3, "semaforo_aparcar");
            txtUsuarios.Text = usuarios.ToString();
            crono.Enabled = true;

            idmensajeEntra= RegisterWindowMessage("WM_ENTRA");
            idmensajeCogeToalla = RegisterWindowMessage("WM_COGE");
            idmensajeDejaToalla = RegisterWindowMessage("WM_DEJA_TOALLA");
            idmensajeDuchaIn = RegisterWindowMessage("WM_DUCHA_IN");
            idmensajeDuchaOut = RegisterWindowMessage("WM_DUCHA_OUT");
        }

        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            Process.Start("..\\..\\..\\Usuario\\bin\\debug\\Usuario.exe");
            
        }

        protected override void WndProc(ref Message m)
        {
            tbLog.Lines = log.ToArray();
            if (m.Msg == idmensajeEntra)
            {
                log.Add("Entra usuario");
                //textBox1.Lines = log.ToArray();
                usuarios++;
                txtUsuarios.Text = usuarios.ToString();
            }
            else if (m.Msg == idmensajeCogeToalla)
            {
                log.Add("Coge toalla");
                if (contLV > 0)
                {
                    lvUsuarios.Items.RemoveAt(contLV);
                    contLV--;
                }

            }
            else if (m.Msg == idmensajeDejaToalla)
            {
                log.Add("Deja toalla");
                if (contLV < 3)
                {
                    lvUsuarios.Items.Add("Toalla");
                    contLV++;
                }
            }
            else if (m.Msg == idmensajeDuchaIn)
            {
                log.Add("Entra ducha");

            }
            else if (m.Msg == idmensajeDuchaOut)
            {
                log.Add("Sale ducha");

            }
            else base.WndProc(ref m);
        }
    }
}
