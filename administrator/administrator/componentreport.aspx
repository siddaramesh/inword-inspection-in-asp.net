<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="componentreport.aspx.cs" Inherits="administrator.componentreport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body bgcolor="#191919">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
            CssClass="floatcenter" ShowFindControls="False" 
            ShowPageNavigationControls="False" ShowBackButton="False" 
            Font-Size="8pt" InteractiveDeviceInfos="(Collection)" 
            WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" 
            Height="29.7cm" Width="820px">
            <LocalReport ReportPath="Report2.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GetData" 
            TypeName="administrator.DataSet1TableAdapters.componentsTableAdapter">
        </asp:ObjectDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:dbconnection %>" 
            SelectCommand="SELECT * FROM [components]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
