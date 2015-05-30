﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="dispatch-return.aspx.cs" Inherits="administrator.dispatch_return" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
<fieldset>
<legend>Dispatch Return</legend>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="Doc. Type:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem Text="All " />
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label2" runat="server" Text="Invoice No:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label4" runat="server" Text="Date:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label3" runat="server" Text="Bill No:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label5" runat="server" Text="Bill Date:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox4" runat="server" TextMode="Date"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label6" runat="server" Text="Party Name:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label7" runat="server" Text="Mode Of Dispatch:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label8" runat="server" Text="Delivery:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label9" runat="server" Text="Validity:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label10" runat="server" Text="Shipment Address:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox9" runat="server" TextMode="MultiLine"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label11" runat="server" Text="Vehicle No:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label12" runat="server" Text="Frieght:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList2" runat="server">
    <asp:ListItem Text="TO PAID" />
    <asp:ListItem Text="PAID" />
    <asp:ListItem Text="NIL" />
    </asp:DropDownList>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label13" runat="server" Text="Payment:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList3" runat="server">
    <asp:ListItem Text="CASH" />
    <asp:ListItem Text="CREADIT" />
    <asp:ListItem Text="IMMEDIATE" />
    <asp:ListItem Text="LC" />
    <asp:ListItem Text="STOCK TRANSFER" />
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label14" runat="server" Text="Transporter:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label15" runat="server" Text="Quot. No:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label51" runat="server" Text="Quot. Date:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox52" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label16" runat="server" Text="Payment Terms:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label52" runat="server" Text="Date of issue"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox53" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label53" runat="server" Text="Time Of Issue"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox54" runat="server" TextMode="Time"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label54" runat="server" Text="Rem. Date"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox55" runat="server" TextMode="Date"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label55" runat="server" Text="Removal Time"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox56" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label56" runat="server" Text="RR No"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox57" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label57" runat="server" Text="RR Date"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox58" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
</td>
</tr>
</table>
 <asp:GridView ID="GridView1" runat="server" >
    <Columns>
    <asp:TemplateField HeaderText="S.O.P No" />
    <asp:TemplateField HeaderText="Item Code" />
<asp:TemplateField HeaderText="Item Name" />
<asp:TemplateField HeaderText="P. Unit" />
<asp:TemplateField HeaderText="S. Unit" />
<asp:TemplateField HeaderText="Store" />
<asp:TemplateField HeaderText="Stock In Hand" />
<asp:TemplateField HeaderText="Bal. Qty" />
<asp:TemplateField HeaderText="BILL. Qty" />
<asp:TemplateField HeaderText="S. Qty" />
<asp:TemplateField HeaderText="Rate" />
<asp:TemplateField HeaderText="Gross Amount" />
<asp:TemplateField HeaderText="Net Amount" />
<asp:TemplateField HeaderText="Remarks" />
    </Columns>
    </asp:GridView>
</fieldset>
<fieldset>
<legend>Charges</legend>
<table style="float:left;">
<tr>
<th>
</th>
<th>
    <asp:Label ID="Label17" runat="server" Text="Charge Name"></asp:Label>
</th>
<th>
    <asp:Label ID="Label18" runat="server" Text="%"></asp:Label>
</th>
<th>
    <asp:Label ID="Label19" runat="server" Text="Value"></asp:Label>
</th>
<th></th>
<th>
    <asp:Label ID="Label43" runat="server" Text="Charge Name"></asp:Label>
</th>
<th>
    <asp:Label ID="Label44" runat="server" Text="Type"></asp:Label>
</th>
<th>
    <asp:Label ID="Label45" runat="server" Text="Value"></asp:Label>
</th>
</tr>
<tr>
<td>
    <asp:Label ID="Label20" runat="server" Text="Discount"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox15" runat="server" Text="0.00"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label21" runat="server" Text="0.00"></asp:Label>
</td>
<td>
    <asp:Label ID="Label37" runat="server" Text="Freight"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox28" runat="server"></asp:TextBox> </td>
<td>
    <asp:DropDownList ID="DropDownList4" runat="server">
    <asp:ListItem Text="+" />
    <asp:ListItem Text="-" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox29" runat="server" Text="0.00"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label22" runat="server" Text="Excise duty"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox17" runat="server" Text="0.00"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label23" runat="server" Text="0.00"></asp:Label>
</td>
<td>
    <asp:Label ID="Label38" runat="server" Text="Cartage"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox30" runat="server"></asp:TextBox> </td>
<td>
    <asp:DropDownList ID="DropDownList5" runat="server">
    <asp:ListItem Text="+" />
    <asp:ListItem Text="-" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox31" runat="server" Text="0.00"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label24" runat="server" Text="CESS"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox19" runat="server" Text="0.00"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label25" runat="server" Text="0.00"></asp:Label>
</td>
<td>
    <asp:Label ID="Label39" runat="server" Text="Entry Tax"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox32" runat="server"></asp:TextBox> </td>
<td>
    <asp:DropDownList ID="DropDownList6" runat="server">
    <asp:ListItem Text="+" />
    <asp:ListItem Text="-" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox33" runat="server" Text="0.00"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label26" runat="server" Text="SHEC"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox21" runat="server" Text="0.00"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label27" runat="server" Text="0.00"></asp:Label>
</td>
<td>
    <asp:Label ID="Label40" runat="server" Text="Insurance"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox34" runat="server"></asp:TextBox> </td>
<td>
    <asp:DropDownList ID="DropDownList7" runat="server">
    <asp:ListItem Text="+" />
    <asp:ListItem Text="-" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox35" runat="server" Text="0.00"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label28" runat="server" Text="VAT/CST"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox23" runat="server" Text="0.00"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label29" runat="server" Text="0.00"></asp:Label>
</td>
<td>
    <asp:Label ID="Label41" runat="server" Text="Packing"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox36" runat="server"></asp:TextBox> </td>
<td>
    <asp:DropDownList ID="DropDownList8" runat="server">
    <asp:ListItem Text="+" />
    <asp:ListItem Text="-" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox37" runat="server" Text="0.00"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label30" runat="server" Text="Additional Tax"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox25" runat="server" Text="0.00"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label31" runat="server" Text="0.00"></asp:Label>
</td>
<td>
    <asp:Label ID="Label42" runat="server" Text="Octorio"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox38" runat="server"></asp:TextBox> </td>
<td>
    <asp:DropDownList ID="DropDownList9" runat="server">
    <asp:ListItem Text="+" />
    <asp:ListItem Text="-" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox39" runat="server" Text="0.00"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label32" runat="server" Text="Surcharge"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
</td>
<td>
    <asp:TextBox ID="TextBox27" runat="server" Text="0.00"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label33" runat="server" Text="0.00"></asp:Label>
</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Label ID="Label34" runat="server" Text="Oth. Chr 1"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox40" runat="server"></asp:TextBox> </td>
<td>
    <asp:DropDownList ID="DropDownList10" runat="server">
    <asp:ListItem Text="+" />
    <asp:ListItem Text="-" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox41" runat="server" Text="0.00"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label35" runat="server" Text="Oth. Chr 2"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox42" runat="server"></asp:TextBox> </td>
<td>
    <asp:DropDownList ID="DropDownList11" runat="server">
    <asp:ListItem Text="+" />
    <asp:ListItem Text="-" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox43" runat="server" Text="0.00"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label36" runat="server" Text="Oth. Chr 3"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox44" runat="server"></asp:TextBox> </td>
<td>
    <asp:DropDownList ID="DropDownList12" runat="server">
    <asp:ListItem Text="+" />
    <asp:ListItem Text="-" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox45" runat="server" Text="0.00"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label46" runat="server" Text="Oth. Chr 4"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox46" runat="server"></asp:TextBox> </td>
<td>
    <asp:DropDownList ID="DropDownList13" runat="server">
    <asp:ListItem Text="+" />
    <asp:ListItem Text="-" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox47" runat="server" Text="0.00"></asp:TextBox>
</td>
</tr>
<tr>
<th>
    <asp:Label ID="Label47" runat="server" Text="Round Off."></asp:Label>
</th>
<td>
<asp:DropDownList ID="DropDownList14" runat="server">
    <asp:ListItem Text="+" />
    <asp:ListItem Text="-" />
    </asp:DropDownList>
</td>
<td>
    <asp:TextBox ID="TextBox48" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label49" runat="server" Text="Gross Amt"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox50" runat="server" Text="0.00"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label48" runat="server" Text="Net Amount"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox49" runat="server" Text="0.00"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label50" runat="server" Text="Remark"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox51" runat="server"></asp:TextBox>
</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Button ID="Button1" runat="server" Text="Save" />
</td>
<td>
    <asp:Button ID="Button2" runat="server" Text="Cancel" />
</td>
</tr>
</table>
</fieldset>
</div>
</asp:Content>
