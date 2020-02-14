using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesSocket;
namespace Enunciado1
{
    public partial class Form1 : Form
    {
        Cliente cli;
        public Form1()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cli = new Cliente(txtIp.Text, int.Parse(txtSocket.Text));
            cli.Conectar();
            cli.OnDatosRecibidos += Cli_OnDatosRecibidos;
        }

        private void Cli_OnDatosRecibidos(string datos)
        {
            MessageBox.Show(datos);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            cli.EnviarDatos(txtPalabra.Text);
        }

        private void CmbComando_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbComando.Text.CompareTo("")!=0)
            {
                cli.EnviarDatos(cmbComando.Text);
            }
        }
    }
}
