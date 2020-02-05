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

var conexion1;
function enviarFormulario() 
{
  // Normalmente cuando creamos un objeto de la clase XMLHttpRequest, inicializamos 
  // la propiedad onreadystatechange con el nombre de la función que procesará 
  // los datos enviados por el servidor.
  conexion1=new XMLHttpRequest();
  conexion1.onreadystatechange = procesarEventos;
  
  var num=document.getElementById('num').value;
  alert('Valor de la propiedad readyState:'+conexion1.readyState);
  conexion1.open('GET','pagina1.php?numero='+num, true);
  conexion1.send();
}


/*
  Por otro lado dentro de la función que previamente fue asignada a la propiedad 
  onreadystatechange, verificamos el estado de la propiedad readyState.
*/
function procesarEventos()
{
  alert('Valor de la propiedad readyState:'+conexion1.readyState);
  var resultados = document.getElementById("resultados");
  if(conexion1.readyState == 4)
  {
    resultados.innerHTML = conexion1.responseText;
  } 
  else
    if (conexion1.readyState==1 || conexion1.readyState==2 || conexion1.readyState==3)
    {
      resultados.innerHTML = 'Procesando...';
    }
}
