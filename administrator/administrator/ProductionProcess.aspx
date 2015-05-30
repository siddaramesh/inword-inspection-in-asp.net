<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductionProcess.aspx.cs" Inherits="administrator.ProductionProcess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
<table>
<tr>
<td>
    <asp:Label ID="Label2" runat="server" ForeColor="Red" Text=""></asp:Label>
</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Process Name:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" CssClass="textbox" AutoPostBack="true" 
        runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
</td>
<td>
    <asp:CheckBox ID="CheckBox1" runat="server" Text="This Process is final finished to store" />
</td>
</tr>
<tr>
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
