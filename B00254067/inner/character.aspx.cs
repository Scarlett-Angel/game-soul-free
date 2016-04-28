﻿using System;
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
        modOuter m = new modOuter();
        string id = (string)(Session["userId"]);

        // Check the extension.

        string extension = Path.GetExtension(FileUpload1.PostedFile.FileName);

        switch (extension.ToLower())
        {
            case ".bmp":

            case ".gif":

            case ".jpg":
            case ".png":

                string characterId = Convert.ToString(m.getCharId(id));
                uploadDirectory = Path.Combine(Request.PhysicalApplicationPath, "Uploads\\" + id + "\\" + characterId);
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
        m = null;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = (string)(Session["userId"]);
        modInner m = new modInner();
        m.updateCharName(id, txt_name.Text);
        Response.Redirect("character.aspx");
    }
}