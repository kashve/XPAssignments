using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections;

namespace UTSprint
{
    public class UserAccountCreation
    {
        public Hashtable UserCredentials = null;
        public UserAccountCreation()
        { 
            UserCredentials = new Hashtable();
        }

        public string UserCreation(string username, string password)
        {
            bool IsValidusername = Validateusername(username);
            bool IsValidpassword = Validatepassword(password);

            if (IsValidusername && IsValidpassword)
            {
                UserCredentials.Add(username, password);
                return ("Registration is a Success");
            }
            else
            {
                return ("Registration is a Failure");
            }
        }
        public bool Validateusername(string username)
        {
            
            if (!Regex.Match(username, "^[A-Z][a-zA-Z]*$").Success)
            {
               // throw new ArgumentNullException(username, "Username should be characters only");
               return false;
            }
            return true;

        }
        public bool Validatepassword(string password)
        {
            int minimumlength = 6;
            if (password.Length >= minimumlength)
            {
                if (Regex.Match(password, @"^.*(?=.*\d)(?=.*[a-zA-Z])[A-Z].*$").Success)
                {
                    return true;
                }
            }
              return false;
        }


    }
}