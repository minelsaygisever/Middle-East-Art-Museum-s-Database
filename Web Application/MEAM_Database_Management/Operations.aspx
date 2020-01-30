<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Operations.aspx.cs" Inherits="MEAM_Database_Management.Operations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>MEAM DATABASE MANAGEMENT SYSTEM</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <h3>Select your operation.</h3>

    <asp:Button ID="OperationButton1" runat="server" OnClick="OperationButton1_Click" Text="INSERT" />
    &nbsp;
    <asp:Button ID="OperationButton2" runat="server" OnClick="OperationButton2_Click" Text="UPDATE" />
    &nbsp;
    <asp:Button ID="OperationButton3" runat="server" OnClick="OperationButton3_Click" Text="DELETE" />
    &nbsp;
    <asp:Button ID="OperationButton4" runat="server" OnClick="OperationButton4_Click" Text="SHOW" />

    <div>
        <hr />
        <a href="Login.aspx">Login Page</a>
        <a href="Operations.aspx">Refresh Page</a>
    </div>
</asp:Content>
