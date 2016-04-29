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
        string id = (string)(Session["userId"]);
        if (string.IsNullOrEmpty(id)){
            Response.Redirect("../outer/index.aspx");
        }

        modOuter o = new modOuter();
        modInner m = new modInner();
        conOuter c = new conOuter ();
        if (c.userHasLiveCharacter(id))
        {
            Response.Redirect("../outer/newchar.aspx");
        }
        int charid = o.getCharId(id);

        string uploadDirectory = Path.Combine(Request.PhysicalApplicationPath, "Uploads\\" + id + "\\" + charid.ToString() + "\\prof");
        string[] types = new string[] { ".jpg", ".bmp", ".gif", ".gif" };
        foreach (string type in types)
        {
            if (File.Exists(uploadDirectory + type))
            {
                avatar.ImageUrl = Request.Url.Scheme + "://" + Request.Url.Authority +
    Request.ApplicationPath.TrimEnd('/') + "/" + "Uploads/" + id + "/" + charid.ToString() + "/prof" + type;
            }
        }
        
        
        Label2.Text = m.getCharName(id);
        
        if (m.ableToLevel(o.getCharId(id).ToString()) != 1)
        {
            levelupchoice.Visible = false;
        }
        else
        {
            ContentPlaceHolder3.Visible = false;
            
            int charlevel = m.getCharLevel(id);
            lbl_mind.Text = m.getskillrating(id, "1");
            lbl_wisdom.Text = m.getskillrating(id, "2");
            lbl_skill.Text = m.getskillrating(id, "3");
            lbl_passion.Text = m.getskillrating(id, "4");
            int levelCheck = charlevel % 2;
            if (levelCheck != 0)
            {
                tier2.Visible = false;

            }
            else
            {
                lbl_memory.Text = m.getskillrating(id, "5");
                lbl_creativity.Text = m.getskillrating(id, "6");
                lbl_observe.Text = m.getskillrating(id, "7");
                lbl_study.Text = m.getskillrating(id, "8");
                lbl_practice.Text = m.getskillrating(id, "9");
                lbl_talent.Text = m.getskillrating(id, "10");
                lbl_courage.Text = m.getskillrating(id, "11");
                lbl_power.Text = m.getskillrating(id, "12");
            }
            levelCheck = charlevel % 3;
            if (levelCheck != 0)
            {
                tier3.Visible = false;

            }
            else
            {
                lbl_remember.Text = m.getskillrating(id, "13");
                lbl_visualise.Text = m.getskillrating(id, "14");
                lbl_newIdea.Text = m.getskillrating(id, "15");
                lbl_analyse.Text = m.getskillrating(id, "16");
                lbl_understand.Text = m.getskillrating(id, "17");
                lbl_generalKnowledge.Text = m.getskillrating(id, "18");
                lbl_consistentResults.Text = m.getskillrating(id, "19");
                lbl_perform.Text = m.getskillrating(id, "20");
                lbl_randomLuck.Text = m.getskillrating(id, "21");
                lbl_overthrow.Text = m.getskillrating(id, "22");
                lbl_mediate.Text = m.getskillrating(id, "23");
                lbl_dominate.Text = m.getskillrating(id, "24");
            }
            levelCheck = charlevel % 4;
            if (levelCheck != 0)
            {
                tier4.Visible = false;

            }
            else
            {
                lbl_gutFeeling.Text = m.getskillrating(id, "25");
                lbl_edicticMemory.Text = m.getskillrating(id, "26");
                lbl_invent.Text = m.getskillrating(id, "27");
                lbl_refineIdea.Text = m.getskillrating(id, "28");
                lbl_seePattern.Text = m.getskillrating(id, "29");
                lbl_manipulate.Text = m.getskillrating(id, "30");
                lbl_explain.Text = m.getskillrating(id, "31");
                lbl_obscureFact.Text = m.getskillrating(id, "32");
                lbl_expertise.Text = m.getskillrating(id, "33");
                lbl_impress.Text = m.getskillrating(id, "34");
                lbl_bluff.Text = m.getskillrating(id, "35");
                lbl_crisisAverted.Text = m.getskillrating(id, "36");
                lbl_revolution.Text = m.getskillrating(id, "37");
                lbl_inspire.Text = m.getskillrating(id, "38");
                lbl_swindle.Text = m.getskillrating(id, "39");
                lbl_feared.Text = m.getskillrating(id, "40");
            }
        }
        m = null;
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        modInner m = new modInner();
        
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
                    m.levelUpSkill(id, "1");
                }
                if (wisdom.Checked == true)
                {
                    m.levelUpSkill(id, "2");
                }
                if (skill.Checked == true)
                {
                    m.levelUpSkill(id, "3");
                }
                if (passion.Checked == true)
                {
                    m.levelUpSkill(id, "4");
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
                    m.levelUpSkill(id, "5");
                }
                if (creativity.Checked == true)
                {
                    m.levelUpSkill(id, "6");
                }
                if (observe.Checked == true)
                {
                    m.levelUpSkill(id, "7");
                }
                if (study.Checked == true)
                {
                    m.levelUpSkill(id, "8");
                }
                if (practice.Checked == true)
                {
                    m.levelUpSkill(id, "9");
                }
                if (talent.Checked == true)
                {
                    m.levelUpSkill(id, "10");
                }
                if (courage.Checked == true)
                {
                    m.levelUpSkill(id, "11");
                }
                if (power.Checked == true)
                {
                    m.levelUpSkill(id, "12");
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
                    m.levelUpSkill(id, "13");
                }
                if (visualise.Checked == true)
                {
                    m.levelUpSkill(id, "14");
                }
                if (newIdea.Checked == true)
                {
                    m.levelUpSkill(id, "15");
                }
                if (analyse.Checked == true)
                {
                    m.levelUpSkill(id, "16");
                }
                if (understand.Checked == true)
                {
                    m.levelUpSkill(id, "17");
                }
                if (generalKnowledge.Checked == true)
                {
                    m.levelUpSkill(id, "18");
                }
                if (consistentResults.Checked == true)
                {
                    m.levelUpSkill(id, "19");
                }
                if (perform.Checked == true)
                {
                    m.levelUpSkill(id, "20");
                }
                if (randomLuck.Checked == true)
                {
                    m.levelUpSkill(id, "21");
                }
                if (overthrow.Checked == true)
                {
                    m.levelUpSkill(id, "22");
                }
                if (mediate.Checked == true)
                {
                    m.levelUpSkill(id, "23");
                }
                if (dominate.Checked == true)
                {
                    m.levelUpSkill(id, "24");
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
                    m.levelUpSkill(id, "25");
                }
                if (edicticMemory.Checked == true)
                {
                    m.levelUpSkill(id, "26");
                }
                if (invent.Checked == true)
                {
                    m.levelUpSkill(id, "27");
                }
                if (refineIdea.Checked == true)
                {
                    m.levelUpSkill(id, "28");
                }
                if (seePattern.Checked == true)
                {
                    m.levelUpSkill(id, "29");
                }
                if (manipulate.Checked == true)
                {
                    m.levelUpSkill(id, "30");
                }
                if (explain.Checked == true)
                {
                    m.levelUpSkill(id, "31");
                }
                if (obscureFact.Checked == true)
                {
                    m.levelUpSkill(id, "32");
                }
                if (expertise.Checked == true)
                {
                    m.levelUpSkill(id, "33");
                }
                if (impress.Checked == true)
                {
                    m.levelUpSkill(id, "34");
                }
                if (bluff.Checked == true)
                {
                    m.levelUpSkill(id, "35");
                }
                if (crisisAverted.Checked == true)
                {
                    m.levelUpSkill(id, "36");
                }
                if (revolution.Checked == true)
                {
                    m.levelUpSkill(id, "37");
                }
                if (inspire.Checked == true)
                {
                    m.levelUpSkill(id, "38");
                }
                if (swindle.Checked == true)
                {
                    m.levelUpSkill(id, "39");
                }
                if (feared.Checked == true)
                {
                    m.levelUpSkill(id, "40");
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
        Session["userId"] = "";
        Response.Redirect("../outer/index.aspx");
    }
}
