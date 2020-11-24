<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MovieLibrary.aspx.cs" Inherits="WebApp.SamplePages.MovieLibrary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Movie Library</h1>
    <div class="row">
        <div class="col-6">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList2" runat="server"></asp:RadioButtonList>

        </div>
        <div class="col-6">

        </div>
    </div>
</asp:Content>
