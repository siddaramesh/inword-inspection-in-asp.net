<%@ Page Title="Delivery Challan" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="deliverychallan.aspx.cs" Inherits="administrator.deliverychallan" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<asp:ScriptManager ID="scriptmanager1" runat="server"></asp:ScriptManager>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" Height="700px" InteractiveDeviceInfos="(Collection)" 
        WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="800px">
        <LocalReport ReportPath="deliverychallan.rdlc">
        </LocalReport>
    </rsweb:ReportViewer>
</asp:Content>
