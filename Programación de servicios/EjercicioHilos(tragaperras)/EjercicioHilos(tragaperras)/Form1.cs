using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace EjercicioHilos_tragaperras_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void TbPalanca_ValueChanged(object sender, EventArgs e)
        {
            if (tbPalanca.Value == 0)
            {
                cambiarEstadoBTN(1);
                cambiarEstadoBTN(2);
                cambiarEstadoBTN(3);
                lanzarPalanca();
            }
        }

        private void lanzarPalanca()
        {
            Thread t1 = new Thread(cambiarImagen1);
            t1.Start();
            Thread t2 = new Thread(cambiarImagen2);
            t2.Start();
            Thread t3 = new Thread(cambiarImagen3);
            t3.Start();
            //cambiarImagen();
        }

        private void cambiarImagen1()
        {
            bool parar=false;
            
            int max = 10000;
            Random r2 = new Random();
            int tiempoaesperar = r2.Next(100, 300);
            int numimagen = r2.Next(0, 8);
            while (!parar)
            {
                DateTime ahora = DateTime.Now;
                pbx1.Image = listaImg.Images[numimagen];
                
                if (numimagen == 8)
                {
                    numimagen = 0;
                }

                //Esperar X tiempo para no cambiar todo el rato
                while ((DateTime.Now - ahora).TotalMilliseconds <= tiempoaesperar)
                {}
                tiempoaesperar += r2.Next(10, 15);
                max -= 20;
                numimagen++;

                int i = r2.Next(1, 10000);
                if (i > max)
                {
                    parar = true;
                    cambiarEstadoBTN(1);
                }
            }
        }

        private void cambiarImagen2()
        {
            bool parar = false;
            
            int max = 10000;
            Random r2 = new Random();
            int tiempoaesperar = r2.Next(100, 300);
            int numimagen = r2.Next(0, 8);
            while (!parar)
            {
                DateTime ahora = DateTime.Now;

                //pbx1.Image = listaImg.Images[numimagen];
                pbx2.Image = listaImg.Images[numimagen];
                //pbx3.Image = listaImg.Images[numimagen];

                
                int i = r2.Next(1, 10000);
                if (i > max)
                {
                    parar = true;
                    cambiarEstadoBTN(2);
                }
                if(numimagen==8)
                {
                    numimagen = 0;
                }


                while ((DateTime.Now - ahora).TotalMilliseconds <= tiempoaesperar)
                { }
                tiempoaesperar += r2.Next(10, 15);
                max -= 20;
                numimagen++;
            }
        }
        private void cambiarImagen3()
        {
            bool parar = false;
            
            int max = 10000;
            Random r2 = new Random();
            int tiempoaesperar = r2.Next(100,300);
            int numimagen = r2.Next(0, 8);
            while (!parar)
            {
                DateTime ahora = DateTime.Now;

                //pbx1.Image = listaImg.Images[numimagen];
                //pbx2.Image = listaImg.Images[numimagen];
                pbx3.Image = listaImg.Images[numimagen];

                Random r = new Random();
                int i = r.Next(1, 10000);
                //Parar
                
                if (numimagen == 8)
                {
                    numimagen = 0;
                }


                while ((DateTime.Now - ahora).TotalMilliseconds <= tiempoaesperar)
                { }
                tiempoaesperar += r2.Next(10,15);
                max -= 20;
                numimagen++;

                if (i > max)
                {
                    parar = true;
                    cambiarEstadoBTN(3);
                }
            }
        }
        private void cambiarEstadoBTN(int i)
        {
            switch (i)
            {
                case 1:
                    {
                        if (btnParar1.Enabled == false)
                        {
                            btnParar1.Enabled = true;
                        }
                        else
                        {
                            btnParar1.Enabled = false;
                        }
                        break;
                    }
                case 2:
                    {
                        if (btnParar2.Enabled == false)
                        {
                            btnParar2.Enabled = true;
                        }
                        else
                        {
                            btnParar2.Enabled = false;
                        }
                        break;
                    }
                case 3:
                    {
                        if (btnParar3.Enabled == false)
                        {
                            btnParar3.Enabled = true;
                        }
                        else
                        {
                            btnParar3.Enabled = false;
                        }
                        break;
                    }
            }
        }
    }
}
