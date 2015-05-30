<%@ Page Title="Bill Of Meterial" EnableEventValidation="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BOM.aspx.cs" Inherits="administrator.BOM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
<script type="text/javascript">

    $(function () {

        $("#<%= TextBox2.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox5.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        
    });
 
</script>

<script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.min.js" type="text/javascript"></script>
 
    <script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.16/jquery-ui.js" type="text/javascript"></script>
 
<link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.16/themes/base/jquery-ui.css" type="text/css" media="all" />
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<p>
    <asp:Label ID="Label17" ForeColor="Red" runat="server" Text=""></asp:Label>
</p>
<div>
<fieldset>
<legend>Header</legend>
<table>
<tr>
<td>
    <asp:Label ID="Label1" CssClass="label" runat="server" Text="BOM No:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label2" runat="server" CssClass="label" Text="BOM DATE:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label4" runat="server" CssClass="label" Text="Revision Number:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label5" runat="server" CssClass="label" Text="Revision Date:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox5" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label16" runat="server" CssClass="label" Text="Category"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList2" CssClass="textbox" runat="server">

    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label6" runat="server" CssClass="label" Text="Part Num:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" AutoPostBack="true" CssClass="textbox" 
        runat="server" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label7" runat="server" CssClass="label" Text="Description:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox6" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label10" runat="server" CssClass="label" Text="Approved By:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox9" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
</table>
</fieldset>
<fieldset>
<legend>Details</legend>
<table width="80%" align="left">
<tr>
<td>
<asp:Button Text="Bill of meterial and assembly item" ID="Tab1" CssClass="addbutton" Height="30px" runat="server"
              OnClick="Tab1_Click" />
<asp:Button Text="Define process and overhead cost" ID="Tab2" CssClass="addbutton" Height="30px" runat="server"
              OnClick="Tab2_Click" />
<asp:MultiView ID="MainView" runat="server">
<asp:View ID="View1" runat="server">
<fieldset>
<legend>Bill of meterial: raw meterial and assembly item</legend>
<table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
<tr>
<th>
    <asp:Label ID="serialno" runat="server" Text="Serial Num"></asp:Label>
</th>
<th>
    <asp:Label ID="lblitemcode" runat="server" Text="Part Num"></asp:Label>
</th>
<th>
    <asp:Label ID="lblitemname" runat="server" Text="Description"></asp:Label>
</th>
<th>
    <asp:Label ID="lblunits" runat="server" Text="Units"></asp:Label>
</th>
<th>
    <asp:Label ID="Label3" runat="server" Text="Alternate1"></asp:Label>
</th>
<th>
    <asp:Label ID="Label8" runat="server" Text="Alternate2"></asp:Label>
</th>
<th>
    <asp:Label ID="Label9" runat="server" Text="Alternate3"></asp:Label>
</th>
<th>
    <asp:Label ID="Label14" runat="server" Text="Alternate4"></asp:Label>
</th>
<th>
    <asp:Label ID="Label15" runat="server" Text="Alternate5"></asp:Label>
</th>
<th>
<asp:Label ID="lblspq" runat="server" Text="SPQ"></asp:Label>
</th>
<th>
<asp:Label ID="lblmoq" runat="server" Text="MOQ"></asp:Label>
</th>
<th>
    <asp:Label ID="lblqty" runat="server" Text="Qty"></asp:Label>
</th>
<th>
    <asp:Label ID="lblrate" runat="server" Text="Rate"></asp:Label>
</th>
<th>
    <asp:Label ID="lblwastage" runat="server" Text="Wastage(%)"></asp:Label>
</th>
<th>
    <asp:Label ID="lblamount" runat="server" Text="Amount"></asp:Label>
</th>
<th>
    <asp:Label ID="smdpts" runat="server" Text="SMD PTS"></asp:Label>
</th>
<th>
    <asp:Label ID="thpts" runat="server" Text="TH PTS"></asp:Label>
</th>
</tr>
<tr>

<td>
    <asp:Label ID="Label18" CssClass="label" runat="server" Text="1"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode1" 
        runat="server" onselectedindexchanged="ddlitemcode1_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T1" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T2" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate1" runat="server">

    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate2" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate3" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate4" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate5" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>

<td>
<asp:TextBox ID="T3" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T4" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T6" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T8" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd1" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th1" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label19" CssClass="label" runat="server" Text="2"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode2" 
        runat="server" onselectedindexchanged="ddlitemcode2_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T9" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T10" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate6" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate7" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate8" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate9" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate10" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T11" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T12" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T13" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T14" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T15" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T16" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd2" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th2" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label20" CssClass="label" runat="server" Text="3"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode3" 
        runat="server" onselectedindexchanged="ddlitemcode3_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T17" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T18" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate11" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate12" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate13" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate14" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate15" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T19" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T20" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T21" CssClass="smalltextbox"  runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T22" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T23" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T24" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd3" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th3" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label21" CssClass="label" runat="server" Text="4"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode4" 
        runat="server" onselectedindexchanged="ddlitemcode4_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T25" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T26" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate16" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate17" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate18" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate19" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate20" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T27" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T28" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T29" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T30" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T31" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T32" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd4" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th4" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label22" CssClass="label" runat="server" Text="5"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode5" 
        runat="server" onselectedindexchanged="ddlitemcode5_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T33" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T34" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate21" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate22" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate23" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate24" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate25" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T35" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T36" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T37" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T38" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T39" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T40" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd5" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th5" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label23" CssClass="label" runat="server" Text="6"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode6" 
        runat="server" onselectedindexchanged="ddlitemcode6_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T41" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T42" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate26" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate27" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate28" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate29" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate30" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T43" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T44" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T45" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T46" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T47" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T48" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd6" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th6" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label24" CssClass="label" runat="server" Text="7"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode7" 
        runat="server" onselectedindexchanged="ddlitemcode7_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T49" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T50" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate31" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate32" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate33" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate34" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate35" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T51" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T52" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T53" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T54" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T55" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T56" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd7" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th7" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label25" CssClass="label" runat="server" Text="8"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode8" 
        runat="server" onselectedindexchanged="ddlitemcode8_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T57" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T58" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate36" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate37" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate38" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate39" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate40" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T59" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T60" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T61" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T62" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T63" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T64" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd8" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th8" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label26" CssClass="label" runat="server" Text="9"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode9" 
        runat="server" onselectedindexchanged="ddlitemcode9_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T65" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T66" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate41" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate42" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate43" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate44" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate45" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T67" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T68" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T69" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T70" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T71" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T72" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd9" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th9" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label27" CssClass="label" runat="server" Text="10"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode10" 
        runat="server" onselectedindexchanged="ddlitemcode10_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T73" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T74" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate46" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate47" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate48" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate49" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate50" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T75" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T76" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T77" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T78" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T79" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T80" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd10" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th10" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label28" CssClass="label" runat="server" Text="11"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode11" 
        runat="server" onselectedindexchanged="ddlitemcode11_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T81" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T82" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate51" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate52" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate53" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate54" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate55" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T83" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T84" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T85" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T86" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T87" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T88" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd11" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th11" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label29" CssClass="label" runat="server" Text="12"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode12" 
        runat="server" onselectedindexchanged="ddlitemcode12_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T89" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T90" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate56" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate57" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate58" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate59" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate60" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T91" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T92" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T93" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T94" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T95" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T96" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd12" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th12" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label30" CssClass="label" runat="server" Text="13"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode13" 
        runat="server" onselectedindexchanged="ddlitemcode13_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T97" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T98" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate61" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate62" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate63" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate64" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate65" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T99" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T100" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T101" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T102" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T103" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T104" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd13" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th13" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label31" CssClass="label" runat="server" Text="14"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode14" 
        runat="server" onselectedindexchanged="ddlitemcode14_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T105" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T106" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate66" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate67" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate68" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate69" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate70" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T107" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T108" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T109" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T110" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T111" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T112" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd14" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th14" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label32" CssClass="label" runat="server" Text="15"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode15" 
        runat="server" onselectedindexchanged="ddlitemcode15_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T113" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T114" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate71" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate72" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate73" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate74" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate75" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T115" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T116" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T117" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T118" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T119" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T120" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd15" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th15" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label33" CssClass="label" runat="server" Text="16"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode16" 
        runat="server" onselectedindexchanged="ddlitemcode16_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T121" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T122" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate76" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate77" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate78" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate79" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate80" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T123" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T124" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T125" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T126" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T127" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T128" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd16" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th16" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label34" CssClass="label" runat="server" Text="17"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode17" 
        runat="server" onselectedindexchanged="ddlitemcode17_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T129" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T130" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate81" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate82" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate83" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate84" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate85" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T131" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T132" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T133" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T134" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T135" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T136" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd17" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th17" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label35" CssClass="label" runat="server" Text="18"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode18" 
        runat="server" onselectedindexchanged="ddlitemcode18_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T137" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T138" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate86" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate87" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate88" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate89" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate90" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T139" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T140" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T141" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T142" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T143" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T144" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd18" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th18" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label36" CssClass="label" runat="server" Text="19"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode19" 
        runat="server" onselectedindexchanged="ddlitemcode19_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T145" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T146" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate91" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate92" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate93" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate94" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate95" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T147" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T148" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T149" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T150" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T151" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T152" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd19" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th19" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label37" CssClass="label" runat="server" Text="20"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode20" 
        runat="server" onselectedindexchanged="ddlitemcode20_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T153" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T154" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate96" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate97" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate98" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate99" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate100" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T155" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T156" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T157" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T158" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T159" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T160" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd20" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th20" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>


<td>
    <asp:Label ID="Label38" CssClass="label" runat="server" Text="21"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode21" 
        runat="server" onselectedindexchanged="ddlitemcode21_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T161" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T162" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate101" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate102" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate103" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate104" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate105" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T163" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T164" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T165" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T166" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T167" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T168" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd21" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th21" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label39" CssClass="label" runat="server" Text="22"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode22" 
        runat="server" onselectedindexchanged="ddlitemcode22_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T169" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T170" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate106" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate107" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate108" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate109" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate110" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T171" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T172" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T173" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T174" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T175" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T176" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd22" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th22" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label40" CssClass="label" runat="server" Text="23"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode23" 
        runat="server" onselectedindexchanged="ddlitemcode23_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T177" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T178" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate111" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate112" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate113" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate114" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate115" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T179" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T180" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T181" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T182" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T183" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T184" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd23" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th23" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label41" CssClass="label" runat="server" Text="24"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode24" 
        runat="server" onselectedindexchanged="ddlitemcode24_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T185" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T186" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate116" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate117" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate118" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate119" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate120" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T187" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T188" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T189" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T190" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T191" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T192" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd24" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th24" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label42" CssClass="label" runat="server" Text="25"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode25" 
        runat="server" onselectedindexchanged="ddlitemcode25_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T193" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T194" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate121" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate122" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate123" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate124" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate125" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T195" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T196" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T197" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T198" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T199" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T200" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd25" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th25" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label43" CssClass="label" runat="server" Text="26"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode26" 
        runat="server" onselectedindexchanged="ddlitemcode26_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T201" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T202" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate126" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate127" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate128" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate129" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate130" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T203" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T204" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T205" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T206" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T207" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T208" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd26" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th26" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label44" CssClass="label" runat="server" Text="27"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode27" 
        runat="server" onselectedindexchanged="ddlitemcode27_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T209" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T210" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate131" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate132" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate133" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate134" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate135" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T211" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T212" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T213" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T214" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T215" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T216" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd27" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th27" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label45" CssClass="label" runat="server" Text="28"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode28" 
        runat="server" onselectedindexchanged="ddlitemcode28_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T217" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T218" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate136" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate137" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate138" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate139" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate140" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T219" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T220" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T221" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T222" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T223" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T224" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd28" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th28" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label46" CssClass="label" runat="server" Text="29"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode29" 
        runat="server" onselectedindexchanged="ddlitemcode29_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T225" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T226" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate141" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate142" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate143" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate144" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate145" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T227" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T228" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T229" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T230" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T231" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T232" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd29" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th29" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label47" CssClass="label" runat="server" Text="30"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode30" 
        runat="server" onselectedindexchanged="ddlitemcode30_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T233" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T234" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate146" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate147" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate148" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate149" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate150" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T235" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T236" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T237" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T238" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T239" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T240" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd30" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th30" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label48" CssClass="label" runat="server" Text="31"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode31" 
        runat="server" onselectedindexchanged="ddlitemcode31_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T241" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T242" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate151" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate152" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate153" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate154" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate155" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T243" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T244" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T245" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T246" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T247" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T248" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd31" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th31" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label49" CssClass="label" runat="server" Text="32"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode32" 
        runat="server" onselectedindexchanged="ddlitemcode32_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T249" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T250" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate156" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate157" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate158" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate159" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate160" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T251" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T252" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T253" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T254" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T255" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T256" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd32" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th32" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label50" CssClass="label" runat="server" Text="33"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode33" 
        runat="server" onselectedindexchanged="ddlitemcode33_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T257" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T258" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate161" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate162" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate163" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate164" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate165" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T259" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T260" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T261" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T262" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T263" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T264" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd33" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th33" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label51" CssClass="label" runat="server" Text="34"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode34" 
        runat="server" onselectedindexchanged="ddlitemcode34_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T265" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T266" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate166" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate167" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate168" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate169" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate170" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T267" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T268" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T269" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T270" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T271" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T272" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd34" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th34" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label52" CssClass="label" runat="server" Text="35"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode35" 
        runat="server" onselectedindexchanged="ddlitemcode35_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T273" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T274" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate171" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate172" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate173" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate174" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate175" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T275" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T276" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T277" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T278" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T279" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T280" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd35" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th35" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label53" CssClass="label" runat="server" Text="36"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode36" 
        runat="server" onselectedindexchanged="ddlitemcode36_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T281" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T282" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate176" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate177" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate178" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate179" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate180" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T283" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T284" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T285" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T286" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T287" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T288" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd36" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th36" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label54" CssClass="label" runat="server" Text="37"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode37" 
        runat="server" onselectedindexchanged="ddlitemcode37_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T289" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T290" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate181" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate182" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate183" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate184" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate185" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T291" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T292" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T293" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T294" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T295" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T296" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd37" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th37" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label55" CssClass="label" runat="server" Text="38"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode38" 
        runat="server" onselectedindexchanged="ddlitemcode38_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T297" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T298" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate186" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate187" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate188" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate189" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate190" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T299" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T300" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T301" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T302" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T303" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T304" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd38" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th38" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label56" CssClass="label" runat="server" Text="39"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode39" 
        runat="server" onselectedindexchanged="ddlitemcode39_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T305" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T306" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate191" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate192" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate193" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate194" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate195" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T307" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T308" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T309" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T310" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T311" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T312" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd39" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th39" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label57" CssClass="label" runat="server" Text="40"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode40" 
        runat="server" onselectedindexchanged="ddlitemcode40_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T313" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T314" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate196" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate197" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate198" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate199" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate200" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T315" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T316" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T317" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T318" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T319" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T320" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd40" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th40" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label58" CssClass="label" runat="server" Text="41"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode41" 
        runat="server" onselectedindexchanged="ddlitemcode41_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T321" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T322" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate201" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate202" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate203" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate204" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate205" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T323" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T324" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T325" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T326" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T327" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T328" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd41" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th41" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label59" CssClass="label" runat="server" Text="42"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode42" 
        runat="server" onselectedindexchanged="ddlitemcode42_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T329" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T330" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate206" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate207" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate208" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate209" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate210" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T331" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T332" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T333" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T334" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T335" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T336" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd42" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th42" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label60" CssClass="label" runat="server" Text="43"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode43" 
        runat="server" onselectedindexchanged="ddlitemcode43_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T337" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T338" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate211" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate212" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate213" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate214" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate215" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T339" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T340" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T341" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T342" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T343" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T344" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd43" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th43" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label61" CssClass="label" runat="server" Text="44"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode44" 
        runat="server" onselectedindexchanged="ddlitemcode44_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T345" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T346" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate216" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate217" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate218" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate219" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate220" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T347" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T348" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T349" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T350" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T351" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T352" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd44" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th44" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label62" CssClass="label" runat="server" Text="45"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode45" 
        runat="server" onselectedindexchanged="ddlitemcode45_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T353" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T354" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate221" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate222" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate223" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate224" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate225" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T355" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T356" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T357" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T358" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T359" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T360" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd45" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th45" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label63" CssClass="label" runat="server" Text="46"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode46" 
        runat="server" onselectedindexchanged="ddlitemcode46_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T361" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T362" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate226" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate227" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate228" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate229" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate230" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T363" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T364" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T365" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T366" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T367" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T368" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd46" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th46" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label64" CssClass="label" runat="server" Text="47"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode47" 
        runat="server" onselectedindexchanged="ddlitemcode47_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T369" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T370" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate231" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate232" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate233" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate234" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate235" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T371" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T372" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T373" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T374" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T375" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T376" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd47" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th47" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label65" CssClass="label" runat="server" Text="48"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode48" 
        runat="server" onselectedindexchanged="ddlitemcode48_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T377" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T378" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate236" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate237" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate238" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate239" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate240" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T379" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T380" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T381" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T382" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T383" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T384" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd48" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th48" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label66" CssClass="label" runat="server" Text="49"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode49" 
        runat="server" onselectedindexchanged="ddlitemcode49_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T385" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T386" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate241" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate242" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate243" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate244" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate245" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T387" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T388" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T389" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T390" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T391" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T392" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd49" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th49" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label67" CssClass="label" runat="server" Text="50"></asp:Label>
</td>
<td>
    <asp:DropDownList CssClass="textbox" AutoPostBack="true" ID="ddlitemcode50" 
        runat="server" onselectedindexchanged="ddlitemcode50_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
 <asp:TextBox ID="T393" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T394" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="alternate246" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate247" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate248" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate249" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="alternate250" runat="server">
    <asp:ListItem Enabled="true" Selected="True" Text=" " Value="0" />
    </asp:DropDownList>
</td>
<td>
<asp:TextBox ID="T395" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>

<td>
<asp:TextBox ID="T396" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T397" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T398" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T399" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="T400" CssClass="smalltextbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="smd50" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="th50" runat="server">
    </asp:DropDownList>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label11" runat="server" Text="production rate of bill of meterial:"></asp:Label>
</td>
<td>
 <asp:TextBox ID="TextBox10" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
</table>
</fieldset>
</asp:View>
<asp:View ID="View2" runat="server">
<fieldset>
<legend>Process Operational Cost</legend>
<table style="width: 100%; border-width: 1px; display: inline-block; border-color: #666; border-style: solid">
<tr>
<th>
    <asp:Label ID="Label68" runat="server" Text="Serial Num"></asp:Label>
</th>
<th>
    <asp:Label ID="lblprocessname" runat="server" Text="Process Name"></asp:Label>
</th>
<th>
    <asp:Label ID="lblper" runat="server" Text="%"></asp:Label>
</th>
<th>
 <asp:Label ID="lbltime" runat="server" Text="Time"></asp:Label>
</th>
<th>
    <asp:Label ID="lblamount1" runat="server" Text="amount"></asp:Label>
</th>
</tr>
<tr>

<td>
    <asp:Label ID="Label69" CssClass="label" runat="server" Text="1"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname1" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time1" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label70" CssClass="label" runat="server" Text="2"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname2" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time2" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label71" CssClass="label" runat="server" Text="3"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname3" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time3" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label72" CssClass="label" runat="server" Text="4"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname4" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time4" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label73" CssClass="label" runat="server" Text="5"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname5" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P9" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time5" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P10" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label74" CssClass="label" runat="server" Text="6"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname6" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P11" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time6" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P12" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label75" CssClass="label" runat="server" Text="7"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname7" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P13" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time7" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P14" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label76" CssClass="label" runat="server" Text="8"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname8" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P15" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time8" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P16" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label77" CssClass="label" runat="server" Text="9"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname9" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P17" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time9" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P18" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label78" CssClass="label" runat="server" Text="10"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname10" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P19" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time10" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P20" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label79" CssClass="label" runat="server" Text="11"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname11" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P21" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time11" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P22" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label80" CssClass="label" runat="server" Text="12"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname12" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P23" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time12" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P24" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label81" CssClass="label" runat="server" Text="13"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname13" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P25" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time13" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P26" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label82" CssClass="label" runat="server" Text="14"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname14" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P27" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time14" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P28" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label83" CssClass="label" runat="server" Text="15"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname15" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P29" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time15" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P30" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label84" CssClass="label" runat="server" Text="16"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname16" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P31" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time16" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P32" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label85" CssClass="label" runat="server" Text="17"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname17" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P33" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time17" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P34" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label86" CssClass="label" runat="server" Text="18"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname18" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P35" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time18" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P36" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label87" CssClass="label" runat="server" Text="19"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname19" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P37" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time19" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P38" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label88" CssClass="label" runat="server" Text="20"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlprocessname20" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="P39" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="time20" CssClass="textbox" TextMode="Time" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="P40" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="Label12" runat="server" CssClass="label" Text="Total Operational Cost:"></asp:Label>
        
</td>
<td>
 <asp:TextBox ID="TextBox11" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
</table>
</fieldset>
<fieldset>
<legend>Other Overhead Cost</legend>
<table style="width: 100%; border-width: 1px; display: inline-block; border-color: #666; border-style: solid">
<tr>
<th>
    <asp:Label ID="Label89" runat="server" Text="Serial Num"></asp:Label>
</th>
<th>
    <asp:Label ID="lbloverhead" runat="server" Text="Overhead Name"></asp:Label>
</th>
<th>
    <asp:Label ID="lblper1" runat="server" Text="%"></asp:Label>
</th>
<th>
    <asp:Label ID="lblamount2" runat="server" Text="Amount"></asp:Label>
</th>
</tr>
<tr>

<td>
    <asp:Label ID="Label90" CssClass="label" runat="server" Text="1"></asp:Label>
</td>
<td>
    <asp:TextBox ID="O1" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label91" CssClass="label" runat="server" Text="2"></asp:Label>
</td>
<td>
    <asp:TextBox ID="O4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label92" CssClass="label" runat="server" Text="3"></asp:Label>
</td>
<td>
    <asp:TextBox ID="O7" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O9" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label93" CssClass="label" runat="server" Text="4"></asp:Label>
</td>
<td>
<asp:TextBox ID="O10" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O11" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O12" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label94" CssClass="label" runat="server" Text="5"></asp:Label>
</td>
<td>
   <asp:TextBox ID="O13" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O14" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O15" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label95" CssClass="label" runat="server" Text="6"></asp:Label>
</td>
<td>
    <asp:TextBox ID="O16" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O17" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O18" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label96" CssClass="label" runat="server" Text="7"></asp:Label>
</td>
<td>
   <asp:TextBox ID="O19" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O20" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O21" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label97" CssClass="label" runat="server" Text="8"></asp:Label>
</td>
<td>
  <asp:TextBox ID="O22" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O23" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O24" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label98" CssClass="label" runat="server" Text="9"></asp:Label>
</td>
<td>
   <asp:TextBox ID="O25" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O26" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O27" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label99" CssClass="label" runat="server" Text="10"></asp:Label>
</td>
<td>
   <asp:TextBox ID="O28" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O29" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O30" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label100" CssClass="label" runat="server" Text="11"></asp:Label>
</td>
<td>
   <asp:TextBox ID="O31" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O32" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O33" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label101" CssClass="label" runat="server" Text="12"></asp:Label>
</td>
<td>
   <asp:TextBox ID="O34" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O35" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O36" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label102" CssClass="label" runat="server" Text="13"></asp:Label>
</td>
<td>
   <asp:TextBox ID="O37" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O38" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O39" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label103" CssClass="label" runat="server" Text="14"></asp:Label>
</td>
<td>
    <asp:TextBox ID="O40" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O41" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O42" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label104" CssClass="label" runat="server" Text="15"></asp:Label>
</td>
<td>
   <asp:TextBox ID="O43" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O44" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O45" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label105" CssClass="label" runat="server" Text="16"></asp:Label>
</td>
<td>
   <asp:TextBox ID="O46" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O47" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O48" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label106" CssClass="label" runat="server" Text="17"></asp:Label>
</td>
<td>
    <asp:TextBox ID="O49" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O50" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O51" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label107" CssClass="label" runat="server" Text="18"></asp:Label>
</td>
<td>
    <asp:TextBox ID="O52" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O53" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O54" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label108" CssClass="label" runat="server" Text="19"></asp:Label>
</td>
<td>
    <asp:TextBox ID="O55" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O56" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O57" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>

<td>
    <asp:Label ID="Label109" CssClass="label" runat="server" Text="20"></asp:Label>
</td>
<td>
    <asp:TextBox ID="O58" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="O59" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="O60" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
 <asp:Label ID="Label13" runat="server" CssClass="label" Text="Total Overhead Cost:"></asp:Label>
</td>
<td>
<asp:TextBox ID="TextBox12" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
</table>
</fieldset>
</asp:View>
</asp:MultiView>
</td>
</tr>
</table>
    <table>
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
</fieldset>
</div>
</asp:Content>
