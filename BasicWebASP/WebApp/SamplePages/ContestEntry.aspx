﻿<%@ Page Title="Contest Entry" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="ContestEntry.aspx.cs" Inherits="WebApp.SamplePages.ContestEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h1>Contest Entry</h1>
    </div>

    <div class="row col-md-12">
        <div class="alert alert-info">
            <blockquote style="font-style: italic">
                This illustrates some simple controls to fill out an entry form for a contest. 
                This form will use basic bootstrap formatting and illustrate Validation.
            </blockquote>
            <p>
                Please fill out the following form to enter the contest. This contest is only available to residents in Western Canada.
            </p>

        </div>
    </div>
    <%-- samples of validation controls --%>
    <asp:RequiredFieldValidator ID="RequiredFirstName" runat="server" 
        ErrorMessage="First name is required"
        ControlToValidate="FirstName" SetFocusOnError="true"
        ForeColor="Firebrick" Display="None">
    </asp:RequiredFieldValidator>
    <%-- left off Display="None" surpasee the autpo display of the next paramete
        The Text parameter will display WHERE the validation control is CODED in your file
        If you do NOT assign a value to the TEXT parameter, it DEFAULTS to the ErrorMessage--%>
    <asp:RequiredFieldValidator ID="RequiredLastName" runat="server" 
        ErrorMessage="Last name is required"
        ControlToValidate="StreetAddress1" SetFocusOnError="true"
        ForeColor="Firebrick" Display="None">
    </asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredStreetAddress1" runat="server" 
        ErrorMessage="Street Address1 is required"
        ControlToValidate="StreetAddress1" SetFocusOnError="true"
        ForeColor="Firebrick" Display="None">
    </asp:RequiredFieldValidator>
     
    <asp:RequiredFieldValidator ID="RequiredPostalCode" runat="server" 
        ErrorMessage="Postal Code is required"
        ControlToValidate="PostalCode" SetFocusOnError="true"
        ForeColor="Firebrick" Display="None">
    </asp:RequiredFieldValidator>
    
    <asp:RequiredFieldValidator ID="RequiredCity" runat="server" 
        ErrorMessage="City is required"
        ControlToValidate="City" SetFocusOnError="true"
        ForeColor="Firebrick" Display="None">
    </asp:RequiredFieldValidator>
     <asp:RequiredFieldValidator ID="RequiredEmailAddress" runat="server" 
        ErrorMessage="EmailAddress is required"
        ControlToValidate="EmailAddress" SetFocusOnError="true"
        ForeColor="Firebrick" Display="None">
    </asp:RequiredFieldValidator>
     <asp:RequiredFieldValidator ID="RequiredCheckAnswer" runat="server" 
        ErrorMessage="Skill testing answer is required"
        ControlToValidate="CheckAnswer" SetFocusOnError="true"
        ForeColor="Firebrick" Display="None">
    </asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator ID="RegExPostalCode" runat="server" 
        ErrorMessage="Invalid Postal Code (ex.T6T6Y0)"
        ControlToValidate="PostalCode" SetFocusOnError="true"
        ForeColor="Firebrick" Display="None"
        ValidationExpression="[A-Z a-z][0-9][A-Z a-z][0-9][A-Z a-z][0-9]">
    </asp:RegularExpressionValidator>
     <asp:RegularExpressionValidator ID="RegExEmailAddress" runat="server" 
        ErrorMessage="Invalid Email Address"
        ControlToValidate="EmailAddress" SetFocusOnError="true"
        ForeColor="Firebrick" Display="None"
        ValidationExpression="^#w+([-+.']\w+)*@\w+([-.]\w+)*\.w+([-.]\w+)*$">
    </asp:RegularExpressionValidator>

    <%-- on the form we do NOt have a field suitable to demo the RangeValidator
        for this example we will use the StreetAddress2 to demo the validator
        
        for rhi validator, use your Type paramaeter to identify the datatype
        for the check--%>
    <asp:RangeValidator ID="RangeStreeAddress2" runat="server" 
        ErrorMessage="Number Must be betweeen 0.0 and 100.0"
         ControlToValidate="StreetAddress2" SetFocusOnError="true"
        ForeColor="Firebrick" Display="None"
        MinimumValue="0.0" MaximumValue="100.0" Type="Double">
        </asp:RangeValidator>

    <%-- samples of the compare validator
        a) check the datatype of a control
        b) check the contents of a control to a literal value
        C) check the contents of a control against the contents of a second control

        REMEMBER the Type paramer IS required if your datatype comparison is anything other than a sting
        --%>

    <%-- a) check the datatype of a control --%>
   <%-- <asp:CompareValidator ID="CompareCheckAnswer" runat="server" 
        ErrorMessage="Skill testing value is not a number"
       SetFocusOnError="true" ForeColor="Firebrick" Display="None"
         ControlToValidate="CheckAnswwer" Operator="DataTypeCheck" Type="Integer">
    </asp:CompareValidator>--%>

    <%--b) check the contents of a control to a literal value--%>
    <%-- <asp:CompareValidator ID="CompareCheckAnswer" runat="server" 
        ErrorMessage="Skill testing value is incorrect"
       SetFocusOnError="true" ForeColor="Firebrick" Display="None" Type="Integer"
         ControlToValidate="CheckAnswwer" Operator="Equal"  ValueToCompare="15">
    </asp:CompareValidator>--%>

    <%-- C) check the contents of a control against the contents of a second control --%>
   <%--  <asp:CompareValidator ID="CompareCheckAnswer" runat="server" 
        ErrorMessage="Skill testing value is notequal to Street Address2"
       SetFocusOnError="true" ForeColor="Firebrick" Display="None" Type="Integer"
         ControlToValidate="CheckAnswwer" Operator="Equal" ControlToCompare="StreetAddress2">
    </asp:CompareValidator>--%>
    <div class="row">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        CssClass="alert alert-danger"
        HeaderText="Data entry errors. Examine your data to resolve the following concerns"/>
    </div>
    <div class="row">
        <div class ="col-md-6">
            <fieldset class="form-horizontal">
                <legend>Contest Application Form</legend>

                <asp:Label ID="Label1" runat="server" Text="First Name"
                     AssociatedControlID="FirstName"></asp:Label>
                <asp:TextBox ID="FirstName" runat="server" 
                    ToolTip="Enter your first name." MaxLength="25"></asp:TextBox> 
                  
                 <asp:Label ID="Label6" runat="server" Text="Last Name"
                     AssociatedControlID="LastName"></asp:Label>
                <asp:TextBox ID="LastName" runat="server" 
                    ToolTip="Enter your last name." MaxLength="25"></asp:TextBox> 
                        
                <asp:Label ID="Label3" runat="server" Text="Street Address 1"
                     AssociatedControlID="StreetAddress1"></asp:Label>
                <asp:TextBox ID="StreetAddress1" runat="server" 
                    ToolTip="Enter your street address." MaxLength="75"></asp:TextBox> 
                  
                  <asp:Label ID="Label7" runat="server" Text="Street Address 2"
                     AssociatedControlID="StreetAddress2"></asp:Label>
                <asp:TextBox ID="StreetAddress2" runat="server" 
                    ToolTip="Enter your additional street address." MaxLength="75"></asp:TextBox> 
                  <br />
                 <asp:Label ID="Label8" runat="server" Text="City"
                     AssociatedControlID="City"></asp:Label>
                <asp:TextBox ID="City" runat="server" 
                    ToolTip="Enter your City name" MaxLength="50"></asp:TextBox> 
                  
                 <asp:Label ID="Label9" runat="server" Text="Province"
                     AssociatedControlID="Province"></asp:Label>
                <asp:DropDownList ID="Province" runat="server" Width="75px">
                    <asp:ListItem Value="AB" Text="AB"></asp:ListItem>
                     <asp:ListItem Value="BC" Text="BC"></asp:ListItem>
                     <asp:ListItem Value="MN" Text="MN"></asp:ListItem>
                     <asp:ListItem Value="SK" Text="SK"></asp:ListItem>
                </asp:DropDownList>
                  
                 <asp:Label ID="Label10" runat="server" Text="Postal Code"
                     AssociatedControlID="PostalCode"></asp:Label>
                <asp:TextBox ID="PostalCode" runat="server" 
                    ToolTip="Enter your postal code"  MaxLength="6"></asp:TextBox> 
                 
                <asp:Label ID="Label2" runat="server" Text="Email"
                     AssociatedControlID="EmailAddress"></asp:Label>
                <asp:TextBox ID="EmailAddress" runat="server" 
                    ToolTip="Enter your email address"
                     TextMode="Email"></asp:TextBox> 
                  
              </fieldset>   
           <p>Note: You must agree to the contest terms in order to be entered.
               <br />
               <asp:CheckBox ID="Terms" runat="server" Text="&nbsp;I agree to the terms of the contest" />
           </p>

            <p>
                Enter your answer to the following calculation instructions:<br />
                Multiply 15 times 6<br />
                Add 240<br />
                Divide by 11<br />
                Subtract 15<br />
                <%-- html validation --%>
                <asp:TextBox ID="CheckAnswer" runat="server" TextMode="Number" step="1" ></asp:TextBox>
            </p>
        </div>
        <div class="col-md-6">   
            <div class="col-md-offset-2">
                <p>
                    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />&nbsp;&nbsp;
                    <asp:Button ID="Clear" runat="server" Text="Clear" 
                        OnClick="Clear_Click"  />
                </p>
                <asp:Label ID="Message" runat="server" ></asp:Label><br />
                <%-- add a control to display a collection of records similar to
                       using a WebGrid in Razor--%>
                <asp:GridView ID="EntryList" runat="server">

                </asp:GridView>
            </div>
        </div>
    </div>
    <%-- this script tag is REQUIRED for bootwrap.freecode to execute --%>
    <script src="../Scripts/bootwrap-freecode.js"></script>
</asp:Content>