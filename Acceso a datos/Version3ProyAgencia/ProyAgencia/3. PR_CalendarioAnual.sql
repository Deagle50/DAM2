USE PRU_IgnacioGonzalo
GO
/****** Object:  StoredProcedure Agencia.[PR_CalendarioAnual]    Script Date: 05/03/2015 11:37:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE Agencia.[PR_CalendarioAnual]
AS
	DECLARE @V_fecha AS date,
			@V_Agno AS smallint,
			@V_DiaAgno AS smallint,
			@V_DiaMes AS tinyint,
			@V_Mes AS tinyint,
			@V_DiaSemana AS tinyint,
			@V_NombreDia AS varchar(10),
			@V_NombreMes AS varchar(10)

BEGIN
	--SELECT to_date('31/12/'||to_char(sysdate,'YYYY'),'DD/MM/YYYY') FROM dual;
	IF MONTH(getdate()) <> 1
	   return

	set @V_fecha = '01/01/' + CAST(year(getdate()) as char(4))

	BEGIN TRANSACTION
	BEGIN TRY
	WHILE @V_fecha <= '31/12/' + CAST(year(getdate()) as char(4))
		BEGIN
			SET @V_Agno = YEAR(@v_fecha)
			SET @V_DiaAgno = DATEPART(dayofyear,@v_fecha)
			SET @V_DiaMes = DAY(@v_fecha)
			SET @V_Mes = MONTH(@v_fecha)
			SET @V_DiaSemana = datepart(WEEKDAY,@v_fecha)
			SET @V_NombreDia = datename(WEEKDAY,@v_fecha)
			SET @V_NombreMes = datename(mm,@v_fecha)

			INSERT INTO Agencia.Calendario (Agno,DiaAgno,DiaMes,Mes,DiaSemana,NombreDia,NombreMes)
			VALUES (@V_Agno,@V_DiaAgno,@V_DiaMes,@V_Mes,@V_DiaSemana,@V_NombreDia,@V_NombreMes)
			
			SET @V_fecha =DATEADD(dd,1, @V_fecha)
		END
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
	    ROLLBACK TRANSACTION
	END CATCH
END