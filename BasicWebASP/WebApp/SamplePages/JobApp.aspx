<%@ Page Title="Job Application" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JobApp.aspx.cs" Inherits="WebApp.SamplePages.JobApp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Job Application</h1>
    <div class="row">
        <div class="offset-1 col-10">
            <blockquote class="alert alert-info" style="font-style:italic">
                This is a page to illustrate some  simple controls to fill out an online jobapplication
                The form will use a basic 2 column bootstrap layout. The form investigates the processing
                for a CheckBoxList control. Dats display will be a simple string
            </blockquote>
        </div>
    </div>
    <div class="row">
        <div class="col-6">
            <asp:Label ID="Label1" runat="server" Text="Name (Last, First)"></asp:Label>&nbsp;
            <asp:TextBox ID="Fullname" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>&nbsp;
            <asp:TextBox ID="EmailAddress" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Phone (best contact)"></asp:Label>&nbsp;
            <asp:TextBox ID="Phone" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Full or Part-time"></asp:Label>
            <asp:RadioButtonList ID="FullOrPartTime" runat="server"
                RepeatLayout="flow">

                <asp:ListItem>Full Time</asp:ListItem>
                <asp:ListItem>Part Time</asp:ListItem>
            </asp:RadioButtonList><br />
            <div class="row">
                <div class="col-2">
                    <asp:Label ID="Label5" runat="server" Text="Position(s)"></asp:Label>
                    <asp:CheckBoxList ID="Jobs" runat="server">

                        <asp:ListItem>&nbsp;Sales</asp:ListItem>
                        <asp:ListItem>&nbsp;Manufacturing</asp:ListItem>
                        <asp:ListItem>&nbsp;Accounting</asp:ListItem>
                        <asp:ListItem>&nbsp;Shipping/Receiving</asp:ListItem>
                        <asp:ListItem>&nbsp;Supervisor</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
            </div>
           </div>
         <div class="col-6">
             <asp:Button ID="Submit" runat="server" Text="Submit"
                 class="btn btn-secondary"/>&nbsp;&nbsp;
             <asp:Button ID="Clear" runat="server" Text="Clear"
                 class="btn btn-light"/>
             <br /><br />
             <asp:Label ID="MessageLabel" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
