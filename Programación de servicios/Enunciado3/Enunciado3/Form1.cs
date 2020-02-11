using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonConectar_Click(object sender, EventArgs e)
        {
            funcionConectar();
            
        }

        private void funcionConectar()
        {
            String ip = TextBoxHost.Text;
            Servidor servidor = new Servidor(ip);

            FileStream fileStream = new FileStream("Fichero.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine("%20s %20s %20s", "Cliente", "Nuevo nombre", "Fecha");
            streamWriter.WriteLine("______________________________________________________________________");

            servidor.OnDatosRecibidos();
        }
    }
}