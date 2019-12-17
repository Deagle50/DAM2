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
using System.Runtime.InteropServices;

namespace PipesRepaso1
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);
        [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam, IntPtr lparam);

        NamedPipeClientStream npcsForm;
        StreamReader srF;

        IntPtr hwnd;

        int idMensajeInfo;

        public Form1()
        {
            idMensajeInfo = RegisterWindowMessage("WM_INFO");
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {            
            npcsForm = new NamedPipeClientStream(".", "serverForm", PipeDirection.In);
            srF = new StreamReader(npcsForm);

            

            Process.Start("..\\..\\..\\Servidor\\bin\\debug\\Servidor.exe");
            Process.Start("..\\..\\..\\Cliente\\bin\\debug\\Cliente.exe");
            npcsForm.Connect();
            //npss.WaitForConnection();
        }

        protected override void WndProc(ref Message m)
        {
            if(m.Msg==idMensajeInfo)
            {
                string nombre = srF.ReadLine();
                int caracteres = int.Parse(srF.ReadLine());
                float media = float.Parse(srF.ReadLine());
                txtCaracteres.Text = caracteres.ToString();
                txtNombre.Text = nombre.ToString();
                txtMedia.Text = media.ToString();
            }
            base.WndProc(ref m);
        }
    }
}
