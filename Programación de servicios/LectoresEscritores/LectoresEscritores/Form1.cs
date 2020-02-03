using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectoresEscritores
{
    public enum Estado { running, cancelling, canceled}
    public partial class Form1 : Form
    {
        
        Pizarra pizarra = new Pizarra(10);
        public Form1()
        {
            InitializeComponent();
        }
    }
}
