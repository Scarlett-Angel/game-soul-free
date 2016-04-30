using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class outer_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void santize_Click(object sender, EventArgs e)
    {
       
        debugmod.run("TRUNCATE TABLE gamestate;TRUNCATE TABLE characters; TRUNCATE TABLE character_levels; TRUNCATE TABLE character_skills;");
    }
    protected void btn__Click(object sender, EventArgs e)
    {
        string var_userName = txt_userName.Text;
        string var_password = txt_password.Text;
        string var_email = txt_email.Text;

        switch (gateway.newAccount(txt_userName.Text, txt_password.Text, txt_email.Text)
        )
        {
            case false:
                lbl_notification.Text = "A user with that username already exists";
                break;
            case true:
                lbl_notification.Text = "Account created you can now login";
                break;
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        acc acc = new acc();
        Label2.Text = acc.getCharStats("1");
    }
}