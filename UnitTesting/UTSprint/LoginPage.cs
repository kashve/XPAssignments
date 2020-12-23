using System;
using System.Text.RegularExpressions;
using System.Collections;

namespace UTSprint
{
    public class LoginPage
    {
       public string UserLogin(string username, string password)
        {

            if (UserAccountCreation.UserCredentials.ContainsKey(username))
            {
                if ((String)UserAccountCreation.UserCredentials[username] == password)
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