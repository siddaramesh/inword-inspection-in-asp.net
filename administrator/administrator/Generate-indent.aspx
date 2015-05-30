<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Generate-indent.aspx.cs" Inherits="administrator.Generate_indent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
<fieldset>
<legend>Generate Indent</legend>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="Meterial Indent Number:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label2" runat="server" Text="Indent Date:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label3" runat="server" Text="Doc.Type:"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem Text="Open indent" />
    <asp:ListItem Text="Againest sales order" />
    <asp:ListItem Text="Againest MAO" />
    </asp:DropDownList>
</td>
<td>
    <asp:Label ID="Label4" runat="server" Text="Doc.No:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label5" runat="server" Text="Department:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label6" runat="server" Text="Requested By:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label7" runat="server" Text="Approved By:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Label ID="Label8" runat="server" Text="Remarks:"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox7" runat="server" TextMode="MultiLine"></asp:TextBox>
</td>
</tr>
</table>
    <asp:GridView ID="GridView1" runat="server">
    <Columns>
    <asp:TemplateField HeaderText="Item Code" />
    <asp:TemplateField HeaderText="Item Name" />
    <asp:TemplateField HeaderText="Unit" />
    <asp:TemplateField HeaderText="S.Unit" />
    <asp:TemplateField HeaderText="Stock In Hand" />
    <asp:TemplateField HeaderText="Req.qty" />
    <asp:TemplateField HeaderText="Req.S. Qty" />
    <asp:TemplateField HeaderText="Last Pur.Date" />
    <asp:TemplateField HeaderText="Last Vendor" />
    <asp:TemplateField HeaderText="Last Cons Date" />
    <asp:TemplateField HeaderText="Remark" />
    <asp:TemplateField HeaderText="Priority" />
    </Columns>
    </asp:GridView>
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
