$(document).ready(function(){
    //recDetalles será nuestra función para enviar la solicitud ajax
    var recDetalles = function(id){
        return $.getJSON( "personas.php", { "id" : id });
    } // Fin de recDetalles
    
    //al hacer click sobre cualquier elemento que tenga el atributo data-usuario.....
    $('[data-usuario]').click(function(e){
        //Detenemos el comportamiento normal del evento click sobre el elemento clicado
        e.preventDefault();
        //Mostramos texto de que la solicitud está en curso
        $("#contenedor-de-respuesta").html("<p>Buscando...</p>");
        //this hace referencia al elemento que ha lanzado el evento click.
        //Con el método .data('usuario') obtenemos el valor del atributo data-usuario de dicho elemento 
        //y lo pasamos a la función recDetalles definida anteriormente.
        recDetalles($(this).data('usuario'))
            .done( function( respuesta ) {
            //done() es ejecutada cuando se recibe la respuesta del servidor. respuesta es el objeto JSON recibido
            if( respuesta.exito ) {                
                var salida  = "<h1>" + respuesta.data.mensaje+ "</h1>";
                //recorremos cada usuario
                $.each(respuesta.data.usuarios, function( key, value ) {
                    salida += "<h2>Detalles del usuario " + value['ID'] + "</h2>";
                    //recorremos los valores de cada usuario
                    $.each( value, function (usuariokey, usuariovalue) {
                        salida += '<ul>';
                        salida += '<li>' + usuariokey + ': ' + usuariovalue + "</li>";
                        salida += '</ul>';
                    }); // fin de each interno
                }); // fin de each externo
                
                //Actualizamos el HTML del elemento con id="#contenedor-de-respuesta"
                $("#contenedor-de-respuesta").html(salida );                
             } 
             else {
                //respuesta.exito no es true
                $("#contenedor-de-respuesta").html('No ha habido suerte: ' + respuesta.data.mensaje);
             } // fin de evaluacion de respuesta
        }) // fin del metodo done()
        
        .fail(function( jqXHR, textStatus, errorThrown ) {
            $("#contenedor-de-respuesta").html("Algo ha fallado: " +  textStatus);
        }); // Fin de fail
        
    }); // Fin del evento click del boton data-usuario
}); //Fin de ready