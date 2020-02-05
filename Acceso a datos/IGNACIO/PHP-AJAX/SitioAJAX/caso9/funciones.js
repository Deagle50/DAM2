addEventListener('load',inicializarEventos,false);

function inicializarEventos()
{
  for(f=1;f<=12;f++)
  {
    var ob=document.getElementById('enlace'+f);
    addEventListener('click',presionEnlace,false);
  }
}

function presionEnlace(e)
{
  e.preventDefault();
  var url=e.target.getAttribute('href');
  cargarHoroscopo(url);     
}


var conexion1;
var tiempo;
function cargarHoroscopo(url) 
{
  if(url=='')
  {
    return;
  }
  conexion1=new XMLHttpRequest();
  conexion1.onreadystatechange = procesarEventos;
  conexion1.open("GET", url, true);
  conexion1.send();
  /* Cuando comenzamos la conexión con el servidor inicializamos un temporizador 
     para que si pasan más de 3 segundos sin responder el servidor proceda a 
     abortar esa conexión e informe al visitante. 
  */
  tiempo=setTimeout("finDeEspera()",3000);
}

function procesarEventos()
{
  var detalles = document.getElementById("detalles");
  /*
    Podemos ver, que si la petición finaliza, procedemos a deshabilitar el 
    temporizador llamando a la función clearTimeout.
  */
  if(conexion1.readyState == 4)
  {
    clearTimeout(tiempo);
    detalles.innerHTML = conexion1.responseText;
  } 
  else 
    if(conexion1.readyState == 1)
    {
      detalles.innerHTML = 'Cargando...';
    }
}

function finDeEspera()
{
  conexion1.abort();
  detalles.innerHTML = 'Intente nuevamente más tarde, el servidor esta sobrecargado.';
}
