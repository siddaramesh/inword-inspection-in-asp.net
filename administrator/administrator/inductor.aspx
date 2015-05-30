<%@ Page Title="Inductor" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="inductor.aspx.cs" Inherits="administrator.inductor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<p>
    <asp:HyperLink ID="HyperLink2" NavigateUrl="" ForeColor="Blue" Font-Size="15px" runat="server">Inward Inspection</asp:HyperLink><span style="color:Black; font-size:14px;">>>Inductor</span>
</p>
    <table class="savebutton">
<tr>
<td>
<asp:Button CssClass=" addbutton" ID="Button1" runat="server" Text="SAVE" 
          />
</td>
</tr>
</table>
   
<div class=" search">
  <fieldset class=" radiusright">
  <legend>Supplier Details</legend>
  <table>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label1" runat="server" Text="Supplier Name:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList1" runat="server" 
          onselectedindexchanged="DropDownList1_SelectedIndexChanged">
      </asp:DropDownList>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label2" runat="server" Text="Category:"></asp:Label>
  </td>
  <td>
      <asp:Label  ID="Label3" runat="server" Text=""></asp:Label>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label4" runat="server" Text="Supplier Invoice No:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox1" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label5" runat="server" Text="Supplier DC No:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox2" runat="server"></asp:TextBox>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label6" runat="server" Text="Supplied Date:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox3" TextMode="Date" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label7" runat="server" Text="Testing Report:"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
 </td>
 <td>
     <asp:Label CssClass="label" ID="Label9" runat="server" Text="Value:"></asp:Label>
 </td>
 <td>
     <asp:TextBox CssClass="textbox" ID="TextBox4" runat="server"></asp:TextBox>
 </td>
 <td>
     <asp:Label CssClass="label" ID="Label10" runat="server" Text="Testing Report Recieved"></asp:Label>
 </td>
 <td>
     <asp:CheckBox ID="CheckBox1" runat="server" />
 </td>
  </tr>
  </table>
</fieldset>
  </div>
  <div class=" search">
  <fieldset class=" radiusright">
  <legend>Aaronlights Pvt Ltd</legend>
  <table>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label11" runat="server" Text="Report No"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label13" runat="server" Text=""></asp:Label>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label12" runat="server" Text="Part no:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList2" runat="server" 
          onselectedindexchanged="DropDownList2_SelectedIndexChanged">
      </asp:DropDownList>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label14" runat="server" Text="Description:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox5" TextMode="MultiLine" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label15" runat="server" Text="Lot Num:"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label16" runat="server" Text=""></asp:Label>
  </td>
  </tr>
  </table>
  </fieldset>
  </div>
   <div class=" search">
  <fieldset class=" radiusright">
  <legend>Meterial Inspection</legend>
  <table>
  <tr>
  <td>
      <asp:Label ID="Label17" CssClass="label" runat="server" Text="Inspection Date:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" TextMode="Date" ID="TextBox6" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label18" runat="server" Text="Quantity Ordered:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox7" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label19" runat="server" Text="Quantity Recieved:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox8" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label20" runat="server" Text="Remarks:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" TextMode="MultiLine" ID="TextBox9" runat="server"></asp:TextBox>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label21" runat="server" Text="Inspected By:"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label28" runat="server" Text=""></asp:Label>
     <!-- <asp:DropDownList ID="DropDownList3" runat="server">
      </asp:DropDownList> -->
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label22" runat="server" Text="Approved By:"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label29" runat="server" Text=""></asp:Label>
    <!--  <asp:DropDownList ID="DropDownList4" runat="server">
      </asp:DropDownList> -->
  </td>
  </tr>
  </table>
  </fieldset>
  </div>
  <div class=" search">
  <fieldset class=" radiusright">
  <legend>Result</legend>
  <table>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label23" runat="server" Text="Inspection Rejected Total:"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label24" runat="server" Text=""></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label25" runat="server" Text="Inspection Accepted Total:"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label26" runat="server" Text=""></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label27" runat="server" Text="Remarks:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" TextMode="MultiLine" ID="TextBox10" runat="server"></asp:TextBox>
  </td>
  </tr>
  </table>
  </fieldset>
  </div>
</asp:Content>
