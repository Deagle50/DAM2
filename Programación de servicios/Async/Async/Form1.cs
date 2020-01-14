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

namespace Async
{
    public partial class Form1 : Form
    {
        public delegate void CallbackDelegate();
        public delegate void FuncionDelegate();
        public delegate void ModificarTexto(String text);
        String[] numeros = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez" };

        private IEnumerable<String> Pares() {
            for (int i = 0; i < 5; i++)
            {
                yield return numeros[i * 2];
            }
        }

        private IEnumerable<String> Impares()
        {
            for (int i = 0; i < 5; i++)
            {
                yield return numeros[i * 2 + 1];
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDale1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(funcion1);
            FuncionDelegate fd = callback1;
            t.Start(fd);
        }

        

        private void BtnDale2_Click(object sender, EventArgs e)
        {
            FuncionDelegate fd = funcion2;
            fd.BeginInvoke(callback, null);
            
        }

        private async void BtnDale3_Click(object sender, EventArgs e)
        {
            txtLog.Text = await Task<String>.Run(funcion3);
            funcion3();
        }
        private void BtnNums_Click(object sender, EventArgs e)
        {
            lbxNumeros.DataSource = Pares().ToList();
        }

        private void BtnImpares_Click(object sender, EventArgs e)
        {
            lbxNumeros.DataSource = Impares().ToList();
        }

        private void funcion1(Object callback)
        {
            DateTime ahora = DateTime.Now;
            ModificarTexto f = modificar;
            txtLog.BeginInvoke(f, "comenzó");

            while ((DateTime.Now - ahora).TotalSeconds <= 10)
            {}
            FuncionDelegate fd = (FuncionDelegate)callback;
            fd();
        }

        private void funcion2(){
            DateTime ahora = DateTime.Now;
            ModificarTexto f = modificar;
            txtLog.BeginInvoke(f, "comenzó");
            
            while ((DateTime.Now - ahora).TotalSeconds <= 10)
            {}
        }

        private string funcion3()
        {
            DateTime ahora = DateTime.Now;
            ModificarTexto f = modificar;
            txtLog.BeginInvoke(f, "comenzó");

            while ((DateTime.Now-ahora).TotalSeconds<=10)
            {}            
            return "Terminó";
        }
        private void callback(IAsyncResult ar)
        {
            ModificarTexto f = modificar;
            txtLog.BeginInvoke(f, "terminó");
        }
        private void callback1()
        {
            ModificarTexto f = modificar;
            txtLog.BeginInvoke(f, "terminó");
        }

        private void modificar(String texto)
        {
            txtLog.Text = texto;
        }

    }
}
