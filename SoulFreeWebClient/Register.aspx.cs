using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn__Click(object sender, EventArgs e)
    {
        string var_userName = txt_userName.Text;
        string var_password = txt_password.Text;
        string var_email = txt_email.Text;
        WebServer.IsoulfreeClient servercon = new WebServer.IsoulfreeClient();
        string serverReturn = servercon.newAccount(var_userName, var_email, var_password);
        switch (serverReturn)
        {
            case "Deny":
                lbl_notification.Text = "A user with that username already exists";
                break;
            case "Confirm":
                customFunctions login = new customFunctions();
                int loginSwitch = login.login(var_userName, var_password);
                switch (loginSwitch)
                {
                    case 0:
                        lbl_notification .Text = "You have entered the wrong username or password!";
                        break;
                };
                break;
        }
      
    }
}