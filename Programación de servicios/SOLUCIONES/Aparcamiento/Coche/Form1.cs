using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
namespace Coche
{
    public partial class Form1 : Form
    {
        Semaphore s;
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);
         [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam,IntPtr lparam);
        int idmensajeAP;
        int idmensajeEX;
        public Form1()
        {
            InitializeComponent();
            s = Semaphore.OpenExisting("semaforo_aparcar");
           idmensajeAP = RegisterWindowMessage("WM_APARCAR");
           idmensajeEX = RegisterWindowMessage("WM_SALIR");
           button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            button1.Enabled = false;
            button2.Enabled = true;
            s.WaitOne();
            PostMessage((IntPtr)0Xffff, idmensajeAP, IntPtr.Zero, IntPtr.Zero);

        }

        private void button2_Click(object sender, EventArgs e)
        {   
           Int32 its=s.Release();
          PostMessage((IntPtr)0Xffff, idmensajeEX, IntPtr.Zero, IntPtr.Zero);
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
