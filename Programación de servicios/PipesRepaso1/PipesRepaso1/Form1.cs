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

namespace PipesRepaso1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            NamedPipeServerStream npss;
            npss = new NamedPipeServerStream("serverform", PipeDirection.Out);

            Process.Start("..\\..\\..\\Servidor\\bin\\debug\\Servidor.exe");
            Process.Start("..\\..\\..\\Cliente\\bin\\debug\\Cliente.exe");

            //npss.WaitForConnection();
        }
    }
}
