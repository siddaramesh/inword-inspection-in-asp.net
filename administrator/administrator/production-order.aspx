<%@ Page Title="Production Order" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="production-order.aspx.cs" Inherits="administrator.production_order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
<script type="text/javascript">

    $(function () {

        $("#<%= txtorderdate.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox3.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox6.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox9.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox12.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox15.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox18.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox21.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox24.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox27.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox30.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox33.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox36.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox39.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox42.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox45.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox48.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox51.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox54.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox57.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox60.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox63.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox66.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox69.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox72.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox75.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox78.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox81.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox84.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox87.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox90.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox93.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox96.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox99.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox102.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox105.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox108.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox111.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox114.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox117.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox120.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox123.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox126.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox129.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox132.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox135.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox138.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox141.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox144.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox147.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox150.ClientID %>").datepicker({
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
    <asp:Label ID="Label7" runat="server" ForeColor="Red" Text=""></asp:Label>
</p>
<div class="description">
<fieldset class="borderradius">
<legend>Customer Details</legend>
<table>
<tr>
<td>
    <asp:Label ID="lblordertype" runat="server" CssClass="label" Text="Order Type:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlorder" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlorder_SelectedIndexChanged">
    <asp:ListItem Enabled="true" Text="Outside Order" Value="OutsideOrder" />
    <asp:ListItem Enabled="true" Text="Internal Order" Value="Internal" />
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="lblcustomercode" runat="server" CssClass="label" Text="Customer Code:"></asp:Label>
    <asp:Label ID="lblrequest" runat="server" Visible="false" CssClass="label" Text="Requested By:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlcustomercode" runat="server">
    <asp:ListItem Enabled="true" Text="please select" Value="0" />
    </asp:DropDownList>
    <asp:TextBox ID="txtrequest" CssClass="textbox" Visible="false" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="lblcustomername" runat="server" CssClass="label" Text="Customer Name:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtcustomername" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="lblordernum" runat="server" CssClass="label" Text="Order Num:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtordernum" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="lblorderdate" runat="server" CssClass="label" Text="Order Date:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtorderdate" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="lblcontact1" runat="server" CssClass="label" Text="Contact Num1:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtcontact1" CssClass="textbox" AutoPostBack="true" 
        runat="server" ontextchanged="txtcontact1_TextChanged"></asp:TextBox>
</td>
<td>
    <asp:Label ID="lblcontact2" runat="server" CssClass="label" Text="Contact Num2:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtcontact2" CssClass="textbox" AutoPostBack="true" 
        runat="server" ontextchanged="txtcontact2_TextChanged"></asp:TextBox>
</td>
<td>
    <asp:Label ID="lblcontact3" runat="server" CssClass="label" Text="Contact Num3:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtcontact3" CssClass="textbox" AutoPostBack="true" 
        runat="server" ontextchanged="txtcontact3_TextChanged"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="lblemail1" runat="server" CssClass="label" Text="E-MAIL ID-1:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtemail1" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="lblemail2" runat="server" CssClass="label" Text="E-MAIL ID-2:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtemail2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="lblemail3" runat="server" CssClass="label" Text="E-MAIL ID-3:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtemail3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
</table>
</fieldset>
</div>
<div class="description">
<fieldset class="borderradius">
<legend>Order Details</legend>
<table style="border:1px solid black;">
<tr>
<th>
    <asp:Label ID="Label1" runat="server" Text="Serial Num"></asp:Label>
</th>
<th>
    <asp:Label ID="Label2" runat="server" Text="PART NUM"></asp:Label>
</th>
<th>
    <asp:Label ID="Label3" runat="server" Text="DESCRIPTION"></asp:Label>
</th>
<th>
    <asp:Label ID="Label4" runat="server" Text="ORDER QTY"></asp:Label>
</th>
<th>
    <asp:Label ID="Label5" runat="server" Text="DELIVERY DATE"></asp:Label>
</th>
<th>
    <asp:Label ID="Label6" runat="server" Text="DELIVERY TYPE"></asp:Label>
</th>
</tr>
<!-- Order Details row 1-->
<tr>
<td>
    <asp:Label ID="no1" CssClass="label" runat="server" Text="1"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno1" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno1_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox1" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype1" CssClass="textbox" runat="server">

    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 2-->
<tr>
<td>
    <asp:Label ID="no2" CssClass="label" runat="server" Text="2"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno2" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno2_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox4" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox6" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype2" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 3-->
<tr>
<td>
    <asp:Label ID="no3" CssClass="label" runat="server" Text="3"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno3" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno3_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox7" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox9" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype3" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 4-->
<tr>
<td>
    <asp:Label ID="no4" CssClass="label" runat="server" Text="4"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno4" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno4_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox10" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox11" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox12" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype4" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 5-->
<tr>
<td>
    <asp:Label ID="no5" CssClass="label" runat="server" Text="5"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno5" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno5_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox13" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox14" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox15" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype5" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 6-->
<tr>
<td>
    <asp:Label ID="no6" CssClass="label" runat="server" Text="6"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno6" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno6_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox16" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox17" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox18" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype6" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 7-->
<tr>
<td>
    <asp:Label ID="no7" CssClass="label" runat="server" Text="7"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno7" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno7_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox19" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox20" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox21" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype7" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 8-->
<tr>
<td>
    <asp:Label ID="no8" CssClass="label" runat="server" Text="8"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno8" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno8_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox22" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox23" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox24" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype8" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 9-->
<tr>
<td>
    <asp:Label ID="no9" CssClass="label" runat="server" Text="9"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno9" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno9_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox25" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox26" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox27" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype9" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 10-->
<tr>
<td>
    <asp:Label ID="no10" CssClass="label" runat="server" Text="10"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno10" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno10_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox28" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox29" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox30" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype10" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 11-->
<tr>
<td>
    <asp:Label ID="no11" CssClass="label" runat="server" Text="11"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno11" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno11_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox31" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox32" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox33" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype11" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 12-->
<tr>
<td>
    <asp:Label ID="no12" CssClass="label" runat="server" Text="12"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno12" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno12_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox34" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox35" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox36" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype12" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 13-->
<tr>
<td>
    <asp:Label ID="no13" CssClass="label" runat="server" Text="13"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno13" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno13_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox37" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox38" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox39" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype13" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 14-->
<tr>
<td>
    <asp:Label ID="no14" CssClass="label" runat="server" Text="14"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno14" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno14_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox40" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox41" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox42" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype14" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 15-->
<tr>
<td>
    <asp:Label ID="no15" CssClass="label" runat="server" Text="15"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno15" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno15_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox43" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox44" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox45" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype15" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 16-->
<tr>
<td>
    <asp:Label ID="no16" CssClass="label" runat="server" Text="16"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno16" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno16_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox46" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox47" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox48" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype16" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 17-->
<tr>
<td>
    <asp:Label ID="no17" CssClass="label" runat="server" Text="17"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno17" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno17_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox49" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox50" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox51" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype17" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 18-->
<tr>
<td>
    <asp:Label ID="no18" CssClass="label" runat="server" Text="18"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno18" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno18_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox52" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox53" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox54" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype18" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 19-->
<tr>
<td>
    <asp:Label ID="no19" CssClass="label" runat="server" Text="19"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno19" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno19_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox55" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox56" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox57" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype19" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 20-->
<tr>
<td>
    <asp:Label ID="no20" CssClass="label" runat="server" Text="20"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno20" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno20_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox58" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox59" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox60" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype20" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 21-->
<tr>
<td>
    <asp:Label ID="no21" CssClass="label" runat="server" Text="21"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno21" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno21_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox61" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox62" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox63" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype21" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 22-->
<tr>
<td>
    <asp:Label ID="no22" CssClass="label" runat="server" Text="22"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno22" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno22_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox64" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox65" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox66" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype22" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 23-->
<tr>
<td>
    <asp:Label ID="no23" CssClass="label" runat="server" Text="23"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno23" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno23_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox67" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox68" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox69" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype23" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 24-->
<tr>
<td>
    <asp:Label ID="no24" CssClass="label" runat="server" Text="24"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno24" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno24_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox70" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox71" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox72" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype24" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 25-->
<tr>
<td>
    <asp:Label ID="no25" CssClass="label" runat="server" Text="25"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno25" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno25_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox73" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox74" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox75" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype25" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 26-->
<tr>
<td>
    <asp:Label ID="no26" CssClass="label" runat="server" Text="26"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno26" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno26_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox76" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox77" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox78" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype26" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 27-->
<tr>
<td>
    <asp:Label ID="no27" CssClass="label" runat="server" Text="27"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno27" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno27_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox79" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox80" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox81" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype27" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 28-->
<tr>
<td>
    <asp:Label ID="no28" CssClass="label" runat="server" Text="28"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno28" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno28_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox82" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox83" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox84" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype28" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 29-->
<tr>
<td>
    <asp:Label ID="no29" CssClass="label" runat="server" Text="29"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno29" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno29_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox85" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox86" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox87" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype29" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 30-->
<tr>
<td>
    <asp:Label ID="no30" CssClass="label" runat="server" Text="30"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno30" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno30_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox88" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox89" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox90" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype30" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 31-->
<tr>
<td>
    <asp:Label ID="no31" CssClass="label" runat="server" Text="31"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno31" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno31_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox91" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox92" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox93" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype31" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 32-->
<tr>
<td>
    <asp:Label ID="no32" CssClass="label" runat="server" Text="32"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno32" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno32_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox94" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox95" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox96" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype32" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 33-->
<tr>
<td>
    <asp:Label ID="no33" CssClass="label" runat="server" Text="33"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno33" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno33_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox97" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox98" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox99" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype33" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 34-->
<tr>
<td>
    <asp:Label ID="no34" CssClass="label" runat="server" Text="34"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno34" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno34_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox100" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox101" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox102" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype34" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 35-->
<tr>
<td>
    <asp:Label ID="no35" CssClass="label" runat="server" Text="35"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno35" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno35_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox103" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox104" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox105" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype35" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 36-->
<tr>
<td>
    <asp:Label ID="no36" CssClass="label" runat="server" Text="36"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno36" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno36_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox106" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox107" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox108" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype36" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 37-->
<tr>
<td>
    <asp:Label ID="no37" CssClass="label" runat="server" Text="37"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno37" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno37_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox109" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox110" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox111" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype37" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 38-->
<tr>
<td>
    <asp:Label ID="no38" CssClass="label" runat="server" Text="38"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno38" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno38_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox112" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox113" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox114" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype38" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 39-->
<tr>
<td>
    <asp:Label ID="no39" CssClass="label" runat="server" Text="39"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno39" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno39_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox115" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox116" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox117" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype39" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 40-->
<tr>
<td>
    <asp:Label ID="no40" CssClass="label" runat="server" Text="40"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno40" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno40_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox118" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox119" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox120" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype40" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 41-->
<tr>
<td>
    <asp:Label ID="no41" CssClass="label" runat="server" Text="41"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno41" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno41_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox121" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox122" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox123" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype41" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 42-->
<tr>
<td>
    <asp:Label ID="no42" CssClass="label" runat="server" Text="42"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno42" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno42_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox124" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox125" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox126" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype42" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 43-->
<tr>
<td>
    <asp:Label ID="no43" CssClass="label" runat="server" Text="43"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno43" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno43_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox127" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox128" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox129" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype43" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 44-->
<tr>
<td>
    <asp:Label ID="no44" CssClass="label" runat="server" Text="44"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno44" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno44_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox130" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox131" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox132" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype44" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 45-->
<tr>
<td>
    <asp:Label ID="no45" CssClass="label" runat="server" Text="45"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno45" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno45_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox133" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox134" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox135" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype45" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 46-->
<tr>
<td>
    <asp:Label ID="no46" CssClass="label" runat="server" Text="46"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno46" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno46_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox136" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox137" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox138" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype46" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 47-->
<tr>
<td>
    <asp:Label ID="no47" CssClass="label" runat="server" Text="47"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno47" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno47_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox139" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox140" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox141" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype47" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 48-->
<tr>
<td>
    <asp:Label ID="no48" CssClass="label" runat="server" Text="48"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno48" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno48_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox142" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox143" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox144" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype48" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 49-->
<tr>
<td>
    <asp:Label ID="no49" CssClass="label" runat="server" Text="49"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno49" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno49_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox145" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox146" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox147" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype49" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
<!-- Order Details row 50-->
<tr>
<td>
    <asp:Label ID="no50" CssClass="label" runat="server" Text="50"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlpartno50" CssClass="textbox" AutoPostBack="true" 
        runat="server" onselectedindexchanged="ddlpartno50_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox148" CssClass="textbox" ReadOnly="true" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox149" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox150" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddldeliverytype50" CssClass="textbox" runat="server">
    <asp:ListItem Enabled="true" Text="Full delivery" Value="1" />
    <asp:ListItem Enabled="true" Text="Partial deliver" Value="2" />
    </asp:DropDownList>
</td>
</tr>
</table>
</fieldset>

<table>
    <tr>
    <td>
        <asp:Button ID="Button1" CssClass="addbutton" Width="80px" Height="30px" 
            runat="server" Text="Save" onclick="Button1_Click" />
    </td>
    <td>
        <asp:Button ID="Button2" CssClass="addbutton" Width="80px" Height="30px" 
            runat="server" Text="Cancel" onclick="Button2_Click" />
    </td>
    </tr>
    </table>
</div>

</asp:Content>
