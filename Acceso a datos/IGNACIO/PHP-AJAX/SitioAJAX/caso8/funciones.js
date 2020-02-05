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
  conexion1=new XMLHttpRequest();
  conexion1.onreadystatechange = procesarEventos;
  var num=document.getElementById('txtNumero').value;
  // Generamos el error pasando un nombre de página (paginax.php) no existente
  conexion1.open('GET','paginax.php?numero='+num, true);  
  conexion1.send();  
}


// En esta versión, al ejecutar la página, observaremos que nos dará el error
// "objeto no localizado ..... Error 404" --> depende del navegador.

// Si quitamos las lineas de comentario, visualizaremos el error
function procesarEventos()
{
  var resultados = document.getElementById("resultados");
  if(conexion1.readyState == 4)
  {
    if (conexion1.status==200)
    {
      resultados.innerHTML = conexion1.responseText;
    }
    else
    {
      resultados.innerHTML=''; 
      alert(conexion1.statusText);
    }
   
    //resultados.innerHTML = conexion1.responseText;
  } 
  else
    if (conexion1.readyState==1 || conexion1.readyState==2 || conexion1.readyState==3)
    {
      resultados.innerHTML = 'Procesando...';
    }
}
