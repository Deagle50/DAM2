using System;
using System.IO;

namespace Acceso_a_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2;

            //Validar que exista el fichero
            using(StreamReader sr=new StreamReader("fichero.txt"))
            {
                if(!File.Exists("fichero.txt"))
                    {
                        Console.WriteLine("El fichero no existe");
                        File.Create("fichero.txt");
                    }
            }
             do{//Pedir número y validar que sea 0, 1 o 2
                Console.WriteLine("Escribe el número 1 para seleccionar escribir tabla, o 2 para seleccionar leer tabla, 0 para salir");
                num=Int32.Parse(Console.ReadLine());
                if(num!=0&&num!=1&&num!=2)
                    Console.WriteLine("Error, escribe un 0, 1 o 2");
                else
                    if(num==1)//Si escogen opción 1
                    {
                        do{//Pedir número y validar que sea positivo
                            Console.WriteLine("Escribe el número (0 para salir)");
                            num2=Int32.Parse(Console.ReadLine());
                            if(num2<0)
                                Console.WriteLine("Error, escribe un número positivo");
                        }while(num2<0);

                        while(num2!=0)
                        {//Hacer ejercicio mientras no metan 0              
                

                            using(StreamWriter sw=new StreamWriter("fichero.txt", true)) 
                            {
                                for(int i=1;i<=10;i++)
                                {
                                    Console.WriteLine("{0}*{1}={2}", num2, i,i*num2);                                        
                                    sw.WriteLine("{0}*{1}={2}", num2, i,i*num2);                    
                                }
                            sw.WriteLine("=========");//Línea separadora en archivo
                            }

                            do{//Pedir número y validar que sea positivo
                                Console.WriteLine("Escribe el número (0 para salir)");
                                num2=Int32.Parse(Console.ReadLine());
                            }while(num2<0);   
                        }
            

                    }
                    if(num==2)//Si escogen opción 2
                    {
                         string linea;
            
                        using (StreamReader sr=new StreamReader("fichero2.txt"))
                        {
                            if(!File.Exists("fichero2.txt"))
                            {
                                Console.WriteLine("El fichero no existe");
                            }
                            else
                                while((linea=sr.ReadLine())!=null)
                                {            
                                    string[] aux = linea.Split(separator:",");
                                    for(var i=0;i<aux.Length;i+=3)
                                    {
                                    Console.WriteLine("{0}*{1}={2}",aux[i],aux[i+1],aux[i+2]);
                                    }    
                                }
                        }

                    }
            }while(num!=0);


            
           
            //FIN
            Console.WriteLine("Fin del programa");
        }
    }
}
