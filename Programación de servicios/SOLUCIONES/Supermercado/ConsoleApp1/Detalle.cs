using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Detalle
    {
        private int Id;
        private int Ud;
        public Detalle(int i,int u)
        {
            Id = i;
            Ud = u;
        }
        public void setId(int i)
        {
            Id = i;
        }
        public void setUd(int u)
        {
            Ud = u;
        }
        public int getId()
        {
            return Id;
        }
        public int getUd()
        {
            return Ud;
        }
    }
}
