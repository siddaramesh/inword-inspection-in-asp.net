<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="userinfo.aspx.cs" Inherits="administrator.userinfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<p>
    <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Default.aspx" ForeColor="Blue" Font-Size="15px" runat="server">Admin</asp:HyperLink><span style="color:Black; font-size:14px;">>>User Details</span>
</p>
<div class="masterdetails">
  <fieldset class="master">
  <legend>Master Details</legend>
  <ul>
  <li><asp:HyperLink CssClass="font" ForeColor="Black" ID="user" runat="server">User Details</asp:HyperLink></li>
  <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/manufacture.aspx" ID="manufactures" runat="server">Manufactures</asp:HyperLink></li>
  <li><asp:HyperLink CssClass="font" ForeColor="Gray" ID="supplierid" NavigateUrl="~/supplier.aspx" runat="server">Supplier Details</asp:HyperLink></li>
  <li><asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/partno.aspx" ID="partnoid" runat="server">PartNum Details</asp:HyperLink></li>
   <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/unitofmeasure.aspx" ID="uom" runat="server">Unit Of Measure</asp:HyperLink></li>  
   <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/poinput.aspx" ID="po" runat="server">PO Input Module</asp:HyperLink></li> 
    <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/modules.aspx" ID="modulename" runat="server">Modules</asp:HyperLink></li>   
      </ul>
      <asp:HyperLink ForeColor="Green" Font-Bold="true" CssClass="font" ID="HyperLink1" runat="server">MODULE MASTERS</asp:HyperLink><br />
      <ul>
   <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-component.aspx" ID="mscomponent" runat="server">Electronic Components</asp:HyperLink></li>
   <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-transformer.aspx" ID="mstransformer" runat="server">Transformer</asp:HyperLink></li>
   <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-inductor.aspx" ID="msinductor" runat="server">Inductor</asp:HyperLink></li>
   <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-barepcb.aspx" ID="msbarepcb" runat="server">BARE PCB</asp:HyperLink></li>
      </ul>
      <asp:HyperLink ForeColor="Green" Font-Bold="true" CssClass="font" ID="HyperLink3" runat="server">MODULE REPORTS</asp:HyperLink><br />
   <ul>
   <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/componentreport.aspx" ID="reportcomponent" runat="server">Electronic Components</asp:HyperLink></li>
 <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ledreport.aspx" ID="reportled" runat="server">Led</asp:HyperLink></li>
 <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/inductorreport.aspx" ID="reportinductor" runat="server">Inductor</asp:HyperLink></li>
 </ul>
  </fieldset>
  </div> 
   <div class=" search">
  <fieldset class="borderradius">
  <legend>Search</legend>
  <table>
  <tr>
   <td>
       <asp:Label ID="Label10" runat="server" Text="User Name:"></asp:Label>
   </td>
   <td>
       <asp:DropDownList ID="DropDownList1" runat="server">
       </asp:DropDownList>
   </td>
   
   <td>
       <asp:Button ID="Button4" CssClass="addbutton" Width="80px" Height="30px" 
           runat="server" Text="Search" onclick="Button4_Click" />
   </td>
  </tr>
  </table>
  </fieldset>
  </div>
  <div class="description">
  <fieldset class="borderradius">
  <legend>Supplier Details</legend>
  <table>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label1" runat="server" Text="Name:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox1" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label2" runat="server" Text="User Name:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox2" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label3" runat="server" Text="Password:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox3" TextMode="Password" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label4" runat="server" Text="Admin"></asp:Label>
  </td>
  <td>
      <asp:CheckBox ID="CheckBox1" runat="server" 
          oncheckedchanged="CheckBox1_CheckedChanged" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label5" runat="server" Text="User Roles:"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
  </td>
  <td>
      <asp:CheckBox ID="CheckBox2" Text="Add" runat="server" />
  </td>
  <td>
      <asp:CheckBox ID="CheckBox6" Text="Inspected" runat="server" />
  </td>
  </tr>
  <tr>
  <td></td>
  <td>
      <asp:CheckBox ID="CheckBox3" Text="Modify" runat="server" />
  </td>
  <td>
      <asp:CheckBox ID="CheckBox7" Text="Approved" runat="server" />
  </td>
  </tr>
  <tr>
  <td></td>
  <td>
      <asp:CheckBox ID="CheckBox5" runat="server" Text="View" />
  </td>
  </tr>
  <tr>
  <td></td>
  <td>
      <asp:CheckBox ID="CheckBox4" Text="Delete" runat="server" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Button ID="Button1" CssClass="addbutton" runat="server" Text="ADD" 
          onclick="Button1_Click" />
  </td>
  <td>
      <asp:Button ID="Button2" CssClass="addbutton" runat="server" Text="EDIT" 
          onclick="Button2_Click" />
  </td>
  <td>
      <asp:Button CssClass="addbutton" ID="Button3" runat="server" Text="DELETE" />
  </td>
  </tr>
      </table>
      </fieldset>
      </div>
      <p>
          <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
      </p>
</asp:Content>
