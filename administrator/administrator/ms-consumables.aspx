﻿<%@ Page Title="Consumables" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ms-consumables.aspx.cs" Inherits="administrator.ms_consumables" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="description">
<fieldset class="borderradius">
<legend>Consumables</legend>
<p>
    <asp:Label ID="Label3" runat="server" ForeColor="Red" Text=""></asp:Label>
</p>
<table>
<tr>
<td>
    <asp:Label ID="Label1" CssClass="label" runat="server" Text="Num:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Consumable Name:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" CssClass="textbox" runat="server"></asp:TextBox>
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
</fieldset>
</div>
</asp:Content>
