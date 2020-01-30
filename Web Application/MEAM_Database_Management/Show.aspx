<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="MEAM_Database_Management.Show" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h3>Select the table which you want to show from.</h3>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="ShowButton1" runat="server" OnClick="ShowButton1_Click" Text="VISITOR" />
    &nbsp;
    <asp:Button ID="ShowButton2" runat="server" OnClick="ShowButton2_Click" Text="PIECE" />
    &nbsp;
    <asp:Button ID="ShowButton3" runat="server" OnClick="ShowButton3_Click" Text="EMPLOYEE" />
    &nbsp;
    <asp:Button ID="ShowButton4" runat="server" OnClick="ShowButton4_Click" Text="SHOP" />
    &nbsp;
    <asp:Button ID="ShowButton5" runat="server" OnClick="ShowButton5_Click" Text="ITEM" />
    <div>
        <hr />
        <a href="Login.aspx">Login Page</a>
        <a href="Operations.aspx">Operations Page</a>
        <a href="Show.aspx">Refresh Page</a>
    </div>

</asp:Content>
