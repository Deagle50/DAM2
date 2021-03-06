USE [AdventureWorks2017]
GO
/****** Object:  StoredProcedure [dbo].[EjemploSeleccionDetalles]    Script Date: 19/04/2016 10:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Este procedimiento nos permite extraer
-- los resultados por pagina.
CREATE PROCEDURE [dbo].EjemploSeleccionDetalles
    -- A partir de que filas queremos los datos
	-- numero de filas / tamaño de pagina
	@startRowIndex int,
	--numero de filas que queremos extraer (tamaño de la pagina
	@maximumRows int
AS
BEGIN
    SET @startRowIndex += 1
	SELECT [SalesOrderID], [OrderQty], [UnitPrice], [ProductID] 
	FROM (
			select [SalesOrderID], [OrderQty], [UnitPrice], [ProductID] ,
				   (row_number() OVER(order by [SalesOrderID])) as numFila
			from sales.SalesOrderDetail
		 ) as infoDetalles
	-- aqui le decimos que solo queremos que devuelva las filas que esten
	-- entre los rangos que le hemos pasado por parametro
	where numFila between @startRowIndex AND (@startRowIndex + @maximumRows) - 1
END