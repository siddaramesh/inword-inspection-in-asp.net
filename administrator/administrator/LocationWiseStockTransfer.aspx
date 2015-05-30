<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LocationWiseStockTransfer.aspx.cs" Inherits="administrator.LocationWiseStockTransfer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
<fieldset>
<legend>Location Wise Stock Transfer</legend>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="Doc No"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label2" runat="server" Text="Doc Date"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label3" runat="server" Text="Remark"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
</td>
</tr>
</table>
</fieldset>
<fieldset>
<legend>Material Detail</legend>
    <asp:GridView ID="GridView1" runat="server">
    <Columns>
    <asp:BoundField HeaderText="Sr. No" />
     <asp:BoundField HeaderText="Item code" />
    <asp:BoundField HeaderText="Item Name" />
    <asp:BoundField HeaderText="P. Unit" />
    <asp:BoundField HeaderText="S. Unit" />
    <asp:BoundField HeaderText="From store" />
    <asp:BoundField HeaderText="Stock" />
    <asp:BoundField HeaderText="To Store" />
    <asp:BoundField HeaderText="Trans. Qty" />
    <asp:BoundField HeaderText="S. Qty" />
    <asp:BoundField HeaderText="Remark" />
    </Columns>
    </asp:GridView>
</fieldset>
<table>
<tr>
<td>
    <asp:Button ID="Button1" runat="server" Text="Save" />
</td>
<td>
    <asp:Button ID="Button2" runat="server" Text="Cancel" />
</td>
</tr>
</table>
</div>
</asp:Content>
