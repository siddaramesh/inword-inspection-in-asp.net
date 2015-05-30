﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IssueSlipMaterial.aspx.cs" Inherits="administrator.IssueSlipMaterial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
<fieldset>
<legend>Issue Slip Material</legend>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="Issue Slip No"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label2" runat="server" Text="Issue Date"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label3" runat="server" Text="Doc Type"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem Text="Demand" />
    <asp:ListItem Text="Indent" />
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label4" runat="server" Text="Demand No"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label5" runat="server" Text="Demand Date"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox4" runat="server" TextMode="Date"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label6" runat="server" Text="Job Card No"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label7" runat="server" Text="Job card date"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox6" runat="server" TextMode="Date"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label8" runat="server" Text="Department"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList2" runat="server">
    <asp:ListItem Text="department" />
    </asp:DropDownList>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label9" runat="server" Text="Remark"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox7" runat="server" TextMode="MultiLine"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label10" runat="server" Text="Generated by"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
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
    <asp:BoundField HeaderText="Store" />
    <asp:BoundField HeaderText="Stock" />
    <asp:BoundField HeaderText="DMD. Qty" />
    <asp:BoundField HeaderText="Issued. Qty" />
    <asp:BoundField HeaderText="Bal. Qty" />
    <asp:BoundField HeaderText="Issue. Qty" />
    <asp:BoundField HeaderText="S. Qty" />
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
