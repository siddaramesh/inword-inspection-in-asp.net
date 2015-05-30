<%@ Page Language="C#" Title="Lead Length" AutoEventWireup="true" CodeBehind="lead.aspx.cs" Inherits="administrator.lead" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function leadreturn() {
            try {
                window.close();
            }
            catch (Error) {
                alert("error" + Error.Message);
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1">
       <fieldset class=" radiusright">
  <legend>Lead Length</legend>
  <table>
  <tr>
  <td>
      <asp:Label ID="Label21" runat="server" Text="Select All:"></asp:Label>
  </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList21" AutoPostBack="true" 
          runat="server" 
          onselectedindexchanged="DropDownList21_SelectedIndexChanged">
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>
  </table>
  <table>
  <tr>
  <td>
      <asp:Label ID="sno" Font-Bold="true" runat="server" Text="S.NO"></asp:Label>
  </td>
  <td>
      <asp:Label ID="soldering" Font-Bold="true" runat="server" Text="Lead Length"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label1" runat="server" Text="1"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList1" runat="server">
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label2" runat="server" Text="2"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList2" runat="server">
     <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label3" runat="server" Text="3"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList3" runat="server">
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label4" runat="server" Text="4"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList4" runat="server">
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label5" runat="server" Text="5"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList5" runat="server">
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label6" runat="server" Text="6"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList6" runat="server">
     <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label7" runat="server" Text="7"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList7" runat="server">
     <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label8" runat="server" Text="8"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList8" runat="server">
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label9" runat="server" Text="9"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList9" runat="server">
     <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label10" runat="server" Text="10"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList10" runat="server">
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label11" runat="server" Text="11"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList11" runat="server">
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label12" runat="server" Text="12"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList12" runat="server">
     <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label13" runat="server" Text="13"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList13" runat="server">
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label14" runat="server" Text="14"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList14" runat="server">
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label15" runat="server" Text="15"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList15" runat="server">
     <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label16" runat="server" Text="16"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList16" runat="server">
     <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label17" runat="server" Text="17"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList17" runat="server">
     <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label18" runat="server" Text="18"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList18" runat="server">
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label19" runat="server" Text="19"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList19" runat="server">
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>

<tr>
  <td>
      <asp:Label ID="Label20" runat="server" Text="20"></asp:Label>
      </td>
  <td>
      <asp:DropDownList CssClass="textbox" ID="DropDownList20" runat="server">
      <asp:ListItem Enabled="true" Text="Yes" Value="1" />
      <asp:ListItem Enabled="true" Text="No" Value="2" />
      </asp:DropDownList>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label22" runat="server" Text="Total Yes:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label23" runat="server" Text="Value"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label24" runat="server" Text="Total No:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label25" runat="server" Text="Value"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
  <asp:Button CssClass="addbutton" Width="80px" Height="30px" ID="Button1" 
                  runat="server" Text="Result" onclick="Button1_Click" />
  </td>
  <td>
     <asp:Button CssClass="addbutton" Width="80px" Height="30px" ID="Button2" 
                  runat="server" Text="Return" onclick="Button2_Click" /> 
  </td>
  </tr>
  </table>
  </fieldset>
    </div>
    </form>
</body>
</html>
