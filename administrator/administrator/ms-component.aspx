﻿<%@ Page Title="Component Master" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ms-component.aspx.cs" Inherits="administrator.ms_component" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<p>
    <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Default.aspx" ForeColor="Blue" Font-Size="15px" runat="server">Admin</asp:HyperLink><span style="color:Black; font-size:14px;">>>Electronic Components</span>
</p>
<div class="masterdetails">
  <fieldset class="master">
  <legend>Master Details</legend>
  <ul>
 <li>     <asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/userinfo.aspx" ID="user" runat="server">User Details</asp:HyperLink></li>
 <li>     <asp:HyperLink CssClass="font" ForeColor="Gray" NavigateUrl="~/supplier.aspx" ID="supplierid" runat="server">Supplier Details</asp:HyperLink></li>
 <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/partno.aspx" ID="partnoid" runat="server">PartNum Details</asp:HyperLink></li>
 <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/manufacture.aspx" ID="manufactures" runat="server">Manufactures</asp:HyperLink></li>
  <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/unitofmeasure.aspx" ID="uom" runat="server">Unit Of Measure</asp:HyperLink></li>  
 <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/poinput.aspx" ID="po" runat="server">PO Input Module</asp:HyperLink></li>  
  <li>     <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/modules.aspx" ID="modulename" runat="server">Modules</asp:HyperLink></li>  
      </ul>
      <asp:HyperLink ForeColor="Green" Font-Bold="true" CssClass="font" ID="HyperLink1" runat="server">MODULE MASTERS</asp:HyperLink>
      <ul>
  <li>    <asp:HyperLink ForeColor="Black" CssClass="font" ID="mscomponent" runat="server">Electronic Components</asp:HyperLink></li>
  <li>    <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-transformer.aspx" ID="mstransformer" runat="server">Transformer</asp:HyperLink></li>
  <li>    <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-inductor.aspx" ID="msinductor" runat="server">Inductor</asp:HyperLink></li>
  <li>    <asp:HyperLink ForeColor="Gray" CssClass="font" NavigateUrl="~/ms-barepcb.aspx" ID="msbarepcb" runat="server">BARE PCB</asp:HyperLink></li>
      </ul>
  </fieldset>
  </div> 
  <div class="description">
  <fieldset class="borderradius">
  <legend>Component Masters</legend>
  <table>
  <tr>
  <td>
      <asp:Label CssClass="label" ID="Label1" runat="server" Text="Recieved Qty Counted:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox1" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" Width="70px" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label8" runat="server" Text="%"></asp:Label>
  </td>
  <td>
  <asp:Label CssClass="label" ID="Label2" runat="server" Text="Part no/mark verification:"></asp:Label>
  </td>
  <td>
  <asp:TextBox CssClass="textbox" ID="TextBox2" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" Width="70px" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label9" runat="server" Text="%"></asp:Label>
  </td>
  <td>
  <asp:Label CssClass="label" ID="Label3" runat="server" Text="Physical Damages:"></asp:Label>
  </td>
  <td>
  <asp:TextBox CssClass="textbox" ID="TextBox3" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" Width="70px" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label10" runat="server" Text="%"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
  <asp:Label CssClass="label" ID="Label4" runat="server" Text="Lead Solderability:"></asp:Label>
  </td>
  <td>
  <asp:TextBox CssClass="textbox" ID="TextBox4" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" Width="70px" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label11" runat="server" Text="%"></asp:Label>
  </td>
  <td>
  <asp:Label CssClass="label" ID="Label5" runat="server" Text="Value Checking LCR Meter(when required):"></asp:Label>
  </td>
  <td>
  <asp:TextBox CssClass="textbox" ID="TextBox5" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" Width="70px" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label12" runat="server" Text="%"></asp:Label>
  </td>
  <td>
  <asp:Label CssClass="label" ID="Label6" runat="server" Text="LED bin verification:"></asp:Label>
  </td>
  <td>
  <asp:TextBox CssClass="textbox" ID="TextBox6" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" Width="70px" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label13" runat="server" Text="%"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
  <asp:Label CssClass="label" ID="Label7" runat="server" Text="Package Description verification:"></asp:Label>
  </td>
  <td>
  <asp:TextBox CssClass="textbox" ID="TextBox7" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" Width="70px" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label14" runat="server" Text="%"></asp:Label>
  </td>
  </tr>
  <tr>
  <td></td><td></td><td></td><td></td><td></td>
  <td>
      <asp:Button ID="Button3" CssClass="addbutton" runat="server" Text="Show" 
          onclick="Button3_Click" />
  </td>
  <td>
  <asp:Button ID="Button1" CssClass="addbutton right" runat="server" Text="Save" 
          onclick="Button1_Click" />
  </td>
  <td>
      <asp:Button ID="Button2" CssClass="addbutton" runat="server" Text="Modify" />
  </td>
  </tr>
  </table>
  </fieldset>
  <p>
  <asp:CompareValidator ID="Validator" runat="server" ControlToValidate="TextBox1"  Operator="DataTypeCheck" Type="Double" ErrorMessage="TextBox1 Value Must be Number" ></asp:CompareValidator>
  </p>
  <p>
  <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox2" Operator="DataTypeCheck" Type="Double" ErrorMessage="TextBox2 Value Must be Number" ></asp:CompareValidator>
  </p>
  <p>
  <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TextBox3" Operator="DataTypeCheck" Type="Double" ErrorMessage="TextBox3 Value Must be Number" ></asp:CompareValidator>
  </p>
  <p>
  <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="TextBox4" Operator="DataTypeCheck" Type="Double" ErrorMessage="TextBox4 Value Must be Number" ></asp:CompareValidator>
  </p>
  <p>
  <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="TextBox5" Operator="DataTypeCheck" Type="Double" ErrorMessage="TextBox5 Value Must be Number" ></asp:CompareValidator>
  </p>
  <p>
  <asp:CompareValidator ID="CompareValidator5" runat="server" ControlToValidate="TextBox6" Operator="DataTypeCheck" Type="Double" ErrorMessage="TextBox6 Value Must be Number" ></asp:CompareValidator>
  </p>
  <p>
  <asp:CompareValidator ID="CompareValidator6" runat="server" ControlToValidate="TextBox7" Operator="DataTypeCheck" Type="Double" ErrorMessage="TextBox7 Value Must be Number" ></asp:CompareValidator>
  </p>
  <p>
      <asp:Label ID="Label15" runat="server" Text=""></asp:Label>
  </p>
  </div>
</asp:Content>
