using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace TDDAuthenticationSprint
{
    public class CreateAccount
    {
        public Dictionary<string, string> dic = new Dictionary<string, string>();
        public Dictionary<string, string> GetUserInfo
        {
            get { return dic; }
            set { dic = value; }
        }

        public bool IsValidUser(string username)
        {
            if ((!string.IsNullOrEmpty(username)) && username.Length > 1 && username.Length < 11 && Regex.IsMatch(username, @"^[a-zA-Z]+$"))

            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsValidPassword(string password)
        {
            if (password.Length >= 8 && Regex.Match(password, @"^.*(?=.*[0-9]{2})(?=.*[a-zA-Z]{2}).*$").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string CreateUser(string username, string password)
        {
            if (IsValidUser(username) && IsValidPassword(password))

            {
                dic.Add(username, password);
                return "User Created Successfully";
            }
            else
            {
                return "User Creation Failed";
            }
        }


    }
}
