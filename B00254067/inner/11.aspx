<%@ Page Title="" Language="C#" MasterPageFile="~/masters/Inner.master" AutoEventWireup="true" CodeFile="11.aspx.cs" Inherits="locations_11" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
    <div class="center-align-outer">
        <div class="center-align-inner">
            <h1>
                <asp:Label ID="txt_pageTitle" runat="server" Text=""></asp:Label></h1>
            <p>
                <asp:Label ID="txt_description" runat="server" Text="Label"></asp:Label>
            </p>
            <div id="canPass" runat ="server" Visible="false">
                <p>Your outdoor abilities and experience allow you to traverse an easy path over the top of the debris.<br />
                    <asp:Button ID="pass" runat="server" Text="Bypass the Debris" />
                </p>
            </div>
            <div id="goInto" runat="server">
                <p>
                    Travelling under the debris will be dangerous and there are many chances to get lost.<br />
                    <asp:Button ID="go" runat="server" Text="Go Into the debris" OnClick="go_Click" Visible="false"/>
                </p>
            </div>
        </div>
    </div>
</asp:Content>

