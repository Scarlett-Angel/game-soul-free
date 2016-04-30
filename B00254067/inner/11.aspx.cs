using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class locations_11 : System.Web.UI.Page
{
    
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
        }
        txt_pageTitle.Text = loc.name;
        txt_description.Text = loc.description;

    }

    protected void go_Click(object sender, EventArgs e)
    {

    }
}