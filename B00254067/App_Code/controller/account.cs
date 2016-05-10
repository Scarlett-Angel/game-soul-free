using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;
/// <summary>
/// Summary description for account
/// </summary>
public class account
{
    private string accID;
    private bool liveChar;
    private string uploadDirectory;
    private string charID;
    private string charName;
    private string usernm;
    private int strngth = -1;
    private int crft = -1;
    private int lck = -1;
    private int mney = -1;
    private int lfe = -1;
    private string algnment;
    private int roll = -1;
    private int state = -1;
    private int areaID = -1;
    private int jbID = -1;
    public account(string username)
    {
        usernm = username;
        acc acc = new acc();
        accID = acc.getAccountID(username);
        if (acc.userHasLiveCharacter(username) > 0)
        {
            liveChar = true;
            charID = acc.getCharID(accID);
        }
        else
        {
            liveChar = false;
        }
    }
    public string characterName
    {
        get
        {
            
            if (string.IsNullOrEmpty(charName))
            {
                acc acc = new acc();
                charName = acc.getCharName(accID);
                return charName;
            }
            else
            {
                return charName;
            }

        }
    }
    public string accountID
    {
        get
        {
            return accID;
        }
    }
    public bool userHasLiveCharacter
    {
        get
        {
            return liveChar;
        }
    }
    public string characterID
    {
       get
        {

            return charID;
        }
           
     
    }
    public void createCharacter(string name, string job)
    {
        jobInfo j = new jobInfo(job);
        acc acc = new acc();
        Random rnd = new Random();
        int money = rnd.Next(1, 6);
        acc.createCharacter(usernm,name, accID, job, j.strength.ToString(), j.craft.ToString(),j.fate.ToString(), j.life.ToString(), j.alignment.ToString(), j.startArea.ToString(), money.ToString());
    }
    public string getUploadDirectory
    {
        get
            {
            
            if (string.IsNullOrEmpty(charID))
            {
                acc acc = new acc();
                charID = acc.getCharID(accID);
            }
            string directory = "Uploads\\" + accID + "\\" + charID;
            return directory;
        }
    }
    public bool ableToLevelUp
    {
        get
        {
            acc acc = new acc();
            if (acc.ableToLevelUp(charID) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public string getskillrating(string sid)
    {
        acc acc = new acc();
        string returnstring = acc.getskillrating(charID, sid);
        if (string.IsNullOrWhiteSpace(returnstring))
        {
            return "0";
        }
        else
        {
            return returnstring;
        }
    }
    public int getCharacterLevel
    {
        get
        {
            acc acc = new acc();
            int count = acc.getCharLevel(charID);
            return count;
        }
    }
    public void levelUpSkill(string sid)
    {
        acc acc = new acc();
        acc.levelUpSkill(charID, sid);
    }
    public string username
    {
        get
        {
            return usernm;
        }
    }
    public void changeCharname(string name)
    {
        acc acc = new acc();
        acc.updateCharName(charID, name);
    }
    public int strength
    {
        get
        {
            if(strngth < 0)
            {
                getStats();
                return strngth;
            }
            else
            {
                return strngth;
            }
        }
    }
    public int craft
    {
        get
        {
            if (crft < 0)
            {
                getStats();
                return crft;
            }
            else
            {
                return crft;
            }
        }
    }
    public int luck
    {
        get
        {
            if (lck < 0)
            {
                getStats();
                return lck;
            }
            else
            {
                return lck;
            }
        }
    }
    public int money
    {
        get
        {
            if (mney  < 0)
            {
                getStats();
                return mney;
            }
            else
            {
                return mney;
            }
        }
    }
    public int life
    {
        get
        {
            if (lfe < 0)
            {
                getStats();
                return lfe;
            }
            else
            {
                return lfe;
            }
        }
    }
    public string alignment
    {
        get
        {
            if (string.IsNullOrEmpty(algnment))
            {
                getStats();
                return algnment;
            }
            else
            {
                return algnment;
            }
        }
    }
    private void getStats()
    {
        acc acc = new acc();
        string[] statstring = acc.getCharStats(charID).Split(';');
        strngth = int.Parse(statstring[0]);
        crft  = int.Parse(statstring[1]);
        lck  = int.Parse(statstring[2]);
        mney = int.Parse(statstring[3]);
        lfe = int.Parse(statstring[4]);
        algnment  = statstring[5];
        jbID = int.Parse(statstring[6]);
        areaID = int.Parse(statstring[7]);
    }
    public int jobID
    {
        get
        {
            if(jbID == -1)
            {
                getStats();
                return jbID;
            }
            else
            {
                return jbID;
            }
        }
    }
    public int locationID
    {
        get
        {
            if (areaID == -1)
            {
                getStats();
                return areaID;
            }
            else
            {
                return areaID;
            }
        }
        
    }
private void getPlayState()
    {
        acc acc = new acc();
        string[] statestring = acc.getPlayState(accID).Split(';');
        roll = int.Parse(statestring[0]);
        state = int.Parse(statestring[1]);
    }
    public int rollState
    {
        get
        {
            if (roll == -1)
            {
                getPlayState();
                return roll;
            }
            else return roll;
        }
    }
    public int playState
    {
        get
        {
            if (state == -1)
            {
                getPlayState();
                return state;
            }
            else return state;
        }
    }
    public void setPlayState(int roll, int state)
    {
        acc acc = new acc();
        acc.setPlayState(state, roll, int.Parse(accID));
    }
    public void increasteStrength(int increase)
    {
        acc acc = new acc();
        acc.increaseStrength(int.Parse (charID), increase);
    }
    public void decreaseLife(int decrease)
    {
        acc acc = new acc();
        acc.decreaseLife(int.Parse(charID), decrease);
    }
    public void setLocation(int location)
    {
        acc acc = new acc();
        acc.setLocation(charID, location);
    }
}