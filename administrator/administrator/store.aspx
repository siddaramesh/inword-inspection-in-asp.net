<%@ Page Title="Store" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="store.aspx.cs" Inherits="administrator.store" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="description">
<fieldset class="borderradius">
<legend>STORE HEADER</legend>
<p>
    <asp:Label ID="Label1" ForeColor="Red" runat="server" Text=""></asp:Label>
</p>
<table>
<tr>
<td>
    <asp:Label ID="jobcard" runat="server" CssClass="label" Text="Job Card No:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="bom" CssClass="label" runat="server" Text="BOM Partno:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
</td>
</tr>
</table>
</fieldset>
</div>
</asp:Content>
