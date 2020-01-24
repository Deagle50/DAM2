select datename(mm,getdate()) -- Nombre del mes
select day(getdate())  -- Numero del dia dentro del mes

select day(EOMONTH('01/02/2016')) -- Saber si el año es bisiesto

select datepart(weekday,getdate()) -- Numero del dia de la semana
select datename(weekday,getdate()) -- Nombre del dia de la semana

select datepart(dayofyear,'31/12/2016') -- Numero del dia dentro del año


