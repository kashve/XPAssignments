using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections;

namespace UTSprint
{
    public class UserAccountCreation
    {
        public static Hashtable UserCredentials = new Hashtable();

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
                throw new ArgumentNullException(username, "Username should be characters only");
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
            throw new ArgumentNullException(password, "Password should be of minimum 6 characters length with 1 Alphabet and 1 Integer");

        }


    }
}