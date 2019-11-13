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
using System.IO.Pipes;
using System.IO;

namespace Pipería_ProyectoChat_
{
    public partial class frmPrincipal : Form
    {
        NamedPipeServerStream npss;
        Process pauricular, pmicrofono;
        ProcessStartInfo psiAuricular, psiMicrofono;
        StreamReader sr;
        StreamWriter sw;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            npss = new NamedPipeServerStream("server", PipeDirection.Out);
            npss.WaitForConnection();

        }
    }
}
