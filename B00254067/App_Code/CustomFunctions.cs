using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomFunctions
/// </summary>
public class CustomFunctions
{
    
    public CustomFunctions()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int login(string username, string password)
    {
        WebServer.IsoulfreeClient serverCon = new WebServer.IsoulfreeClient();
        int loginReturn = serverCon.login(username, password);
        switch (loginReturn)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            case 2:
                return 2;
            case 999:
                return 3;
            default:
                return 999;
        }


    }


}