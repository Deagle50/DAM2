<?php
	$car=$_REQUEST['cod'];
	if ($car==1)
	{
	  $materias=array('Programacion I','Analisis Matematico','Estructura de las Organizaciones','Etica Profesional');
	}
	if ($car==2)
	{
	  $materias=array('Fundamentos de Fisica','Analisis Matematico 1','Ingles Tecnico I','Sistemas de Comunicaciones I
	');
	}
	if ($car==3)
	{
	  $materias=array('Informatica I','Multimedia I','Bases de Datos');
	}
	
	
	$xml="<?xml version=\"1.0\"?>\n";
	$xml.="<materias>\n";
	for($f=0;$f<count($materias);$f++)
	{
	  $xml.="<materia>" .$materias[$f]. "</materia>\n";
	}
	$xml.="</materias>\n";
	header('Content-Type: text/xml');
	echo $xml;	
?>