<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RGP-Incoming.aspx.cs" Inherits="administrator.RGP_Incoming" %>
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
    <asp:Label ID="Label5" runat="server" Text="Scrap Store:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label6" runat="server" Text="Return Type:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList2" runat="server">
    <asp:ListItem Text="Same" />
    <asp:ListItem Text="Conversion" />
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label7" runat="server" Text="Remark:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine"></asp:TextBox>
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
<legend>Issue Material Details</legend>
<asp:GridView ID="GridView1" runat="server">
    <Columns>
    <asp:BoundField HeaderText="Sr. No" />
    <asp:BoundField HeaderText="RGP. No" />
    <asp:BoundField HeaderText="Item Code" />
<asp:BoundField HeaderText="Item Name" />
<asp:BoundField HeaderText="P. Unit" />
<asp:BoundField HeaderText="S. Unit" />
<asp:BoundField HeaderText="Store" />
<asp:BoundField HeaderText="Process" />
<asp:BoundField HeaderText="Job Qty" />
<asp:BoundField HeaderText="Recd. Qty" />
<asp:BoundField HeaderText="Bal Qty" />
<asp:BoundField HeaderText="Recv. Qty" />
<asp:BoundField HeaderText="S. Qty" />
<asp:BoundField HeaderText="Scrap Qty" />
    </Columns>
    </asp:GridView>
</fieldset>
<fieldset>
<legend>Recieve Material Details</legend>
<asp:GridView ID="GridView2" runat="server">
    <Columns>
    <asp:BoundField HeaderText="Sr. No" />
    <asp:BoundField HeaderText="Item Code" />
<asp:BoundField HeaderText="Item Name" />
<asp:BoundField HeaderText="P. Unit" />
<asp:BoundField HeaderText="S. Unit" />
<asp:BoundField HeaderText="Store" />
<asp:BoundField HeaderText="Recv. Qty" />
<asp:BoundField HeaderText="S. Qty" />
<asp:BoundField HeaderText="Scrap Qty" />
    </Columns>
    </asp:GridView>
</fieldset>
</div>
</asp:Content>
