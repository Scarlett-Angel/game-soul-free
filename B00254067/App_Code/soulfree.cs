using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "soulfree" in code, svc and config file together.
public class soulfree : Isoulfree
{
    WcfService3.DBconnect datacon = new WcfService3.DBconnect();
    public int login(string username, string password)
    {
        bool userconfirmed = datacon.VerifyUser(username, password);
        if (userconfirmed == true)
        {
            int hasChar = datacon.userHasCharacter(username);
            return hasChar;
        }
        else
        {
            //wrong credentials
            return 0;
        }

    }
    public string newAccount(string username, string email, string password)
    {
        bool userconfirmed = datacon.VerifyUser(username, password);
        if (userconfirmed == false)
        {
            datacon.NewUser(email, username, password);
            return "Confirm";
        }
        else
        {
            return "Deny";
        }
    }

    public void newCharacter(string characterName, string id)
    {
        datacon.createCharacter(characterName, id);
    }

    public int getAccountId(string username)
    {
        int id = datacon.getAccountId(username);
        return id;
    }
    public int getCharLevel(string id)
    {
        int idreturn = datacon.getCharLevel(id);
        return idreturn;
    }
    public void sqlcommand(string query)
    {
        datacon.sqlquery(query);
    }
    public string getSkillLevel(string uid, string sid)
    {
        string returnvalue = datacon.getskillid(uid, sid);
        return returnvalue;
    }
    public void levelUpSkill(string uid, string sid)
    {
        datacon.levelUpSkill(uid, sid);
    }

}