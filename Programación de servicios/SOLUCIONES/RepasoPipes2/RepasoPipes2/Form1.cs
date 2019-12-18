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
namespace RepasoPipes2
{
    public partial class Form1 : Form
    { int veces_mayor, veces_menor;
        String STR_WM_MAYOR="WM_MAYOR", STR_WM_MENOR="WM_MENOR", STR_WM_IGUAL="WM_IGUAL";
        int WM_MAYOR, WM_MENOR, WM_IGUAL;
        public Form1()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            if(m.Msg==WM_MAYOR)
            {
                veces_mayor++;
                txtVecesMayor.Text = veces_mayor.ToString();

            }
            else if(m.Msg==WM_MENOR)
            {
                veces_menor++;
                txtVecesMenor.Text = veces_menor.ToString();

            }
            else if(m.Msg==WM_IGUAL)
            {
                MessageBox.Show(String.Format("Acertaste en {0} intentos", 
                    veces_mayor + veces_menor));
                txtVecesMayor.Text = "0";
                txtVecesMayor.Text = "0";
            }
            else
            {
                base.WndProc(ref m);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("..\\..\\..\\Cliente\\bin\\debug\\Cliente.exe");
            Process.Start("..\\..\\..\\Servidor\\bin\\debug\\Servidor.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WM_IGUAL = Funciones.RegisterWindowMessage(STR_WM_IGUAL);
            WM_MAYOR = Funciones.RegisterWindowMessage(STR_WM_MAYOR);
            WM_MENOR = Funciones.RegisterWindowMessage(STR_WM_MENOR);
        }
    }
}
