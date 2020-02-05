addEventListener('load',inicializarEventos,false);

function inicializarEventos()
{
  var ref;
  ref=document.getElementById('fecha');
  var vec=ref.getElementsByTagName('a'); 
  for(f=0;f<vec.length;f++)
  {
    vec[f].addEventListener('click',presionEnlace,false);
  }
}

// La función presionEnlace se dispara cuando se presiona alguno de los hipervínculos
function presionEnlace(e)
{
  e.preventDefault(); // desactivamos el evento
  var url=e.target.getAttribute('href');
  verComentarios(url);     
}


/*
  Creamos un objeto de tipo XMLHttpRequest y procedemos a almacenarlo en la variable conexion1 
  (que al ser una variable global podrá utilizarse y accederse desde otra función).
  
  Las siguientes tres líneas son similares a problemas que hemos realizado anteriormente. 
  Primero, inicializamos la propiedad onreadystatechange con el nombre de la función que procesará 
  los eventos del objeto XMLHttpRequest.
  Como segundo paso llamamos al método open indicando que enviaremos la fecha mediante el método GET,
  el siguiente parámetro el nombre de la página a llamar junto con la fecha a enviar y por último 
  pasamos el valor true indicando que emplearemos comunicación asincrónica.
  El tercer paso es llamar al método send. (ej. pagina1.php?fecha=21/01/2019)
*/
var conexion1;
function verComentarios(url) 
{
  if(url=='')
  {
    return;
  }
  conexion1=new XMLHttpRequest();
  conexion1.onreadystatechange = procesarEventos;
  conexion1.open("GET", url, true);
  conexion1.send();
}

// La función procesarEventos es donde accedemos a la propiedad responseText
function procesarEventos()
{
  var detalles = document.getElementById("comentarios");
  if(conexion1.readyState == 4)
  {
    detalles.innerHTML = conexion1.responseText;
  } 
  else 
  {
    detalles.innerHTML = 'Cargando...';
  }
}

