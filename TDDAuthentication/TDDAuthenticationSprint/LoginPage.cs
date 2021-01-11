namespace TDDAuthenticationSprint
{
    public class LoginPage
    {
        public LoginPage(CreateAccount createAccount)
        {
            this.CreateAccount = createAccount;
        }
        CreateAccount CreateAccount;

        public string UserLogin(string username, string password)
        {
          if (CreateAccount.GetUserInfo.ContainsKey(username))
            {
                if ((string)CreateAccount.GetUserInfo[username] == password)
                {
                    return "User Logged in successfully";
                }
                else
                {
                    return "Login failed. Invalid password";
                }
            }
            else
            {
                return "Login failed. Invalid username";
            }

        }
    }
}