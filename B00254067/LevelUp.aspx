<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LevelUp.aspx.cs" Inherits="LevelUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        td {padding: 0px 15px 0px 15px; margin: 0px 5px 0px 5px; border-left:thin; border-right:thin; border-color: black;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="tier1" runat="server">
        <center>
            <h1>
                Tier 1 Skills</h1>
            <h3>
                <asp:Label ID="lbl_tier1warning" runat="server" Text="please select a skill" ForeColor="Red" Visible="False"></asp:Label></h3>
     <table>
            <tr>
                <td><center><strong>MIND</strong></center></td>
                <td><center><strong>WISDOM</strong></center></td>
                <td><center><strong>SKILL</strong></center></td>
                <td><center><strong>PASSION</strong></center></td>
            </tr>
            <tr>
                    <td><center><asp:RadioButton ID="mind" runat="server" GroupName="tier1skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="wisdom" runat="server" GroupName="tier1skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="skill" runat="server" GroupName="tier1skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="passion" runat="server" GroupName="tier1skills"></asp:RadioButton></center></td>
            </tr>
            <tr>
                <td><center><asp:Label ID="lbl_mind" runat="server"></asp:Label></center></td>
                <td><center><asp:Label ID="lbl_wisdom" runat="server" ></asp:Label></center></td>
                <td><center><asp:Label ID="lbl_skill" runat="server" ></asp:Label></center></td>
                <td><center><asp:Label ID="lbl_passion" runat="server"></asp:Label></center></td>
            </tr>
        </table>
        </center>
    </div>
        <div id="tier2"  runat="server">
        <center>
            <h1>Tier 2 Skills</h1>
            <h3>
                <asp:Label ID="lbl_tier2warning" runat="server" Text="please select a skill" ForeColor="Red" Visible="False"></asp:Label></h3>
            <table>
                <tr>
                    <td><center><strong>MEMORY</strong></center></td>
                    <td><center><strong>CREATIVITY</strong></center></td>
                    <td><center><strong>OBSERVE</strong></center></td>
                    <td><center><strong>STUDY</strong></center></td>
                    <td><center><strong>PRACTICE</strong></center></td>
                    <td><center><strong>TALENT</strong></center></td>
                    <td><center><strong>COURAGE</strong></center></td>
                    <td><center><strong>POWER</strong></center></td>
                </tr>
                <tr>
                    <td><center><asp:RadioButton ID="memory" runat="server" GroupName="tier2skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="creativity" runat="server" GroupName="tier2skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="observe" runat="server" GroupName="tier2skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="study" runat="server" GroupName="tier2skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="practice" runat="server" GroupName="tier2skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="talent" runat="server" GroupName="tier2skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="courage" runat="server" GroupName="tier2skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="power" runat="server" GroupName="tier2skills"></asp:RadioButton></center></td>
                </tr>
                <tr>
                    <td><center><asp:Label ID="lbl_memory" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_creativity" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_observe" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_study" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_practice" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_talent" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_courage" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_power" runat="server"></asp:Label></center></td>
                </tr>
               
            </table>
             </center>
    </div>
    </div>
        <div id="tier3"  runat="server">
        <center>
            <h1>Tier 3 Skills</h1>
            <h3>
                <asp:Label ID="lbl_tier3warning" runat="server" Text="please select a skill" ForeColor="Red" Visible="False"></asp:Label></h3>
            <table>
                <tr>
                    <td><center><strong>REMEMBER</strong></center></td>
                    <td><center><strong>VISUALISE</strong></center></td>
                    <td><center><strong>NEW IDEA</strong></center></td>
                    <td><center><strong>ANALYSE</strong></center></td>
                    <td><center><strong>UNDERSTAND</strong></center></td>
                    <td><center><strong>GENERAL KNOWLEDGE</strong></center></td>
                    </tr>
                 <tr>
                    <td><center><asp:RadioButton ID="remember" runat="server" GroupName="tier3skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="visualise" runat="server" GroupName="tier3skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="newIdea" runat="server" GroupName="tier3skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="analyse" runat="server" GroupName="tier3skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="understand" runat="server" GroupName="tier3skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="generalKnowledge" runat="server" GroupName="tier3skills"></asp:RadioButton></center></td>
                     </tr>
                <tr>
                    <td><center><asp:Label ID="lbl_remember" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_visualise" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_newIdea" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_analyse" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_understand" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_generalKnowledge" runat="server"></asp:Label></center></td>
                </tr>
                <tr>
                    <td><center><strong>CONSISTENT RESULTS</strong></center></td>
                    <td><center><strong>PERFORM</strong></center></td>
                    <td><center><strong>RANDOM LUCK</strong></center></td>
                    <td><center><strong>OVERTHROW</strong></center></td>
                    <td><center><strong>MEDIATE</strong></center></td>
                    <td><center><strong>DOMINATE</strong></center></td>
                </tr>
               <tr>
                    <td><center><asp:RadioButton ID="consistentResults" runat="server" GroupName="tier3skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="perform" runat="server" GroupName="tier3skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="randomLuck" runat="server" GroupName="tier3skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="overthrow" runat="server" GroupName="tier3skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="mediate" runat="server" GroupName="tier3skills"></asp:RadioButton></center></td>
                    <td><center><asp:RadioButton ID="dominate" runat="server" GroupName="tier3skills"></asp:RadioButton></center></td>
                </tr>
                <tr>
                    <td><center><asp:Label ID="lbl_consistentResults" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_perform" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_randomLuck" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_overthrow" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_mediate" runat="server"></asp:Label></center></td>
                    <td><center><asp:Label ID="lbl_dominate" runat="server"></asp:Label></center></td>
                </tr>
            </table>
             </center>
    </div>
             
    </div>
        <div id="tier4"  runat="server">
        <center>
            <h1>Tier 4 Skills</h1>
            <h3>
                <asp:Label ID="lbl_tier4warning" runat="server" Text="please select a skill" ForeColor="Red" Visible="False"></asp:Label></h3>
             <table>
                <tr>
                    <td><center><strong>GUT FEELING</strong></center></td>
                    <td><center><strong>EDICTIC MEMORY</strong></center></td>
                    <td><center><strong>INVENT</strong></center></td>
                    <td><center><strong>REFINE IDEA</strong></center></td>
                    <td><center><strong>SEE PATTERN</strong></center></td>
                    <td><center><strong>MANIPULATE</strong></center></td>
                    <td><center><strong>EXPLAIN</strong></center></td>
                    <td><center><strong>OBSCURE FACT</strong></center></td>
                   
             </tr>
                 <tr>
                     <td><center><asp:RadioButton ID="gutFeeling" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="edicticMemory" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="invent" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="refineIdea" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="seePattern" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="manipulate" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="explain" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="obscureFact" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                    
                 </tr>
                 <tr>
                     <td><center><asp:Label ID="lbl_gutFeeling" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_edicticMemory" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_invent" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_refineIdea" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_seePattern" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_manipulate" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_explain" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_obscureFact" runat="server"></asp:Label></center></td>
                 </tr>
                 <tr>
                      <td><center><strong>EXPERTISE</strong></center></td>
                    <td><center><strong>IMPRESS</strong></center></td>
                    <td><center><strong>BLUFF</strong></center></td>
                    <td><center><strong>CRISES AVERTED</strong></center></td>
                    <td><center><strong>REVOLUTION</strong></center></td>
                    <td><center><strong>INSPIRE</strong></center></td>
                    <td><center><strong>SWINDLE</strong></center></td>
                    <td><center><strong>FEARED</strong></center></td>
                 </tr>
                 <tr>
                      <td><center><asp:RadioButton ID="expertise" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="impress" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="bluff" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="crisisAverted" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="revolution" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="inspire" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="swindle" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                     <td><center><asp:RadioButton ID="feared" runat="server" GroupName="tier4skills"></asp:RadioButton></center></td>
                 </tr>
                 <tr>
                     <td><center><asp:Label ID="lbl_expertise" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_impress" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_bluff" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_crisisAverted" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_revolution" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_inspire" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_swindle" runat="server"></asp:Label></center></td>
                     <td><center><asp:Label ID="lbl_feared" runat="server"></asp:Label></center></td>
                 </tr>
                 </table>
                  </center>
    </div>
    
    <center>
        <asp:Button ID="submit" runat="server" Text="Assign Skill Points" OnClick="submit_Click" />
        </center>
    
    </form>
</body>
</html>
