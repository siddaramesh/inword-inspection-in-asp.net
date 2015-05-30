<%@ Page Title="Components" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="component.aspx.cs" Inherits="administrator.component" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
<script type="text/javascript">
    function handlethis(cb) {
        if (cb.checked == true) {
            alert('Test Report/Lot # Recieved!!!');
        } else {
            //alert('Message 2');
        }
    }
</script>
 <script type="text/javascript">
     var popup,tin,lead,dcr;
     function select() {
         popup = window.open("primary.aspx", "popup", "width=500,height=300");
         popup.focus();
         return false;
     }
     function tinning() {
         tin = window.open("tinning.aspx", "tinning", "width=300,height=400");
         tin.focus();
         return false;
     }
     function lead() {
         lead = window.open("lead.aspx", "lead", "width=300,height=400");
         lead.focus();
         return false;
     }
     function dcr() {
         dcr = window.open("dcr.aspx", "dcr", "width=500,height=300");
         dcr.focus();
         return false;
     }
 </script>
  <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.min.js" type="text/javascript"></script>
 
    <script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.16/jquery-ui.js" type="text/javascript"></script>
 
<link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.16/themes/base/jquery-ui.css" type="text/css" media="all" />
 
 
 
<script type="text/javascript">

    $(function () {

        $("#<%= TextBox3.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox6.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
    });
 
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<p>
    <asp:HyperLink ID="HyperLink2" NavigateUrl="" ForeColor="Blue" Font-Size="15px" runat="server">Inward Inspection</asp:HyperLink><span style="color:Black; font-size:14px;">>>Electronic Components</span>
</p>
<!-- <div class=" search">
  <fieldset class="borderradius">
  <legend>Search</legend>
  <table>
  <tr>
   <td>
       <asp:Label ID="Label85" runat="server" Text=" Part Num:"></asp:Label>
   </td>
   <td>
       <asp:DropDownList ID="DropDownList8" runat="server">
       </asp:DropDownList>
   </td>
   <td>
       <asp:Button ID="Button5" CssClass="addbutton" Width="80px" Height="30px" 
           runat="server" Text="Search" onclick="Button5_Click" />
   </td>
  </tr>
  </table>
  </fieldset>
  </div> -->
  <div>
  <table>
  <tr>
  <td>
      <asp:Label ForeColor="Red" ID="Label86" runat="server" Text=""></asp:Label>
  </td>
  </tr>
  </table>
  </div>
<div class=" search">
  <fieldset class=" radiusright">
  <legend>Supplier Details</legend>
  <table>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label1" runat="server" Text="Supplier Name:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" 
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
      
   <asp:TextBox CssClass="textbox" ID="TextBox3" runat="server"></asp:TextBox> 
  </td>
 
 <td>
     <asp:Label CssClass="label" ID="Label10" runat="server" Text="Test Report/Lot #:"></asp:Label>
 </td>
 <td>
     <asp:DropDownList ID="testreport" AutoPostBack="true" runat="server" 
         onselectedindexchanged="testreport_SelectedIndexChanged">
     <asp:ListItem Enabled="true" Text="" Value="0" />
     <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
     <asp:ListItem Enabled="true" Text="No" Value="No" />
     </asp:DropDownList>
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
      <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" 
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
      <asp:TextBox CssClass="textbox" ID="TextBox16" runat="server"></asp:TextBox>
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
      <asp:TextBox CssClass="textbox" ID="TextBox6" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label18" runat="server" Text="Quantity Ordered:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox7" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label19" runat="server" Text="Quantity As Per Invoice:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" AutoPostBack="true" ID="TextBox8" 
          runat="server" ontextchanged="TextBox8_TextChanged"></asp:TextBox>
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
      
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label22" runat="server" Text="Approved By:"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label29" runat="server" Text=""></asp:Label>
  
  </td>
  </tr>
  </table>
  </fieldset>
  </div>
  <div id="electronic" runat="server" visible="false" class=" search">
  <fieldset class=" radiusright">
  <legend>Electronic Computation Fields</legend>
  <table>
  <tr>
  <td>
      <asp:Label ID="Label7" CssClass="label" runat="server" Text="Recieved Qty Counted:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox4" AutoPostBack="true" 
          runat="server" ontextchanged="TextBox4_TextChanged"></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label8" runat="server" Text="PartNum/Top mark verification:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="partnoverification" AutoPostBack="true" runat="server" onselectedindexchanged="partnoverification_SelectedIndexChanged" 
         >
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label9" runat="server" Text="Physical Damages:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="physicaldamage" runat="server" AutoPostBack="true" onselectedindexchanged="physicaldamage_SelectedIndexChanged" 
         >
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label30" runat="server" Visible="false" Text="Remarks:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" AutoPostBack="true" ID="TextBox13" 
          Visible="false" runat="server" ontextchanged="TextBox13_TextChanged" ></asp:TextBox>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label31" runat="server" Text="Lead Solderability:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList5" AutoPostBack="true" runat="server" 
          onselectedindexchanged="DropDownList5_SelectedIndexChanged">
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="Yes" />
      <asp:ListItem Enabled="true" Text="No" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label33" runat="server" Text="Package verification Order vs Recieved:"></asp:Label>
  </td>
  <td>
     <asp:DropDownList ID="DropDownList6" AutoPostBack="true" runat="server" 
          onselectedindexchanged="DropDownList6_SelectedIndexChanged">
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="Yes" />
      <asp:ListItem Enabled="true" Text="No" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Image ID="Image1" Width="100px" Height="100px" runat="server" />
  </td>
  <td>
      <asp:Label ID="Label32" runat="server" Text="Quantity Accepted:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" AutoPostBack="true" ID="TextBox11" 
          runat="server" ontextchanged="TextBox11_TextChanged"></asp:TextBox>
  </td>
  </tr>

  </table>
  </fieldset>
  </div>
  <div id="electronic1" runat="server" visible="false" class=" search">
  <fieldset class=" radiusright">
  <legend>Result</legend>
  <table>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label23" runat="server" Text="Recieved Qty Counting vs Invoice Qty:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label24" runat="server" Text="value"></asp:Label>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label25" runat="server" Text="Recieved Qty Counting vs Ordered Qty:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label26" runat="server" Text="value"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label27" runat="server" Text="PartNum/Top Mark Verification:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label34" runat="server" Text="value"></asp:Label>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label35" runat="server" Text="Physical Damages:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label36" runat="server" Text="value"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label37" runat="server" Text="Lead Solderability:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label38" runat="server" Text="if result is no meterial is rejected"></asp:Label>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label39" runat="server" Text="Package Verification:"></asp:Label>
  </td>
  <td>
  <asp:Label ForeColor="Black" ID="Label40" runat="server" Text="if result is no meterial is rejected"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label41" runat="server" Text="Quantity Rejected:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label42" runat="server" Text="qty recieved - qty accepted"></asp:Label>
  </td>
  </tr>
  </table>
  </fieldset>
  <table class="savebutton">
<tr>
<td>
<asp:Button CssClass=" addbutton" ID="Button1" Width="80px" Height="30px" runat="server" Text="SAVE" onclick="Button1_Click" />
</td>
</tr>
</table>
  </div>

  <!-- led modules -->
  <div id="led" runat="server" visible="false" class=" search">
  <fieldset class=" radiusright">
  <legend>Led Computation Fields</legend>
  <table>
  <tr>
  <td>
      <asp:Label ID="Label43" CssClass="label" runat="server" Text="Recieved Qty Counted:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox10" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label44" runat="server" Text="PartNum Verification:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList3" AutoPostBack="true" runat="server" onselectedindexchanged="DropDownList3_SelectedIndexChanged" 
         >
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label45" runat="server" Text="Physical Damages:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="true" onselectedindexchanged="DropDownList4_SelectedIndexChanged" 
         >
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label46" runat="server" Visible="false" Text="Remarks:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox12" Visible="false" 
          AutoPostBack="true" runat="server" ontextchanged="TextBox12_TextChanged" ></asp:TextBox>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label47" runat="server" Text="Lead Solderability:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList ID="DropDownList7" AutoPostBack="true" runat="server" 
          onselectedindexchanged="DropDownList7_SelectedIndexChanged">
      <asp:ListItem Enabled="true" Text="" />
      <asp:ListItem Enabled="true" Text="Yes" />
      <asp:ListItem Enabled="true" Text="No" />
      </asp:DropDownList>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label48" runat="server" Text="Bin Verification:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox15" AutoPostBack="true" 
          runat="server" ontextchanged="TextBox15_TextChanged"></asp:TextBox>
  </td>
  <td>
      <asp:Image ID="Image2" Width="100px" Height="100px" runat="server" />
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label49" runat="server" Text="Quantity Accepted:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox14" AutoPostBack="true" 
          runat="server" ontextchanged="TextBox14_TextChanged"></asp:TextBox>
  </td>
  </tr>

  </table>
  </fieldset>
  </div>
  <div id="led1" runat="server" visible="false" class=" search">
  <fieldset class=" radiusright">
  <legend>Result</legend>
  <table>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label50" runat="server" Text="Recieved Qty Counting vs Invoice Qty:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label51" runat="server" Text="value"></asp:Label>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label52" runat="server" Text="Recieved Qty Counting vs Ordered Qty:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label53" runat="server" Text="value"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label54" runat="server" Text="PartNum Verification:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label55" runat="server" Text="value"></asp:Label>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label56" runat="server" Text="Physical Damages:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label57" runat="server" Text="value"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label58" runat="server" Text="Lead Solderability:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label59" runat="server" Text="if result is no meterial is rejected"></asp:Label>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label60" runat="server" Text="Bin Verification:"></asp:Label>
  </td>
  <td>
  <asp:Label ForeColor="Black" ID="Label61" runat="server" Text="display textbox15 value"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label62" runat="server" Text="Quantity Rejected:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label63" runat="server" Text="qty recieved - qty accepted"></asp:Label>
  </td>
  </tr>
  </table>
  </fieldset>
  <table class="savebutton">
<tr>
<td>
<asp:Button CssClass=" addbutton" ID="Button2" Width="80px" Height="30px" 
        runat="server" Text="SAVE" onclick="Button2_Click"  />
</td>
</tr>
</table>
  </div>

  <!-- Inductor Module -->
  <div id="inductor" runat="server" visible="false"  class=" search">
  <fieldset class=" radiusright">
  <legend>Inductor Computation Fields</legend>
  <table>
  <tr>
  <td>
      <asp:Label ID="Label16" CssClass="label" runat="server" Text="Recieved Qty Counted:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox17" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label64" runat="server" Text="Primary Inductance:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="primary" runat="server"></asp:TextBox>
  </td>
  <td>
   <asp:Button ID="popup1" runat="server" Text="open" onclick="popup1_Click" />
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label65" runat="server" Text="Tinning/Solderability:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox18" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Button ID="tinning" runat="server" Text="open" OnClientClick="tinning();" />
  </td>
  <td>
      
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label67" runat="server" Text="Physical Damage:"></asp:Label>
  </td>
  <td>
       <asp:TextBox CssClass="textbox" ID="TextBox21" AutoPostBack="true" Text="0"
       onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" runat="server" ontextchanged="TextBox21_TextChanged"></asp:TextBox>
  </td>
  <td>
     
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label68" runat="server" Text="Lead Length:"></asp:Label>
  </td>
  <td>
    <asp:TextBox CssClass="textbox" ID="TextBox19" AutoPostBack="true" 
          runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Button ID="lead" runat="server" OnClientClick="lead();" Text="open" />
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label69" runat="server" Text="DCR:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox20"
          runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Button ID="popup2" runat="server" Text="open" onclick="popup2_Click" />
  </td>
  </tr>

  </table>
  </fieldset>
  </div>
  <div id="inductor1" runat="server" visible="false" class=" search">
  <fieldset class=" radiusright">
  <legend>Result</legend>
  <table>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label70" runat="server" Text="Recieved Qty Counting vs Invoice Qty:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label71" runat="server" Text="value"></asp:Label>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label72" runat="server" Text="Recieved Qty Counting vs Ordered Qty:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label73" runat="server" Text="value"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label74" runat="server" Text="Primary inductance:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label75" runat="server" Text="value=out of range quantity"></asp:Label>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label76" runat="server" Text="Tinning/Solderability:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label77" runat="server" Text="if result is no meterial is rejected"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label78" runat="server" Text="Physical Damage:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label79" runat="server" Text="value"></asp:Label>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label80" runat="server" Text="Lead Length:"></asp:Label>
  </td>
  <td>
  <asp:Label ForeColor="Black" ID="Label81" runat="server" Text="if result is no meterial is rejected"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label82" runat="server" Text="DCR:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label83" runat="server" Text="value=out of range quantity"></asp:Label>
  </td>
  <td>
      <asp:Label CssClass="label" ID="Label66" runat="server" Text="Inductor Rejection:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label84" runat="server" Text="Value"></asp:Label>
  </td>
  </tr>
  </table>
  </fieldset>
  <table class="savebutton">
<tr>
<td>
<asp:Button CssClass=" addbutton" ID="Button3" Width="80px" Height="30px" 
        runat="server" Text="SHOW" onclick="Button3_Click"   />
</td>
<td>
<asp:Button CssClass=" addbutton" ID="Button4" Width="80px" Height="30px" 
        runat="server" Text="SAVE" onclick="Button4_Click" 
          />
</td>
</tr>
</table>
  </div>
</asp:Content>
