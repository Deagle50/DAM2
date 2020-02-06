using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de detalleDataSource
/// </summary>

namespace AJAX2
{
    /// <summary>
    /// Este sera el "DataSource" que enlazaremos como proxy
    /// para el GridView.
    /// </summary>
    public class detalleDataSource
    {        
	    public detalleDataSource()
	    {
		    //
		    // TODO: Agregar aquí la lógica del constructor
		    //
	    }

        /// <summary>
        /// Devolvemos el numero de filas total que tiene la consulta
        /// </summary> 
        public int selectNumFilas()
        {
            int numFilas = 0;
            using (SqlConnection conexion = new SqlConnection("Data Source=segundo150; Initial Catalog=Adventureworks2017; Integrated Security=true;"))
            using (SqlCommand comando = new SqlCommand("EjemploCuentaDetalles", conexion))
            {
                conexion.Open();
                comando.CommandType = CommandType.StoredProcedure;
                numFilas = (int)comando.ExecuteScalar();
            }
            return numFilas;
        }

        /// <summary>
        /// Este metodo lo usamos para extraer los datos de una pagina que nos pida el grid.
        /// </summary> 
        /// <param name="maximumRows">Tamaño de pagina</param>
        /// <param name="startRowIndex">A partir de que fila queremos extraer datos</param>
        /// <returns></returns>

        public detalleCollection select(int maximumRows, int startRowIndex)
        {
            //Ejecutamos el procedimiento almacenado que hemos creado.
            using (SqlConnection conexion = new SqlConnection("Data Source=segundo150; Initial Catalog=Adventureworks2017; Integrated Security=SSPI;"))
            using (SqlCommand comando = new SqlCommand("EjemploSeleccionDetalles", conexion))
            {
                conexion.Open();
                comando.CommandType = CommandType.StoredProcedure;

                // Le indicamos a partir de que fila queremos obtener los resultados,
                // así como cuantas filas como maximo nos queremos traer (tamaño de la página)
                comando.Parameters.AddWithValue("@startRowIndex", startRowIndex);
                comando.Parameters.AddWithValue("@maximumRows", maximumRows);

                detalleCollection detalles = new detalleCollection();
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // Cargamos los datos en nuestro objeto personalizado "lineas"
                        Detalle detalle = new Detalle();
                        detalle.salesOrderID = (Int32)lector["salesOrderID"];
                        detalle.orderQty = (Int16)lector["orderQty"];
                        detalle.unitPrice = (Decimal)lector["unitPrice"];
                        detalle.productID = (Int32)lector["productID"];
                        
                        // Añadimos el producto a la lista de productos que
                        // devolveremos al GridView
                        detalles.Add(detalle);
                    }
                }
                return detalles;
            }

        }
    }
}
