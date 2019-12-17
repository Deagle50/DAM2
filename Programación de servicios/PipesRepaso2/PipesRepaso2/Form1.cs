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

namespace PipesRepaso2
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);
        [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam, IntPtr lparam);

        NamedPipeClientStream npcsForm;
        StreamReader srF;

        int mayor=0, menor=0;
        int idMsgMayor, idMsgMenor, idMsgIgual;

        public Form1()
        {
            InitializeComponent();

            txtVMayor.Text = mayor.ToString();
            txtVMenor.Text = menor.ToString();

            idMsgIgual = RegisterWindowMessage("WM_IGUAL");
            idMsgMenor = RegisterWindowMessage("WM_MENOR");
            idMsgMayor = RegisterWindowMessage("WM_MAYOR");


        }

        private void BtnEmpezar_Click(object sender, EventArgs e)
        {
            Process.Start("..\\..\\..\\Servidor\\bin\\debug\\Servidor.exe");
            Process.Start("..\\..\\..\\Cliente\\bin\\debug\\Cliente.exe");

            npcsForm = new NamedPipeClientStream(".", "serverForm", PipeDirection.In);
            npcsForm.Connect();
            srF = new StreamReader(npcsForm);

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == idMsgMayor)
            {
                mayor++;
                txtVMayor.Text = mayor.ToString();
            }
            else if (m.Msg== idMsgMenor)
            {
                menor++;
                txtVMenor.Text = menor.ToString();
            }
            else if (m.Msg== idMsgIgual)
            {
                MessageBox.Show("Se ha intentado {0} veces"+ menor + mayor);
            }
            base.WndProc(ref m);
        }
    }
}
