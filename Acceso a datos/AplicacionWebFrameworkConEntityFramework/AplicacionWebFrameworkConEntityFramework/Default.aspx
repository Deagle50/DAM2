<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplicacionWebFrameworkConEntityFramework._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="formulario">
            <form method="post">
                <label>ID</label>
                <input id="txtNumero" type="number">
                <input type="button" onclick="buscar();" value="Buscar">
                <br />

                <label>Nombre completo</label>
                <input type="text" id="txtNombre" /><br />

                <label>Marca</label>
                <input type="text" id="txtMarca"/><br />
                

                <label>Forma</label>
                <input type="text" id="txtForma"/><br />

                <label>Pastillas</label>
                <input type="text" id="txtPastillas"/><br />

                <label>Color</label>
                <input type="text" id="txtColor"/><br />

                <label>Precio</label>
                <input type="number" id="txtPrecio"/><br />

                <input type="button" onclick="anterior();" value="Anterior" />
                <input type="button" onclick="siguiente();" value="Siguiente" />
                <input type="button" onclick="borrar();" value="Borrar" />
                <input type="button" onclick="anadir();" value="Añadir" />
                <input type="button" onclick="modificar();" value="Modificar" />
                
            </form>
        <br />
       
        </div>

    <script type="text/javascript">
        var datos, datos2;
        var num=-1;
        var siguienteID;
        function buscar() {
            //alert("pepito");
            var xmlhttp = new XMLHttpRequest();


            xmlhttp.onreadystatechange = function () {

                if (this.readyState == 4 && this.status == 200) {
                    num = document.getElementById("txtNumero").value - 1;
                    //alert(num);
                    datos = this.responseText;
                    datos2 = JSON.parse(datos);
                    if (num >= datos2.length) {
                        limpiarCampos();
                        alert("inserta un número válido");
                    }
                    else {
                        mostrarDatos();
                    }
                }
            }
            xmlhttp.open("GET", "https://localhost:44330/api/guitarras", true);
            xmlhttp.send();


        }

        function borrar() {
            
            var xmlhttp = new XMLHttpRequest();
            var id; 

            xmlhttp.onreadystatechange = function () {
                limpiarCampos();
                id = document.getElementById("txtNumero").value;
            }
            xmlhttp.open("DELETE", "https://localhost:44330/api/guitarras", true);
            xmlhttp.setRequestHeader("content-type", "application/json");
            xmlhttp.setRequestHeader("cache-control", "no-cache");
            xmlhttp.send(id);
        }

        function anadir() {
            var datosAnadir;
            var nuevaGuitarra = {};
            //alert("1");
            var xmlhttp = new XMLHttpRequest();
            xmlhttp.onreadystatechange = function () {

                if (this.readyState == 4 && this.status == 200) {
                    
                    
                    
                }
                nuevaGuitarra.id_guitarra = siguienteID;
                nuevaGuitarra.nombre = document.getElementById("txtNombre").value;
                nuevaGuitarra.marca = document.getElementById("txtMarca").value;
                nuevaGuitarra.forma = document.getElementById("txtForma").value;
                nuevaGuitarra.pastillas = document.getElementById("txtPastillas").value;
                nuevaGuitarra.color = document.getElementById("txtColor").value;
                nuevaGuitarra.precio = document.getElementById("txtPrecio").value;
                console.log(nuevaGuitarra);
                datosAnadir = JSON.stringify(nuevaGuitarra);
            }
            xmlhttp.open("POST", "https://localhost:44330/api/guitarras", true);
            xmlhttp.setRequestHeader("content-type", "application/json");
            xmlhttp.setRequestHeader("cache-control", "no-cache");
            xmlhttp.send(datosAnadir);
            alert("2");
            siguienteID++;
        }

        function modificar() {
            var datosAnadir;
            var nuevaGuitarra = {};
            var id;
            var xmlhttp = new XMLHttpRequest();
            xmlhttp.onreadystatechange = function () {

                if (this.readyState == 4 && this.status == 200) {



                }
                id = document.getElementById("txtNumero").value;
                nuevaGuitarra.id_guitarra = document.getElementById("txtNumero").value;
                nuevaGuitarra.nombre = document.getElementById("txtNombre").value;
                nuevaGuitarra.marca = document.getElementById("txtMarca").value;
                nuevaGuitarra.forma = document.getElementById("txtForma").value;
                nuevaGuitarra.pastillas = document.getElementById("txtPastillas").value;
                nuevaGuitarra.color = document.getElementById("txtColor").value;
                nuevaGuitarra.precio = document.getElementById("txtPrecio").value;
                console.log(nuevaGuitarra);
                datosAnadir = JSON.stringify(nuevaGuitarra);
            }
            xmlhttp.open("PUT", "https://localhost:44330/api/guitarras", true);
            xmlhttp.setRequestHeader("content-type", "application/json");
            xmlhttp.setRequestHeader("cache-control", "no-cache");
            xmlhttp.send(id, datosAnadir);
            alert("2");
            
        }

        function siguiente() {
            num++;
            
            if (num >= datos2.length) {
                limpiarCampos();
                alert("Fuera de rango");
                num--;
            }
            else {
                mostrarDatos();                
                cambiarTxtNumero();
            }
        }

        function anterior() {
            num--;
            if (num < 0) {
                limpiarCampos();
                alert("Fuera de rango");
                num++;
            }
            else {
                mostrarDatos();
                cambiarTxtNumero();
            }
        }

        function mostrarDatos() {
            document.getElementById("txtNombre").value = datos2[num].nombre;
            document.getElementById("txtMarca").value = datos2[num].marca;
            document.getElementById("txtForma").value= datos2[num].forma;
            document.getElementById("txtPastillas").value= datos2[num].pastillas;
            document.getElementById("txtColor").value = datos2[num].color;
            document.getElementById("txtPrecio").value= datos2[num].precio;

            //Calcular id siguiente para añadir
            siguienteID = datos2.length + 1;
            
        }

        function limpiarCampos() {
            document.getElementById("txtNombre").value = "";
            document.getElementById("txtMarca").value = "";
            document.getElementById("txtForma").value = "";
            document.getElementById("txtPastillas").value = "";
            document.getElementById("txtColor").value = "";
            document.getElementById("txtPrecio").value = "";

            document.getElementById("txtNumero").value = "";
        }

        function cambiarTxtNumero() {
            document.getElementById("txtNumero").value = num + 1;
        }
    </script>
</asp:Content>
