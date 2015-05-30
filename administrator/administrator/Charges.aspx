<%@ Page Title="Charges" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Charges.aspx.cs" Inherits="administrator.Charges" %>
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
    <asp:Label ID="Label1" CssClass="label" runat="server" Text="Charge Name"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" CssClass="textbox" AutoPostBack="true" 
        runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label2" CssClass="label" runat="server" Text="Charge Type"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" CssClass="textbox" runat="server">
    <asp:ListItem Text="" Value="0" />
    <asp:ListItem Text="Excise duty"  Value="1" />
    <asp:ListItem Text="Cess" Value="2" />
    <asp:ListItem Text="Shec" Value="3" />
    <asp:ListItem Text="Tax" Value="4" />
    <asp:ListItem Text="Additional Tax" Value="5" />
    <asp:ListItem Text="Surcharge" Value="6" />
    <asp:ListItem Text="Freight" Value="7" />
    <asp:ListItem Text="Discount" Value="8" />
    <asp:ListItem Text="Cartage" Value="9" />
    <asp:ListItem Text="Entry tax" Value="10" />
    <asp:ListItem Text="Insurance" Value="11" />
    <asp:ListItem Text="Packing" Value="12" />
    <asp:ListItem Text="Octroi" Value="13" />
    <asp:ListItem Text="Misc" Value="14" />
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label3" CssClass="label" runat="server" Text="Purchase Account"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList2" CssClass="textbox" runat="server">
    <asp:ListItem Text="" Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label4" runat="server" CssClass="label" Text="Sales Account"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList3" CssClass="textbox" runat="server">
     <asp:ListItem Text="" Value="0" />
    </asp:DropDownList>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label5" runat="server" CssClass="label" Text="Percent (%)"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server" CssClass="textbox" Text="0.00" onFocus="if(this.value=='0.00')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0.00';
      }"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label6" runat="server" CssClass="label" Text="Decimal Place"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox3" CssClass="textbox" runat="server"></asp:TextBox>
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
