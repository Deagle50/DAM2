<?php
	header('Content-Type: text/html; charset=utf-8');
	$ar=fopen("comentarios.txt","a") or
	  die("No se pudo abrir el archivo");
	  
	fputs($ar,"Nombre:".$_POST['nombre']."\n");
	fputs($ar,"Comentarios:".$_POST['comentarios']."\n\n");
	fclose($ar);
?>
