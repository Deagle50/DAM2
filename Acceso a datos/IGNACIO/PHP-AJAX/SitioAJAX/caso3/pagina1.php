<?php
	header('Content-Type: text/html; charset=utf-8');
	$ar=fopen("votos.txt","a") or
	  die("No se pudo abrir el archivo");
	  
	fputs($ar,$_REQUEST['voto']."-\n");
	fclose($ar);
?>
