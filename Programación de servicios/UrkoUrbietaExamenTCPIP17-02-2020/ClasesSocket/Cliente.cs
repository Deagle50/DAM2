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
    public delegate void BufferLleno();
    public class Cliente
    {
        private TcpClient varcliente;
        private String _host;
        private int _socket;
        private String[] _buffer;
        private Thread _hiloHablar;
        private NetworkStream srw;
        private int _bufferSize;

        public event DatosRecibidosCliente OnDatosRecibidos;
        public event ConexionTerminadaCliente OnConexionTerminada;
        public event BufferLleno OnBufferLleno;
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

        public String[] buffer{
            get
            {
                return _buffer;
            }
            set
            {
                _buffer = value;
            }
        }
        
        public int bufferSize {
            get
            {
                return _bufferSize;
            }
            set
            {
                _bufferSize = value;
            }
        }

        public Cliente(String host, int socket, int max)
        {            
            _host = host;
            puerto = socket;
            bufferSize = max;

            buffer = new String[max];


            OnConexionTerminada += () => { };
            OnDatosRecibidos += (x) => { };
            OnBufferLleno += () => { };
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
        {
            //Si el buffer no está lleno guardar dato en buffer y no enviar
            if (buffer.Length != bufferSize)
            {
                buffer.SetValue(datos, buffer.Length);
            }
            //Si está lleno lanzar onBufferLleno y enviar todos los datos
            else {
                //Lanzar evento on buffer lleno
                OnBufferLleno();
                String cadena="";
                //Pasar todos los datos a una cadena
                for (int i = 0; i < buffer.Length; i++)
                {
                    cadena += buffer.GetValue(i);
                    if(i!=buffer.Length-1)
                        cadena += ";";
                }                
                //Enviar la cadena cadena
                byte[] datosbyte = ProcesarBytes.DecodeByte(cadena);
                srw.Write(datosbyte, 0, datosbyte.Length);

                //Vaciar buffer
                for (int i = 0; i < buffer.Length; i++)
                    buffer.SetValue("", i);
            }
            
        }
    }

}
