using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

/// <summary>
/// Descripción breve de detalleCollection
/// </summary>

namespace AJAX2
{
    public class detalleCollection : List<Detalle>
    {
        /// <summary>
        /// Lista de productos. Utilizando la clase Collection con una plantilla
        /// obtenemos una lista fuertemente tipada sin tener que teclear
        /// ninguna linea de codigo
        /// </summary>
        public detalleCollection()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
    }
}