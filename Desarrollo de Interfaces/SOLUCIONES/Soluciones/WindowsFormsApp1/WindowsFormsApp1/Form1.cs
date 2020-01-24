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
namespace WindowsFormsApp1
{
    public delegate void CallbackDelegate();
    public delegate void FuncionDelegate();
    public delegate void ModificaTextbox(String text);
    public partial class Form1 : Form
    {
        String[] numeros = { "cero","uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };

        private IEnumerable<String> Pares()
        {
            for (int i = 0; i < 5; i++)
                yield return numeros[i * 2];
        }
        private IEnumerable<String> Impares()
        {
            for (int i = 0; i < 5; i++)
                yield return numeros[i * 2+1];
        }
        public Form1()
        {
            InitializeComponent();
            button3.Click += async (s, e) =>
                                  {
                                      textBox1.Text = await Task<String>.Run(funcion3);
                                  };
            button4.Click += (s, e) =>
                                  {
                                      listBox1.DataSource = Pares().ToList();
                                  };
            button5.Click += (s, e) =>
                                     {
                                         listBox1.DataSource = Impares().ToList();
                                     };
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Thread ts = new Thread(funcion1);
            FuncionDelegate fd = () =>
            {
                ModificaTextbox f = modificar;
                textBox1.BeginInvoke(f, new string[] { "Terminó" });
            };
            ts.Start(fd);

        }

        private String funcion3()
        {
            ModificaTextbox f = modificar;
            textBox1.BeginInvoke(f, new String[] { "Modificar" });
            DateTime ahora = DateTime.Now;
            while ((DateTime.Now - ahora).TotalSeconds <= 10)
            {
                if((DateTime.Now - ahora).TotalSeconds>=1)
                {
                    ModificaTextbox mt = (x) => { textBox2.Text = x; };
                    textBox2.BeginInvoke(mt, DateTime.Now.ToLongTimeString());
                    ahora = DateTime.Now;
                }
            }
            return "Terminó";

        }

        private void funcion1(Object callback)
        {
            ModificaTextbox f = modificar;
            textBox1.BeginInvoke(f, new String[] { "Empezó" });
            DateTime ahora = DateTime.Now;
            while ((DateTime.Now - ahora).TotalSeconds <= 10) ;
            ((FuncionDelegate)callback)();
        }

        private void funcion2()
        {
            ModificaTextbox f = modificar;
            textBox1.BeginInvoke(f, new String[] { "Comenzó" });
            DateTime ahora = DateTime.Now;
            while ((DateTime.Now - ahora).TotalSeconds <= 10) ;


        }

        private void modificar(string text)
        {
            textBox1.Text = text;
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            FuncionDelegate fd = funcion2;
            fd.BeginInvoke((ar) =>
            {
                ModificaTextbox f = modificar;
                textBox1.BeginInvoke(f, new string[] { "Terminó" });
            }, null);
        }

       
    }


    }
