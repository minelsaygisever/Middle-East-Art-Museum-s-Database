<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="DeletePiece.aspx.cs" Inherits="MEAM_Database_Management.DeletePiece" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <h3>Select the piece type that you want to delete.
    </h3>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="DeletePieceButton1" runat="server" OnClick="DeletePieceButton1_Click" Text="PAINTING" />
    &nbsp;
    <asp:Button ID="DeleteButton2" runat="server" OnClick="DeletePieceButton2_Click" Text="SCULPTURE" />
    &nbsp;
    <asp:Button ID="DeleteButton3" runat="server" OnClick="DeletePieceButton3_Click" Text="CLOTHES" />
     &nbsp;
    <asp:Button ID="LinkButton4" runat="server" OnClick="DeletePieceButton4_Click" Text="TOOL" />
    <div>
        <hr />
        <a href="Login.aspx">Login Page</a>
        <a href="Delete.aspx">Delete Page</a>
        <a href="DeletePiece.aspx">Refresh Page</a>
    </div>
   
</asp:Content>
