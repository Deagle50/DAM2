using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClasesSocket
{
    public delegate void ConexionTerminadaCliente();
    public delegate void DatosRecibidosCliente(String datos);
   public class Cliente
    /*
     i.	Eliminar del constructor el parámetro socket y hacer que el cliente siempre conecte al 8888.
     Crear una constante de clase llamada SOCKET para almacenar dicho valor.*/
    {
        const int SOCKET=8888;
        private TcpClient varcliente;
        private String _host;
        private int _socket;
        private Thread _hiloHablar;
        private NetworkStream srw;
        public event DatosRecibidosCliente OnDatosRecibidos;
        public event ConexionTerminadaCliente OnConexionTerminada;
        public String hostRemoto
        {
            get
            { return _host; }
            set
            { _host = value; }
        }

        public int puerto
        {
            get
            {
                return _socket;
            }
            set
            {
                _socket = value;

            }
        }

        public Cliente(String h)
        {   
            puerto = SOCKET;
            _host = h;
            OnConexionTerminada += () => { };
            OnDatosRecibidos += (x) => { };
        }
        public void Conectar()
        {
            varcliente = new TcpClient(_host, _socket);
            srw = varcliente.GetStream();
            _hiloHablar = new Thread(new ThreadStart(Escuchar));
            _hiloHablar.Start();

        }
        private void Escuchar()
        {
            try
            {
                while(varcliente.Connected)
                {
                    int tam = varcliente.ReceiveBufferSize;
                    byte[] bytedatos = new byte[tam];
                    varcliente.Client.Receive(bytedatos);
                    String datos = ProcesarBytes.EncodeBytes(bytedatos);
                    //On datos recibidos
                    OnDatosRecibidos(datos);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

                //Conexion Terminada
                OnConexionTerminada();
            }
        }
        public void EnviarDatos(String datos)
        { byte[] datosbyte = ProcesarBytes.DecodeByte(datos);
            srw.Write(datosbyte, 0, datosbyte.Length);
        }
    }

}
