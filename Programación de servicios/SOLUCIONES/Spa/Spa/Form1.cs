using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensajes;
using System.Diagnostics;
using System.Threading;
namespace Spa
{
    public partial class Form1 : Form
    {
        int MSG_ENTRA, MSG_COGE_TOALLA, MSG_DEJA_TOALLA, MSG_DUCHA_IN, MSG_DUCHA_OUT;
        Semaphore semaforoUsuario;
        Mutex mutexUsuario;

        private void Button2_Click(object sender, EventArgs e)
        {
            Process.Start("..\\..\\..\\Limpieza\\Bin\\debug\\Limpieza.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MSG_ENTRA = Funciones.RegisterWindowMessage("MSG_ENTRA");
            MSG_COGE_TOALLA = Funciones.RegisterWindowMessage("MSG_COGE_TOALLA");
            MSG_DEJA_TOALLA = Funciones.RegisterWindowMessage("MSG_DEJA_TOALLA");
            MSG_DUCHA_IN = Funciones.RegisterWindowMessage("MSG_DUCHA_IN");
            MSG_DUCHA_OUT = Funciones.RegisterWindowMessage("MSG_DUCHA_OUT");
            semaforoUsuario = new Semaphore(3, 3, "semaforoUsuario");
            mutexUsuario = new Mutex(false,"mutexUsuario");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("..\\..\\..\\Usuario\\Bin\\debug\\Usuario.exe");
        }

        protected override void WndProc(ref Message m)
        {
            if(m.Msg==MSG_ENTRA)
            {
                int num = int.Parse(textBox1.Text);
                num++;
                textBox1.Text = num.ToString();
            }
            else if(m.Msg==MSG_DUCHA_OUT)
            {
                checkBox1.Checked = false;
                int num = int.Parse(textBox1.Text);
                num--;
                textBox1.Text = num.ToString();
            }
            else if(m.Msg==MSG_DUCHA_IN)
            {
                checkBox1.Checked = true;
            }
            else if(m.Msg==MSG_COGE_TOALLA)
            {
                listBox1.Items.RemoveAt(0);

            }
            else if(m.Msg==MSG_DEJA_TOALLA)
            {
                listBox1.Items.Add("TOALLA");
            }
            else base.WndProc(ref m);

        }
    }
}
