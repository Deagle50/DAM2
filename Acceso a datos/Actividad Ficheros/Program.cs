using System;
using System.IO;

namespace Actividad_Ficheros
{
    class ActividadArchivosResumen
    {
        static void Main(string[] args)
        {
            string linea;
            int num;
            //Pedir número
            do{
            Console.WriteLine("1.\tMostrar\n2.\tModificar\n3.\tBorrar\n4.\tSalir");
            num=Int32.Parse(Console.ReadLine());
            }while(num<0||num>4);

            while(num!=4){
                switch(num){
                    case 1:
                    //COMPROBAR SI EXISTE FICHERO
                        if(File.Exists("fichero.txt"))
                        {
                            using(StreamReader sr=new StreamReader("fichero.txt"))            
                            {
                                while((linea=sr.ReadLine())!=null)
                                {
                                    Console.WriteLine(linea);
                                }
                            }
                        }
                        else{
                            Console.WriteLine("Error 404: Fichero no encontrado");
                        }
                        break;

                    case 2:
                        
                        break;
                    case 3:
                        File.Delete("fichero.txt");
                        Console.WriteLine("Borrado correctamente");
                        break;
                }




            //Pedir número
                do{
            Console.WriteLine("1.\tMostrar\n2.\tModificar\n3.\tBorrar\n4.\tSalir");
            num=Int32.Parse(Console.ReadLine());
            }while(num<0||num>4);

        }

        //FIN
            Console.WriteLine("Fin del programa");

            /*//Comprobar si existe el fichero
            Console.WriteLine(File.Exists("fichero2.txt"));
            //Añadir este texto al fichero
            using(StreamWriter outputFile=new StreamWriter("fichero2.txt", true)){
                outputFile.WriteLine("Linea4");
            }
            Console.WriteLine("App");
            
            using(StreamReader sr=new StreamReader("fichero2.txt"))
            {
                //linea=sr.ReadLine();
                while((linea=sr.ReadLine())!=null){
                    Console.WriteLine(linea);
                }
            }
            

            Console.WriteLine(linea); */
        }
    }
}

