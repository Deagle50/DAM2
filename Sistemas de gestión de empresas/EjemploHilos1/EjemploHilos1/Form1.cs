using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EjemploHilos1
{
    public partial class Form1 : Form
    {
        Thread t1, t2;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void BtnStart2_Click(object sender, EventArgs e)
        {
            temporizador tmp = new temporizador(textBox2, int.Parse(textBox2.Text));
            ThreadStart ts = new ThreadStart(tmp.countdown);

            t2 = new Thread(ts);
            t2.Start();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            temporizador tmp = new temporizador(textBox1, int.Parse(textBox1.Text));
            ThreadStart ts = new ThreadStart(tmp.countdown);

            t1 = new Thread(ts);
            t1.Start();
        }
    }
}
