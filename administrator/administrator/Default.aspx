<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="administrator._Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
<link rel="Stylesheet" href="Styles/menu.css" />
<!-- <link rel="stylesheet" href="http://code.jquery.com/ui/1.9.1/themes/base/jquery-ui.css" />  -->
<script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
<script type="text/javascript" src="http://code.jquery.com/ui/1.9.1/jquery-ui.js"></script>
<script type="text/javascript">
    $(function () {
        $("#accordion").accordion({
            heightStyle: "fill"
        });
    });
</script>

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<p>
<span class="black" style="color:Black; font-size:14px;">>>Admin</span>
</p>
 
  <div id="accordion-resizer">
  <div id="accordion">
  <h3 style="font-family:Lucida Sans Unicode; font-weight:bold;">HOME</h3>
  <div>
  <ul>
    <li><asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/userinfo.aspx" ID="user" runat="server">User Details</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/manufacture.aspx" ID="manufactures" runat="server">Manufactures</asp:HyperLink></li>
    <li><asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/supplierhome.aspx" ID="supplier" runat="server">Supplier Details</asp:HyperLink></li>
    <li><asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/partno.aspx" ID="partno"  runat="server">PartNum Details</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/unitofmeasurehome.aspx" ID="uom" runat="server">Unit Of Measure</asp:HyperLink></li>  
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/poinputhome.aspx" ID="po" runat="server">PO Input Module</asp:HyperLink></li>  
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/modules.aspx" ID="modulename" runat="server">Modules</asp:HyperLink></li>  
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/chargeshome.aspx" ID="ChargesMaster" runat="server">Charges Master</asp:HyperLink></li>  
      </ul>
  </div>
  <h3 style="font-family:Lucida Sans Unicode; font-weight:bold;">MODULE MASTER</h3>
  <div>
     <ul>
     <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/taskhome.aspx" ID="task" runat="server">Job Task Master</asp:HyperLink></li>
     <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/consumableshome.aspx" ID="consumable" runat="server">Consumables Master</asp:HyperLink></li>
        <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-component.aspx" ID="mscomponent" runat="server">Electronic Components</asp:HyperLink></li>
        <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-transformer.aspx" ID="mstransformer" runat="server">Transformer</asp:HyperLink></li>
        <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-inductor.aspx" ID="msinductor" runat="server">Inductor</asp:HyperLink></li>
        <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-barepcb.aspx" ID="msbarepcb" runat="server">BARE PCB</asp:HyperLink></li>
   </ul>
  </div>
  <h3 style="font-family:Lucida Sans Unicode; font-weight:bold;">MANUFACTURING MASTER</h3>
  <div>
  <ul>
  <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/productionprocesshome.aspx" ID="productionprocess" runat="server">Production Process</asp:HyperLink></li>
  <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/production-order-home.aspx" ID="productionorder" runat="server">Production Order</asp:HyperLink></li>
  <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/BOM.aspx" ID="Billofmaterial" runat="server">Bill Of Material</asp:HyperLink></li>
  </ul>
  </div>
  <h3 style="font-family:Lucida Sans Unicode; font-weight:bold;">VENDOR ORDER PROCESS</h3>
  <div>
  <ul>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/Generate-indent.aspx" ID="generateindent" runat="server">Generate Indent</asp:HyperLink></li>
      <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/Purchase-order.aspx" ID="Purchaseorder" runat="server">Purchase Order</asp:HyperLink></li>
      <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/Material-reciept-note.aspx" ID="Materialrecieptnote" runat="server">Material Receipt Note</asp:HyperLink></li>
      <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/Purchase-Return.aspx" ID="PurchaseReturn" runat="server">Purchase Return</asp:HyperLink></li>
      <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/Purchase-ordershort-close.aspx" ID="purchaseordershortclose" runat="server">Purchase Order Short Close</asp:HyperLink></li>
  </ul>
  </div>
  <h3 style="font-family:Lucida Sans Unicode; font-weight:bold;">CUSTOMER ORDER PROCESS</h3>
  <div>
  <ul>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/Lead-Generate.aspx" ID="Leadgenerate" runat="server">Lead Generate</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/sales-order.aspx" ID="salesorder" runat="server">Sales Order</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/Dispatch-note.aspx" ID="DispatchNote" runat="server">Dispatch Note</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/dispatch-return.aspx" ID="DispatchReturn" runat="server">Dispatch Return</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/sales-ordershort-close.aspx" ID="salesordershortclose" runat="server">Sales Order Short Close</asp:HyperLink></li>
  </ul>
  </div>
  <h3 style="font-family:Lucida Sans Unicode; font-weight:bold;">IC TRANSACTION</h3>
  <div>
  <ul>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/adjustment.aspx" ID="icadjustment" runat="server">IC Adjustment</asp:HyperLink></li>
  </ul>
  </div>
  <h3 style="font-family:Lucida Sans Unicode; font-weight:bold;">JOB WORK VENDOR PROCESS</h3>
  <div>
  <ul>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/RGP-Outgoing.aspx" ID="rgpoutgoing" runat="server">RGP Outgoing</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/RGP-Incoming.aspx" ID="rgpincoming" runat="server">RGP Incoming</asp:HyperLink></li>
  </ul>
  </div>
  <h3 style="font-family:Lucida Sans Unicode; font-weight:bold;">JOB WORK CUSTOMER PROCESS</h3>
  <div>
  <ul>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/job-order-process.aspx" ID="joborderprocess" runat="server">Job Order Process</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/IncomingMaterialRecievedByCustomer.aspx" ID="IMRC" runat="server">Incoming Material Recieved By Customer</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/JobWorkDispatch.aspx" ID="jobworkdispatch" runat="server">Job Work Dispatch</asp:HyperLink></li>
  </ul>
  </div>
  <h3 style="font-family:Lucida Sans Unicode; font-weight:bold;">MANUFACTURING PROCESS</h3>
  <div>
  <ul>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/MaterialRequirementPlanning.aspx" ID="Materialrequirementplanning" runat="server">Material Requirement Planning</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ManufacturingAdviceOrder.aspx" ID="manufacturingadviceorder" runat="server">Manufacturing Advice Order</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/JobRouteCard.aspx" ID="jobcard" runat="server">Job Route Card</asp:HyperLink></li>
  </ul>
  </div>
  <h3 style="font-family:Lucida Sans Unicode; font-weight:bold;">INVENTORY CONTROL</h3>
  <div>
  <ul>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/LocationWiseStockTransfer.aspx" ID="locationwisestocktransfer" runat="server">Location Wise Stock Transfer</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/PhysicalStockAdjestment.aspx" ID="Physicalstockadjestment" runat="server">Physical Stock Adjestment</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/IssueSlipMaterial.aspx" ID="issueslipmaterial" runat="server">Issue Slip Material</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ReturnFromProductionUnit.aspx" ID="returnfromproductionunit" runat="server">Return From Production Unit</asp:HyperLink></li>
    <li><asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/FinishedMaterialRecieve.aspx" ID="finishedmaterialreceive" runat="server">Finished Material Receive</asp:HyperLink></li>
  </ul>
  </div>
  <h3 style="font-family:Lucida Sans Unicode; font-weight:bold;">MODULE REPORTS</h3>
  <div>
    <ul>
     <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/componentreport.aspx" ID="reportcomponent" runat="server">Electronic Components</asp:HyperLink></li>
     <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ledreport.aspx" ID="reportled" runat="server">Led</asp:HyperLink></li>
     <li> <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/inductorreport.aspx" ID="reportinductor" runat="server">Inductor</asp:HyperLink></li>
 
   </ul>
  </div>
  </div>
  </div>

</asp:Content>
