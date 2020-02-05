addEventListener('load',inicializarEventos,false);

function inicializarEventos()
{
  var ob=document.getElementById('boton1');
  ob.addEventListener('click',presionBoton,false);
}
// Lo primero que hacemos es inicializar el evento load con la función inicializarEventos, 
// en esta inicializamos el evento click del único botón que contiene la página

function presionBoton(e)
{
  var ob1=document.getElementById('cboVoto');
  var ob2=document.getElementById('txtNombre');
  cargarVoto(ob1.value,ob2.value);
}
// Cuando se presiona el botón se dispara la función presionBoton, donde obtenemos la referencia 
// a los dos controles (select y text) que tienen almacenados los valores. 
// Llamamos finalmente a la función cargarVoto

var conexion1;
function cargarVoto(voto,nom) 
{
  conexion1=new XMLHttpRequest();  
  conexion1.onreadystatechange = procesarEventos();
  conexion1.open('GET','pagina1.php?puntuacion='+voto+'&nombre='+nom, true);
  conexion1.send();
}
// La función cargarVoto recibe como parámetro el valor del voto y el nombre del visitante,
// seguidamente creamos un objeto de la clase XMLHttpRequest.
// Por último inicializamos la propiedad onreadystatechange y llamamos a los métodos open y send. 
// En el método open pasamos los dos datos en la cabecera de la petición de página.


function procesarEventos()
{
  var resultados = document.getElementById("resultados");
  if(conexion1.readyState == 4)
  {
    resultados.innerHTML = conexion1.responseText;
  } 
  else 
  {
    resultados.innerHTML = 'Cargando...';
  }
}
// Cuando la propiedad readyState del objeto XMLHttpRequest tiene un valor 4 (proceso completado) 
// recupera el valor de la propiedad responseText con la información que se retornó desde el servidor.