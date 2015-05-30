<%@ Page Title="Part Num" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="partno.aspx.cs" Inherits="administrator.partno" %>
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
    <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Default.aspx" ForeColor="Blue" Font-Size="15px" runat="server">Admin</asp:HyperLink><span style="color:Black; font-size:14px;">>>PartNum Details</span>
</p>
<div>
<p>
  <asp:Label ForeColor="Red" ID="Label5" runat="server" Text=""></asp:Label>
  </p>
</div>
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
  <!--  <div class="masterdetails">
  <fieldset class="master">
  <legend>Master Details</legend>
  <ul>
 <li> <asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/userinfo.aspx" ID="user" runat="server">User Details</asp:HyperLink></li>
 <li>    <asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/manufacture.aspx" ID="manufactures" runat="server">Manufactures</asp:HyperLink></li>
 <li>     <asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/supplier.aspx" ID="supplierid" runat="server">Supplier Details</asp:HyperLink></li>
 <li>     <asp:HyperLink ForeColor="Black" CssClass="font" ID="partnoid" runat="server">PartNum Details</asp:HyperLink></li>
  <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/unitofmeasure.aspx" ID="uom" runat="server">Unit Of Measure</asp:HyperLink></li>  
  <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/poinput.aspx" ID="po" runat="server">PO Input Module</asp:HyperLink></li>  
   <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/modules.aspx" ID="modulename" runat="server">Modules</asp:HyperLink></li>  
      </ul>
      <asp:HyperLink ForeColor="Green" Font-Bold="true" CssClass="font" ID="HyperLink1" runat="server">MODULE MASTERS</asp:HyperLink><br />
       <ul>
  <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-component.aspx" ID="mscomponent" runat="server">Electronic Components</asp:HyperLink></li>
  <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-transformer.aspx" ID="mstransformer" runat="server">Transformer</asp:HyperLink></li>
  <li>    <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-inductor.aspx" ID="msinductor" runat="server">Inductor</asp:HyperLink></li>
  <li>    <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-barepcb.aspx" ID="msbarepcb" runat="server">BARE PCB</asp:HyperLink></li>
      </ul>
  </fieldset>
  </div>  -->
  <div class=" search">
  <fieldset class="borderradius">
  <legend>Search</legend>
  <table>
  <tr>
   <td>
       <asp:Label ID="Label7" runat="server" Text="ERP Part Num:"></asp:Label>
   </td>
   <td>
       <asp:DropDownList ID="DropDownList1" runat="server">
       </asp:DropDownList>
   </td>
   <td>
       <asp:Button ID="Button2" CssClass="addbutton" Width="80px" Height="30px" 
           runat="server" Text="Search" onclick="Button2_Click"  />
   </td>
  </tr>
  </table>
  </fieldset>
  </div>
  <div class="description">
  <fieldset class="borderradius">
  <legend>PartNum Details</legend>
  <table>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label3" runat="server" Text=" No:"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label1" runat="server" Text="ERP Part Num:"></asp:Label></td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox1" runat="server"></asp:TextBox>
      
       </td>
       <td>
           <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
       </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label2" runat="server" Text="Description:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox2" TextMode="MultiLine" runat="server"></asp:TextBox>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label29" CssClass="label" runat="server" Text="Category:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList19" CssClass="textbox" runat="server">
      </asp:DropDownList>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label30" CssClass="label" runat="server" Text="Store:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList20" CssClass="textbox" runat="server">
      </asp:DropDownList>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label8" runat="server" Text="MPN:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox3" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label12" runat="server" Text="Manufacturer:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList2" runat="server">
      </asp:DropDownList>
      <asp:TextBox ID="TextBox6" CssClass="textbox" Visible="false" runat="server"></asp:TextBox>
  </td>
  <td>
      
      
  </td>
  </tr>
  <tr>
  <td></td>
  <td>
      <asp:CheckBox ID="CheckBox1" Visible="false" onclick="handlethis(this)" runat="server" Text="InActive" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label13" runat="server" Text="Alternate Part No1:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList3" runat="server">
      </asp:DropDownList>
      <asp:DropDownList ID="DropDownList8" runat="server">
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="Form,Fit,Functional Replacement"></asp:ListItem>
      <asp:ListItem Enabled="true" Text="Compatible Equivalent" />
      <asp:ListItem Enabled="true" Text="Functional Equivalent" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button4" runat="server" Text="Add" onclick="Button4_Click" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label14" runat="server" Visible="false" Text="Alternate Part No2:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList4" Visible="false" runat="server">
      </asp:DropDownList>
      <asp:DropDownList ID="DropDownList9" Visible="false" runat="server">
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="Form,Fit,Functional Replacement"></asp:ListItem>
      <asp:ListItem Enabled="true" Text="Compatible Equivalent" />
      <asp:ListItem Enabled="true" Text="Functional Equivalent" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button5" runat="server" Visible="false" Text="Add" 
          onclick="Button5_Click" />
      <asp:Button ID="Button6" runat="server" Visible="false" Text="Cancel" 
          onclick="Button6_Click" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label15" runat="server" Visible="false" Text="Alternate Part No3:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList5" Visible="false" runat="server">
      </asp:DropDownList>
      <asp:DropDownList ID="DropDownList10" Visible="false" runat="server">
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="Form,Fit,Functional Replacement"></asp:ListItem>
      <asp:ListItem Enabled="true" Text="Compatible Equivalent" />
      <asp:ListItem Enabled="true" Text="Functional Equivalent" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button7" runat="server" Visible="false" Text="Add" 
          onclick="Button7_Click" />
      <asp:Button ID="Button8" runat="server" Visible="false" Text="Cancel" 
          onclick="Button8_Click" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label16" runat="server" Visible="false" Text="Alternate Part No4:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList6" Visible="false" runat="server">
      </asp:DropDownList>
      <asp:DropDownList ID="DropDownList11" Visible="false" runat="server">
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="Form,Fit,Functional Replacement"></asp:ListItem>
      <asp:ListItem Enabled="true" Text="Compatible Equivalent" />
      <asp:ListItem Enabled="true" Text="Functional Equivalent" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button9" runat="server" Visible="false" Text="Add" 
          onclick="Button9_Click" />
      <asp:Button ID="Button10" runat="server" Visible="false" Text="Cancel" 
          onclick="Button10_Click" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label17" runat="server" Visible="false" Text="Alternate Part No5:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList7" Visible="false" runat="server">
      </asp:DropDownList>
      <asp:DropDownList ID="DropDownList12" Visible="false" runat="server">
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="Form,Fit,Functional Replacement"></asp:ListItem>
      <asp:ListItem Enabled="true" Text="Compatible Equivalent" />
      <asp:ListItem Enabled="true" Text="Functional Equivalent" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button11" runat="server" Visible="false" Text="Add" 
          onclick="Button11_Click" />
      <asp:Button ID="Button12" runat="server" Visible="false" Text="Cancel" 
          onclick="Button12_Click" />
  </td>
  </tr>

  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label27" runat="server" Visible="false" Text="Alternate Part No6:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList15" Visible="false" runat="server">
      </asp:DropDownList>
      <asp:DropDownList ID="DropDownList16" Visible="false" runat="server">
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="Form,Fit,Functional Replacement"></asp:ListItem>
      <asp:ListItem Enabled="true" Text="Compatible Equivalent" />
      <asp:ListItem Enabled="true" Text="Functional Equivalent" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button13" runat="server" Visible="false" Text="Add" 
          onclick="Button13_Click" />
      <asp:Button ID="Button14" runat="server" Visible="false" Text="Cancel" 
          onclick="Button14_Click" />
  </td>
  </tr>

  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label28" runat="server" Visible="false" Text="Alternate Part No7:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList17" Visible="false" runat="server">
      </asp:DropDownList>
      <asp:DropDownList ID="DropDownList18" Visible="false" runat="server">
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="Form,Fit,Functional Replacement"></asp:ListItem>
      <asp:ListItem Enabled="true" Text="Compatible Equivalent" />
      <asp:ListItem Enabled="true" Text="Functional Equivalent" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Button ID="Button16" runat="server" Visible="false" Text="Cancel" 
          onclick="Button16_Click" />
  </td>
  </tr>

  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label18" runat="server" Text="SPQ:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox7" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label19" runat="server" Text="MOQ:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox8" runat="server"></asp:TextBox>
  </td>
  </tr>
 
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label20" runat="server" Text="Package:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox9" runat="server"></asp:TextBox>
  </td>
   <td>
      <asp:Label CssClass="label" ID="Label21" runat="server" Text="Image:"></asp:Label>
  </td>
   <td>
      <asp:FileUpload ID="FileUpload2" runat="server" />
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label22" CssClass="label" runat="server" Text="Inspection Module:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList13" runat="server">
      
      </asp:DropDownList>
  </td>
  <td>
      <asp:Label ID="Label23" CssClass="label" runat="server" Text="Unit Of Measure:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList14" runat="server">
      </asp:DropDownList>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label24" runat="server" Text="MIN Range:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox10" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label25" runat="server" Text="MAX Range:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox11" runat="server"></asp:TextBox>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label9" runat="server" Text="Classification TL:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox4" runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label10" runat="server" Text="Classification DC:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox5" runat="server"></asp:TextBox>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label26" CssClass="label" runat="server" Text="Wastage(%):"></asp:Label>
  </td>
  <td>
  <asp:TextBox ID="TextBox12" runat="server" CssClass="textbox" Text="0.00" onFocus="if(this.value=='0.00')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0.00';
      }"></asp:TextBox>
  </td>
  
  </tr>
  <tr>
  <td></td><td></td>
  <td>
      <asp:Button CssClass="addbutton" Width="80px" Height="30px" ID="Button1" 
          runat="server" Text="ADD" onclick="Button1_Click" /></td>
   <td>
       <asp:Button CssClass="addbutton" Width="80px" Height="30px" ID="Button3" 
           runat="server" Text="UPDATE" onclick="Button3_Click" />
   </td>
  </tr>
  
  </table>
  </fieldset>
  
  <p>
  <asp:CompareValidator ID="CompareValidator1" runat="server" ForeColor="Red" ControlToValidate="TextBox10" Operator="DataTypeCheck" Type="Double" ErrorMessage="Min Value Must be Number" ></asp:CompareValidator>
  </p>
  <p>
  <asp:CompareValidator ID="CompareValidator2" runat="server" ForeColor="Red" ControlToValidate="TextBox11" Operator="DataTypeCheck" Type="Double" ErrorMessage="Max Value Must be Number" ></asp:CompareValidator>
  </p>
  <p>
  <asp:CompareValidator ID="CompareValidator3" runat="server" ForeColor="Red" ControlToValidate="TextBox7" Operator="DataTypeCheck" Type="Double" ErrorMessage="SPQ Value Must be Number" ></asp:CompareValidator>
  </p>
  <p>
  <asp:CompareValidator ID="CompareValidator4" runat="server" ForeColor="Red" ControlToValidate="TextBox8" Operator="DataTypeCheck" Type="Double" ErrorMessage="MOQ Value Must be Number" ></asp:CompareValidator>
  </p>
  <p>
  <asp:CompareValidator ID="CompareValidator5" runat="server" ForeColor="Red" ControlToValidate="TextBox12" Operator="DataTypeCheck" Type="Double" ErrorMessage="Wastage Value Must be Number" ></asp:CompareValidator>
  </p>
  </div>
     <!-- </table> -->
</asp:Content>
