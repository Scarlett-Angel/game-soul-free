using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class masters_Inner : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string username = (string)(Session["username"]);
        if (string.IsNullOrEmpty(username)){
            Response.Redirect("../outer/index.aspx");
        }

        account acc = new account(username);
        if (!acc.userHasLiveCharacter)
        {
            Response.Redirect("../outer/newchar.aspx");
        }
        string uploadDirectory = Path.Combine(Request.PhysicalApplicationPath, acc.getUploadDirectory + "\\prof");
        string[] types = new string[] { ".jpg", ".bmp", ".gif", ".png" };
        foreach (string type in types)
        {
            if (File.Exists(uploadDirectory + type))
            {
                avatar.ImageUrl = Request.Url.Scheme + "://" + Request.Url.Authority +
    Request.ApplicationPath.TrimEnd('/') + "/" + "Uploads/" + acc.accountID  + "/" + acc.characterID  + "/prof" + type;
            }
        }

        jobInfo job = new jobInfo(acc.jobID.ToString());
        location loc = new location(acc.locationID);
        lbl_title.Text = "<strong>lvl " +acc.getCharacterLevel +" "+ job.name + ":</strong> " + acc.characterName;
        lbl_strength.Text = "<strong>Strength: </strong>" + acc.strength;
        lbl_craft.Text = "<strong>Craft: </strong>" + acc.craft;
        lbl_luck.Text = "<strong>Luck: </strong>" + acc.luck;
        lbl_life.Text = "<strong>Life: </strong>" + acc.life;
        lbl_alignment.Text = "<strong>Alignment: </strong>" + acc.alignment;
        lbl_location.Text = "<strong>Location: </strong>" + loc.name;
        if (!acc.ableToLevelUp)
        {
            levelupchoice.Visible = false;
        }
        else
        {
            ContentPlaceHolder3.Visible = false;
            lbl_mind.Text = acc.getskillrating ("1");
            lbl_wisdom.Text = acc.getskillrating ("2");
            lbl_skill.Text = acc.getskillrating ("3");
            lbl_passion.Text = acc.getskillrating ("4");
            int levelCheck = acc.getCharacterLevel % 2;
            if (levelCheck != 0)
            {
                tier2.Visible = false;

            }
            else
            {
                lbl_memory.Text = acc.getskillrating ("5");
                lbl_creativity.Text = acc.getskillrating ("6");
                lbl_observe.Text = acc.getskillrating ("7");
                lbl_study.Text = acc.getskillrating ("8");
                lbl_practice.Text = acc.getskillrating ("9");
                lbl_talent.Text = acc.getskillrating ("10");
                lbl_courage.Text = acc.getskillrating ("11");
                lbl_power.Text = acc.getskillrating ("12");
            }
            levelCheck = acc.getCharacterLevel % 3;
            if (levelCheck != 0)
            {
                tier3.Visible = false;

            }
            else
            {
                lbl_remember.Text = acc.getskillrating ("13");
                lbl_visualise.Text = acc.getskillrating ("14");
                lbl_newIdea.Text = acc.getskillrating ("15");
                lbl_analyse.Text = acc.getskillrating ("16");
                lbl_understand.Text = acc.getskillrating ("17");
                lbl_generalKnowledge.Text = acc.getskillrating ("18");
                lbl_consistentResults.Text = acc.getskillrating ("19");
                lbl_perform.Text = acc.getskillrating ("20");
                lbl_randomLuck.Text = acc.getskillrating ("21");
                lbl_overthrow.Text = acc.getskillrating ("22");
                lbl_mediate.Text = acc.getskillrating ("23");
                lbl_dominate.Text = acc.getskillrating ("24");
            }
            levelCheck = acc.getCharacterLevel % 4;
            if (levelCheck != 0)
            {
                tier4.Visible = false;

            }
            else
            {
                lbl_gutFeeling.Text = acc.getskillrating ("25");
                lbl_edicticMemory.Text = acc.getskillrating ("26");
                lbl_invent.Text = acc.getskillrating ("27");
                lbl_refineIdea.Text = acc.getskillrating ("28");
                lbl_seePattern.Text = acc.getskillrating ("29");
                lbl_manipulate.Text = acc.getskillrating ("30");
                lbl_explain.Text = acc.getskillrating ("31");
                lbl_obscureFact.Text = acc.getskillrating ("32");
                lbl_expertise.Text = acc.getskillrating ("33");
                lbl_impress.Text = acc.getskillrating ("34");
                lbl_bluff.Text = acc.getskillrating ("35");
                lbl_crisisAverted.Text = acc.getskillrating ("36");
                lbl_revolution.Text = acc.getskillrating ("37");
                lbl_inspire.Text = acc.getskillrating ("38");
                lbl_swindle.Text = acc.getskillrating ("39");
                lbl_feared.Text = acc.getskillrating ("40");
            }
        }
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string username = (string)(Session["username"]);
        account acc = new account(username);
        string id = (string)(Session["username"]);
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
                   acc.levelUpSkill("1");
                }
                if (wisdom.Checked == true)
                {
                    acc.levelUpSkill("2");
                }
                if (skill.Checked == true)
                {
                    acc.levelUpSkill("3");
                }
                if (passion.Checked == true)
                {
                    acc.levelUpSkill("4");
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
                    acc.levelUpSkill("5");
                }
                if (creativity.Checked == true)
                {
                    acc.levelUpSkill("6");
                }
                if (observe.Checked == true)
                {
                    acc.levelUpSkill("7");
                }
                if (study.Checked == true)
                {
                    acc.levelUpSkill("8");
                }
                if (practice.Checked == true)
                {
                    acc.levelUpSkill("9");
                }
                if (talent.Checked == true)
                {
                    acc.levelUpSkill("10");
                }
                if (courage.Checked == true)
                {
                    acc.levelUpSkill("11");
                }
                if (power.Checked == true)
                {
                    acc.levelUpSkill("12");
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
                    acc.levelUpSkill("13");
                }
                if (visualise.Checked == true)
                {
                    acc.levelUpSkill("14");
                }
                if (newIdea.Checked == true)
                {
                    acc.levelUpSkill("15");
                }
                if (analyse.Checked == true)
                {
                    acc.levelUpSkill("16");
                }
                if (understand.Checked == true)
                {
                    acc.levelUpSkill("17");
                }
                if (generalKnowledge.Checked == true)
                {
                    acc.levelUpSkill("18");
                }
                if (consistentResults.Checked == true)
                {
                    acc.levelUpSkill("19");
                }
                if (perform.Checked == true)
                {
                    acc.levelUpSkill("20");
                }
                if (randomLuck.Checked == true)
                {
                    acc.levelUpSkill("21");
                }
                if (overthrow.Checked == true)
                {
                    acc.levelUpSkill("22");
                }
                if (mediate.Checked == true)
                {
                    acc.levelUpSkill("23");
                }
                if (dominate.Checked == true)
                {
                    acc.levelUpSkill("24");
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
                    acc.levelUpSkill("25");
                }
                if (edicticMemory.Checked == true)
                {
                    acc.levelUpSkill("26");
                }
                if (invent.Checked == true)
                {
                    acc.levelUpSkill("27");
                }
                if (refineIdea.Checked == true)
                {
                    acc.levelUpSkill("28");
                }
                if (seePattern.Checked == true)
                {
                    acc.levelUpSkill("29");
                }
                if (manipulate.Checked == true)
                {
                    acc.levelUpSkill("30");
                }
                if (explain.Checked == true)
                {
                    acc.levelUpSkill("31");
                }
                if (obscureFact.Checked == true)
                {
                    acc.levelUpSkill("32");
                }
                if (expertise.Checked == true)
                {
                    acc.levelUpSkill("33");
                }
                if (impress.Checked == true)
                {
                    acc.levelUpSkill("34");
                }
                if (bluff.Checked == true)
                {
                    acc.levelUpSkill("35");
                }
                if (crisisAverted.Checked == true)
                {
                    acc.levelUpSkill("36");
                }
                if (revolution.Checked == true)
                {
                    acc.levelUpSkill("37");
                }
                if (inspire.Checked == true)
                {
                    acc.levelUpSkill("38");
                }
                if (swindle.Checked == true)
                {
                    acc.levelUpSkill("39");
                }
                if (feared.Checked == true)
                {
                    acc.levelUpSkill("40");
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

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Session["username"] = "";
        Response.Redirect("../outer/index.aspx");
    }
}
