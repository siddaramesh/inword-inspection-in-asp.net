<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="meterial-group.aspx.cs" Inherits="administrator.meterial_group" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
<table>
<tr>
<td>
    <asp:Label ID="Label7" runat="server" ForeColor="Red" Text=""></asp:Label>
</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Group Name:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" CssClass="textbox" AutoPostBack="true" 
        runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Alias Name:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label3" runat="server" CssClass="label" Text="Under Group:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label4" runat="server" CssClass="label" Text="Fixed Group Assets:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList2" CssClass="textbox" runat="server">
    <asp:ListItem Text="" Value="0" />
    <asp:ListItem Text="Finish Goods" Value="1"></asp:ListItem>
    <asp:ListItem Text="Fixed Assets" Value="2" />
    <asp:ListItem Text="Consumable Items" Value="3" />
    <asp:ListItem Text="Raw Meterials" Value="4" />
    <asp:ListItem Text="Semi Finished" Value="5" />
    <asp:ListItem Text="Tool Fixers" Value="6" />
    <asp:ListItem Text="Measurement Instrument" Value="7" />
    </asp:DropDownList>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label5" runat="server" CssClass="label" Text="Item Series:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label6" runat="server" CssClass="label" Text="Traffic Heading:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td></td><td></td>
<td>
    <asp:Button ID="Button1" CssClass="addbutton" Width="80px" Height="30px" 
        runat="server" Text="Save" onclick="Button1_Click" />
</td>
<td>
    <asp:Button ID="Button2" CssClass="addbutton" Width="80px" Height="30px" runat="server" Text="Cancel" />
</td>
</tr>
</table>
</div>
</asp:Content>
