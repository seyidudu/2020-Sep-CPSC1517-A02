﻿<%@ Page Title="Test Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="WebApp.SamplePages.TestPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Test Page</h1>
    <div class ="row">
        <div class="col-7">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/erd.png" />
        </div>
        <div class="col-5">
            <h3>Scenario Description</h3>
            <p>This where the scenario description would be placed</p>
        </div>
   </div>

    <div class ="row">
        <div class="col-7">
         <h3>Class Diagram</h3>
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/class-diagram.png" />
        </div>
        <div class="col-5">
            <h3>Known Bugs</h3>
            <p>This is where the scenario description would be placed</p>
            <h3>sql Stored Procedures</h3>
            <ul>
                <li>Procedure 1</li>
                <li>Procedure 2</li>
            </ul>
        </div>
   </div>
    </asp:Content>
