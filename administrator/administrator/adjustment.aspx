<%@ Page Title="IC Adjustment" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adjustment.aspx.cs" Inherits="administrator.adjustment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="description">
<fieldset class="borderradius">
<legend>IC-Adjustment</legend>
<p>
    <asp:Label ID="Label11" ForeColor="Red" runat="server" Text=""></asp:Label>
</p>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Adjustment Num:"></asp:Label>
</td>
<td>
   <asp:TextBox ID="TextBox1" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Adjustment Date:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label3" runat="server" CssClass="label" Text="Description:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label4" runat="server" CssClass="label" Text="Reference:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
</table>
</fieldset>
</div>
<div class="description">
<fieldset class="borderradius">
<legend>Adjustment</legend>
<table>
<tr>
<th>
    <asp:Label ID="Label5" runat="server" Text="Num"></asp:Label>
</th>
<th>
    <asp:Label ID="Label6" runat="server" Text="Item Number"></asp:Label>
</th>
<th>
    <asp:Label ID="Label7" runat="server" Text="Adjustment type"></asp:Label>
</th>
<th>
    <asp:Label ID="Label8" runat="server" Text="Store"></asp:Label>
</th>
<th>
    <asp:Label ID="Label9" runat="server" Text="Quantity"></asp:Label>
</th>
<th>
    <asp:Label ID="Label10" runat="server" Text="Cost"></asp:Label>
</th>
</tr>
<tr>
<td>
    <asp:Label ID="num1" runat="server" CssClass="label" Text="1"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="itemno1" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="adj1" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="store1" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qty1" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
<td>
 <asp:TextBox ID="cost1" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="num2" runat="server" CssClass="label" Text="2"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="itemno2" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="adj2" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="store2" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qty2" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
<td>
 <asp:TextBox ID="cost2" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="num3" runat="server" CssClass="label" Text="3"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="itemno3" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="adj3" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="store3" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qty3" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
<td>
 <asp:TextBox ID="cost3" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="num4" runat="server" CssClass="label" Text="4"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="itemno4" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="adj4" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="store4" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qty4" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
<td>
 <asp:TextBox ID="cost4" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="no5" runat="server" CssClass="label" Text="5"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="itemno5" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="adj5" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="store5" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qty5" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
<td>
 <asp:TextBox ID="cost5" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="num6" runat="server" CssClass="label" Text="6"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="itemno6" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="adj6" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="store6" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qty6" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
<td>
 <asp:TextBox ID="cost6" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="num7" runat="server" CssClass="label" Text="7"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="itemno7" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="adj7" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="store7" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qty7" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
<td>
 <asp:TextBox ID="cost7" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="num8" runat="server" CssClass="label" Text="8"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="itemno8" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="adj8" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="store8" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qty8" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
<td>
 <asp:TextBox ID="cost8" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="num9" runat="server" CssClass="label" Text="9"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="itemno9" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="adj9" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="store9" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qty9" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
<td>
 <asp:TextBox ID="cost9" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="num10" runat="server" CssClass="label" Text="10"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="itemno10" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="adj10" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="store10" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qty10" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
<td>
 <asp:TextBox ID="cost10" runat="server" CssClass="smalltextbox" Text="0" onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"></asp:TextBox>
</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Button ID="Button1" CssClass="addbutton" Width="80px" Height="30px" runat="server" Text="Save" />
</td>
<td>
    <asp:Button ID="Button2" CssClass="addbutton" Width="80px" Height="30px" runat="server" Text="Cancel" />
</td>
</tr>
</table>
</fieldset>
</div>
</asp:Content>
