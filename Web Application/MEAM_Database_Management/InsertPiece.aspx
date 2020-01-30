<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="InsertPiece.aspx.cs" Inherits="MEAM_Database_Management.InsertPiece" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h3>Choose piece type : </h3>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="PAINTING" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="SCULPTURE" />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="TOOL" />
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="CLOTHES" />
    <div>
        <hr />
        <a href="Login.aspx">Login Page</a>
        <a href="Insert.aspx">Insert Page</a>
        <a href="InsertPiece.aspx">Refresh Page</a>
    </div>
</asp:Content>
