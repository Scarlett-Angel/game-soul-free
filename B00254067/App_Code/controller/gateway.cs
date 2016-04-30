using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Functions for accessing information about a users account
/// </summary>
public static class gateway
{
    /// <summary>
    /// Will return Boolean Yes if the Use's Name as password is correct
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns></returns>
public static bool login(string username, string password)
    {
        acc acc = new acc();
        if(acc.verUserPassword(username, password) > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static public bool newAccount(string username, string password, string email)
    {
        acc acc = new acc();
        if (acc.verUserPassword(username, password) == 0)
        {
            acc.newUserAccount(username, password, email);
            return true;
        }
        else
        {
            return false;
        }
    }
}