using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LectoresEscritores
{
    class Pizarra
    {
        int[] coleccion;
        int lectores = 0;

        public Pizarra(int max)
        {
            coleccion = new int[max];
        }

        public void escribir(int valor, int pos){
            coleccion[pos] = valor;
        }

        public int leer(int pos)
        {
            return coleccion[pos];
        }

        public void obtenerExclusivo(){
            lock(this)
            {
                while (lectores != 0)
                {
                    Monitor.Wait(this);
                }
                lectores--;
            }
        }

        public void liberarExclusivo() {
            lock (this)
            {
                lectores++;
                Monitor.PulseAll(this);
            }
        }

        public void obtenerCompartido() {
            lock (this) {
                while (lectores < 0)
                    Monitor.Wait(this);
                lectores++;
            }
        }

        public void liberarCompartido(){
            lock (this)
            {
                lectores--;
                if (lectores == 0)
                    Monitor.PulseAll(this);
            }
        }
    }
}
