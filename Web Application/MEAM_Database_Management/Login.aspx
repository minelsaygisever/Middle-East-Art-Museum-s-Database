<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MEAM_Database_Management.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>MEAM DATABASE MANAGEMENT SYSTEM</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <b>
            USER ACCOUNT
        </b>
    </p>

    <p>
        Employee Id&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Password&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Style="height: 26px" />
    </p>
    <p>
        &nbsp;
    </p>

</asp:Content>
