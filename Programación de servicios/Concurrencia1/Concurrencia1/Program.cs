using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Concurrencia1
{
    class Program
    {
        static int x = 0;
        static int limite=1000;
        static void sumaPares() {
            for (int i = 0; i <= limite; i+=2)
            {
                x += i;
            }
        }
        static void sumaImpares() {
            for (int i = 1; i <= limite; i += 2)
            {
                x += i;
            }            
        }
        static void Main(string[] args)
        {
            ThreadStart ts1= new ThreadStart(sumaPares);
            Thread t1 = new Thread(ts1);
            ThreadStart ts2 = new ThreadStart(sumaImpares);
            Thread t2 = new Thread(ts2);
            t1.Start();
            t2.Start();

            /*sumaPares();
            sumaImpares();*/

            Console.WriteLine("El resultado es {0}", x);
            Console.WriteLine("El resultado es {0}", x);
            Console.ReadLine();
        }
    }
}
