<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MaterialRequirementPlanning.aspx.cs" Inherits="administrator.MaterialRequirementPlanning" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
<fieldset>
<legend>Generate MRP</legend>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="From"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label2" runat="server" Text="To"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
</td>
<td>
    <asp:Button ID="Button1" runat="server" Text="View" />
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label3" runat="server" Text="No Of Orders"></asp:Label>
</td>
<td>
    <asp:Label ID="Label4" runat="server" Text="0"></asp:Label>
</td>
</tr>
</table>
    <asp:GridView ID="GridView1" runat="server">
    <Columns>
    <asp:BoundField HeaderText="Order Date" />
    <asp:BoundField HeaderText="Order No" />
    <asp:BoundField HeaderText="Party Code" />
    <asp:BoundField HeaderText="Item Code" />
    <asp:BoundField HeaderText="Item Name" />
<asp:BoundField HeaderText="P. Unit" />
<asp:BoundField HeaderText="S. Unit" />
<asp:BoundField HeaderText="Order Qty" />
<asp:BoundField HeaderText="S. Qty" />
<asp:BoundField HeaderText="Stock Qty" />
<asp:BoundField HeaderText="Reserved Qty" />
<asp:BoundField HeaderText="BOM No" />

    </Columns>
    </asp:GridView>
</fieldset>
<table>
<tr>
<td>
    <asp:Button ID="Button2" runat="server" Text="Export to XL" />

</td>
<td>
    <asp:Button ID="Button3" runat="server" Text="Generate" />
</td>
<td>
    <asp:Button ID="Button4" runat="server" Text="Cancel" />
</td>
</tr>
</table>
</div>
</asp:Content>
