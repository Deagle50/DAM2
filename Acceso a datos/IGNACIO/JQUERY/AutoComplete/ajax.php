<?php
	if(!empty($_GET['nombre'])) {
		$datoBuscar = $_GET["nombre"];
	
		//conecto con una base de datos
		$conexion = mysqli_connect("localhost", "root", "","json");	
		
		//busco un valor aproximado al dato escrito
		$sql = "select id, nombre from clientes where nombre like '%" . $datoBuscar . "%'";
		$res = mysqli_query($conexion,$sql);
		
		//creo el array de los elementos sugeridos
		$data = array();
		
		//bucle para meter todas las sugerencias de autocompletar en el array
		while ($fila = mysqli_fetch_array($res)){
		   array_push($data,utf8_encode($fila["nombre"]));
		}		 	
	}
	echo json_encode($data);exit();
?>

