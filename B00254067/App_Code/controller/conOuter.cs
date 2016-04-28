using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for outer
/// </summary>
public  class conOuter
{

    public bool login(string username, string password)
    {
        modOuter m = new modOuter();
        
        if (m.VerifyUser(username, password) > 0)
        {
            m = null;
            return true;
        }
        else
        {
            m = null;
            return false;
        }
    }
    public bool userHasLiveCharacter(string username)
    {
        modOuter m = new modOuter();
        if (m.userHasliveCharacter(username) > 0)
        {
            m = null;
            return true;
        }
        else
        {
            m = null;
            return false;
        }
    }
    public bool newAccount(string username, string email, string password)
    {
        modOuter m = new modOuter();
        int userconfirmed = m.VerifyUser(username, password);
        if (userconfirmed == 0)
        {
            m.NewUser(email, username, password);
            m = null;
            return true;
        }
        else
        {
            m = null;
            return false;
        }
    }

}
