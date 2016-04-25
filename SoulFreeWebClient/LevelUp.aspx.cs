using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LevelUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        WebServer.IsoulfreeClient servercon = new WebServer.IsoulfreeClient();
        string id = (string)(Session["userId"]);
        int charlevel = servercon.getCharLevel(id);
        lbl_mind.Text = servercon.getSkillLevel(id, "1");
        lbl_wisdom.Text = servercon.getSkillLevel(id, "2");
        lbl_skill.Text = servercon.getSkillLevel(id, "3");
        lbl_passion.Text = servercon.getSkillLevel(id, "4");
        int levelCheck = charlevel % 2;
        if (levelCheck != 0)
        {
            tier2.Visible = false;

        }
        else
        {
            lbl_memory.Text = servercon.getSkillLevel(id, "5");
            lbl_creativity.Text = servercon.getSkillLevel(id, "6");
            lbl_observe.Text = servercon.getSkillLevel(id, "7");
            lbl_study.Text = servercon.getSkillLevel(id, "8");
            lbl_practice.Text = servercon.getSkillLevel(id, "9");
            lbl_talent.Text = servercon.getSkillLevel(id, "10");
            lbl_courage.Text = servercon.getSkillLevel(id, "11");
            lbl_power.Text = servercon.getSkillLevel(id, "12");
        }
        levelCheck = charlevel % 3;
        if (levelCheck != 0)
        {
            tier3.Visible = false;

        }
        else
        {
            lbl_remember.Text = servercon.getSkillLevel(id, "13");
            lbl_visualise.Text = servercon.getSkillLevel(id, "14");
            lbl_newIdea.Text = servercon.getSkillLevel(id, "15");
            lbl_analyse.Text = servercon.getSkillLevel(id, "16");
            lbl_understand.Text = servercon.getSkillLevel(id, "17");
            lbl_generalKnowledge.Text = servercon.getSkillLevel(id, "18");
            lbl_consistentResults.Text = servercon.getSkillLevel(id, "19");
            lbl_perform.Text = servercon.getSkillLevel(id, "20");
            lbl_randomLuck.Text = servercon.getSkillLevel(id, "21");
            lbl_overthrow.Text = servercon.getSkillLevel(id, "22");
            lbl_mediate.Text = servercon.getSkillLevel(id, "23");
            lbl_dominate.Text = servercon.getSkillLevel(id, "24");
        }
        levelCheck = charlevel % 4;
        if (levelCheck != 0)
        {
            tier4.Visible = false;

        }
        else
        {
            lbl_gutFeeling.Text = servercon.getSkillLevel(id, "25");
            lbl_edicticMemory.Text = servercon.getSkillLevel(id, "26");
            lbl_invent.Text = servercon.getSkillLevel(id, "27");
            lbl_refineIdea.Text = servercon.getSkillLevel(id, "28");
            lbl_seePattern.Text = servercon.getSkillLevel(id, "29");
            lbl_manipulate.Text = servercon.getSkillLevel(id, "30");
            lbl_explain.Text = servercon.getSkillLevel(id, "31");
            lbl_obscureFact.Text = servercon.getSkillLevel(id, "32");
            lbl_expertise.Text = servercon.getSkillLevel(id, "33");
            lbl_impress.Text = servercon.getSkillLevel(id, "34");
            lbl_bluff.Text = servercon.getSkillLevel(id, "35");
            lbl_crisisAverted.Text = servercon.getSkillLevel(id, "36");
            lbl_revolution.Text = servercon.getSkillLevel(id, "37");
            lbl_inspire.Text = servercon.getSkillLevel(id, "38");
            lbl_swindle.Text = servercon.getSkillLevel(id, "39");
            lbl_feared.Text = servercon.getSkillLevel(id, "40");
        }



    }

    protected void submit_Click(object sender, EventArgs e)
    {
        string id = (string)(Session["userId"]);
        WebServer.IsoulfreeClient servercon = new WebServer.IsoulfreeClient();
        bool tier1check = false;
        bool tier1block = false;
        bool tier2check = false;
        bool tier2block = false;
        bool tier3check = false;
        bool tier3block = false;
        bool tier4check = false;
        bool tier4block = false;

        if (mind.Checked == true || wisdom.Checked == true || skill.Checked == true || passion.Checked == true)
        {
            tier1check = true;
        }
        else
        {
            lbl_tier1warning.Visible = true;
            tier1block = true;
        }
        if (tier2.Visible == true)
        {
            if (memory.Checked == true || creativity.Checked == true || observe.Checked == true || study.Checked == true || practice.Checked == true || talent.Checked == true || courage.Checked == true || power.Checked == true)
            {
                tier2check = true;
            }
            else
            {
                lbl_tier2warning.Visible = true;
                tier2block = true;
            }

        }
        if (tier3.Visible == true)
        {
            if (remember.Checked == true || visualise.Checked == true || newIdea.Checked == true || analyse.Checked == true || understand.Checked == true || generalKnowledge.Checked == true || consistentResults.Checked == true || perform.Checked == true || randomLuck.Checked == true || overthrow.Checked == true || mediate.Checked == true || dominate.Checked == true)
            {
                tier3check = true;
            }
            else
            {
                lbl_tier3warning.Visible = true;
                tier3block = true;
            }


        }
        if (tier4.Visible == true)
        {
            if (gutFeeling.Checked == true || edicticMemory.Checked == true || invent.Checked == true || refineIdea.Checked == true || seePattern.Checked == true || manipulate.Checked == true || explain.Checked == true || obscureFact.Checked == true || expertise.Checked == true || impress.Checked == true || bluff.Checked == true || crisisAverted.Checked == true || revolution.Checked == true || inspire.Checked == true || swindle.Checked == true || feared.Checked == true)
            {
                tier4check = true;
            }
            else
            {
                lbl_tier4warning.Visible = true;
                tier4block = true;
            }
        }
        if (tier1check == true)
            {
                if (tier2block == true || tier3block == true || tier4block == true) { }
                else
                {
                    if (mind.Checked == true)
                    {
                        servercon.levelUpSkill(id, "1");
                    }
                    if (wisdom.Checked == true)
                    {
                        servercon.levelUpSkill(id, "2");
                    }
                    if (skill.Checked == true)
                    {
                        servercon.levelUpSkill(id, "3");
                    }
                    if (passion.Checked == true)
                    {
                        servercon.levelUpSkill(id, "4");
                    }
                }
                
            }
            if (tier2check == true)
            {
                if (tier1block == true || tier3block == true || tier4block == true) { }
                else
                {

                    if (memory.Checked == true)
                    {
                        servercon.levelUpSkill(id, "5");
                    }
                    if (creativity.Checked == true)
                    {
                        servercon.levelUpSkill(id, "6");
                    }
                    if (observe.Checked == true)
                    {
                        servercon.levelUpSkill(id, "7");
                    }
                    if (study.Checked == true)
                    {
                        servercon.levelUpSkill(id, "8");
                    }
                    if (practice.Checked == true)
                    {
                        servercon.levelUpSkill(id, "9");
                    }
                    if (talent.Checked == true)
                    {
                        servercon.levelUpSkill(id, "10");
                    }
                    if (courage.Checked == true)
                    {
                        servercon.levelUpSkill(id, "11");
                    }
                    if (power.Checked == true)
                    {
                        servercon.levelUpSkill(id, "12");
                    }
                }
            }
            if (tier3check == true)
            {
                if (tier1block == true || tier2block == true || tier4block == true) { }
                else
                {
                    if (remember.Checked == true)
                    {
                        servercon.levelUpSkill(id, "13");
                    }
                    if (visualise.Checked == true)
                    {
                        servercon.levelUpSkill(id, "14");
                    }
                    if (newIdea.Checked == true)
                    {
                        servercon.levelUpSkill(id, "15");
                    }
                    if (analyse.Checked == true)
                    {
                        servercon.levelUpSkill(id, "16");
                    }
                    if (understand.Checked == true)
                    {
                        servercon.levelUpSkill(id, "17");
                    }
                    if (generalKnowledge.Checked == true)
                    {
                        servercon.levelUpSkill(id, "18");
                    }
                    if (consistentResults.Checked == true)
                    {
                        servercon.levelUpSkill(id, "19");
                    }
                    if (perform.Checked == true)
                    {
                        servercon.levelUpSkill(id, "20");
                    }
                    if (randomLuck.Checked == true)
                    {
                        servercon.levelUpSkill(id, "21");
                    }
                    if (overthrow.Checked == true)
                    {
                        servercon.levelUpSkill(id, "22");
                    }
                    if (mediate.Checked == true)
                    {
                        servercon.levelUpSkill(id, "23");
                    }
                    if (dominate.Checked == true)
                    {
                        servercon.levelUpSkill(id, "24");
                    }
                }
            }
            if (tier4check == true)
            {
                if (tier1block == true || tier2block == true || tier3block == true) { }
                else
                {
                    
                    if (gutFeeling.Checked == true)
                    {
                        servercon.levelUpSkill(id, "25");
                    }
                    if (edicticMemory.Checked == true)
                    {
                        servercon.levelUpSkill(id, "26");
                    }
                    if (invent.Checked == true)
                    {
                        servercon.levelUpSkill(id, "27");
                    }
                    if (refineIdea.Checked == true)
                    {
                        servercon.levelUpSkill(id, "28");
                    }
                    if (seePattern.Checked == true)
                    {
                        servercon.levelUpSkill(id, "29");
                    }
                    if (manipulate.Checked == true)
                    {
                        servercon.levelUpSkill(id, "30");
                    }
                    if (explain.Checked == true)
                    {
                        servercon.levelUpSkill(id, "31");
                    }
                    if (obscureFact.Checked == true)
                    {
                        servercon.levelUpSkill(id, "32");
                    }
                    if (expertise.Checked == true)
                    {
                        servercon.levelUpSkill(id, "33");
                    }
                    if (impress.Checked == true)
                    {
                        servercon.levelUpSkill(id, "34");
                    }
                    if (bluff.Checked == true)
                    {
                        servercon.levelUpSkill(id, "35");
                    }
                    if (crisisAverted.Checked == true)
                    {
                        servercon.levelUpSkill(id, "36");
                    }
                    if (revolution.Checked == true)
                    {
                        servercon.levelUpSkill(id, "37");
                    }
                    if (inspire.Checked == true)
                    {
                        servercon.levelUpSkill(id, "38");
                    }
                    if (swindle.Checked == true)
                    {
                        servercon.levelUpSkill(id, "39");
                    }
                    if (feared.Checked == true)
                    {
                        servercon.levelUpSkill(id, "40");
                    }
             
                }
            }
        if (
            (tier1block == false)
            &
            (tier2.Visible == false || (tier2.Visible == true & tier2block == false))
            &
            (tier3.Visible == false || (tier3.Visible == true & tier3block == false))
            &
            (tier4.Visible == false || (tier4.Visible == true & tier4block == false))
            )
        {
            Response.Redirect("overview.aspx");
        }

    }
}
