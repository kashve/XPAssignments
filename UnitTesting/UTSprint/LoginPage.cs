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
       
        public string ValidatePassword(string password)
        {
            int minimumlength =  6 ;
            if(password.Length >=minimumlength)
            {
                if(Regex.Match(password, @"^.(?=.*\d)(?=.*[a-zA-Z])[A-Z].*$").Success)
                {
                    return("Password is correct");
                }
                else 
                {
                    return("Password should be of minimum 6 characters length with 1 Alphabet and 1 Integer");
                }
            }
            return("Password should be of minimum 6 characters length with 1 Alphabet and 1 Integer");
        }

    } 
}