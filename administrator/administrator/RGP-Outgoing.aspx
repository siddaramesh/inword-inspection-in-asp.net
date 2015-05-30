<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RGP-Outgoing.aspx.cs" Inherits="administrator.RGP_Outgoing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="Doc Type:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem Text="All Materials" />
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label2" runat="server" Text="Doc No:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label3" runat="server" Text="Doc Date:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label4" runat="server" Text="Party Name:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label5" runat="server" Text="Transporter:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label6" runat="server" Text="Removal Time:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label7" runat="server" Text="Removal Date:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label8" runat="server" Text="Vehicle No:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label9" runat="server" Text="Party Address"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox8" runat="server" TextMode="MultiLine"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label10" runat="server" Text="Remarks"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox9" runat="server" TextMode="MultiLine"></asp:TextBox>
</td>
</tr>
</table>
<fieldset>
<legend>Material Details</legend>
    <asp:GridView ID="GridView1" runat="server">
    <Columns>
    <asp:BoundField HeaderText="Sr. No" />
    <asp:BoundField HeaderText="Item Code" />
<asp:BoundField HeaderText="Item Name" />
<asp:BoundField HeaderText="P. Unit" />
<asp:BoundField HeaderText="S. Unit" />
<asp:BoundField HeaderText="Store" />
<asp:BoundField HeaderText="Stock" />
<asp:BoundField HeaderText="Process" />
<asp:BoundField HeaderText="Issue Qty" />
<asp:BoundField HeaderText="S. Qty" />
<asp:BoundField HeaderText="Rate" />
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
