<%@ Page Title="Supplier Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="supplier.aspx.cs" Inherits="administrator.supplier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
<script type="text/javascript">
    function handlethis(cb) {
        if (cb.checked == true) {
            alert('You Wish to InActivate this Record');
        } else {
            //alert('Message 2');
        }
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<p>
    <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Default.aspx" ForeColor="Blue" Font-Size="15px" runat="server">Admin</asp:HyperLink><span style="color:Black; font-size:14px;">>>Supplier Details</span>
</p>
    <div>
    <table>
  <tr>
  <td>
  <asp:Button ID="export" runat="server" Visible="false" Text="Export" onclick="export_Click" />
  </td>
  <td>
  <asp:Button ID="view" runat="server" Visible="false" Text="View" onclick="view_Click" />
  </td>
  </tr>
  <tr>
  <td>
  <asp:FileUpload ID="FileUpload1" Visible="false" runat="server" />
  </td>
  <td>
  <asp:Button ID="import" runat="server" Visible="false" Text="Import" onclick="import_Click" />
  </td>
  </tr>
  <tr>
  <td></td>
  <td><asp:Label ID="lblconform" runat="server" Text=""></asp:Label></td>
  </tr>
  </table>
    </div>
    <div class="masterdetails">
  <fieldset class="master">
  <legend>Master Details</legend>
  <ul>
 <li> <asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/userinfo.aspx" ID="user" runat="server">User Details</asp:HyperLink></li>
 <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/manufacture.aspx" ID="manufactures" runat="server">Manufactures</asp:HyperLink></li>
 <li>     <asp:HyperLink ForeColor="Black" CssClass="font" ID="supplierid" runat="server">Supplier Details</asp:HyperLink></li>
 <li>     <asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/partno.aspx" ID="partnoid" runat="server">PartNum Details</asp:HyperLink></li>
  <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/unitofmeasure.aspx" ID="uom" runat="server">Unit Of Measure</asp:HyperLink></li>  
 <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/poinput.aspx" ID="po" runat="server">PO Input Module</asp:HyperLink></li>  
  <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/modules.aspx" ID="modulename" runat="server">Modules</asp:HyperLink></li>  
  </ul>
  <asp:HyperLink ForeColor="Green" Font-Bold="true" CssClass="font" ID="HyperLink1" runat="server">MODULE MASTERS</asp:HyperLink><br />
  <ul>
 <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-component.aspx" ID="mscomponent" runat="server">Electronic Components</asp:HyperLink></li>
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
       <asp:Label ID="Label7" runat="server" Text="Supplier Name:"></asp:Label>
   </td>
   <td>
       <asp:DropDownList ID="DropDownList3" runat="server">
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
  <legend>Supplier Details</legend>
  <table>
  <tr>
  <td>
      <asp:Label  ID="Label3" runat="server" Text="supplier No:"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label  ID="Label8" runat="server" Text="ERP Vendor No:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox2" runat="server"></asp:TextBox>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label  ID="Label1" runat="server" Text="Supplier Name:"></asp:Label></td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox1" runat="server"></asp:TextBox>
      <!-- <asp:RequiredFieldValidator ID ="suppliername" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="* supplier name is required" ToolTip="username is required">
    </asp:RequiredFieldValidator> -->
       </td>
       <td>
           <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
       </td>
  </tr>
  <tr>
  <td>
      <asp:Label  ID="Label2" runat="server" Text="Category:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList Width="100px" ID="DropDownList1" runat="server">
      <asp:ListItem Text="A" Value="A" Enabled="true"></asp:ListItem>
      <asp:ListItem Text="B" Value="B" Enabled="true"></asp:ListItem>
      </asp:DropDownList>
  </td>
  
  </tr>
  <tr>
  <td>
  </td>
  <td>
  <asp:CheckBox ID="CheckBox1" Visible="false" onclick="handlethis(this)" runat="server" Text="InActive" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label9" runat="server" Text="Manufacture1:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList2" runat="server">
      </asp:DropDownList>
     <!-- <asp:ListBox ID="ListBox1" CssClass="listbox" SelectionMode="Multiple" Width="200px" Height="100px" runat="server">
      </asp:ListBox> -->
  </td>
  <td>
      <asp:Button ID="Button3" runat="server" Text="Add" onclick="Button3_Click" /> 
      
       <!-- <asp:TextBox ID="TextBox3" TextMode="MultiLine" runat="server"></asp:TextBox> -->
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label10" runat="server" Visible="false"  Text="Manufacture2:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList4" Visible="false" runat="server">
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button4" runat="server" Visible="false"  Text="Add" 
          onclick="Button4_Click" />
          <asp:Button ID="Button14" runat="server" Visible="false"  Text="Cancel" 
          onclick="Button14_Click" /> 
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label11" runat="server" Visible="false"  Text="Manufacture3:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList5" Visible="false" runat="server">
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button5" runat="server" Visible="false"  Text="Add" 
          onclick="Button5_Click" />
          <asp:Button ID="Button15" runat="server" Visible="false"  Text="Cancel" 
          onclick="Button15_Click" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label12" runat="server" Visible="false" Text="Manufacture4:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList6" Visible="false" runat="server">
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button6" runat="server" Visible="false" Text="Add" 
          onclick="Button6_Click" />
          <asp:Button ID="Button16" runat="server" Visible="false" Text="Cancel" 
          onclick="Button16_Click" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label13" runat="server" Visible="false" Text="Manufacture5:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList7" Visible="false" runat="server">
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button7" runat="server" Visible="false" Text="Add" 
          onclick="Button7_Click" />
          <asp:Button ID="Button17" runat="server" Visible="false" Text="Cancel" 
          onclick="Button17_Click" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label14" runat="server" Visible="false" Text="Manufacture6:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList8" Visible="false" runat="server">
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button8" runat="server" Visible="false" Text="Add" 
          onclick="Button8_Click" />
          <asp:Button ID="Button18" runat="server" Visible="false" Text="Cancel" 
          onclick="Button18_Click" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label15" runat="server" Visible="false" Text="Manufacture7:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList9" Visible="false" runat="server">
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button9" runat="server" Visible="false" Text="Add" 
          onclick="Button9_Click" />
          <asp:Button ID="Button19" runat="server" Visible="false" Text="Cancel" 
          onclick="Button19_Click" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label16" runat="server" Visible="false" Text="Manufacture8:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList10" Visible="false" runat="server">
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button10" runat="server" Visible="false" Text="Add" 
          onclick="Button10_Click" />
          <asp:Button ID="Button20" runat="server" Visible="false" Text="Cancel" 
          onclick="Button20_Click" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label17" runat="server" Visible="false" Text="Manufacture9:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList11" Visible="false" runat="server">
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button11" runat="server" Visible="false" Text="Add" 
          onclick="Button11_Click" />
      <asp:Button ID="Button21" runat="server" Visible="false" Text="Cancel" /> 
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label18" runat="server" Visible="false" Text="Manufacture10:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList12" Visible="false" runat="server">
      </asp:DropDownList>
  </td>
  <td>
      
     <asp:Button ID="Button22" runat="server" Visible="false" Text="Cancel" /> 
  </td>
  </tr>
  
  <tr>
  <td></td><td></td>
  <td>
      <asp:Button CssClass="addbutton" Width="80px" Height="30px" ID="Button1" 
          runat="server" Text="ADD" onclick="Button1_Click" /></td>
      <td>
          <asp:Button CssClass="addbutton" Width="80px" Height="30px" ID="Button12" 
              runat="server" Text="UPDATE" onclick="Button12_Click" OnClientClick="Confirm()" />
      </td>    
  </tr>
  
  </table>
  </fieldset>
  <p>
  <asp:Label ForeColor="Red" ID="Label5" runat="server" Text=""></asp:Label>
  </p>
  </div>
</asp:Content>
