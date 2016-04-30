using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for job
/// </summary>
public class jobInfo
{
    private int jobStrength;
    private int jobCraft;
    private int jobFate;
    private int jobLife;
    private string jobAlignment;
    private int jobStartArea;
    string jobName;
    public jobInfo(string jobID)
    {
        job job = new job();
        string[] rstring = job.jobDefaults(jobID).Split(';');
        jobStrength = int.Parse(rstring[0]);
        jobCraft = int.Parse(rstring[1]);
        jobFate = int.Parse(rstring[2]);
        jobLife = int.Parse(rstring[3]);
        jobAlignment = rstring[4];
        jobStartArea = int.Parse(rstring[5]);
        jobName = rstring[6];
    }
    public int strength
    {
        get
        {
            return jobStrength;
        }
    }
    public int craft
    {
        get
        {
            return jobCraft;
        }
    }
    public int fate
    {
        get
        {
            return jobFate;
        }
    }
    public int life
    {
        get
        {
            return jobLife;
        }
    }
    public string alignment
    {
        get
        {
            return jobAlignment;
        }
    }
    public int startArea
    {
        get
        {
            return jobStartArea;
        }
    }
    public string name
    {
        get
        {
            return jobName;
        }
    }
}