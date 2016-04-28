<%@ Page Title="" Language="C#" MasterPageFile="~/masters/newchar.master" AutoEventWireup="true" CodeFile="newchar.aspx.cs" Inherits="outer_newchar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
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
                    <strong>Upload a character image</strong>
                </td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
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
        <asp:Label ID="Label1" runat="server"></asp:Label>
</asp:Content>

