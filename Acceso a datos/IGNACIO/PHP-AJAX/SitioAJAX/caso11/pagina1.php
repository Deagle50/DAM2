<?php
	header('Content-Type: text/html; charset=utf-8');
	
	if (isset($_REQUEST['pos']))
	  $inicio=$_REQUEST['pos'];
	else
	  $inicio=0;
	
	$conexion=mysqli_connect("localhost","root","","AJAX") or
	    die("Problemas con la conexión");
	
	$registros=mysqli_query($conexion,"select * from comentarios limit $inicio,2") or
	  die("Problemas en el select:".mysqli_error($conexion));
	$impresos=0;
	while ($reg=mysqli_fetch_array($registros))
	{
	  $impresos++;
	  echo "Nombre:".$reg['nombre']."<br>";
	  echo "Fecha:".$reg['fecha']."<br>";
	  echo "Comentarios:".$reg['comentarios']."<br>";
	  echo "<br>";
	}
	mysqli_close($conexion);
	
	if ($inicio==0)
	  echo "anteriores ";
	else
	{
	  $anterior=$inicio-2;
	  echo "<a href=\"pagina1.php?pos=$anterior\" id=\"ant\">Anteriores </a>";
	}
	if ($impresos==2)
	{
	  $proximo=$inicio+2;
	  echo "<a href=\"pagina1.php?pos=$proximo\" id=\"sig\">Siguientes</a>";
	}
	else
	  echo "siguientes";
?>