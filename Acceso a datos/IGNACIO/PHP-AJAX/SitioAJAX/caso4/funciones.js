addEventListener('load',inicializarEventos,false);

/*
  Obtener la referencia del formulario e inicializar el evento submit para poder 
  capturar el momento en que los datos se enviarán al servidor. Es decir,
  la función enviarDatos se ejecutará cuando el operador presione el botón de tipo submit.
*/
function inicializarEventos()
{
  var ref=document.getElementById('formulario');
  ref.addEventListener('submit',enviarDatos,false);
}

function enviarDatos(e)
{
  e.preventDefault(); // desactivamos el evento
  enviarFormulario();
}


/*
  Obtenemos el valor contenido en cada control (input y textarea) y luego concatenamos
  nombre del dato y valor separándolos por el caracter ámpersand.
  Llamamos a la función JavaScript encodeURIComponent para codificar los datos ingresados
  por el visitante de forma que se puedan enviar correctamente al servidor.
*/
function retornarDatos()
{
  var cad='';
  var nom=document.getElementById('txtNombre').value;
  var com=document.getElementById('txtComentarios').value;
  cad='nombre='+encodeURIComponent(nom)+'&comentarios='+encodeURIComponent(com);
  return cad;
}


/*
  Inicializamos el objeto XMLHttpRequest indicando en el método open que los datos se 
  enviarán mediante el comando POST.
  Luego, llamamos al método setRequestHeader indicando el tipo de contenido a enviar al servidor.
  Finalmente, llamamos al método send con los datos. Estos datos los recuperamos del formulario 
  llamando a la función retornarDatos() que explicaremos a continuación.
*/
var conexion1;
function enviarFormulario() 
{
  conexion1=new XMLHttpRequest();
  conexion1.onreadystatechange = procesarEventos;
  conexion1.open('POST','pagina1.php', true);
  conexion1.setRequestHeader("Content-Type","application/x-www-form-urlencoded");
  conexion1.send(retornarDatos());  
}


function procesarEventos()
{
  var resultados = document.getElementById("resultados");
  if(conexion1.readyState == 4)
  {
    resultados.innerHTML = 'Gracias.';
  } 
  else 
  {
    // resultados.innerHTML = 'Procesando...';
    resultados.innerHTML = conexion1.readyState;
  }
  
}
