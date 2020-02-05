<meta charset="utf-8" />
 <?php
	// Recuperamos el parámetro que nos llega mediante la url que invoca xmlhttp
	$pais=$_POST["pais"];
	$resultadoConsulta = '';
	$msg = 'El pais recibido en segundo plano ahora es '.$pais;
	if ($pais) {
	    $link = mysqli_connect("localhost", "root", "");
	    mysqli_select_db($link, "ajax");
	    $tildes = $link->query("SET NAMES 'utf8'"); //Para que se muestren las tildes correctamente
	    $resultado = mysqli_query($link, "SELECT ciudades.nombre as ciudad
	                FROM ciudades JOIN paises 
	                ON ciudades.codPais = paises.codPais
	                AND ciudades.codPais= '".$pais."'");
	
		while ($fila = mysqli_fetch_assoc($resultado)){
			$resultadoConsulta .= ','.$fila['ciudad'];
		}
	
		//Devolvemos la cadena de respuesta
		echo $msg.$resultadoConsulta;
		
		mysqli_free_result($resultado);
		mysqli_close($link);
	} 
	else {
	    echo 'No se han recibido datos';
	}
?>