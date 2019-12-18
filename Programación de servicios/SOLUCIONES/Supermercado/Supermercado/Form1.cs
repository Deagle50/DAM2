using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class Form1 : Form
    {
        int msgEntrar, msgSalir, msgPagar;
        Semaphore s = new Semaphore(5, 5, "SemaforoPagar");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msgEntrar = Funciones.FuncionesAPI.RegisterWindowMessage("WM_ENTRAR");
            msgSalir = Funciones.FuncionesAPI.RegisterWindowMessage("WM_SALIR");
            msgPagar = Funciones.FuncionesAPI.RegisterWindowMessage("WM_PAGAR");
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtClientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            s.Close();
            s.Dispose();
        }
        protected override void WndProc(ref Message m)
        {   if (m.Msg==msgEntrar)
            {
                txtClientes.Text = (int.Parse(txtClientes.Text) + 1).ToString();
            }
        else if(m.Msg==msgSalir)
            {
                txtClientes.Text = (int.Parse(txtClientes.Text) -1).ToString();

                if (listBox1.Items.Count!=0)
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
        else if(m.Msg==msgPagar)
            {
                listBox1.Items.Add("Pagando");
            }
         else   base.WndProc(ref m);
        }
    }
}
