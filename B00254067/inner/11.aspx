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
                    <asp:Button ID="pass" runat="server" Text="Bypass the Debris and travel to the next desination" />
                </p>
            </div>
            <div id="goInto" runat="server" Visible="false">
                <p>
                    Travelling under the debris will be dangerous and there are many chances to get lost.<br />
                    <asp:Button ID="go" runat="server" Text="Go Into the debris" OnClick="go_Click" />
                </p>
            </div>
            <div id="lost" runat="server" Visible="false">
                <p>
                    You are lost in the debris. Keep trying to find a way out.<br />
                    <asp:Button ID="lostBtn" runat="server" Text="Keep Searching for a way out"  OnClick="lostBtn_Click" />
                </p>
            </div>
            <div id="feat" runat="server" Visible="false">
                <p>
                    As you are close to escaping the ceiling collapses on top of you. You lie there in the dust and dark and something enters your mind.<br />
                    I am not dying in here!<br />
                    You fight with all of your might to push and squeeze your way out with all of your strength. When you make it out to the other side you make the the promise never to be weak and just allow yourself to die.<br />
                    <strong>You gained 1 strength point</strong><br />
                    <asp:Button ID="Button4" runat="server" Text="Travel to the Next Desination" OnClick="Button4_Click" />
                </p>
            </div>
            <div id="accidentWin" runat="server" Visible="false">
                <p>
                    Travelling through the dark you hear the roof above you begin to shake. Using your <strong>crafty ability</strong> you manage to quickly move to a save area. As the dust clears you can see a way out of the debris.<br />
                    <asp:Button ID="Button3" runat="server" Text="Travel to the Next Desination" OnClick="Button3_Click" />
                </p>
            </div>
            <div id="accidentLose" runat="server" Visible="false">
                <p>
                    Travelling through the dark you hear the roof above you begin to shake. You try to be <strong>crafty</strong> and predict where the roof will fall but you are hit on the head as you make it out of the danger and you manage to quickly move to a save area. As the dust clears you can see a way out of the debris.<br />
                    <strong>You lost 1 health</strong><br />
                    <asp:Button ID="Button2" runat="server" Text="Travel to the Next Desination" OnClick="Button2_Click" />
                </p>
            </div>
            <div id="escape" runat="server" visible="false">
                <p>
                    You manage to escape the debris.<br />
                    <asp:Button ID="Button1" runat="server" Text="Travel to the Next Desination" OnClick="Button1_Click" />
                </p>
            </div>
        </div>
    </div>
</asp:Content>

