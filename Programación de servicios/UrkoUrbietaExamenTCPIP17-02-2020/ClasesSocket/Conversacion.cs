using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClasesSocket
{
    class Conversacion
    {
        public Socket puerto
        {
            get;set;
        }

       public  Thread proceso
        {
            get;set;
        }

        public Boolean cerrado
        {
            get;set;
        }
        public void Cerrar()
        {
            puerto.Close();
            while(true)
            {
                try
                {
                    proceso.Join();
                    break;
                }
                catch(Exception ex)
                {

                }
            }
        }
    }
}
