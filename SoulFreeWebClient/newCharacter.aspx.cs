using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class newCharacter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        WebServer.IsoulfreeClient servercon = new WebServer.IsoulfreeClient();
        string id = (string)(Session["userId"]);
        string name = txt_name.Text;
        servercon.newCharacter(name, id);
        Response.Redirect("LevelUp.aspx");
    }
}