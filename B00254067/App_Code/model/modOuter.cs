using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
/// <summary>
/// Summary description for modOuter
/// </summary>
public class modOuter
{
    SqlConnection con = new SqlConnection();
    public modOuter()
    {
        con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\project\\game-soul-free\\B00254067\\App_Data\\Database.mdf;Integrated Security=True";
    }
    private SqlCommand sqlquery(string query)
    {
        SqlCommand thequery = new SqlCommand(query, con);
        return thequery;
    }
    SqlDataReader thereader;
    //verify user password is correct
    public int VerifyUser(string username, string password)
    {
        string query = "SELECT COUNT(*) as result FROM users WHERE username='" + username + "' AND pw='" + password + "';";
        int countusers;
        SqlCommand cmd = sqlquery(query);
        con.Open();
        thereader = cmd.ExecuteReader();
        thereader.Read();
        countusers = int.Parse(thereader["result"].ToString());
        con.Close();
        return countusers;
    }

    public int userHasliveCharacter(string username)
    {
        int count;
        string query = "SELECT COUNT(*) as result FROM (SELECT users.username , characters.id, characters.death from users INNER JOIN characters on users.id = characters.userid WHERE username = '"+username+"' AND death is null) temptable;";
        SqlCommand cmd = sqlquery(query);
        con.Open();
        thereader = cmd.ExecuteReader();
        thereader.Read();
        count = int.Parse(thereader["result"].ToString());
        con.Close();
        return count;
    }
    public bool NewUser(string email, string username, string password)
    {
        string query = "INSERT INTO users (email, username, pw) VALUES ('" + email + "','" + username + "','" + password + "')";
        SqlCommand cmd = sqlquery(query);
        con.Open();
        int resutl = cmd.ExecuteNonQuery();
        con.Close();
        return true;
    }
    public void runsqlquery(string query)
    {
        SqlCommand cmd = sqlquery(query);
        con.Open();
        int resutl = cmd.ExecuteNonQuery();
        con.Close();
    }
    public void createCharacter(string characterName, string id, string job)
    {
        int charId;
        Random rnd = new Random();

        string themoney = rnd.Next(1, 6).ToString();
        string query = "INSERT INTO characters ( name, userid, strength, craft, fate, money, life, Alignment, oldlife, area) VALUES ('" + characterName + "','" + id + "', (SELECT Strength from oldLife WHERE Id = '" + job + "'),(SELECT craft from oldLife WHERE Id = '" + job + "'),(SELECT luck from oldLife WHERE Id = '" + job + "'),'"+themoney+ "', (SELECT life from oldLife WHERE Id = '" + job + "'),(SELECT aligment from oldLife WHERE Id = '" + job + "'),'"+job+ "', (SELECT start from oldLife WHERE Id = '" + job + "'));";

        SqlCommand cmd = sqlquery(query);
        con.Open();
        int resutl = cmd.ExecuteNonQuery();
        con.Close();
        charId = getCharId(id);
        query = "INSERT INTO character_levels (characterid, levelid, rating, progression, inc) VALUES ('" + charId + "', '1', '1','1','1'); INSERT INTO character_skills(characterid, skillid, value) VALUES ('" + charId + "','1','1'); INSERT INTO character_skills(characterid, skillid, value) VALUES ('" + charId + "','2','1'); INSERT INTO character_skills(characterid, skillid, value) VALUES ('" + charId + "','3','1'); INSERT INTO character_skills(characterid, skillid, value) VALUES ('" + charId + "','4','1');";
        cmd = sqlquery(query);
        con.Open();
        resutl = cmd.ExecuteNonQuery();
        con.Close();
    }
    public int getCharId(string id)
    {
        int returnid;
        string query = "Select id from characters where userid ='" + id + "' and death is NULL;";
        SqlCommand cmd = sqlquery(query);
        con.Open();
        SqlDataReader thereader;
        thereader = cmd.ExecuteReader();
        thereader.Read();
        if (thereader.HasRows)
        
            returnid = int.Parse(thereader["id"].ToString());
      
        returnid = int.Parse(thereader["id"].ToString());
        con.Close();
        return returnid;

    }

}