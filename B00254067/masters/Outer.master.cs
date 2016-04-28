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
        string id = (string)(Session["userId"]);
        if (!string.IsNullOrEmpty(id))
        {
            Response.Redirect("../inner/overview.aspx");
        }
    }
    protected void btn_login_Click(object sender, EventArgs e)
    {
        conOuter c = new conOuter();
        modInner m = new modInner();
        bool loginSwitch = c.login(txt_loginUsername.Text, txt_loginPassword.Text);
        switch (c.login(txt_loginUsername.Text, txt_loginPassword.Text))
        {
            case false:
                txt_notifcation.Text = "You have entered the wrong username or password!";
                break;
            case true:
                Session["userId"] = m.getAccountId(txt_loginUsername.Text).ToString();
                //check has character
                if(c.userHasLiveCharacter(txt_loginUsername.Text) == true)
                {
                    Response.Redirect("../inner/Overview.aspx");
                }
                else
                {
                    Response.Redirect("newchar.aspx");
                }
                break;
        }
        c = null;
        m = null;
    }

  
}
