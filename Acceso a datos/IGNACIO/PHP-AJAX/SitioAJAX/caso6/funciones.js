addEventListener('load',inicializarEventos,false);

function inicializarEventos()
{
  var ob=document.getElementById('boton1');
  ob.addEventListener('click',presionBoton,false);
}


/*
  Recuperamos el pais seleccionado en el control select y llamamos a la función 
  recuperarDatos() pasando como parámetro dicho pais.
*/
function presionBoton(e)
{
  // Accedemos al comboBox
  var ob1=document.getElementById('pais');
  recuperarDatos(ob1.value);
}


/*
  La función recuperarDatos() crea un objeto de la clase XMLHttpRequest y abre una 
  conexión con el servidor mediante el método GET pasando como parámetro el 
  nombre del país seleccionado.
  Como hemos visto, la propiedad onreadystatechange se inicializa con el nombre 
  de la función que procesará los cambios de estado del objeto XMLHttpRequest.
*/
var conexion1;
function recuperarDatos(pais) 
{
  conexion1=new XMLHttpRequest();
  conexion1.onreadystatechange = procesarEventos;
  conexion1.open('GET','pagina1.php?pa='+pais, true);
  conexion1.send();
}


function procesarEventos()
{
  var resultados = document.getElementById("resultados");

  /*
    Cuando los datos han llegado completamente, es decir, la propiedad readyState del
    objeto XMLHttpRequest almacena el valor 4, procedemos a cargar los datos 
    dentro del div 'resultados'.
  */
  if(conexion1.readyState == 4)
  {
    var xml = conexion1.responseXML;
    var capital=xml.getElementsByTagName('capital');
    var superficie=xml.getElementsByTagName('superficie');
    var idioma=xml.getElementsByTagName('idioma');
    var poblacion=xml.getElementsByTagName('poblacion');
    resultados.innerHTML='Capital='+capital[0].firstChild.nodeValue + '<br>' +
                         'Superficie='+superficie[0].firstChild.nodeValue + '<br>' +
                         'Idioma='+idioma[0].firstChild.nodeValue + '<br>' +
                         'Poblacion='+poblacion[0].firstChild.nodeValue ;
  } 
  else 
  {
    resultados.innerHTML = 'Cargando...';
  }
}
