<%@ Page Title="" Language="C#" MasterPageFile="~/masters/Inner.master" AutoEventWireup="true" CodeFile="character.aspx.cs" Inherits="inner_character" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <div>
    <h1>Update Character Info</h1>
        <table>
            <tr>
                <td><strong>Character Name</strong></td>
                <td>
                    <asp:TextBox ID="txt_name" runat="server"></asp:TextBox><strong>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Change Character Name" />
                    </strong></td>
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
                    <asp:Button ID="btn_submit" runat="server" Text="Upload new Character Picture" OnClick="btn_submit_Click" />
                </td>
            </tr>
        </table>
    </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
</asp:Content>

