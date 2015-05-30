<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="modules.aspx.cs" Inherits="administrator.modules" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<p>
    <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Default.aspx" ForeColor="Blue" Font-Size="15px" runat="server">Admin</asp:HyperLink><span style="color:Black; font-size:14px;">>>Modules</span>
</p>
<div class="masterdetails">
  <fieldset class="master">
  <legend>Master Details</legend>
  <ul>
  <li>   <asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/userinfo.aspx" ID="user" runat="server">User Details</asp:HyperLink></li> 
  <li>    <asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/manufacture.aspx" ID="manufactures" runat="server">Manufactures</asp:HyperLink></li>
  <li>    <asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/supplier.aspx" ID="supplierid" runat="server">Supplier Details</asp:HyperLink></li> 
  <li>    <asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/partno.aspx" ID="partnoid" runat="server">PartNum Details</asp:HyperLink></li> 
   <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/unitofmeasure.aspx" ID="uom" runat="server">Unit Of Measure</asp:HyperLink></li>  
   <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/poinput.aspx" ID="po" runat="server">PO Input Module</asp:HyperLink></li>  
   <li>     <asp:HyperLink ForeColor="Black" CssClass="font" NavigateUrl="" ID="modulename" runat="server">Modules</asp:HyperLink></li>  
      </ul>
      <asp:HyperLink ForeColor="Green" Font-Bold="true" CssClass="font" ID="HyperLink1" runat="server">MODULE MASTERS</asp:HyperLink><br />
      <ul>
 <li> <asp:HyperLink ForeColor="Gray" CssClass="font"  NavigateUrl="~/ms-component.aspx" ID="mscomponent" runat="server">Electronic Components</asp:HyperLink></li> 
 <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-transformer.aspx" ID="mstransformer" runat="server">Transformer</asp:HyperLink></li> 
 <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-inductor.aspx" ID="msinductor" runat="server">Inductor</asp:HyperLink></li> 
 <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-barepcb.aspx" ID="msbarepcb" runat="server">BARE PCB</asp:HyperLink></li> 
      </ul>
  </fieldset>
  </div> 
  <div class=" search">
  <fieldset class="borderradius">
  <legend>Search</legend>
  <table>
  <tr>
   <td>
       <asp:Label ID="Label7" runat="server" Text="Module Names:"></asp:Label>
   </td>
   <td>
       <asp:DropDownList ID="DropDownList1" runat="server">
       </asp:DropDownList>
   </td>
   
   <td>
       <asp:Button ID="Button2" CssClass="addbutton" Width="80px" Height="30px" 
           runat="server" Text="Search" onclick="Button2_Click" />
   </td>
  </tr>
  </table>
  </fieldset>
  </div>
  <div class="description">
  <fieldset class="borderradius">
  <legend>Modules</legend>
  <table>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label1" runat="server" Text=" No:"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label3" runat="server" Text="Module Name:"></asp:Label></td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox1" runat="server"></asp:TextBox>
      
       </td>
  </tr>
  <tr>
  <td></td><td></td>
  <td>
      <asp:Button CssClass="addbutton" Width="80px" Height="30px" ID="Button1" 
          runat="server" Text="ADD" onclick="Button1_Click" /></td>
     <td>
         <asp:Button CssClass="addbutton" Width="80px" Height="30px" ID="Button3" 
             runat="server" Text="UPDATE" />
     </td>     
  </tr>
  </table>
  </fieldset>
   <p>
  <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
  </p>
  <p>
  <asp:CompareValidator ID="Validator" runat="server" ControlToValidate="TextBox1"  Operator="DataTypeCheck" Type="String" ErrorMessage="Prefix must be charecters" ></asp:CompareValidator>
  </p>
  </div>
</asp:Content>
