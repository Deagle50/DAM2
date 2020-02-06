using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Detalle
/// </summary>
public class Detalle
{
	public Detalle()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
   
    // Un variable miembro para cada columna de detalle
    private Int32 _SalesOrderID;
    private Int16 _OrderQty;
    private Decimal _UnitPrice;
    private Int32 _ProductID;

    // Exponemos las variables usando propiedades
    public Int32 salesOrderID
    {
        get { return _SalesOrderID; }
        set { _SalesOrderID = value; }
    }

    public Int16 orderQty
    {
        get { return _OrderQty; }
        set { _OrderQty = value; }
    }

    public Decimal unitPrice
    {
        get { return _UnitPrice; }
        set { _UnitPrice = value; }
    }

    public Int32 productID
    {
        get { return _ProductID; }
        set { _ProductID = value; }
    }

  
}