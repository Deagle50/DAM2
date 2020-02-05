addEventListener('load',inicializarEventos,false);

function inicializarEventos()
{
  var ref=document.getElementById('votofoto1');
  var vec= ref.getElementsByTagName('li');
  var vec2=ref.getElementsByTagName('a');
  // Pasamos la asignación de eventos a estos elementos dentro de un for. A los elementos 
  // de tipo li les definimos los eventos mouseover y mouseout. 
  // A los elementos "a" les definimos el evento click
  for(var f=0;f<vec2.length;f++)
  {
    vec[f].addEventListener('mouseover',entrar,false);
    vec[f].addEventListener('mouseout',salir,false);
    vec2[f].addEventListener('click',presionBoton,false);
  }
}

// La función entrar() se ejecuta cuando el ratón se sitúa dentro de algún elemento 
// de la lista. Dentro del for cambiamos el color de todos los elementos menores,
// incluyendo al que emitió el evento.
function entrar(e)
{
  var ref=e.target;
  var ob=document.getElementById('votofoto1');
  var vec=ob.getElementsByTagName('li');
  for(var f=0;f<ref.firstChild.nodeValue;f++)
  {
    vec[f].firstChild.style.background='#f00';
    vec[f].firstChild.style.color='#fff';
  }    
}

// El algoritmo es similar cuando con el ratón salimos de un elemento de tipo li
function salir(e)
{
  var ref=e.target;
  var ob=document.getElementById('votofoto1');
  var vec=ob.getElementsByTagName('li');
  for(var f=0;f<ref.firstChild.nodeValue;f++)
  {
    vec[f].firstChild.style.background='#f7f8e8';
    vec[f].firstChild.style.color='#f00';
  }  
}


// La función presionBoton() se ejecuta cuando alguno de los elementos a (anchor) es presionado
function presionBoton(e)
{
  e.preventDefault();
  var ref=e.target;
  cargarVoto(ref.firstChild.nodeValue);
}
// En esta función hemos desactivado la acción por defecto de un elemento "a" llamando 
// a la función e.preventDefault().
// Procedemos luego a llamar a la función cargarVoto pasando como referencia el valor contenido
// en el elemento "a".



// Otro parametro que vamos a incorporar es el envío de un valor aleatorio. Esto es necesario si el 
// navegador está configurado para recuperar las páginas de la cache. Imaginemos que votamos y 
// asignamos el valor 10. Luego, si volvemos a seleccionar el 10, es posible que el navegador
// recupere la pagina1.php?voto=10 de la cache y no actualice el archivo de texto con el 
// voto seleccionado.
// La solución mas sencilla es enviar un parámetro con un valor aleatorio, por lo que el navegador 
// interpretará que se trata de otra página.
var conexion1;
function cargarVoto(voto) 
{
  conexion1=new XMLHttpRequest(); 
  conexion1.onreadystatechange = procesarEventos;
  var aleatorio=Math.random();
  conexion1.open('GET','pagina1.php?voto='+voto+"&aleatorio="+aleatorio, true);
  conexion1.send();
}


// La función procesarEventos() obtiene una referencia al div llamado detalles y muestra 
// inicialmente el texto: 'Cargando...'. Posteriormente, cuando el servidor informa que los datos 
// se registraron, pasa a mostrar el texto: 'Gracias'.
function procesarEventos()
{
  var resultados = document.getElementById("resultados");
  if(conexion1.readyState == 4)
  {
    resultados.innerHTML = 'Gracias.';
  } 
  else 
  {
    resultados.innerHTML = 'Procesando...';
  }
}

