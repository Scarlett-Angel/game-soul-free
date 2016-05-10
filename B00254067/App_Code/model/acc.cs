using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

/// <summary>
/// Handles all database queries relating to a users account
/// </summary>
public class acc
{
    public int verUserPassword(string username, string password)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "SELECT COUNT(*) as result FROM users WHERE username='" + username + "' AND pw='" + password + "';";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        int count = int.Parse(rdr["result"].ToString());
        con.Close();
        return count;
    }
    public string getAccountID(string username)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "Select id from users where username='" + username + "';";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        string returnstring = rdr["id"].ToString();
        con.Close();
        return returnstring;
    }
    public int userHasLiveCharacter(string username)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "SELECT COUNT(*) as result FROM (SELECT users.username , characters.id, characters.death from users INNER JOIN characters on users.id = characters.userid WHERE username = '" + username + "' AND death is null) temptable;";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        int count = int.Parse(rdr["result"].ToString());
        con.Close();
        return count;
    }
    public void newUserAccount(string username, string password, string email)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = db.con();
        string query = "INSERT INTO users (email, username, pw) VALUES ('" + email + "','" + username + "','" + password + "')";
        cmd = db.query(query, con);
        con.Open();
        int e = cmd.ExecuteNonQuery();
        con.Close();
    }
    public void createCharacter(string username, string characterName, string id, string job, string strength, string craft, string fate, string life, string alignment, string startArea, string money)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = db.con();
        string query = "INSERT INTO characters ( name, userid, strength, craft, fate, money, life, Alignment, oldlife, area) VALUES ('" + characterName + "'," + id + ", "+strength +","+craft+","+fate+"," + money + ", "+life+",'"+alignment +"'," + job + ","+startArea +");";
        cmd = db.query(query, con);
        con.Open();
        int e = cmd.ExecuteNonQuery();
        con.Close();
        account account = new account(username);
        query = "INSERT INTO character_levels (characterid, levelid, rating, progression, inc) VALUES ('" +account.characterID  +"', '1', '1','1','1'); INSERT INTO character_skills(characterid, skillid, value) VALUES ('" + account.characterID + "','1','1'); INSERT INTO character_skills(characterid, skillid, value) VALUES ('" + account.characterID + "','2','1'); INSERT INTO character_skills(characterid, skillid, value) VALUES ('" + account.characterID + "','3','1'); INSERT INTO character_skills(characterid, skillid, value) VALUES ('" + account.characterID + "','4','1');";
        con.Open();
        cmd = db.query(query, con);
        e = cmd.ExecuteNonQuery();
        con.Close();
        query = "INSERT INTO gamestate (accID, state, roll) VALUES ('" + account.accountID  + "', '1', '0');";
        con.Open();
        cmd = db.query(query, con);
        e = cmd.ExecuteNonQuery();
        con.Close();
    }
    public string getCharID(string accID)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "Select id from characters where userid ='" + accID + "' and death is NULL;";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        string rstring = rdr["id"].ToString();
        con.Close();
        return rstring;
    }
    public string getCharName(string accID)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "Select name from characters where userid ='" + accID + "' and death is NULL;";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        string rstring = rdr["name"].ToString();
        con.Close();
        return rstring;
    }
    public int ableToLevelUp(string charID)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "Select Count(*) as value from character_levels where characterid='" + charID + "' AND rating <= progression;";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        int count = int.Parse(rdr["value"].ToString());
        con.Close();
        return count;
    }
    public string getskillrating(string charID, string skillID)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "Select value from character_skills where characterid ='" + charID + "' and skillid='" + skillID + "';";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        string returnstring;
        if (rdr.HasRows)
        {
            returnstring = rdr["value"].ToString();
        }
        else
        {
            returnstring = "";
        }
        con.Close();
        return returnstring;
    }
    public int getCharLevel(string charID)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "Select rating from character_levels where characterid ='" + charID + "' AND levelid ='1';";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        int count = int.Parse(rdr["rating"].ToString());
        con.Close();
        return count;
    }
    public void levelUpSkill(string charid, string sid)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "SELECT COUNT(*) as result FROM character_skills WHERE characterid='" + charid + "' AND skillid='" + sid + "';";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        int count = int.Parse(rdr["result"].ToString());
        con.Close();
        if (count > 0)
        {
            query = "UPDATE character_skills SET value = value + 1 WHERE characterid='" + charid + "' AND skillid='" + sid + "';";
            cmd = db.query(query, con);
            con.Open();
            int erd = cmd.ExecuteNonQuery();
            con.Close();
        }
        else
        {
            query = "INSERT INTO character_skills (characterid, skillid, value) VALUES ('" + charid + "','" + sid + "', '1');";
            cmd = db.query(query, con);
            con.Open();
            int erd = cmd.ExecuteNonQuery();
            con.Close();
        }
        query = "UPDATE character_levels SET rating = rating + inc WHERE characterid='" + charid + "' AND levelid='" + 1 + "';UPDATE character_levels SET inc = inc + 1 WHERE characterid='" + charid + "' AND levelid='" + 1 + "';";
        cmd = db.query(query, con);
        con.Open();
        int e = cmd.ExecuteNonQuery();
        con.Close();
    }
    public void updateCharName(string charid, string name)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = db.con();
        string query = "UPDATE characters SET name ='" + name + "' WHERE id='" + charid + "' and death is NULL;";
        cmd = db.query(query, con);
        con.Open();
        int erd = cmd.ExecuteNonQuery();
        con.Close();
    }
    public string getJobName(string charID)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "Select oldlife from characters where id ='" + charID + "';";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        string rstring = rdr["oldlife"].ToString();
        con.Close();
        query = "Select name from oldLife where id ='" + rstring + "';";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        string rstring2 = rdr["name"].ToString();
        con.Close();
        return rstring2;
    }
    public string getCharStats(string charID)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "Select * from characters WHERE Id = '" + charID + "';";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        string returnstring = rdr["strength"].ToString() + ";" + rdr["craft"].ToString() + ";" + rdr["fate"].ToString() + ";" + rdr["money"].ToString() + ";" + rdr["life"].ToString() + ";" + rdr["Alignment"].ToString() + ";" + rdr["oldlife"] + ";" + rdr["area"].ToString();
        con.Close();
        return returnstring;
    }
    public string getPlayState(string charID)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "Select * from gamestate WHERE accID = '" + charID + "';";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        string returnstring = rdr["roll"].ToString() + ";" + rdr["state"].ToString();
        con.Close();
        return returnstring;
    }
    public void setPlayState(int state, int roll, int accID)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = db.con();
        string query = "UPDATE gamestate SET roll = "+ roll + ", state = '" + state + "' WHERE accID=" + accID + ";";
        cmd = db.query(query, con);
        con.Open();
        int erd = cmd.ExecuteNonQuery();
        con.Close();
    }
    public void increaseStrength(int charID, int increase)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = db.con();
        string query = "UPDATE characters SET strength = strength + " + increase + " WHERE id = " + charID + ";";
        cmd = db.query(query, con);
        con.Open();
        int erd = cmd.ExecuteNonQuery();
        con.Close();
    }
    public void decreaseLife(int charID, int ammount)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = db.con();
        string query = "UPDATE characters SET life = life - " + ammount  + " WHERE id = " + charID + ";";
        cmd = db.query(query, con);
        con.Open();
        int erd = cmd.ExecuteNonQuery();
        con.Close();
    }
    public void setLocation(string charID, int location)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = db.con();
        string query = "UPDATE characters SET area = " + location + " WHERE id = " + charID + ";";
        cmd = db.query(query, con);
        con.Open();
        int erd = cmd.ExecuteNonQuery();
        con.Close();
    }

}