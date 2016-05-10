using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for play
/// </summary>
static public class play
{
    private static Random rnd = new Random();
    static public int roll(int numberofDice)
    {
        
        int max = numberofDice * 6 +1;
        int returnInt = rnd.Next(1, max);
        return returnInt;
    }
    static public bool fightCraft(int charCraft , int enemyCraft)
    {
        int playerScore = charCraft + roll(1);
        int enemyScore = enemyCraft + roll(1);
        if ( playerScore > enemyScore)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static public string testfight(int charCraft, int enemyCraft)
    {
        int playerScore = charCraft + roll(1);
        int enemyScore = enemyCraft + roll(1);
        return playerScore + " " + enemyScore;
    }
}