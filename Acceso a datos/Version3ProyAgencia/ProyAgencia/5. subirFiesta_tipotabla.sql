USE PRU_IgnacioGonzalo
GO

CREATE procedure Agencia.[pa_ImportaFiestas]
	@fiestas Agencia.tipoFiestas READONLY
AS
	--DECLARE @salida TABLE (fecha datetime, err varchar(250))
	--DECLARE @auxF varchar(30)
	DECLARE lecLin CURSOR FOR
		SELECT Fecha,Fiesta FROM @fiestas
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		
		update calendario set festivo = 0, DescFestivo=NULL
		where agno = year(GETDATE()) --borra todos los festivos de este año

		OPEN lecLin

		DECLARE     @Fecha date,
					@Fiesta varchar(30)
		FETCH NEXT FROM lecLin INTO
					@Fecha,
					@Fiesta
		WHILE @@FETCH_STATUS = 0
		BEGIN
			--BEGIN TRY
				
			--	IF (((select DescFestivo from calendario where anio = year(@Fecha) and diaAnio = datepart(dayofyear, @Fecha) and Festivo = 1) = null))
			--	BEGIN
			--		set @auxF = (select cast(@Fecha as varchar(30)) + ' ya es festivo.')
			--		Raiserror(@auxF , 16,1)
			--	END

			
			update Agencia.calendario 
			set festivo = 1, 
			     DescFestivo = @Fiesta 
		    where agno = year(@Fecha) and diaAgno = datepart(dayofyear, @Fecha)

			--END TRY
			--BEGIN CATCH
			--	INSERT INTO @salida(fecha,err) VALUES (@Fecha,ERROR_MESSAGE())
			--END CATCH

			FETCH NEXT FROM lecLin INTO
						@Fecha,
						@Fiesta
		END
		CLOSE lecLin
		DEALLOCATE lecLin

		--IF exists(SELECT fecha FROM @salida)
		--	Raiserror('Error(es) en lineas.', 16,1)

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		--IF exists(SELECT fecha FROM @salida)
		--	SELECT fecha,err from @salida
	END CATCH
END



--/****** Object:  UserDefinedTableType [dbo].[importPedLins]    Script Date: 04/03/2015 10:43:20 ******/
--CREATE TYPE Agencia.tipoFiestas AS TABLE(
--	Fecha datetime NULL,
--	Fiesta [varchar](30) NULL
--)
--GO