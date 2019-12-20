<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>        
        <asp:GridView ID="GridView1" runat="server">

        </asp:GridView>
        
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        
        <asp:Button ID="btnMostrar1" runat="server" OnClick="btnMostrar1_Click" Text="Mostrar uno" />
        
        <asp:Button ID="btnMostrarTodos" runat="server" OnClick="btnMostrarTodos_Click" Text="Mostrar todos" />
        
    </div>

</asp:Content>
