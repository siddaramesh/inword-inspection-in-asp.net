<%@ Page Language="C#" Title="Primary Inductance" AutoEventWireup="true" CodeBehind="primary.aspx.cs" Inherits="administrator.primary" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function getvalue() {
          
            try {

              //  return true;
                window.close();
             /*   if (window.opener != null && window.opener.closed) {
                    var txtname = window.opener.document.getElementById('primary').value;
                    var txt=
                    txtname.value = document.getElementById('TextBox21').value;
                    alert(txtname); */
                }
            catch (Error) {
                alert("error:"+Error.Message);
            }
          
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1">
       <fieldset class=" radiusright">
  <legend>Primary Inductance</legend>
  <table>
  <tr>
  <td>
      <asp:Label ForeColor="Red" ID="Label87" runat="server" Text=""></asp:Label>
  </td>
  </tr>
  </table>
  <table>
  <tr>
  <td>
      <asp:Label Font-Bold="true" CssClass="center" ID="Label1" runat="server" Text="NUM"></asp:Label>
  </td>
  <td>
      <asp:Label Font-Bold="true" CssClass="center" ID="Label2" runat="server" Text="MIN"></asp:Label>
  </td>
  <td>
      <asp:Label Font-Bold="true" CssClass="center" ID="Label3" runat="server" Text="MAX"></asp:Label>
  </td>
  <td>
      <asp:Label Font-Bold="true" CssClass="center" ID="Label4" runat="server" Text="VALUE"></asp:Label>
  </td>
  <td>
      <asp:Label Font-Bold="true" CssClass="center" ID="Label5" runat="server" Text="RESULT"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label6" runat="server" Text="1"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label7" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label8" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox1" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label9" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label10" runat="server" Text="2"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label11" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label12" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox2" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label13" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label14" runat="server" Text="3"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label15" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label16" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox3" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"  runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label17" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label18" runat="server" Text="4"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label19" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label20" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox4" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label21" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label22" runat="server" Text="5"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label23" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label24" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox5" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label25" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label26" runat="server" Text="6"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label27" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label28" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox6" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label29" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label30" runat="server" Text="7"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label31" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label32" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox7" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label33" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label34" runat="server" Text="8"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label35" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label36" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox8" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"  runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label37" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label38" runat="server" Text="9"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label39" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label40" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox9" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label41" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label42" runat="server" Text="10"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label43" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label44" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox10" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"  runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label45" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label46" runat="server" Text="11"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label47" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label48" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox11" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"  runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label49" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label50" runat="server" Text="12"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label51" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label52" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox12" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"  runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label53" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label54" runat="server" Text="13"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label55" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label56" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox13" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"  runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label57" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label58" runat="server" Text="14"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label59" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label60" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox14" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"  runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label61" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label62" runat="server" Text="15"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label63" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label64" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox15" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"  runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label65" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label66" runat="server" Text="16"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label67" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label68" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox16" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"  runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label69" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label70" runat="server" Text="17"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label71" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label72" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox17" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"  runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label73" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label74" runat="server" Text="18"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label75" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label76" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox18" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"  runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label77" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label78" runat="server" Text="19"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label79" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label80" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox19" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }" runat="server" ></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label81" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td>
      <asp:Label ID="Label82" runat="server" Text="20"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label83" runat="server" Text="min"></asp:Label>
  </td>
  <td>
      <asp:Label ID="Label84" runat="server" Text="max"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox"  ID="TextBox20" Text="0"
      onFocus="if(this.value=='0')
      {
      this.value='';
      }"
      onBlur="if(this.value=='')
      {
      this.value='0';
      }"  runat="server"></asp:TextBox>
  </td>
  <td>
      <asp:Label ID="Label85" runat="server" Text="ok/morethan/lessthan"></asp:Label>
  </td>
  </tr>
  <tr>
  <td></td><td></td><td></td>
  <td>
      <asp:Label ID="Label92" runat="server" Text="OK Items:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label93" runat="server" Text="Label"></asp:Label>
  </td>
  </tr>
  <tr>
  <td></td><td></td><td></td>
  <td>
      <asp:Label ID="Label88" runat="server" Text="LESSTHAN MIN:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label89" runat="server" Text="Label"></asp:Label>
  </td>
  </tr>
  <tr>
  <td></td><td></td><td></td>
  <td>
      <asp:Label ID="Label90" runat="server" Text="MORETHAN MAX:"></asp:Label>
  </td>
  <td>
      <asp:Label ForeColor="Black" ID="Label91" runat="server" Text="Label"></asp:Label>
  </td>
  </tr>
  <tr>
  <td></td><td></td><td></td>
  <td>
      <asp:Label ID="Label86" runat="server" Text="Out of Range Items:"></asp:Label>
  </td>
  <td>
      <asp:TextBox CssClass="textbox" ID="TextBox21" runat="server"></asp:TextBox>
      
  </td>
  </tr>
  <tr>
  <td>
  </td>
  <td></td><td></td>
  <td>
     <asp:Button CssClass="addbutton" Width="80px" Height="30px" ID="Button1" 
          runat="server" Text="Result" onclick="Button1_Click" /></td>
          <td>
              <asp:Button CssClass="addbutton" Width="80px" Height="30px" ID="Button2" 
                  runat="server" Text="Send" 
                  onclick="Button2_Click1" />
          </td>
  </tr>
  </table>
  </fieldset>
    </div>
    </form>
</body>
</html>
