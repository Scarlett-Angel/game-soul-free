using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class inner_travel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string username = (string)(Session["username"]);
        account acc = new account(username);
        switch (acc.playState)
        {
            case 1:
                string goTo =  acc.locationID + ".aspx";
                Response.Redirect(goTo);
                break;
        }
    }
}