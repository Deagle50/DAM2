USE [AdventureWorks2017]
GO
/****** Object:  StoredProcedure [dbo].[EjemploCuentaDetalles]    Script Date: 19/04/2016 10:43:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Este procedimiento nos permite saber 
--cuantas filas nos da la query.
CREATE PROCEDURE [dbo].EjemploCuentaDetalles
AS
BEGIN
	select COUNT(*)
	from sales.SalesOrderDetail
END