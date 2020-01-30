<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="MEAM_Database_Management.Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h3>Select the table which you want to delete from.
    </h3>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Button ID="DeleteButton1" runat="server" OnClick="DeleteButton1_Click" Text="VISITOR" />
    &nbsp;
    <asp:Button ID="DeleteButton2" runat="server" OnClick="DeleteButton2_Click" Text="PIECE" />
    &nbsp;
    <asp:Button ID="DeleteButton3" runat="server" OnClick="DeleteButton3_Click" Text="EMPLOYEE" />
    &nbsp;
    <asp:Button ID="LinkButton4" runat="server" OnClick="DeleteButton4_Click" Text="SHOP" />
    &nbsp;
    <asp:Button ID="LinkButton5" runat="server" OnClick="DeleteButton5_Click" Text="ITEM" />


    <br />
    <p>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
    </p>
    <div>
        <hr />
        <a href="Login.aspx">Login Page</a>
        <a href="Operations.aspx">Operations Page</a>
        <a href="Delete.aspx">Refresh Page</a>
    </div>
</asp:Content>
