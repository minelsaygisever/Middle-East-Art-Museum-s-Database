<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="UpdateEmployee.aspx.cs" Inherits="MEAM_Database_Management.UpdateEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="enterId" runat="server">
         <h3>Enter the Personal ID of the employee you want to update.
    </h3>
    <p>
        Personal ID &nbsp;
        <asp:TextBox ID="TextBoxPersonalID" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enter" style="height: 26px" />
    </p>
    </div>

    <div id="vis" runat="server">
        <h3>
            Personal ID = <asp:Label id="textid" runat="server" Text=""></asp:Label>
             <br />
        </h3>
        <h4>
            Change the informations you want.
        </h4>
        <p>
        Name =
        <asp:TextBox ID="TextBoxName" runat="server" required="required"></asp:TextBox>
        Task =
        <asp:TextBox ID="TextBoxTask" runat="server" required="required"></asp:TextBox>
        <br />
        <br />
        Salary =
        <asp:TextBox ID="TextBoxSalary" runat="server" required="required"></asp:TextBox>
        Address =
        <asp:TextBox ID="TextBoxAddress" runat="server" placeholder="District"></asp:TextBox>
        Email =
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        Shop Name =
        <asp:TextBox ID="TextBoxShop" runat="server"></asp:TextBox>
        Manager ID =
        <asp:TextBox ID="TextBoxManID" runat="server"></asp:TextBox>
        Birth =
        <asp:TextBox ID="TextBoxBirth" runat="server" placeholder="YYYY-MM-DD"></asp:TextBox>
        Phone Number =
        <asp:TextBox ID="TextBoxPhone" runat="server" TextMode="MultiLine" Rows="10" placeholder="Enter numbers line by line!" required="required"></asp:TextBox>
        <br />
        <br />
        Language =
        <asp:TextBox ID="TextBoxLangs" runat="server" TextMode="MultiLine" Rows="10" placeholder="Enter languages line by line!"></asp:TextBox>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" Style="height: 26px" />
        </p>
    </p>
    </div>

    <div id="vis2" runat="server">
        <h3>Updated version: </h3>
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
        <a href="UpdateEmployee.aspx">Refresh Page</a>
    </div>
</asp:Content>
