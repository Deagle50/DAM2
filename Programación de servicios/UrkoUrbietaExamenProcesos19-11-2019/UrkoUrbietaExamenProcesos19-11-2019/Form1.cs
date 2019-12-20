using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;

namespace UrkoUrbietaExamenProcesos19_11_2019
{
    public partial class Form1 : Form
    {
        
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);
        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
        [DllImport("user32")]
        public static extern int FindWindow(String clase, String title);

        NamedPipeServerStream npssTem, npssPro;
        StreamWriter swT;
        StreamReader srP;

        int idMsgEncender, idMsgProgramarEncender;
        int tiempo;

        private void Form1_Load(object sender, EventArgs e)
        {
            npssTem = new NamedPipeServerStream("serverTem", PipeDirection.Out);
            npssPro = new NamedPipeServerStream("serverPro", PipeDirection.In);

            idMsgEncender = RegisterWindowMessage("WM_ENCENDER");
            idMsgProgramarEncender = RegisterWindowMessage("WM_PROGRAMAR_ENCENDER");
        }

        public Form1()
        {
            InitializeComponent();            
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            //Ejecutar programador encender
            Process.Start("..\\..\\..\\ProgramadorEncender\\Bin\\debug\\ProgramadorEncender.exe");
            //Conectar con pipe de Programador Encender
            npssPro.WaitForConnection();
            srP = new StreamReader(npssPro);
        }

        protected override void WndProc(ref Message m)
        {
            DateTimeConverter dtc = new DateTimeConverter();
            //Al recibir mensaje de PROGRAMAR ENCENDER
            if (m.Msg == idMsgProgramarEncender)
            {
                //Recibir tiempo
                tiempo = int.Parse(srP.ReadLine());
                srP.Close();                
                npssPro.Close();
                if (!cbxLuz.Checked)
                {
                    //Añadir tiempo a textbox
                    txtProximoEncendido.Text = DateTime.Now.AddMinutes(tiempo).ToString();
                    //Abrir temporizador
                    Process.Start("..\\..\\..\\TemporizadorEncender\\Bin\\debug\\TemporizadorEncender.exe");

                    //Conectar con temporizador y enviar texto de encendido
                    npssTem.WaitForConnection();
                    swT = new StreamWriter(npssTem);
                    swT.WriteLine(txtProximoEncendido.Text);
                }
                //DESCONECTAR DEL PIPE
                swT.Close();                
                npssTem.Close();
            }
            //Al recibir mensaje de ENCENDER            
            else if (m.Msg == idMsgEncender)
            {
                cbxLuz.Checked = true;

                //Añadir items al LV
                anadirItem();                
            }
            base.WndProc(ref m);
        }

        private void anadirItem() {
            ListViewItem lvItem = new ListViewItem();
            
            lvItem.SubItems.Add(DateTime.Now.ToString());
            lvItem.SubItems.Add("Encender");
            lvFechas.Items.Add(lvItem);
        }
    }
}
