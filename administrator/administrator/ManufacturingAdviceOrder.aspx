<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManufacturingAdviceOrder.aspx.cs" Inherits="administrator.ManufacturingAdviceOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
<fieldset>
<legend>Manufacturing Advice Order</legend>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="MAO No"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label2" runat="server" Text="MAO Date"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label3" runat="server" Text="DOC No:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label4" runat="server" Text="Department"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label5" runat="server" Text="Requested By"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label6" runat="server" Text="Approved By"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label7" runat="server" Text="Remarks"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine"></asp:TextBox>
</td>
</tr>
</table>
    <asp:GridView ID="GridView1" runat="server">
    <Columns>
    <asp:BoundField HeaderText="Item Code" />
    <asp:BoundField HeaderText="Item Name" />
    <asp:BoundField HeaderText="Description" />
    <asp:BoundField HeaderText="Unit" />
    <asp:BoundField HeaderText="S. Unit" />
    <asp:BoundField HeaderText="Stock" />
    <asp:BoundField HeaderText="Qty" />
    <asp:BoundField HeaderText="S. Qty" />
    <asp:BoundField HeaderText="Remarks" />
    
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
