<?php
	header('Content-Type: text/html; charset=utf-8');
	// Lo primero que hacemos es abrir el archivo para agregar datos, es decir no borramos 
	// los votos existentes (se puede probar de cambiar "a" de append por "w" que crea el archivo):
	$fpuntuaciones=fopen("puntuacion.txt","a") or
	  die("No se pudo abrir el archivo");
	
	// Luego recuperamos los parámetros que llegan a la página y los grabamos en el archivo
	fputs($fpuntuaciones,"Nombre:".$_REQUEST['nombre']."<br>");
	fputs($fpuntuaciones,"Voto:".$_REQUEST['puntuacion']."<br><br>");
	fclose($fpuntuaciones);
	
	// Por último generamos el contenido a devolver al navegador
	$fpuntuaciones=fopen("puntuacion.txt","r") or
	  die("No se pudo abrir el archivo");
	while (!feof($fpuntuaciones))
	{
	  $registro=fgets($fpuntuaciones);
	  echo $registro;
	}
	fclose($fpuntuaciones);
?>