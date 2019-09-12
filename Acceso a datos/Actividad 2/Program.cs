using System;
using System.IO;

namespace Actividad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;
            using (StreamReader sr = new StreamReader("fichero3.txt")){
                if(!File.Exists("fichero3.txt")){
                    Console.WriteLine("El fichero no existe");
                }else{
                    while((linea = sr.ReadLine()) != null){
                        string[] aux = linea.Split(separator:",");
                        for(var i=0;i<aux.Length;i++){
                            Console.Write(aux[i]);
                            Console.Write(" ");
                        }
                        Console.WriteLine("");
                    }

                }
            }
        }
    }
}
