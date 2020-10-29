<%@ Page Title="Hello World" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="WebApp.HelloWorld" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Hello World</h1>
    <div class="row">
        <asp:Label ID="PromptLabel1" runat="server" 
            Text="Enter your name"></asp:Label>&nbsp;&nbsp;
        <asp:TextBox ID="NameArg" runat="server" 
            ToolTip="Enter your name"></asp:TextBox>&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" 
            Text="Press Me" OnClick="PressMe_Click" 
            CssClass="btn btn-primary" /><br /><br />
        <asp:Label ID="OutputArea" runat="server"></asp:Label>


    </div>
</asp:Content>
