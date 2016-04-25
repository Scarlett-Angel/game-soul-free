<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newCharacter.aspx.cs" Inherits="newCharacter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Create a New Character</h1>
        <table>
            <tr>
                <td><strong>Character Name</strong></td>
                <td>
                    <asp:TextBox ID="txt_name" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                  
                </td>
                <td>
                    <asp:Button ID="btn_submit" runat="server" Text="submit" OnClick="btn_submit_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
