using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Pipes;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace WindowsFormsApplication1
{   
    public partial class Form1 : Form
    {   List<String> log=new List<String>();
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);
        [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam, IntPtr lparam);

        Semaphore s;

        int idmensajeAP;
        int idmensajeEX;

        public Form1()
        {
          InitializeComponent();
          s = new Semaphore(2, 2, "semaforo_aparcar");
          timer1.Enabled = true;
          idmensajeAP = RegisterWindowMessage("WM_APARCAR");
          idmensajeEX = RegisterWindowMessage("WM_SALIR");
            
        }
        protected override void WndProc(ref Message m)
        {   
            if (m.Msg == idmensajeAP)
            {
                log.Add("Entra coche");
                textBox1.Lines = log.ToArray();
                txtCuantos.Text = (int.Parse(txtCuantos.Text) - 1).ToString();
            }
            else if (m.Msg == idmensajeEX)
            {
                log.Add("Sale coche");
                textBox1.Lines=log.ToArray();
                txtCuantos.Text = (int.Parse(txtCuantos.Text) + 1).ToString();
            }
            else  base.WndProc(ref m);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            s.Close();
            s.Dispose();
         
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath+"\\imagenes\\Rojo.png");
            this.pictureBox1.Refresh();
            timer1.Enabled = false;
            s.WaitOne();
            s.Release();
            timer1.Enabled = true;
            pictureBox1.Image = Image.FromFile("imagenes\\verde.png");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Process p = new Process();
           p.StartInfo.FileName="..\\..\\..\\Coche\\bin\\debug\\coche.exe";
           p.Start();
        }

       
    }
}
