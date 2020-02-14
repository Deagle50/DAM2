using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesSocket
{
    class ProcesarBytes
    {
        public  static string EncodeBytes(byte[] buff)
        {
            char []caracteres=Encoding.ASCII.GetChars(buff);
            String cadena = "";
            for (int i=0;caracteres[i]!='\0';i++)
            {
                cadena += caracteres[i];
            }
             return cadena;
        }

        public static byte[] DecodeByte(String s)
        {
            return Encoding.ASCII.GetBytes(s);
        }
    }
}
