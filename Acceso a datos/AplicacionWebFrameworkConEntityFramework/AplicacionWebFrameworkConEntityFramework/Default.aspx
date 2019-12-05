<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplicacionWebFrameworkConEntityFramework._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="datos">
        <label>Nombre</label>
        <label id="txtNombre"></label>
        <button id="btnMostrar" onclick="buscar();">Mostrar datos</button>
    </div>

    <script type="text/javascript">
        var datos, datos2;
        var num;
        function buscar() {
            //alert("pepito");
            var xmlhttp = new XMLHttpRequest();
            //alert("1");
            console.log("2");
            xmlhttp.onreadystatechange = function () {

                if (this.readyState == 4 && this.status == 200) {
              //      alert("2");
                    datos = this.responseText;
                    datos2 = JSON.parse(datos);
                    console.log(datos2);
                    document.getElementById("txtNombre").innerText = datos2;
                //    alert("2");
                }
            }
            xmlhttp.open("GET", "https://localhost:44330/api/guitarras", true);
            xmlhttp.send();


        }
    </script>
</asp:Content>
