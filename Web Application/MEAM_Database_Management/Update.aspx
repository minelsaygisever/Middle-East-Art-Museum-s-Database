<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="MEAM_Database_Management.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <h3>Select the table which you want to update an entry from.
    </h3>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="UpdateButton3" runat="server" OnClick="UpdateButton3_Click" Text="EMPLOYEE" />
     &nbsp;
    <asp:Button ID="UpdateButton4" runat="server" OnClick="UpdateButton4_Click" Text="SHOP" />
    &nbsp;
    <asp:Button ID="UpdateButton5" runat="server" OnClick="UpdateButton5_Click" Text="ITEM" />
    <div>
        <hr />
        <a href="Login.aspx">Login Page</a>
        <a href="Operations.aspx">Operations Page</a>
        <a href="Update.aspx">Refresh Page</a>
    </div>
</asp:Content>
