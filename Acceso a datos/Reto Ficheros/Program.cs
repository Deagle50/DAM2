using System;
using System.IO;

namespace Acceso_a_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            //Validar que exista el fichero
            using(StreamReader sr=new StreamReader("fichero.txt"))
            {
                if(!File.Exists("fichero.txt"))
                    {
                        Console.WriteLine("El fichero no existe");
                        File.Create("fichero.txt");
                    }
            }
            do{//Pedir número y validar que sea positivo
                Console.WriteLine("Escribe el número");
                num=Int32.Parse(Console.ReadLine());
                if(num<0)
                    Console.WriteLine("Error, escribe un número positivo");
            }while(num<0);

            while(num!=0){//Hacer ejercicio mientras no metan 0              
                

                using(StreamWriter sw=new StreamWriter("fichero.txt", true)) 
                {
                    for(int i=1;i<=10;i++)
                    {
                        Console.WriteLine("{0}*{1}={2}", num, i,i*num);                                        
                        sw.WriteLine("{0}*{1}={2}", num, i,i*num);                    
                    }
                sw.WriteLine("=========");//Línea separadora en archivo
                }

             do{//Pedir número y validar que sea positivo
                Console.WriteLine("Escribe el número");
                num=Int32.Parse(Console.ReadLine());
            }while(num<0);   
            }
            
            string linea;
            int x,y,z;
            using (StreamReader sr=new StreamReader("fichero.txt")){
                while((linea=sr.ReadLine())!=null)
                {
                    int x=linea.Split(separator:",");
                    int y=linea.Split(separator:",");
                    int z=linea.Split(separator:",");

                    Console.ReadLine("{0}*{1}={2}", x, y, x*y);
                }
            }

            //FIN
            Console.WriteLine("Fin del programa");
        }
    }
}
