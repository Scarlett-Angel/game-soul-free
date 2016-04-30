using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class inner_character : System.Web.UI.Page
{
    private string uploadDirectory;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        
        string username = (string)(Session["username"]);

        // Check the extension.

        string extension = Path.GetExtension(FileUpload1.PostedFile.FileName);

        switch (extension.ToLower())
        {
            case ".bmp":

            case ".gif":

            case ".jpg":
            case ".png":
                account acc = new account(username );
                string characterId = acc.characterID ;
                uploadDirectory = Path.Combine(Request.PhysicalApplicationPath, acc.getUploadDirectory );
                if (!System.IO.Directory.Exists(uploadDirectory))
                {
                    System.IO.Directory.CreateDirectory(uploadDirectory);
                }
                string fullUploadPath = Path.Combine(uploadDirectory, "prof" + extension.ToLower());
                FileUpload1.PostedFile.SaveAs(fullUploadPath);

                Response.Redirect("../inner/character.aspx");
                break;

            default:

                Label1.Text = "This file type is not allowed.";

                return;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = (string)(Session["username"]);
        account acc = new account(username);
        acc.changeCharname(txt_name.Text);
        Response.Redirect("character.aspx");
    }
}