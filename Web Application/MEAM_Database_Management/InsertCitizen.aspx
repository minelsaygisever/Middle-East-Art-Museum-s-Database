<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="InsertCitizen.aspx.cs" Inherits="MEAM_Database_Management.InsertCitizen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h3>Choose citizen type : </h3>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="STUDENT" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ADULT" />
    <div>
        <hr />
        <a href="Login.aspx">Login Page</a>
        <a href="Insert.aspx">Insert Page</a>
        <a href="InsertCitizen.aspx">Refresh Page</a>
    </div>
</asp:Content>
