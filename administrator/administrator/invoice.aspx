<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="invoice.aspx.cs" Inherits="administrator.invoice" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" InteractiveDeviceInfos="(Collection)" 
        WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Height="700px" 
        Width="100%" ExportContentDisposition="AlwaysInline">
        <LocalReport ReportPath="invoice.rdlc">
        </LocalReport>
    </rsweb:ReportViewer>
</asp:Content>
