<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="UpdateItem.aspx.cs" Inherits="MEAM_Database_Management.UpdateItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div id="choose" runat="server">
          <h3>
              What type of your item?
          </h3>
          <p>
              <asp:Button ID="ButtonSouvenir" runat="server" OnClick="ButtonSouvenir_Click" Text="Souvenir" Style="height: 26px" />
          </p>
          <p>
              <asp:Button ID="ButtonBook" runat="server" OnClick="ButtonBook_Click" Text="Book" Style="height: 26px" />
          </p>
          <p>
              <asp:Button ID="ButtonItem" runat="server" OnClick="ButtonItem_Click" Text="Food or Drink" Style="height: 26px" />
          </p>
          
      </div>

    <div id="itemBarcode" runat="server">
         <h3>Enter the barcode of the item you want to update.</h3>
         <p>
             Barcode &nbsp;
             <asp:TextBox ID="TextBoxFirstItemBarcode" runat="server"></asp:TextBox>
             <asp:Button ID="ButtonItemBarcode" runat="server" OnClick="ButtonItemBarcode_Click" Text="Enter" style="height: 26px" />
         </p>
    </div>

    <div id="itemUpdate" runat="server">
        <h3>
            Barcode = <asp:Label id="textbarcode" runat="server" Text=""></asp:Label>
             <br />
        </h3>
        <h4>
            Change the informations you want.
        </h4>
        <p>
            
            Name =
            <asp:TextBox ID="TextBoxItemName" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Description =
            <asp:TextBox ID="TextBoxItemDes" runat="server"></asp:TextBox>
            <br />
            <br />
            Price =
            <asp:TextBox ID="TextBoxItemPrice" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Tax Percentage =
            <asp:TextBox ID="TextBoxItemTaxPer" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Item Supplier Tax Number =
            <asp:TextBox ID="TextBoxItemSupTax" runat="server" required="required"></asp:TextBox>
             <p>
            <asp:Button ID="ButtonUpdateItem" runat="server" OnClick="ButtonUpdateItem_Click" Text="Update" Style="height: 26px" />
        </p>
    </div>

     <div id="newItem" runat="server">
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
        </div>

    <div id="souvenirBarcode" runat="server">
         <h3>Enter the barcode of the item you want to update.</h3>
         <p>
             Barcode &nbsp;
             <asp:TextBox ID="TextBoxFirstSouvenirBarcode" runat="server"></asp:TextBox>
             <asp:Button ID="ButtonSouvenirBarcode" runat="server" OnClick="ButtonSouvenirBarcode_Click" Text="Enter" style="height: 26px" />
         </p>
    </div>

    <div id="souvenirUpdate" runat="server">
         <h3>
            Barcode = <asp:Label id="textsbarcode" runat="server" Text=""></asp:Label>
             <br />
        </h3>
        <h4>
            Change the informations you want.
        </h4>
        <p>
           
            Name =
            <asp:TextBox ID="TextBoxSouvenirName" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Description =
            <asp:TextBox ID="TextBoxSouvenirDes" runat="server"></asp:TextBox>
            <br />
            <br />
            Price =
            <asp:TextBox ID="TextBoxSouvenirPrice" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Tax Percentage =
            <asp:TextBox ID="TextBoxSouvenirTaxPer" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Item Supplier Tax Number =
            <asp:TextBox ID="TextBoxSouvenirSupTax" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Category =
            <asp:TextBox ID="TextBoxSouvenirCategory" runat="server" ></asp:TextBox>
             <p>
            <asp:Button ID="ButtonUpdateSouvenir" runat="server" OnClick="ButtonUpdateSouvenir_Click" Text="Update" Style="height: 26px" />
        </p>
    </div>

   <div id="newSouvenir" runat="server">
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

    <div id="bookBarcode" runat="server">
         <h3>Enter the barcode of the item you want to update.</h3>
         <p>
             Barcode &nbsp;
             <asp:TextBox ID="TextBoxFirstBookBarcode" runat="server"></asp:TextBox>
             <asp:Button ID="ButtonBookBarcode" runat="server" OnClick="ButtonBookBarcode_Click" Text="Enter" style="height: 26px" />
         </p>
    </div>

    <div id="bookUpdate" runat="server">
         <h3>
            Barcode = <asp:Label id="textbbarcode" runat="server" Text=""></asp:Label>
             <br />
        </h3>
        <h4>
            Change the informations you want.
        </h4>
        <p>
            Name =
            <asp:TextBox ID="TextBoxBookName" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Description =
            <asp:TextBox ID="TextBoxBookDes" runat="server"></asp:TextBox>
            <br />
            <br />
            Price =
            <asp:TextBox ID="TextBoxBookPrice" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Tax Percentage =
            <asp:TextBox ID="TextBoxBookTaxPer" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Item Supplier Tax Number =
            <asp:TextBox ID="TextBoxBookSupTax" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Author =
            <asp:TextBox ID="TextBoxBookAuthor" runat="server" ></asp:TextBox>
             <br />
            <br />
            Genre =
            <asp:TextBox ID="TextBoxBookGenre" runat="server" ></asp:TextBox>
             <p>
            <asp:Button ID="ButtonUpdateBook" runat="server" OnClick="ButtonUpdateBook_Click" Text="Update" Style="height: 26px" />
        </p>
    </div>

   <div id="newBook" runat="server">
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
       <br />
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
    </div>
    <div>
        <hr />
        <a href="Login.aspx">Login Page</a>
        <a href="Update.aspx">Update Page</a>
        <a href="UpdateItem.aspx">Refresh Page</a>
    </div>


</asp:Content>
