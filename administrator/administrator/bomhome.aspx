﻿<%@ Page Title="Bill of Material" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bomhome.aspx.cs" Inherits="administrator.bomhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
<script type="text/javascript">
    var popup, tin, lead, dcr;
    function popupnew() {
        popup = window.open("bom.aspx", "popup", "width=1000,height=500");
        popup.focus();
        return false;
    }
    function popupedit() {
        popup = window.open("bom.aspx", "popup", "width=1000,height=500");
        popup.focus();
        return false;
    }
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
<table>
<tr>
<td>
    <asp:Button ID="popupnew" runat="server" Width="80px" Height="30px" 
        align="center" Text="NEW" onclick="popupnew_Click" />
</td>
<td>
<asp:Button ID="popupview" runat="server" Width="80px" Height="30px" 
        align="center" Text="VIEW" onclick="popupview_Click" />
</td>
<td>
    <asp:Button ID="popuprefresh" runat="server" Width="80px" Height="30px" 
        align="center" Text="REFRESH" onclick="popuprefresh_Click"  />
</td>
<td>
    <asp:Button ID="popupdelete" runat="server" Width="80px" Height="30px" align="center" Text="DELETE" />
</td>
<td>
    <asp:Button ID="Button4" runat="server" Width="80px" Height="30px" align="center" Text="EXPORT" />
</td>
<td>
    <asp:Button ID="Button1" runat="server" Width="80px" Height="30px" align="center" Text="CLOSE" />
</td>
</tr>
</table>
</div>
<div class="gridview">
    <asp:GridView ID="GridView1" Width="100%" HeaderStyle-BackColor="Gray"
        HeaderStyle-ForeColor="White" OnRowDataBound="OnRowDataBound" 
        runat="server" onselectedindexchanged="GridView1_SelectedIndexChanged"   >
    
    </asp:GridView>
</div>
</asp:Content>
