<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="InsertReceipt.aspx.cs" Inherits="MEAM_Database_Management.InsertReceipt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h4>Receipt Table : </h4>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
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
    <hr />
    <div>
        Shop Name =
        <asp:TextBox ID="TextBoxSName" runat="server" required="required"></asp:TextBox>
        Visitor Number =
        <asp:TextBox ID="TextBoxVNum" runat="server" required="required" placeholder="????"></asp:TextBox>
        Receipt Number =
        <asp:TextBox ID="TextBoxRNum" runat="server" required="required" placeholder="????"></asp:TextBox>
        <br />
        <br />
        Cost =
        <asp:TextBox ID="TextBoxCost" runat="server" required="required"></asp:TextBox>
        Cutting Day =
        <asp:TextBox ID="TextBoxDay" runat="server" required="required"></asp:TextBox>
        Cutting Month =
        <asp:TextBox ID="TextBoxMonth" runat="server" required="required"></asp:TextBox>
        Cutting Year =
        <asp:TextBox ID="TextBoxYear" runat="server" required="required"></asp:TextBox>
        <br />
        <br />
        Cutting Hour =
        <asp:TextBox ID="TextBoxHour" runat="server" required="required"></asp:TextBox>
        Cutting Minute =
        <asp:TextBox ID="TextBoxMin" runat="server" required="required"></asp:TextBox>
        Cashier =
        <asp:TextBox ID="TextBoxCashier" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enter" Style="height: 26px" />
        </p>
    </div>
    <hr />
    <h4>New Receipt Table : </h4>
    <p>
        <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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
        <a href="Insert.aspx">Insert Page</a>
        <a href="InsertReceipt.aspx">Refresh Page</a>
    </div>
</asp:Content>
