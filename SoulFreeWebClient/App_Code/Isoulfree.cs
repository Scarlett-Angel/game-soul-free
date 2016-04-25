using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Isoulfree" in both code and config file together.
[ServiceContract]
public interface Isoulfree
{
    [OperationContract]
    int login(string username, string password);
    [OperationContract]
    string newAccount(string username, string email, string password);
    [OperationContract]
    void newCharacter(string charactername, string id);
    [OperationContract]
    int getAccountId(string username);
    [OperationContract]
    int getCharLevel(string id);
    [OperationContract]
    void sqlcommand(string query);
    [OperationContract]
    string getSkillLevel(string uid, string sid);
    [OperationContract]
    void levelUpSkill(string uid, string sid);
}
