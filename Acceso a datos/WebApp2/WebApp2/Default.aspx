<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>        
        <asp:GridView ID="GridView1" runat="server" DataSourceID="EntityDataSource1">

        </asp:GridView>
        
    </div>

</asp:Content>
