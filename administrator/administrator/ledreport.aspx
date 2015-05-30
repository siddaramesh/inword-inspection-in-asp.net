<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ledreport.aspx.cs" Inherits="administrator.ledreport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <title>Led Reports</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <table>
    <tr>
    <td>
        <asp:Label CssClass="label" ID="Label1" runat="server" Text="PartNum:"></asp:Label>
    </td>
    <td>
     <asp:TextBox CssClass="textbox"  ID="TextBox1" runat="server"></asp:TextBox>
    </td>
    <td>
    <asp:Button ID="Button1" runat="server" Text="Report" onclick="Button1_Click" />
    </td>
    </tr>
    </table>  
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Height="1096px" 
            Width="794px">
        </rsweb:ReportViewer>
    </div>
    </form>
</body>
</html>
