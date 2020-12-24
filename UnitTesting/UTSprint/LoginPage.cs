using System;
using System.Text.RegularExpressions;
using System.Collections;

namespace UTSprint
{
    public class LoginPage
    {
    public LoginPage(UserAccountCreation objusercreation)
    {
       this.useraccountcreation = objusercreation;
    }
       UserAccountCreation useraccountcreation;
       public string UserLogin(string username, string password)
        {
            if (useraccountcreation.UserCredentials.ContainsKey(username))
            {
                if ((String)useraccountcreation.UserCredentials[username] == password)
                {
                    return ("Login is successful");
                }
                else
                {
                    return ("Login has failed as password mismatches");
                }
            }
            else
            {
                return ("Login has failed as account doesnot exist");
            }
        }


    } 
}