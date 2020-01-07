using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploHilos1
{
    class temporizador
    {
        public TextBox txtSalida { get; }
        public int valor { get; }

        public void countdown() {
            int i;
            DateTime inicio = DateTime.Now;
            txtSalida.Text = valor.ToString();
            for (i = valor; i >= 0; i--)
            {
                if ((DateTime.Now - inicio).TotalSeconds == 1)
                {
                    txtSalida.Text = i.ToString();
                    inicio = DateTime.Now;
                }
            }
        }

        public temporizador(TextBox txt, int seg) {
            txtSalida = txt;
            valor = seg;
        }
    }
}
