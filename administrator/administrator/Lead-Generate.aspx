<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lead-Generate.aspx.cs" Inherits="administrator.Lead_Generate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label2" runat="server" Text="Print Name"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label3" runat="server" Text="Category"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem Text="Debitor" />
    <asp:ListItem Text="Debitor-Creditor" />
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label4" runat="server" Text="Code"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</td>
</tr>
</table>
<fieldset>
<legend>Company Information</legend>
<table>
<tr>
<td>
    <asp:Label ID="Label5" runat="server" Text="Contact Person"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label6" runat="server" Text="Mobile No"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label7" runat="server" Text="E-mail Id"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
   <asp:Label ID="Label8" runat="server" Text="Address 1"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label9" runat="server" Text="Address 2"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label10" runat="server" Text="Address 3"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label11" runat="server" Text="City"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label12" runat="server" Text="State"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList3" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label13" runat="server" Text="Country"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList4" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label14" runat="server" Text="Pin Code"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label15" runat="server" Text="Phone No"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label16" runat="server" Text="Website"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label17" runat="server" Text="Fax No"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
</td>
</tr>
</table>
</fieldset>
<fieldset>
<legend>Follow Up Details</legend>
<table>
<tr>
<td>
    <asp:Label ID="Label18" runat="server" Text="Sr. No"></asp:Label>
</td>
<td>
    <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
</td>
<td>
    <asp:Label ID="Label20" runat="server" Text="Follow Up Date"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox14" runat="server" TextMode="Date"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label21" runat="server" Text="Description"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox15" runat="server" TextMode="MultiLine"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label22" runat="server" Text="Next Follow Up Date"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox16" runat="server" TextMode="Date"></asp:TextBox>
</td>
</tr>
</table>
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
