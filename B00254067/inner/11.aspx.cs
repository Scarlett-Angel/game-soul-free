using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class locations_11 : System.Web.UI.Page
{
    //playstates
    //1 start on page
    //2 got lost
    //3 incredible feat and escapred
    //4 in accident but survived and get out
    //5 in accident but got hurt and get out
    //6 Escaped
    protected void Page_Load(object sender, EventArgs e)
    {
        string username = (string)(Session["username"]);
        account acc = new account(username);
        location loc = new location(acc.locationID);
        switch (acc.playState)
        {
            case 1:
                if (acc.jobID == 2)
                {
                    canPass.Visible = true;
                }
                goInto.Visible = true;
                break;
            //rolled the dice but got lost
            case 2:
                lost.Visible = true;
                break;
            case 3:
                //had an incredible feat an survived
                feat.Visible = true;
                break;
            case 4:
                //in accident but got out
                accidentWin.Visible = true;
                break;
            case 5:
                //in accident but got hurt
                accidentLose.Visible = true;
                break;
            case 6:
                //escaped
                escape.Visible = true;
                break;
        }
        //first come to page

        txt_pageTitle.Text = loc.name;
        txt_description.Text = loc.description;

    }
    private void debris()
    {
        string username = (string)(Session["username"]);
        account acc = new account(username);
        int dice = play.roll(1);
        switch (dice)
        {
            case 1:
                if(play.fightCraft(acc.craft, 4))

                {
                    acc.setPlayState(0, 4);
                }
                else
                {
                    acc.setPlayState(0, 5);
                    acc.decreaseLife(1);
                }
                Response.Redirect("11.aspx");
                break;
            case 2:
            //lost repeat roll
            case 3:
                acc.setPlayState(dice, 2);
                Response.Redirect("11.aspx");
                break;
            case 4:
            //safe you pass freely
            case 5:
                acc.setPlayState(0, 6);
                Response.Redirect("11.aspx");
                break;
            case 6:
                //you have an incredible feat and you gain 1 strength
                acc.setPlayState(dice, 3);
                acc.increasteStrength(1);
                Response.Redirect("11.aspx");
                break;
        }
    }


    protected void go_Click(object sender, EventArgs e)
    {
        debris();
    }
    protected void restart_page()
    {
        string username = (string)(Session["username"]);
        account acc = new account(username);
        canPass.Visible = false;
        goInto.Visible = false;
        lost.Visible = false;
}

    protected void lostBtn_Click(object sender, EventArgs e)
    {
        debris();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        nextLoc();
    }
    private void nextLoc()
    {
        string username = (string)(Session["username"]);
        account acc = new account(username);
        acc.setPlayState(0, 1);
        acc.setLocation(11);
        Response.Redirect("11.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        nextLoc();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        nextLoc();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nextLoc();

    }
}