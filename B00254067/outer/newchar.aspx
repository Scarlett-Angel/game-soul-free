<%@ Page Title="" Language="C#" MasterPageFile="~/masters/newchar.master" AutoEventWireup="true" CodeFile="newchar.aspx.cs" Inherits="outer_newchar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <div>
    <h1>Create a New Character</h1>
        <table>
            
            <tr>
                <td colspan ="2">
                   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowSorting="True" CellPadding="10" CellSpacing="10" DataKeyNames="id">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" Visible="False" />
                            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                            <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                            <asp:BoundField DataField="aligment" HeaderText="aligment" SortExpression="aligment" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [id], [name], [description], [aligment] FROM [oldLife] ORDER BY [name]"></asp:SqlDataSource></td>
            </tr>
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

