<%@ Page Title="Job Card" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="jobcard.aspx.cs" Inherits="administrator.jobcard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
<script type="text/javascript">

    $(function () {

        $("#<%= txtorderdate.ClientID %>").datepicker({
            dateFormat: 'dd-mm-yy'
        });
        $("#<%= TextBox2.ClientID %>").datepicker({
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
    <asp:Label ID="Label39" runat="server" ForeColor="Red" Text=""></asp:Label>
</p>
<div class="description">
<fieldset class="borderradius">
<legend>Job Card</legend>
<table>
<tr>
<td>
    <asp:Label ID="jobcardno" runat="server" CssClass="label" Text="Job Card No:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtjobcardno" ReadOnly="true" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="orderno" runat="server" CssClass="label" Text="Order No:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlorderno" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="orderqty" runat="server" CssClass="label" Text="Order Qty:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtorderqty" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="orderdate" CssClass="label" runat="server" Text="Order Date:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtorderdate" CssClass="textbox"  runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="partno" runat="server" CssClass="label" Text="Product Partno:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtproductpartno" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="sfgpartno" runat="server" CssClass="label" Text="SFG Partno:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlsfgpartno" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
</tr>
</table>
</fieldset>
</div>
<div class="description">
<fieldset class="borderradius">
<legend>Details</legend>
<table>
<tr>
<td>
<asp:Button Text="Activity/Task" ID="Tab1" CssClass="addbutton" Height="30px" 
        runat="server" onclick="Tab1_Click" />
<asp:Button Text="Extra Material" ID="Tab2" CssClass="addbutton" Height="30px" 
        runat="server" onclick="Tab2_Click" />
<asp:Button ID="Tab3" Text="Consumables" CssClass="addbutton" Height="30px" 
        runat="server" onclick="Tab3_Click" />
    <asp:MultiView ID="MainView" runat="server">
<asp:View ID="view1" runat="server">
<div class="description">
<fieldset>
<legend>Activity/Task</legend>
<table>
<tr>
<th>
    <asp:Label ID="Label1" runat="server" Text="NUM"></asp:Label>
</th>
<th>
    <asp:Label ID="Label2" runat="server" Text="PROCESS/ACTIVITY"></asp:Label>
</th>
<th>
    <asp:Label ID="Label3" runat="server" Text="START DATE"></asp:Label>
</th>
<th>
    <asp:Label ID="Label4" runat="server" Text="START TIME"></asp:Label>
</th>
<th>
    <asp:Label ID="Label5" runat="server" Text="END DATE"></asp:Label>
</th>
<th>
    <asp:Label ID="Label6" runat="server" Text="END TIME"></asp:Label>
</th>
<th>
    <asp:Label ID="Label7" runat="server" Text="TEAM STRENGTH"></asp:Label>
</th>
<th>
    <asp:Label ID="Label8" runat="server" Text="QTY PLANNED"></asp:Label>
</th>
<th>
    <asp:Label ID="Label9" runat="server" Text="QTY FINISHED"></asp:Label>
</th>
<th>
    <asp:Label ID="Label10" runat="server" Text="OPERATORS"></asp:Label>
</th>
<th>
    <asp:Label ID="Label11" runat="server" Text="COMMENTS"></asp:Label>
</th>
</tr>

<!-- Row 1 -->
<tr>
<td>
<asp:Label ID="no1" CssClass="label" runat="server" Text="1"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddltask1" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate1" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime1" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate1" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime1" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team1" CssClass="smalltextbox" MaxLength="2" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator1" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment1" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 2 -->
<tr>
<td>
<asp:Label ID="no2" CssClass="label" runat="server" Text="2"></asp:Label>
</td>
<td>
     <asp:DropDownList ID="ddltask2" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team2" CssClass="smalltextbox" MaxLength="2" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 3 -->
<tr>
<td>
<asp:Label ID="no3" CssClass="label" runat="server" Text="3"></asp:Label>
</td>
<td>
   <asp:DropDownList ID="ddltask3" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team3" CssClass="smalltextbox" MaxLength="2" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 4 -->
<tr>
<td>
<asp:Label ID="no4" CssClass="label" runat="server" Text="4"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddltask4" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team4" CssClass="smalltextbox" MaxLength="2" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 5 -->
<tr>
<td>
<asp:Label ID="no5" CssClass="label" runat="server" Text="5"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddltask5" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate5" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime5" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate5" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime5" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team5" CssClass="smalltextbox" MaxLength="2" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator5" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment5" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 6 -->
<tr>
<td>
<asp:Label ID="no6" CssClass="label" runat="server" Text="6"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddltask6" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate6" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime6" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate6" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime6" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team6" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator6" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment6" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 7 -->
<tr>
<td>
<asp:Label ID="no7" CssClass="label" runat="server" Text="7"></asp:Label>
</td>
<td>
     <asp:DropDownList ID="ddltask7" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate7" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime7" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate7" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime7" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team7" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator7" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment7" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 8 -->
<tr>
<td>
<asp:Label ID="no8" CssClass="label" runat="server" Text="8"></asp:Label>
</td>
<td>
     <asp:DropDownList ID="ddltask8" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate8" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime8" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate8" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime8" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team8" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator8" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment8" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 9 -->
<tr>
<td>
<asp:Label ID="no9" CssClass="label" runat="server" Text="9"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddltask9" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate9" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime9" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate9" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime9" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team9" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned9" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished9" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator9" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment9" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 10 -->
<tr>
<td>
<asp:Label ID="no10" CssClass="label" runat="server" Text="10"></asp:Label>
</td>
<td>
     <asp:DropDownList ID="ddltask10" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate10" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime10" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate10" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime10" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team10" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned10" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished10" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator10" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment10" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 11 -->
<tr>
<td>
<asp:Label ID="no11" CssClass="label" runat="server" Text="11"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddltask11" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate11" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime11" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate11" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime11" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team11" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned11" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished11" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator11" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment11" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 12 -->
<tr>
<td>
<asp:Label ID="no12" CssClass="label" runat="server" Text="12"></asp:Label>
</td>
<td>
     <asp:DropDownList ID="ddltask12" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate12" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime12" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate12" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime12" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team12" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned12" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished12" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator12" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment12" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 13 -->
<tr>
<td>
<asp:Label ID="no13" CssClass="label" runat="server" Text="13"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddltask13" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate13" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime13" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate13" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime13" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team13" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned13" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished13" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator13" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment13" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 14 -->
<tr>
<td>
<asp:Label ID="no14" CssClass="label" runat="server" Text="14"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddltask14" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate14" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime14" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate14" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime14" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team14" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned14" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished14" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator14" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment14" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 15 -->
<tr>
<td>
<asp:Label ID="no15" CssClass="label" runat="server" Text="15"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddltask15" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate15" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime15" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate15" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime15" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team15" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned15" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished15" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator15" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment15" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 16 -->
<tr>
<td>
<asp:Label ID="no16" CssClass="label" runat="server" Text="16"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddltask16" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate16" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime16" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate16" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime16" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team16" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned16" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished16" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator16" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment16" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 17 -->
<tr>
<td>
<asp:Label ID="no17" CssClass="label" runat="server" Text="17"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddltask17" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate17" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime17" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate17" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime17" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team17" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned17" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished17" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator17" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment17" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 18 -->
<tr>
<td>
<asp:Label ID="no18" CssClass="label" runat="server" Text="18"></asp:Label>
</td>
<td>
   <asp:DropDownList ID="ddltask18" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate18" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime18" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate18" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime18" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team18" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned18" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished18" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator18" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment18" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 19 -->
<tr>
<td>
<asp:Label ID="no19" CssClass="label" runat="server" Text="19"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddltask19" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate19" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime19" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate19" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime19" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team19" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned19" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished19" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator19" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment19" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- Row 20 -->
<tr>
<td>
<asp:Label ID="no20" CssClass="label" runat="server" Text="20"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddltask20" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="startdate20" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="starttime20" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="enddate20" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="endtime20" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="team20" runat="server" CssClass="smalltextbox" MaxLength="2"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyplanned20" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyfinished20" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="operator20" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="comment20" CssClass="textbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td></td><td></td><td></td>
<td>
    <asp:Label ID="Label18" runat="server" CssClass="label" Text="Actual EndTime of Task:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox5" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td></td>
<td>
    <asp:Label ID="Label19" runat="server" CssClass="label" Text="Actual Qty Finished:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
</table>
</fieldset>
</div>
<div>
<fieldset>
<legend>Billing</legend>
<table>
<tr>
<th>
    <asp:Label ID="Label12" runat="server" Text="NUM"></asp:Label>
</th>
<th>
    <asp:Label ID="Label13" runat="server" Text="ACTIVITY CODE"></asp:Label>
</th>
<th>
    <asp:Label ID="Label14" runat="server" Text="ESTIMATED TIME REQ"></asp:Label>
</th>
<th>
    <asp:Label ID="Label15" runat="server" Text="BILLING(YES/NO)"></asp:Label>
</th>
<th>
    <asp:Label ID="Label16" runat="server" Text="BILLING RATE"></asp:Label>
</th>
<th>
    <asp:Label ID="Label17" runat="server" Text="BILLING VALUE"></asp:Label>
</th>
</tr>
<!-- row 1 -->
<tr>
<td>
    <asp:Label ID="num1" runat="server" CssClass="label" Text="1"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity1" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime1" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable1" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 2 -->
<tr>
<td>
    <asp:Label ID="num2" runat="server" CssClass="label" Text="2"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable2" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 3 -->
<tr>
<td>
    <asp:Label ID="num3" runat="server" CssClass="label" Text="3"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable3" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 4 -->
<tr>
<td>
    <asp:Label ID="num4" runat="server" CssClass="label" Text="4"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable4" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 5 -->
<tr>
<td>
    <asp:Label ID="num5" runat="server" CssClass="label" Text="5"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity5" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime5" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable5" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 6 -->
<tr>
<td>
    <asp:Label ID="num6" runat="server" CssClass="label" Text="6"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity6" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime6" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable6" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 7 -->
<tr>
<td>
    <asp:Label ID="num7" runat="server" CssClass="label" Text="7"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity7" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime7" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable7" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 8 -->
<tr>
<td>
    <asp:Label ID="num8" runat="server" CssClass="label" Text="8"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity8" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime8" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable8" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 9 -->
<tr>
<td>
    <asp:Label ID="num9" runat="server" CssClass="label" Text="9"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity9" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime9" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable9" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate9" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue9" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 10 -->
<tr>
<td>
    <asp:Label ID="num10" runat="server" CssClass="label" Text="10"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity10" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime10" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable10" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate10" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue10" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 11 -->
<tr>
<td>
    <asp:Label ID="num11" runat="server" CssClass="label" Text="11"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity11" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime11" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable11" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate11" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue11" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 12 -->
<tr>
<td>
    <asp:Label ID="num12" runat="server" CssClass="label" Text="12"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity12" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime12" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable12" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate12" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue12" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 13 -->
<tr>
<td>
    <asp:Label ID="num13" runat="server" CssClass="label" Text="13"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity13" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime13" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable13" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate13" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue13" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 14 -->
<tr>
<td>
    <asp:Label ID="num14" runat="server" CssClass="label" Text="14"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity14" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime14" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable14" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate14" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue14" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 15 -->
<tr>
<td>
    <asp:Label ID="num15" runat="server" CssClass="label" Text="15"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity15" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime15" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable15" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate15" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue15" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 16 -->
<tr>
<td>
    <asp:Label ID="num16" runat="server" CssClass="label" Text="16"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity16" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime16" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable16" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate16" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue16" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 17 -->
<tr>
<td>
    <asp:Label ID="num17" runat="server" CssClass="label" Text="17"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity17" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime17" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable17" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate17" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue17" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 18 -->
<tr>
<td>
    <asp:Label ID="num18" runat="server" CssClass="label" Text="18"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity18" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime18" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable18" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate18" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue18" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 19 -->
<tr>
<td>
    <asp:Label ID="num19" runat="server" CssClass="label" Text="19"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity19" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime19" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable19" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate19" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue19" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 20 -->
<tr>
<td>
    <asp:Label ID="num20" runat="server" CssClass="label" Text="20"></asp:Label>
</td>
<td>
    <asp:TextBox ID="activity20" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="estimatedtime20" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:DropDownList ID="ddlbillable20" CssClass="smalltextbox" runat="server">
    <asp:ListItem Enabled="true" Text="Yes" Value="Yes" />
    <asp:ListItem Enabled="true" Text="No" Value="No" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="billingrate20" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="billingvalue20" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td></td>
<td>
    <asp:Label ID="labourtotal" runat="server" CssClass="label" Text="Labour Total:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
</table>
</fieldset>
</div>
</asp:View>
<asp:View ID="view2" runat="server">
<div>
<fieldset>
<legend>Extra Materials</legend>
<table>
<tr>
<th>
    <asp:Label ID="Label20" runat="server" Text="NUM"></asp:Label>
</th>
<th>
    <asp:Label ID="Label21" runat="server" Text="MATERIALS"></asp:Label>
</th>
<th>
    <asp:Label ID="Label22" runat="server" Text="PARTNO"></asp:Label>
</th>
<th>
    <asp:Label ID="Label23" runat="server" Text="QTY ISSUED"></asp:Label>
</th>
<th>
    <asp:Label ID="Label24" runat="server" Text="EXTRA ISSUED QTY"></asp:Label>
</th>
<th>
    <asp:Label ID="Label25" runat="server" Text="COMMENT"></asp:Label>
</th>
<th>
    <asp:Label ID="Label26" runat="server" Text="UNIT COST"></asp:Label>
</th>
<th>
    <asp:Label ID="Label27" runat="server" Text="MATERIAL COST"></asp:Label>
</th>
<th>
    <asp:Label ID="Label28" runat="server" Text="MARK-UP (%)"></asp:Label>
</th>
<th>
    <asp:Label ID="Label29" runat="server" Text="MATERIAL CHARGE"></asp:Label>
</th>
</tr>
<!-- row 1 -->
<tr>
<td>
    <asp:Label ID="n1" runat="server" CssClass="label" Text="1"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlmaterial1" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="ddlpartno1" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qtyissued1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="extraqty1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="cmt1" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="unitcost1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcost1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="markup1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcharge1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 2 -->
<tr>
<td>
    <asp:Label ID="n2" runat="server" CssClass="label" Text="2"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlmaterial2" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="ddlpartno2" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qtyissued2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="extraqty2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="cmd2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="unitcost2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcost2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="markup2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcharge2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 3 -->
<tr>
<td>
    <asp:Label ID="n3" runat="server" CssClass="label" Text="3"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlmaterial3" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="ddlpartno3" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qtyissued3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="extraqty3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="cmd3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="unitcost3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcost3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="markup3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcharge3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 4 -->
<tr>
<td>
    <asp:Label ID="n4" runat="server" CssClass="label" Text="4"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlmaterial4" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="ddlpartno4" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qtyissued4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="extraqty4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="cmt4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="unitcost4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcost4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="markup4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcharge4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 5 -->
<tr>
<td>
    <asp:Label ID="n5" runat="server" CssClass="label" Text="5"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlmaterial5" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="ddlpartno5" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qtyissued5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="extraqty5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="cmt5" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="unitcost5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcost5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="markup5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcharge5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 6 -->
<tr>
<td>
    <asp:Label ID="n6" runat="server" CssClass="label" Text="6"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlmaterial6" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="ddlpartno6" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qtyissued6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="extraqty6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="cmt6" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="unitcost6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcost6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="markup6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcharge6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 7 -->
<tr>
<td>
    <asp:Label ID="n7" runat="server" CssClass="label" Text="7"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlmaterial7" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="ddlpartno7" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qtyissued7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="extraqty7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="cmt7" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="unitcost7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcost7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="markup7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcharge7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 8 -->
<tr>
<td>
    <asp:Label ID="n8" runat="server" CssClass="label" Text="8"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="ddlmaterial8" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="ddlpartno8" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="qtyissued8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="extraqty8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="cmt8" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="unitcost8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcost8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="markup8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="materialcharge8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>

</table>
</fieldset>
</div>
</asp:View>
<asp:View ID="view3" runat="server">
<div>
<fieldset>
<legend>Consumables</legend>
<table>
<tr>
<th>
    <asp:Label ID="Label30" runat="server" Text="NUM"></asp:Label>
</th>
<th>
    <asp:Label ID="Label31" runat="server" Text="CONSUMABLES"></asp:Label>
</th>
<th>
    <asp:Label ID="Label32" runat="server" Text="PARTNO"></asp:Label>
</th>
<th>
    <asp:Label ID="Label33" runat="server" Text="UNIT"></asp:Label>
</th>
<th>
    <asp:Label ID="Label34" runat="server" Text="UNIT COST"></asp:Label>
</th>
<th>
    <asp:Label ID="Label35" runat="server" Text="MATERIAL COST"></asp:Label>
</th>
<th>
    <asp:Label ID="Label36" runat="server" Text="MARK-UP (%)"></asp:Label>
</th>
<th>
    <asp:Label ID="Label37" runat="server" Text="MATERIAL CHARGE"></asp:Label>
</th>
<th>
    <asp:Label ID="Label38" runat="server" Text="QTY ISSUED"></asp:Label>
</th>
</tr>
<!-- row 1 -->
<tr>
<td>
    <asp:Label ID="nom1" runat="server" Text="1"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="consumables1" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="pno1" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="u1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="ucost1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mc1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mp1" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="matcharge1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyissue1" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 2 -->
<tr>
<td>
    <asp:Label ID="nom2" runat="server" Text="2"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="consumables2" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="pno2" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="u2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="ucost2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mc2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mp2" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="matcharge2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyissue2" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 3 -->
<tr>
<td>
    <asp:Label ID="nom3" runat="server" Text="3"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="consumables3" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="pno3" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="u3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="ucost3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mc3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mp3" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="matcharge3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyissue3" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 4 -->
<tr>
<td>
    <asp:Label ID="nom4" runat="server" Text="4"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="consumables4" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="pno4" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="u4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="ucost4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mc4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mp4" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="matcharge4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyissue4" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 5 -->
<tr>
<td>
    <asp:Label ID="nom5" runat="server" Text="5"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="consumables5" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="pno5" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="u5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="ucost5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mc5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mp5" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="matcharge5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyissue5" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 6 -->
<tr>
<td>
    <asp:Label ID="nom6" runat="server" Text="6"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="consumables6" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="pno6" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="u6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="ucost6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mc6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mp6" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="matcharge6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyissue6" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 7 -->
<tr>
<td>
    <asp:Label ID="nom7" runat="server" Text="7"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="consumables7" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="pno7" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="u7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="ucost7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mc7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mp7" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="matcharge7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyissue7" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 8 -->
<tr>
<td>
    <asp:Label ID="nom8" runat="server" Text="8"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="consumables8" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="pno8" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="u8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="ucost8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mc8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mp8" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="matcharge8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyissue8" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 9 -->
<tr>
<td>
    <asp:Label ID="nom9" runat="server" Text="9"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="consumables9" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="pno9" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="u9" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="ucost9" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mc9" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mp9" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="matcharge9" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyissue9" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 10 -->
<tr>
<td>
    <asp:Label ID="nom10" runat="server" Text="10"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="consumables10" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="pno10" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="u10" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="ucost10" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mc10" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mp10" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="matcharge10" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyissue10" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 11 -->
<tr>
<td>
    <asp:Label ID="nom11" runat="server" Text="11"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="consumables11" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="pno11" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="u11" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="ucost11" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mc11" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mp11" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="matcharge11" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyissue11" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 12 -->
<tr>
<td>
    <asp:Label ID="nom12" runat="server" Text="12"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="consumables12" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="pno12" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="u12" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="ucost12" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mc12" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mp12" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="matcharge12" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyissue12" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>
<!-- row 13 -->
<tr>
<td>
    <asp:Label ID="nom13" runat="server" Text="13"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="consumables13" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="pno13" CssClass="textbox" runat="server">
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="u13" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="ucost13" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mc13" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="mp13" CssClass="textbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="matcharge13" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="qtyissue13" CssClass="smalltextbox" runat="server"></asp:TextBox>
</td>
</tr>

</table>
</fieldset>
</div>
</asp:View>
    </asp:MultiView>
</td>
</tr>
<tr>
<td>
 <asp:Button ID="Button1" CssClass="addbutton" Width="80px" Height="30px" 
            runat="server" Text="Save" />
 <asp:Button ID="Button2" CssClass="addbutton" Width="80px" Height="30px" runat="server" Text="Cancel" />
</td>
<td>

</td>
</tr>
</table>
</fieldset>
</div>
</asp:Content>
