<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="UpdateShop.aspx.cs" Inherits="MEAM_Database_Management.UpdateShop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="nameEnter" runat="server">
          <h3>
              Enter the name of the shop you want to update.
          </h3>
          <p>
             Shop Name &nbsp;
             <asp:TextBox ID="TextBoxFirstShopName" runat="server"></asp:TextBox>
             <asp:Button ID="ButtonShopName" runat="server" OnClick="ButtonShopName_Click" Text="Enter" style="height: 26px" />
         </p>
          
      </div>

    <div id="shopUpdate" runat="server">
         <h3>
            Shop Name = <asp:Label id="textshop" runat="server" Text=""></asp:Label>
             <br />
        </h3>
        <h4>
            Change the informations you want.
        </h4>
        <p>
           
            Profit =
            <asp:TextBox ID="TextBoxProfit" runat="server"></asp:TextBox>
            <br />
            <br />
            Manager ID =
            <asp:TextBox ID="TextBoxManagerID" runat="server"></asp:TextBox>
            <br />
            <br />
            Phone Number =
            <asp:TextBox ID="TextBoxPhone" runat="server" TextMode="MultiLine" Rows="10" placeholder="Enter the numbers line by line!" required="required"></asp:TextBox>
            <br />
            <br />
            Items =
            <asp:TextBox ID="TextBoxItem" runat="server" TextMode="MultiLine" Rows="10" placeholder="Enter the barcodes line by line!" required="required"></asp:TextBox>
            <p>
                <asp:Button ID="ButtonUpdateShop" runat="server" OnClick="ButtonUpdateShop_Click" Text="Update" Style="height: 26px" />
           </p>
    </div>

    <div id="newTables" runat="server">
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
        <br />
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
        <br />
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
    </div>
    <div>
        <hr />
        <a href="Login.aspx">Login Page</a>
        <a href="Update.aspx">Update Page</a>
        <a href="UpdateShop.aspx">Refresh Page</a>
    </div>
</asp:Content>
