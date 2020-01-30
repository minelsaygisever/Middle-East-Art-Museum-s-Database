<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="MEAM_Database_Management.Insert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h3>Select the table which you want to insert a new entry.
    </h3>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="VISITOR" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="PIECE" />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="EMPLOYEE" />
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="SHOP" />
    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="ITEM" />
    <div>
        <hr />
        <a href="Login.aspx">Login Page</a>
        <a href="Operations.aspx">Operations Page</a>
        <a href="Insert.aspx">Refresh Page</a>
    </div>
</asp:Content>
