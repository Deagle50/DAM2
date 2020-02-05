addEventListener('load',inicializarEventos,false);

function inicializarEventos()
{
  var ref=document.getElementById('formulario');
  ref.addEventListener('submit',enviarDatos,false);
}

function enviarDatos(e)
{
  e.preventDefault();
  enviarFormulario();
}


function devolverDatos()
{
  var cad='';
  var nom=document.getElementById('txtNombre').value;
  var com=document.getElementById('txtComentarios').value;
  cad='nombre='+encodeURIComponent(nom)+'&comentarios='+encodeURIComponent(com);
  return cad;
}

var conexion1;
function enviarFormulario() 
{
  conexion1=new XMLHttpRequest();
  conexion1.onreadystatechange = procesarEventos;
  conexion1.open('POST','pagina1.php', true);
  conexion1.setRequestHeader("Content-Type","application/x-www-form-urlencoded; charset=UTF-8");
  conexion1.send(devolverDatos());  
}

function procesarEventos()
{
  var resultados = document.getElementById("resultados");
  if(conexion1.readyState == 4)
  {
    if (conexion1.status==200)
      resultados.innerHTML = 'Gracias.';
    else
      alert(conexion1.statusText);
  } 
  else 
  {
    // Esta es la novedad del problema
    resultados.innerHTML = '<img src="../imagenes/cargando.gif">';
  }
}
