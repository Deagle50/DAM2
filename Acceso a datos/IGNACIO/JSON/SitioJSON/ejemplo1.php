<?php 

	$servidor = "localhost";
	$usuario = "root";
	$pass = "";
	$bd = "json";
	
	//Creamos la conexión
	$conexion = mysqli_connect($servidor, $usuario, $pass, $bd) 
	     or die("Ha sucedido un error inexperado en la conexion de la base de datos");
	
	//generamos la consulta
	$sql = "SELECT * FROM clientes";
	mysqli_set_charset($conexion, "utf8"); //formato de datos utf8
	
	if(!$resultado = mysqli_query($conexion, $sql)) die();
	
	$clientes = array(); //creamos un array
	
	while($fila = mysqli_fetch_array($resultado)) 
	{ 
	    $id=$fila['id'];
	    $nombre=$fila['nombre'];
	    $email=$fila['email'];
	    $sexo=$fila['sexo'];    
	    $ciudad=$fila['ciudad'];
	    $telefono=$fila['telefono'];    
	
	    $clientes[] = array('id'=> $id, 'nombre'=> $nombre, 'email'=> $email,
	                      'sexo'=> $sexo, 'ciudad'=> $ciudad, 'telefono'=> $telefono);			
	}
	    
	//desconectamos la base de datos
	$cerrado = mysqli_close($conexion) 
	or die("Ha sucedido un error inexperado en la desconexion de la base de datos");
	  
	
	//Creamos el JSON
	$json_string = json_encode($clientes);
	echo $json_string;
	
	//Si queremos crear un archivo json, sería de esta forma:
	/*
	$file = 'clientes.json';
	file_put_contents($file, $json_string);
	*/
    

?>