<!--
  En la página PHP grabamos en un archivo de texto los datos 
  y mediante la función sleep detenemos la ejecución del programa
  en el servidor una determinada cantidad de segundos. Esto lo
  hacemos para poder ver en el navegador el gif. En la realidad,
  no hay que llamar a sleep.
-->
ç<?php
	header('Content-Type: text/html; charset=utf-8');
	
	$ar=fopen("comentarios.txt","a") or
	  die("No se pudo abrir el archivo");
	  
	fputs($ar,"Nombre:".$_REQUEST['nombre']."\n");
	fputs($ar,"Comentarios:".$_REQUEST['comentarios']."\n\n");
	fclose($ar);
	
	sleep(5);
?>