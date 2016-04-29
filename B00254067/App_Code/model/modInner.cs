using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
/// <summary>
/// Summary description for modInner
/// </summary>
public class modInner
{
    SqlConnection con = new SqlConnection();
    public modInner()
    {
        con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\project\\game-soul-free\\B00254067\\App_Data\\Database.mdf;Integrated Security=True";
    }
    private SqlCommand sqlquery(string query)
    {
        SqlCommand thequery = new SqlCommand(query, con);
        return thequery;
    }
 
    public int getAccountId(string username)
    {
        string query = "Select id from users where username='" + username + "';";
        int id;
        SqlCommand cmd = sqlquery(query);
        con.Open();
        SqlDataReader thereader;
        thereader = cmd.ExecuteReader();
        thereader.Read();
        id = int.Parse(thereader["id"].ToString());
        con.Close();
        return id;
    }
    public int ableToLevel(string charId)
    {
        string query = "Select Count(*) as value from character_levels where characterid='" + charId + "' AND rating <= progression;";
        int id;
        SqlCommand cmd = sqlquery(query);
        con.Open();
        SqlDataReader thereader;
        thereader = cmd.ExecuteReader();
        thereader.Read();
        id = int.Parse(thereader["value"].ToString());
        con.Close();
        return id;
    }
    public string getskillrating(string uid, string sid)
    {
        modOuter m = new modOuter();
        int charid = m.getCharId(uid);
        string returnstring;
        string query = "Select value from character_skills where characterid ='" + charid + "' and skillid='" + sid + "';";
        SqlCommand cmd = sqlquery(query);
        con.Open();
        SqlDataReader thereader;
        thereader = cmd.ExecuteReader();
        thereader.Read();
        if (thereader.HasRows)
        {
            returnstring = thereader["value"].ToString();
        }
        else
        {
            returnstring = "";
        }

        con.Close();

        if (string.IsNullOrWhiteSpace(returnstring))
        {
            return "0";
        }
        else
        {
            return returnstring;
        }
    }
    public int getCharLevel(string id)
    {
        modOuter m = new modOuter();
        int charid = m.getCharId(id);
        int returnrating;
        string query = "Select rating from character_levels where characterid ='" + charid + "' AND levelid ='1';";
        SqlCommand cmd = sqlquery(query);
        con.Open();
        SqlDataReader thereader;
        thereader = cmd.ExecuteReader();
        thereader.Read();
        returnrating = int.Parse(thereader["rating"].ToString());
        con.Close();
        return returnrating;
    }
    public void levelUpSkill(string uid, string sid)
    {
        int count = 0;
        modOuter o = new modOuter();
        int charid = o.getCharId(uid);
        string query = "SELECT COUNT(*) as result FROM character_skills WHERE characterid='" + charid + "' AND skillid='" + sid + "';";
        SqlCommand cmd = sqlquery(query);
        con.Open();
        SqlDataReader thereader;
        thereader = cmd.ExecuteReader();
        thereader.Read();
        count = int.Parse(thereader["result"].ToString());
        con.Close();
        int resutl;
        if (count > 0)
        {
            query = "UPDATE character_skills SET value = value + 1 WHERE characterid='" + charid + "' AND skillid='" + sid + "';";
            cmd = sqlquery(query);
            con.Open();
            resutl = cmd.ExecuteNonQuery();
            con.Close();
        }
        else
        {
            query = "INSERT INTO character_skills (characterid, skillid, value) VALUES ('" + charid + "','" + sid + "', '1');";
            cmd = sqlquery(query);
            con.Open();
            resutl = cmd.ExecuteNonQuery();
            con.Close();
        }
        query = "UPDATE character_levels SET rating = rating + inc WHERE characterid='" + charid + "' AND levelid='" + 1 + "';UPDATE character_levels SET inc = inc + 1 WHERE characterid='" + charid + "' AND levelid='" + 1 + "';";
        cmd = sqlquery(query);
        con.Open();
        resutl = cmd.ExecuteNonQuery();
        con.Close();
    }
    public string getCharName(string id)
    {
        modOuter o = new modOuter();
        int charid = o.getCharId(id);
        string query = "Select name from characters where userid ='" + id + "' and death is NULL;";
        SqlCommand cmd = sqlquery(query);
        con.Open();
        SqlDataReader thereader;
        thereader = cmd.ExecuteReader();
        thereader.Read();
        string returnname = "";
        if (thereader.HasRows)
        {
            returnname = thereader["name"].ToString();
        }
        con.Close();
        return returnname;
    }
    public void updateCharName(string id, string name)
    {
        modOuter o = new modOuter();
        int charid = o.getCharId(id);
        string query = "UPDATE characters SET name ='" + name + "' WHERE id='" + charid + "' and death is NULL;";
        SqlCommand cmd = sqlquery(query);
        con.Open();
        int resutl = cmd.ExecuteNonQuery();
        con.Close();
    }
    public string getCharJob(string id)
    {
        modOuter m = new modOuter();
        int charid = m.getCharId(id);
        string returnstring;
        string query = "Select Name from oldLife";
        SqlCommand cmd = sqlquery(query);
        con.Open();
        SqlDataReader thereader;
        thereader = cmd.ExecuteReader();
        thereader.Read();
        returnrating = int.Parse(thereader["rating"].ToString());
        con.Close();
        return returnrating;
    }
}