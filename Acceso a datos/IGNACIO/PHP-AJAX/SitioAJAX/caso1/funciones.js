addEventListener('load',inicializarEventos,false);

/*
  Lo primero que se ejecuta es la llamada a la función inicializarEventos() inmediatamente
  despues de que la página se ha cargado por completo en el navegador.
  
  En esta función registramos el evento click para los doce enlaces de los signos del horóscopo. 
  Para facilitar la codificación recordemos que todos tienen casi el mismo nombre, 
  difieren por un número al final. Luego, dentro de un for, rescatamos la referencia a cada enlace 
  y registramos el evento click indicando que se debe llamar a la función presionEnlace.
*/
function inicializarEventos()
{
  for(var f=1;f<=12;f++)
  {
    var ob=document.getElementById('enlace'+f);
    ob.addEventListener('click',presionEnlace,false);
  }
}


/*
  Primero, desactivamos el evento por defecto para el hipervínculo. A continuación, llamamos a la función 
  cargarHoroscopo pasándole como referencia la url que contiene el hipervínculo.
*/
function presionEnlace(e)
{
    e.preventDefault();
    var url=e.target.getAttribute('href');
    cargarHoroscopo(url); 
}


/*
  Previamente a la definición de esta función, definimos una variable global llamada conexion1 que 
  será utilizada en esta y la siguiente función.
  La función recibe como parámetro la url a la que debe hacer la petición de datos.
  Lo primero que hacemos es crear un objeto de la clase XMLHttpRequest (luego veremos 
  que este objeto nos permite comunicarnos con el servidor de forma asincrónica).
  
  La propiedad onreadystatechange se inicializa con la referencia de una función que será la encargada
  de procesar los datos enviados por el servidor, veremos el código de esta función más adelante.
  Seguidamente llamamos al método open que tiene tres parámetros:
	Primero, el método de envío de datos (GET o POST). Recordemos que si los datos se envían como 
	parámetros (como es nuestro ejemplo) debemos indicar que utilizamos el método GET.
	El segundo parámetro es la url y la página que procesará los datos que le enviemos.
	En el tercer parámetro indicamos si se procesarán los datos de forma asíncrona (true) o síncrona (false).
  
  Por último nos falta llamar al método send para que comience el proceso.
*/
var conexion1;
function cargarHoroscopo(url) 
{
  conexion1=new XMLHttpRequest();  
  conexion1.onreadystatechange = procesarEventos;
  conexion1.open("GET", url, true);
  conexion1.send();
}


/*
  la función procesarEventos que se ejecuta cada vez que el objeto conexion1 de la 
  clase XMLHttpRequest cambia de estado. 
  Tengamos en cuenta que los estados posibles de este objeto son:
	0 No inicializado.
	1 Cargando.
	2 Cargado.
	3 Interactivo.
	4 Completado.

  Para conocer el estado del objeto debemos acceder a la propiedad readyState que almacena 
  alguno de los cinco valores que enunciamos.
*/
function procesarEventos()
{
  var detalles = document.getElementById("detalles");
  if(conexion1.readyState == 4)
  {
    detalles.innerHTML = conexion1.responseText;
  } 
  else 
  {
    detalles.innerHTML = 'Cargando...';
  }
}