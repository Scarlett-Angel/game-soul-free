using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for location
/// </summary>
public class location
{
    private string nme;
    private string descript;
    public location(int locationID)
    {
        loc loc = new loc();
        string[] locString = loc.getlocationDetails(locationID).Split(';');
        nme = locString[0];
        descript  = locString[1];
    }
    public string name
    {
        get
        {
            return nme;
        }
    }
    public string description
    {
        get
        {
            return descript;
        }
    }
}