<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="InsertTool.aspx.cs" Inherits="MEAM_Database_Management.InsertTool" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h4>Piece Table : </h4>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
    <h4>Tools Table : </h4>
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

    <hr />

    <div>
        Number =
        <asp:TextBox ID="TextBoxNumber" runat="server" required="required" placeholder="???"></asp:TextBox>
        Name =
        <asp:TextBox ID="TextBoxName" runat="server" required="required"></asp:TextBox>
        Description =
        <asp:TextBox ID="TextBoxDecription" runat="server"></asp:TextBox>
        <br />
        <br />
        Year of Made =
        <asp:TextBox ID="TextBoxYoM" runat="server"></asp:TextBox>
        Entry Day =
        <asp:TextBox ID="TextBoxDay" runat="server"></asp:TextBox>
        Entry Month =
        <asp:TextBox ID="TextBoxMonth" runat="server"></asp:TextBox>
        Entry Year =
        <asp:TextBox ID="TextBoxYear" runat="server"></asp:TextBox>
        <br />
        <br />
        Entry Hour =
        <asp:TextBox ID="TextBoxHour" runat="server"></asp:TextBox>
        Country of Origin =
        <asp:TextBox ID="TextBoxCoO" runat="server"></asp:TextBox>
        Personal ID =
        <asp:TextBox ID="TextBoxPersonalID" runat="server" required="required"></asp:TextBox>
        <br />
        <br />
        Category =
        <asp:TextBox ID="TextBoxCategory" runat="server" required="required"></asp:TextBox>
        Owner =
        <asp:TextBox ID="TextBoxOwner" runat="server"></asp:TextBox>
        Materials =
        <asp:TextBox ID="TextBoxMaterials" runat="server" TextMode="MultiLine" Rows="10" placeholder="Enter materials line by line!" required="required"></asp:TextBox>

        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enter" Style="height: 26px" />
        </p>
    </div>

    <hr />

    <p>
        <h5>New Piece_T : </h5>
        <asp:GridView ID="GridView3" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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
    <p>
        <h5>New Tools_T : </h5>
        <asp:GridView ID="GridView4" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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
    <p>
        <h5>New Tools_Materials_T : </h5>
        <asp:GridView ID="GridView5" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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
        <a href="InsertTool.aspx">Refresh Page</a>
    </div>
</asp:Content>
