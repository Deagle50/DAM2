using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;

namespace Usuario
{
    class Program
    {
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);
        [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam, IntPtr lparam);
        static void Main(string[] args)
        {
            int idmensajeEntra, idmensajeCogeToalla, idmensajeDejaToalla, idmensajeDuchaIn, idmensajeDuchaOut;
            idmensajeEntra = RegisterWindowMessage("WM_ENTRA");
            idmensajeCogeToalla = RegisterWindowMessage("WM_COGE");
            idmensajeDejaToalla = RegisterWindowMessage("WM_DEJA_TOALLA");
            idmensajeDuchaIn = RegisterWindowMessage("WM_DUCHA_IN");
            idmensajeDuchaOut = RegisterWindowMessage("WM_DUCHA_OUT");

            PostMessage((IntPtr)0Xffff, idmensajeEntra, IntPtr.Zero, IntPtr.Zero);
            PostMessage((IntPtr)0Xffff, idmensajeCogeToalla, IntPtr.Zero, IntPtr.Zero);
            PostMessage((IntPtr)0Xffff, idmensajeDejaToalla, IntPtr.Zero, IntPtr.Zero);
            PostMessage((IntPtr)0Xffff, idmensajeDuchaIn, IntPtr.Zero, IntPtr.Zero);
            PostMessage((IntPtr)0Xffff, idmensajeDuchaOut, IntPtr.Zero, IntPtr.Zero);

            Console.WriteLine("Lorolorololo");
            Console.ReadLine();


        }


    }
}
