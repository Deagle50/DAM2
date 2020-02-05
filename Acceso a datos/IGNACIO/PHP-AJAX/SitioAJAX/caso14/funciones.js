addEventListener('load',inicializarEventos,false);

function inicializarEventos()
{
  var ob=document.getElementById('txtPalabra');
  ob.addEventListener('keyup',presionTecla,false);
}

var conexion1;
function presionTecla(e)
{
  conexion1=new XMLHttpRequest();
  conexion1.onreadystatechange = procesarEventos;
  palabra=document.getElementById('txtPalabra').value;
  conexion1.open('GET','pagina1.php?palabra='+palabra, true);
  conexion1.send();
}

function procesarEventos()
{
  var resultados = document.getElementById("resultados");
  if(conexion1.readyState == 4)
  {
    if (conexion1.status==200)
    {
      var xml = conexion1.responseXML;
      var pals=xml.getElementsByTagName('palabra');
      resultados.innerHTML='';      
      for(var f=0;f<pals.length;f++)
      {
        resultados.innerHTML = resultados.innerHTML + pals[f].firstChild.nodeValue + '<br>';
      } 
    }
    else
      alert(conexion1.statusText);
  } 
  else 
  {
    resultados.innerHTML = '<img src="../imagenes/cargando.gif">';
  }
}
