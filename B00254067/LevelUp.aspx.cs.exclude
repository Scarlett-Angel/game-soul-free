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
        soulfree soulfree = new soulfree();
        string id = (string)(Session["userId"]);
        int charlevel = soulfree.getCharLevel(id);
        lbl_mind.Text = soulfree.getSkillLevel(id, "1");
        lbl_wisdom.Text = soulfree.getSkillLevel(id, "2");
        lbl_skill.Text = soulfree.getSkillLevel(id, "3");
        lbl_passion.Text = soulfree.getSkillLevel(id, "4");
        int levelCheck = charlevel % 2;
        if (levelCheck != 0)
        {
            tier2.Visible = false;

        }
        else
        {
            lbl_memory.Text = soulfree.getSkillLevel(id, "5");
            lbl_creativity.Text = soulfree.getSkillLevel(id, "6");
            lbl_observe.Text = soulfree.getSkillLevel(id, "7");
            lbl_study.Text = soulfree.getSkillLevel(id, "8");
            lbl_practice.Text = soulfree.getSkillLevel(id, "9");
            lbl_talent.Text = soulfree.getSkillLevel(id, "10");
            lbl_courage.Text = soulfree.getSkillLevel(id, "11");
            lbl_power.Text = soulfree.getSkillLevel(id, "12");
        }
        levelCheck = charlevel % 3;
        if (levelCheck != 0)
        {
            tier3.Visible = false;

        }
        else
        {
            lbl_remember.Text = soulfree.getSkillLevel(id, "13");
            lbl_visualise.Text = soulfree.getSkillLevel(id, "14");
            lbl_newIdea.Text = soulfree.getSkillLevel(id, "15");
            lbl_analyse.Text = soulfree.getSkillLevel(id, "16");
            lbl_understand.Text = soulfree.getSkillLevel(id, "17");
            lbl_generalKnowledge.Text = soulfree.getSkillLevel(id, "18");
            lbl_consistentResults.Text = soulfree.getSkillLevel(id, "19");
            lbl_perform.Text = soulfree.getSkillLevel(id, "20");
            lbl_randomLuck.Text = soulfree.getSkillLevel(id, "21");
            lbl_overthrow.Text = soulfree.getSkillLevel(id, "22");
            lbl_mediate.Text = soulfree.getSkillLevel(id, "23");
            lbl_dominate.Text = soulfree.getSkillLevel(id, "24");
        }
        levelCheck = charlevel % 4;
        if (levelCheck != 0)
        {
            tier4.Visible = false;

        }
        else
        {
            lbl_gutFeeling.Text = soulfree.getSkillLevel(id, "25");
            lbl_edicticMemory.Text = soulfree.getSkillLevel(id, "26");
            lbl_invent.Text = soulfree.getSkillLevel(id, "27");
            lbl_refineIdea.Text = soulfree.getSkillLevel(id, "28");
            lbl_seePattern.Text = soulfree.getSkillLevel(id, "29");
            lbl_manipulate.Text = soulfree.getSkillLevel(id, "30");
            lbl_explain.Text = soulfree.getSkillLevel(id, "31");
            lbl_obscureFact.Text = soulfree.getSkillLevel(id, "32");
            lbl_expertise.Text = soulfree.getSkillLevel(id, "33");
            lbl_impress.Text = soulfree.getSkillLevel(id, "34");
            lbl_bluff.Text = soulfree.getSkillLevel(id, "35");
            lbl_crisisAverted.Text = soulfree.getSkillLevel(id, "36");
            lbl_revolution.Text = soulfree.getSkillLevel(id, "37");
            lbl_inspire.Text = soulfree.getSkillLevel(id, "38");
            lbl_swindle.Text = soulfree.getSkillLevel(id, "39");
            lbl_feared.Text = soulfree.getSkillLevel(id, "40");
        }

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        soulfree soulfree = new soulfree();
        string id = (string)(Session["userId"]);
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
                    soulfree.levelUpSkill(id, "1");
                }
                if (wisdom.Checked == true)
                {
                    soulfree.levelUpSkill(id, "2");
                }
                if (skill.Checked == true)
                {
                    soulfree.levelUpSkill(id, "3");
                }
                if (passion.Checked == true)
                {
                    soulfree.levelUpSkill(id, "4");
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
                    soulfree.levelUpSkill(id, "5");
                }
                if (creativity.Checked == true)
                {
                    soulfree.levelUpSkill(id, "6");
                }
                if (observe.Checked == true)
                {
                    soulfree.levelUpSkill(id, "7");
                }
                if (study.Checked == true)
                {
                    soulfree.levelUpSkill(id, "8");
                }
                if (practice.Checked == true)
                {
                    soulfree.levelUpSkill(id, "9");
                }
                if (talent.Checked == true)
                {
                    soulfree.levelUpSkill(id, "10");
                }
                if (courage.Checked == true)
                {
                    soulfree.levelUpSkill(id, "11");
                }
                if (power.Checked == true)
                {
                    soulfree.levelUpSkill(id, "12");
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
                    soulfree.levelUpSkill(id, "13");
                }
                if (visualise.Checked == true)
                {
                    soulfree.levelUpSkill(id, "14");
                }
                if (newIdea.Checked == true)
                {
                    soulfree.levelUpSkill(id, "15");
                }
                if (analyse.Checked == true)
                {
                    soulfree.levelUpSkill(id, "16");
                }
                if (understand.Checked == true)
                {
                    soulfree.levelUpSkill(id, "17");
                }
                if (generalKnowledge.Checked == true)
                {
                    soulfree.levelUpSkill(id, "18");
                }
                if (consistentResults.Checked == true)
                {
                    soulfree.levelUpSkill(id, "19");
                }
                if (perform.Checked == true)
                {
                    soulfree.levelUpSkill(id, "20");
                }
                if (randomLuck.Checked == true)
                {
                    soulfree.levelUpSkill(id, "21");
                }
                if (overthrow.Checked == true)
                {
                    soulfree.levelUpSkill(id, "22");
                }
                if (mediate.Checked == true)
                {
                    soulfree.levelUpSkill(id, "23");
                }
                if (dominate.Checked == true)
                {
                    soulfree.levelUpSkill(id, "24");
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
                    soulfree.levelUpSkill(id, "25");
                }
                if (edicticMemory.Checked == true)
                {
                    soulfree.levelUpSkill(id, "26");
                }
                if (invent.Checked == true)
                {
                    soulfree.levelUpSkill(id, "27");
                }
                if (refineIdea.Checked == true)
                {
                    soulfree.levelUpSkill(id, "28");
                }
                if (seePattern.Checked == true)
                {
                    soulfree.levelUpSkill(id, "29");
                }
                if (manipulate.Checked == true)
                {
                    soulfree.levelUpSkill(id, "30");
                }
                if (explain.Checked == true)
                {
                    soulfree.levelUpSkill(id, "31");
                }
                if (obscureFact.Checked == true)
                {
                    soulfree.levelUpSkill(id, "32");
                }
                if (expertise.Checked == true)
                {
                    soulfree.levelUpSkill(id, "33");
                }
                if (impress.Checked == true)
                {
                    soulfree.levelUpSkill(id, "34");
                }
                if (bluff.Checked == true)
                {
                    soulfree.levelUpSkill(id, "35");
                }
                if (crisisAverted.Checked == true)
                {
                    soulfree.levelUpSkill(id, "36");
                }
                if (revolution.Checked == true)
                {
                    soulfree.levelUpSkill(id, "37");
                }
                if (inspire.Checked == true)
                {
                    soulfree.levelUpSkill(id, "38");
                }
                if (swindle.Checked == true)
                {
                    soulfree.levelUpSkill(id, "39");
                }
                if (feared.Checked == true)
                {
                    soulfree.levelUpSkill(id, "40");
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
