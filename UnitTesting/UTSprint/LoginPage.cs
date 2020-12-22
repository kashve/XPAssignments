using System;
using System.Text.RegularExpressions;
using System.Collections;

namespace UTSprint
{
    public class LoginPage
    {
        Hashtable UserCredentials;
        
        public LoginPage()
        {
            UserCredentials = new Hashtable();
            UserCredentials.Add("Kashve","ABC456");
        }

        public string UserRegistration(string username,string password)
        {
            if(!Regex.Match(username, "^[A-Z][a-zA-Z]*$").Success)  
            {
                throw new ArgumentNullException(username, "UserName should be characters only");
            }
            
            UserCredentials.Add(username,password);

            return("Registration is successful");
        }

        public string ValidateUser(string username,string password)
        {  
            foreach(DictionaryEntry de in UserCredentials)
            {
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            }
            if(UserCredentials.ContainsKey(username))
            {
                if((String) UserCredentials[username] == password)
                {
                    return("Login is successful");
                }
                else
                {
                    return("Login has failed");
                }
            }
            else
            {
                return("Login has failed");
            }

        }
    } 
}