<%@ Page Title="WebForm2" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <form>
        Correo electrónico
        <input type="text" />
        <button>Enviar</button>
    </form>
</asp:Content>
