addEventListener('load',inicializarEventos,false);

function inicializarEventos()
{
  cargarPagina('pagina1.php'); 
}

function presionEnlace(e)
{
  e.preventDefault();
  var url=e.target.getAttribute('href');
  cargarPagina(url);     
}


var conexion1;
function cargarPagina(url) 
{
  if(url=='')
  {
    return;
  }
  conexion1=new XMLHttpRequest();
  conexion1.onreadystatechange = procesarEventos;
  conexion1.open("GET", url, true);
  conexion1.send(null);
}

function procesarEventos()
{
  var detalles = document.getElementById("detalles");
  if(conexion1.readyState == 4)
  {
    detalles.innerHTML = conexion1.responseText;
    var ob1=document.getElementById('sig');
    if (ob1!=null)
      ob1.addEventListener('click',presionEnlace,false);
    var ob2=document.getElementById('ant');
    if (ob2!=null)
      ob2.addEventListener('click',presionEnlace,false);
  } 
  else 
  {
    detalles.innerHTML = '<img src="..imagenes/cargando.gif">';
  }
}
