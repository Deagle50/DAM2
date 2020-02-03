<?php
	//defino una clase para los elementos del campo autocompletar
	class ElementoAutocompletar {
	   //propiedades de los elementos
	   var $label;
	   var $value;
	   
	   //constructor que recibe los datos para inicializar los elementos
	   function __construct($label, $value){
	      $this->label= $label;
	      $this->value= $value;
	   }
	}
	
	//recibo el dato que deseo buscar sugerencias
	$datoBuscar = $_GET["term"];
	
	//conecto con una base de datos
	$conexion = mysqli_connect("localhost", "root", "","json");	
	
	//busco un valor aproximado al dato escrito
	$sql = "select id, nombre from clientes where nombre like '%" . $datoBuscar . "%'";
	$res = mysqli_query($conexion,$sql);
	
	//creo el array de los elementos sugeridos
	$arrayElementos = array();
	
	//bucle para meter todas las sugerencias de autocompletar en el array
	while ($fila = mysqli_fetch_array($res)){
	   array_push($arrayElementos, 
	           new ElementoAutocompletar(utf8_encode($fila["nombre"]), 
	                                     $fila["id"]));
	}
	
	echo json_encode($arrayElementos); 
?>

