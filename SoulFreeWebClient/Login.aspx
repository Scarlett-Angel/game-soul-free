<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SoulFree</title>
    <style type="text/css">
        .auto-style1 {
            height: 16px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td><strong>Username</strong></td>
            <td><asp:TextBox ID="txt_loginUsername" runat="server" CssClass="txt_login"></asp:TextBox></td>
        </tr>
        <tr>
            <td><strong>Password</strong></td>
            <td>
                <asp:TextBox ID="txt_loginPassword" runat="server" CssClass="txt_login"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>

                <asp:Button ID="btn_login" runat="server" Text="Login"  OnClick="btn_login_Click" style="height: 29px" />

            </td>
        </tr>
         <tr>
            <td class="auto-style1">
                Need an account?&nbsp;&nbsp;
            </td>
            <td class="auto-style1">

               <center> <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Register.aspx">Register</asp:LinkButton></center>

            </td>
        </tr>
    </table>
        <asp:Button ID="santize" runat="server" Text="santise database" OnClick="santize_Click" />
    
    
    </div>
        <p>
            <asp:Label ID="txt_notifcation" runat="server" ForeColor="Red"></asp:Label>
        </p>
    </form>
</body>
</html>
