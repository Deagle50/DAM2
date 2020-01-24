/*Funciones de fecha y hora*/
	select DATENAME(mm,GETDATE()) --nombre del mes
	select day(getdate()) --numero del dia dentro del mes
	select day(eomonth('01/02/2016')) --saber si el año es bisiesto
	select DATEPART(weekday,GETDATE()) --numero del dia de la semana
	select DATENAME(weekday,GETDATE()) --nombre del dia de la semana
	select DATEPART(DAYOFYEAR,GETDATE()) --numero del dia dentro del año
	SELECT DATEADD(dd,1,getdate())