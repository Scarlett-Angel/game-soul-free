using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class masters_Outer : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Is the user Logged in? Automatically redirect to the inner area
        string username = (string)(Session["username"]);
        if (!string.IsNullOrEmpty(username))
        {
            Response.Redirect("../inner/overview.aspx");
        }
    }
    protected void btn_login_Click(object sender, EventArgs e)
    {
        switch (gateway.login(txt_loginUsername.Text, txt_loginPassword.Text))
        {
            case false:
                txt_notifcation.Text = "You have entered the wrong username or password!";
                break;
            case true:
                Session["username"] = txt_loginUsername.Text;
                account acc = new account(txt_loginUsername.Text);
                if(acc.userHasLiveCharacter)
                {
                    Response.Redirect("../inner/Overview.aspx");
                }
                else
                {
                    Response.Redirect("newchar.aspx");
                }
                break;
        }
    }

  
}
