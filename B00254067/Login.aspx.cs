using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_login_Click(object sender, EventArgs e)
    {
        string var_userName = txt_loginUsername.Text;
        string var_password = txt_loginPassword.Text;
        CustomFunctions login = new CustomFunctions();
        int loginSwitch = login.login(var_userName, var_password);
        int id;
        soulfree soulfree = new soulfree();
        switch (loginSwitch)
        {

            case 0:
                txt_notifcation.Text = "You have entered the wrong username or password!";
                break;
            case 2:

                id = soulfree.getAccountId(var_userName);
                Session["userId"] = id.ToString();
                Response.Redirect("newCharacter.aspx");
                break;
            case 1:

                id = soulfree.getAccountId(var_userName);
                Session["userId"] = id.ToString();
                Response.Redirect("overview.aspx");
                break;
        };
    }

    protected void santize_Click(object sender, EventArgs e)
    {
        soulfree soulfree = new soulfree();
        soulfree.sqlcommand("TRUNCATE characters; TRUNCATE character_levels; TRUNCATE character_skills;");
    }
}