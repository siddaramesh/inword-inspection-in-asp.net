<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="administrator.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="accountInfo loginmiddle">
                <fieldset class="login">
                    <legend>Account Information</legend>
                    <p>
                        <asp:Label ID="username" runat="server" Text="Username:"></asp:Label><br />
                        <asp:TextBox ID="txtUserName" runat="server" CssClass="textEntry"></asp:TextBox>
                        <asp:RequiredFieldValidator ID ="rfvuserName" runat="server" ControlToValidate="txtUserName" Display="Dynamic" ErrorMessage="*" ToolTip="username is required">
    </asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label ID="password" runat="server" Text="Password:"></asp:Label><br />
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID ="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="*" ToolTip="username is required">
    </asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </p>
                    <p class="submitButton">
                    
                        <asp:Button ID="loginbutton" runat="server" Text="Log In" 
                            onclick="loginbutton_Click" />
                </p>
                </fieldset>
            </div>
    </form>
</body>
</html>
