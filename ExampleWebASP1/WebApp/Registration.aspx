<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApp.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h5 class="col-md-12 text-center">User Registration</h5>
    <div class="row">
        <div class="col-md-6  text-right">
            <asp:Label ID="fName" runat="server" 
                Text="First Name"></asp:Label><br />
                </div>
        <div class="col-md-6">
            <asp:TextBox ID="firstName" runat="server" 
                ToolTip="Enter your First Name"
                 placeholder="your first name"></asp:TextBox><br /><br />
             </div>
        <div class="col-md-6  text-right">
              <asp:Label ID="lName" runat="server" 
                Text="Last Name"></asp:Label>
            </div>
        <div class="col-md-6">
            <asp:TextBox ID="lastName" runat="server" 
                ToolTip="Enter your Last Name"
                 placeholder="your last name"></asp:TextBox><br /><br />
            </div>
        <div class="col-md-6  text-right">
            <asp:Label ID="user" runat="server" 
                Text="User Name"></asp:Label>
            </div>
        <div class="col-md-6">
            <asp:TextBox ID="userName" runat="server" 
                ToolTip="Enter your User Name"
                 placeholder="your user name"></asp:TextBox><br /><br />
            </div>
        <div class="col-md-6  text-right">
             <asp:Label ID="email" runat="server" 
                Text="Email Address"></asp:Label>
            </div>
        <div class="col-md-6">
            <asp:TextBox ID="emailAddress" runat="server" 
                ToolTip="Enter your Email Address"
                 placeholder="your email address"></asp:TextBox><br /><br />
            </div>
        <div class="col-md-6 text-right">
            <asp:Label ID="cemail" runat="server" 
                Text="Confirm Email"></asp:Label>
            </div>
        <div class="col-md-6">
            <asp:TextBox ID="confirmEmail" runat="server" 
                ToolTip="Confirm your Email Address"
                 placeholder="confirm email address"></asp:TextBox><br /><br />
            </div>
        <div class="col-md-6 text-right">
            <asp:Label ID="pwd" runat="server" 
                Text="Password"></asp:Label>
                  </div>
        <div class="col-md-6">
            <asp:TextBox ID="password" runat="server" 
                ToolTip="Enter your password"
                 placeholder="your password"></asp:TextBox><br /><br />
            </div>
        <div class="col-md-6 text-right">
            <asp:Label ID="cpwd" runat="server" 
                Text="Confirm Password"></asp:Label>
                  </div>
        <div class="col-md-6">
            <asp:TextBox ID="confirmPassword" runat="server" 
                ToolTip="Confirm your password"
                 placeholder="confirm your password"></asp:TextBox><br /><br />
          </div>
        <div class="col-md-12 text-center">
            <asp:CheckBox ID="agree" runat="server" />
            <asp:Label ID="agreeToTerms" runat="server" Text="I agreee to the terms of the site"></asp:Label>
            </div>
        </div>
        <div class="col-md-12 text-center">
            <asp:Button ID="submit" runat="server"
                CssClass="btn btn-primary" Text="Submit Registration" OnClick="PressMe_Click" /><br />
            <asp:Label ID="OutputArea" runat="server"></asp:Label>
        </div>
   
</asp:Content>
