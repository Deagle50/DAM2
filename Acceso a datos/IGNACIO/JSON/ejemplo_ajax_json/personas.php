<?php
if( isset($_GET['id']) ) {
    get_personas($_GET['id']);
} else {
    die("Solicitud no vÃ¡lida.");
}

function get_personas( $id ) {    
    //Cambia por los detalles de tu base datos
    $servidor = "localhost";
    $usuario = "root";
    $password = "";
    $bdatos = "json";
    
    $bd = new mysqli($servidor, $usuario, $password, $bdatos);
    
    if($bd->connect_errno) {
        die("No se pudo conectar a la base de datos");
    }
    
    $datosjson = array();
    
    //Desinfectamos la entrada y prepararamos la consulta
    if( is_array($id) ) {
        //Ejecutamos la funcion intval entregándole el array
        $id = array_map('intval', $id);
        $consulta = "WHERE `ID` IN (" . implode( ',', $id ) . ")";
    } else {
        $id = intval($id);
        $consulta = "WHERE `ID` = " . $id;
    }
    
    if ( $resultado = $bd->query( "SELECT * FROM `tablausuarios` " . $consulta ) ) {        
        if( $resultado->num_rows > 0 ) {            
            $datosjson["exito"] = true;
            $datosjson["data"]["mensaje"] = sprintf("Se han encontrado %d usuarios", $resultado->num_rows);
            $datosjson["data"]["usuarios"] = array();
            while( $fila = $resultado->fetch_object() ) {
                //$jsondata["data"]["usuarios"][] es un array no asociativo. 
                //Tendremos que utilizar JSON_FORCE_OBJECT en json_encode si no
                //queremos recibir un array en lugar de un objeto JSON en la respuesta.
                //Ver http://www.php.net/manual/es/function.json-encode.php para más información
                $datosjson["data"]["usuarios"][] = $fila;
            }            
        } else {            
            $datosjson["exito"] = false;
            $datosjson["data"] = array('mensaje' => 'No se encontró ningún resultado.');            
        }        
        $resultado->close();        
    } else {        
        $datosjson["exito"] = false;
        $datosjson["data"] = array('mensaje' => $bd->error);        
    }
    
    header('Content-type: application/json; charset=utf-8');
    echo json_encode($datosjson, JSON_FORCE_OBJECT);
    
    $bd->close();    
}

exit();                            