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
        public int contLV = 3;

        Semaphore sem, semducha;

        List<String> log = new List<String>();
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);        

        [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam, IntPtr lparam);



        public Form1()
        {
            InitializeComponent();
            sem = new Semaphore(3, 3, "semaforo_toalla");
            semducha = new Semaphore(1, 1, "semaforo_ducha");
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
                lvUsuarios.Items.RemoveAt(0);
            }
            else if (m.Msg == idmensajeDejaToalla)
            {                
                log.Add("Deja toalla");             
                lvUsuarios.Items.Add("Toalla");
            }
            else if (m.Msg == idmensajeDuchaIn)
            {
                log.Add("Entra ducha");
                cbxDucha.Checked = true;
            }
            else if (m.Msg == idmensajeDuchaOut)
            {
                log.Add("Sale ducha");
                cbxDucha.Checked = false;
                usuarios--;
                txtUsuarios.Text = usuarios.ToString();
            }
            else base.WndProc(ref m);
        }

        private void Crono_Tick(object sender, EventArgs e)
        {
            crono.Enabled = false;
            sem.WaitOne();
            sem.Release();
            crono.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sem.Close();
            sem.Dispose();
        }
    }
}
