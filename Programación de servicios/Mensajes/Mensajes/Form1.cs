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
namespace Mensajes
{
    public partial class Form1 : Form
    {
        int codMensaje;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr h;
            foreach (Process p in Process.GetProcessesByName("notepad"))
            {    h =p.MainWindowHandle;
                Funciones.PostMessage(h, 0x0012, IntPtr.Zero, IntPtr.Zero);
            }

             h= Process.GetCurrentProcess().MainWindowHandle;
            Funciones.PostMessage(h, 0x0012, IntPtr.Zero, IntPtr.Zero);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          // codMensaje= Funciones.RegisterWindowMessage("WM_CERRAR");
        }
    }
}
