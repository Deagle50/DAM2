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

namespace EjemploHilo2
{
    public partial class Form1 : Form
    {
        Estado est;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            btnStart.Tag = 0;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (int.Parse(btnStart.Tag.ToString()) == 0)
            {
                ThreadStart ts = new ThreadStart(progress);
                Thread t = new Thread(ts);
                est = Estado.activo;
                t.Start();
                btnStart.Tag = 1;
                btnStart.Text = "Stop";
            }
            else if (int.Parse(btnStart.Tag.ToString()) == 1)
            {
                est = Estado.cancelando;
                while (true)
                {
                    try
                    {

                    }
                    catch
                    {

                    }
                }
            }
        }

        private void progress() {
            DateTime t = DateTime.Now;
            while (proBarChrono.Value < proBarChrono.Maximum&&est != Estado.inactivo)
            {
                if (est == Estado.cancelando)
                    break;
                if ((DateTime.Now - t).TotalSeconds >= 1)
                {
                    proBarChrono.Value++;
                    t = DateTime.Now;
                }
                est = Estado.inactivo;
                btnStart.Enabled = true;
                btnStart.Text = "Start";
            }
        }
    }

    public enum Estado {
    activo, inactivo, cancelando
    }
}
