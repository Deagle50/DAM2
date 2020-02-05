<?php
    if ($_REQUEST['pa']=='Alemania')
	{
	  $superficie=357578;
	  $capital="Berlín";
	  $idioma="Alemán";
	  $poblacion=83000000;
	}

	if ($_REQUEST['pa']=='Argentina')
	{
	  $superficie=2780000;
	  $capital="Buenos Aires";
	  $idioma="Castellano";
	  $poblacion=40000000;
	}
	if ($_REQUEST['pa']=='Francia')
	{
	  $superficie=676000;
	  $capital="París";
	  $idioma="Francés";
	  $poblacion=68000000;
	}
	if ($_REQUEST['pa']=='España')
	{
	  $superficie=506000;
	  $capital="Madrid";
	  $idioma="Castellano";
	  $poblacion=47000000;
	}

	if ($_REQUEST['pa']=='Brasil')
	{
	  $superficie=8500000;
	  $capital="Brasilia";
	  $idioma="Portugues";
	  $poblacion=208000000;
	}
	if ($_REQUEST['pa']=='Chile')
	{
	  $superficie=750000;
	  $capital="Santiago";
	  $idioma="Castellano";
	  $poblacion=19000000;
	}
	
	$xml="<?xml version=\"1.0\"?>\n";
	$xml.="<pais>\n";
	$xml.="<superficie>$superficie</superficie>\n";
	$xml.="<capital>$capital</capital>\n";
	$xml.="<idioma>$idioma</idioma>\n";
	$xml.="<poblacion>$poblacion</poblacion>\n";
	$xml.="</pais>\n";
	header('Content-Type: text/xml');
	echo $xml;
?>