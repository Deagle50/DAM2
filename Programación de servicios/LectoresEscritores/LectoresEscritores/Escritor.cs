using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LectoresEscritores
{
    class Escritor
    {
        Estado estado;
        Pizarra pizarra;
        bool Escribir = false;
        int pos, cont;

        public Escritor(Pizarra pizarra)
        {
            this.pizarra = pizarra;
        }

        public void hayDato(int valor, int pos)
        {
            this.pos = pos;
            this.cont = valor;
            Escribir = true;
        }

        public void Start() {
            estado = Estado.running;
            Thread t = new Thread(Run);
            t.Start();
        }

        public void Stop()
        {
            estado = Estado.cancelling;

        }

        public void Run()
        {
            while (estado == Estado.running)
            {
                if (Escribir)
                {
                    pizarra.obtenerExclusivo();
                    pizarra.escribir(cont, pos);
                    pizarra.liberarExclusivo();
                }

            }
            estado = Estado.canceled;
        }
    }
}
