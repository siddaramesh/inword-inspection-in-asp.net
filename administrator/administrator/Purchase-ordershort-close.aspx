<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Purchase-ordershort-close.aspx.cs" Inherits="administrator.Purchase_ordershort_close" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
<table>
<tr>
<th>Party Name</th>
<th>Item code</th>
<th>Item Name</th>
</tr>
<tr>
<td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Button ID="Button1" runat="server" Text="GO" />
</td>
</tr>
</table>
    <asp:GridView ID="GridView1" runat="server">
    <Columns>
    <asp:BoundField HeaderText="Party Name" />
    <asp:BoundField HeaderText="Order No" />
    <asp:BoundField HeaderText="Date" />
    <asp:BoundField HeaderText="Item Code" />
    <asp:BoundField HeaderText="Item Name" />
    <asp:BoundField HeaderText="Description" />
    <asp:BoundField HeaderText="Unit" />
    <asp:BoundField HeaderText="Order Qty" />
    <asp:BoundField HeaderText="Recd. Qty" />
    <asp:BoundField HeaderText="Bal. Qty" />
    <asp:BoundField HeaderText="Short. Qty" />
    </Columns>
    </asp:GridView>
    <table>
    <tr>
    <td>
        <asp:Button ID="Button2" runat="server" Text="Excel" />
    </td>
    <td>
        <asp:Button ID="Button3" runat="server" Text="Save" />
    </td>
    <td>
        <asp:Button ID="Button4" runat="server" Text="Close" />
    </td>
    </tr>
    </table>
</div>
</asp:Content>
