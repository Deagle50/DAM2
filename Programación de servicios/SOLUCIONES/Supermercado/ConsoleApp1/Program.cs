using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int msgEntrar, msgSalir, msgPagar;
        static IntPtr handle;
        static void Main(string[] args)
        {
            StreamWriter sw;
            SqlConnection cn = new SqlConnection(@"Data Source = SEGUNDO150; Initial Catalog = DaniDB; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("SELECT max(Id) FROM Semaforo.Productos");
            cn.Open();
            cmd.Connection = cn;
            int max = int.Parse(cmd.ExecuteScalar().ToString());
            cn.Close();
            msgEntrar = Funciones.FuncionesAPI.RegisterWindowMessage("WM_ENTRAR");
            msgSalir = Funciones.FuncionesAPI.RegisterWindowMessage("WM_SALIR");
            msgPagar = Funciones.FuncionesAPI.RegisterWindowMessage("WM_PAGAR");
            handle = Process.GetProcessesByName("Supermercado")[0].MainWindowHandle;
            List<Detalle> carrito = new List<Detalle>();
            Random r = new Random(DateTime.Now.Millisecond);
            char resp;
            Funciones.FuncionesAPI.SendMessage(handle, msgEntrar, IntPtr.Zero, IntPtr.Zero);
           
            
            do
            {
                int id, ud;
                id = r.Next(max);
                ud = r.Next(25);
                id++;
                Console.WriteLine("{0} unidades del producto {1}", ud, id);
                
                carrito.Add(new Detalle(id, ud));
                Thread.Sleep(500);
                Console.WriteLine("Desea continuar comprando?");

                if (r.Next(100) % 15 == 0)
                {
                    resp = 'n';
                }
                else
                {
                    resp = 's';
                }
            } while (resp == 's');

            Semaphore s = Semaphore.OpenExisting("SemaforoPagar");
            s.WaitOne();
            Funciones.FuncionesAPI.SendMessage(handle, msgPagar, IntPtr.Zero, IntPtr.Zero);
            sw = new StreamWriter(Process.GetCurrentProcess().Id.ToString());
            Console.WriteLine("{0,8}  {1,8}  {2,6}  {3,7}", "Producto", "Unidades", "Precio", "Importe");
            sw.WriteLine("{0,8}  {1,8}  {2,6}  {3,7}", "Producto", "Unidades", "Precio", "Importe");
            SqlDataAdapter daProductos = new SqlDataAdapter("Select Id, Descripcion,precio from Semaforo.Productos", cn);
            DataSet dsProductos = new DataSet();
            daProductos.Fill(dsProductos);
            dsProductos.Tables[0].PrimaryKey = new DataColumn[] { dsProductos.Tables[0].Columns["Id"] };
            float suma = 0;
            foreach (Detalle d in carrito)
            {
                DataRow fila = dsProductos.Tables[0].Rows.Find(d.getId());
                Console.WriteLine("{0,8}  {1,8}  {2,6}  {3,7}", fila["Descripcion"], d.getUd(), fila["Precio"], d.getUd() * float.Parse(fila["precio"].ToString()));
                sw.WriteLine("{0,8}  {1,8}  {2,6}  {3,7}", fila["Descripcion"], d.getUd(), fila["Precio"], d.getUd() * float.Parse(fila["precio"].ToString()));
                suma += d.getUd() * float.Parse(fila["precio"].ToString());
                Thread.Sleep(500);
            }
            Console.WriteLine("Total: {0}", suma.ToString());
            Console.WriteLine("Total Pagar:{0}", suma * 1.21f);
            sw.WriteLine("Total: {0}", suma.ToString());
            sw.WriteLine("Total Pagar:{0}", suma * 1.21f);
            sw.Close();
            Funciones.FuncionesAPI.SendMessage(handle, msgSalir, IntPtr.Zero, IntPtr.Zero);
            s.Release();
            
        }
            
            
                
        }
    }

