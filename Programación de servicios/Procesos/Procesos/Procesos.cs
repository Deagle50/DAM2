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


namespace Procesos
{
    public partial class frmProcess : Form
    {
        Process []procesos;
        int i;

        public frmProcess()
        {
            InitializeComponent();
        }

        private void BtnKill_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

        }
        private void LlenarProcesos()
        {
            procesos = Process.GetProcesses();
            lstProcesos.Items.Clear();
            int index;
            for (index = 0; index < procesos.Length && index < lstProcesos.Items.Count; index++)
            {

            }
        }

        public frmProcess()
        {
            InitializeComponent();
        }

        private void lstProcesos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                i = lstProcesos.SelectedIndex;
                String[] mensajes = {String.Format("Nombre de proceso:{0}\n", procesos[i].ProcessName),
String.Format("PID:{0}\n", procesos[i].Id),
String.Format("Prioridad: {0}\n", procesos[i].BasePriority),
String.Format("Uso de Memoria:{0}\n", procesos[i].WorkingSet64),
String.Format("Tiempo de CPU:{0}\n",procesos[i].TotalProcessorTime),
String.Format("Módulo principal:{0}\n",procesos[i].MainModule.FileName)};
                txtInfo.Lines = mensajes;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        private void frmProcess_Load(object sender, EventArgs e)
        {
            LlenarProcesos();
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
