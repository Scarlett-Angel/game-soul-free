<%@ Page Title="" Language="C#" MasterPageFile="~/masters/Outer.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="outer_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
    <div class="center-align-outer">
        <div class="center-align-inner">
            <h2>Sign Up</h2>
            <table>
                <tr>
                    <td><strong>Username</strong></td>
                    <td>
                        <asp:TextBox ID="txt_userName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><strong>Email</strong></td>
                    <td>
                        <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><strong>Password</strong></td>
                    <td>
                        <asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>


            <asp:Label ID="lbl_notification" runat="server" ForeColor="Red"></asp:Label>
            <asp:Button ID="btn_" runat="server" OnClick="btn__Click" Text="Register" Width="80px" />
            <asp:Button ID="santize" runat="server" Text="santise database" OnClick="santize_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </div>
</asp:Content>

