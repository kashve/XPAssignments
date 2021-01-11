using NUnit.Framework;
using TDDAuthenticationSprint;
namespace TDDAuthentication.Tests
{
    public class LoginPageTest
    {  
        [Test]
        public void ShouldReturnSuccessMessagewithvalidusernameandpassword()
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.dic.Add("KashveTrisal", "34514");

            LoginPage loginpage = new LoginPage(createAccount);
            string result = loginpage.UserLogin("KashveTrisal", "34514");

            Assert.AreEqual("User Logged in successfully", result);
        }
        [Test]
        public void ShouldReturnFailureMessagewithinvalidusername()
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.dic.Add("KashveTrisal", "34514");

            LoginPage loginpage = new LoginPage(createAccount);
            string result = loginpage.UserLogin("KashvABC", "34514");
            Assert.AreEqual("Login failed. Invalid username", result);
        }
        [Test]        
         public void ShouldReturnFailureMessagewithinvalidpassword()
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.dic.Add("KashveTrisal", "34514");

            LoginPage loginpage = new LoginPage(createAccount);
            string result = loginpage.UserLogin("KashveTrisal", "78910");
            Assert.AreEqual("Login failed. Invalid password", result);
        }
        [Test]        
         public void ShouldReturnFailureMessagewithemptydpassword()
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.dic.Add("KashveTrisal", "34514");

            LoginPage loginpage = new LoginPage(createAccount);
            string result = loginpage.UserLogin("KashveTrisal", "");
            Assert.AreEqual("Login failed. Invalid password", result);
        }
        [Test]        
         public void ShouldReturnFailureMessagewithdpasswordasnull()
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.dic.Add("KashveTrisal", "34514");

            LoginPage loginpage = new LoginPage(createAccount);
            string result = loginpage.UserLogin("KashveTrisal",null);
            Assert.AreEqual("Login failed. Invalid password", result);
        }
    }
}