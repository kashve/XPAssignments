using NUnit.Framework;
using TDDAuthenticationSprint;

namespace TDDAuthentication.Tests
{
    public class CreateAccountTest
    {
        [Test]
        public void ShouldReturnSucessMessageWhenValidUserCredentials()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("Kashve", "AB345678");
               Assert.AreEqual("User Created Successfully", result);
       }
       [Test]        
       public void ShouldReturnFailureMessageWhenUsernamecontainsNonAlphabets()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("Kashve1456", "123456");
               Assert.AreEqual("User Creation Failed", result);
       }
       [Test]
        public void ShouldReturnSuccessMessageWhenValidUserNameLengthisgreaterthan1andlessthan11()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("KashveTris", "AB345678");
               Assert.AreEqual("User Created Successfully", result);
       }
        [Test]   
        public void ShouldReturnFailureMessageWhenUserNameLengthisgreaterthan11()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("KashveTrisss", "12345678");
               Assert.AreEqual("User Creation Failed", result);
       }
       [Test]   
        public void ShouldReturnFailureMessageWhenUserNameLengthislessthan1()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("", "12345678");
               Assert.AreEqual("User Creation Failed", result);
       }
       [Test]   
        public void ShouldReturnFailureMessageWhenUserNameisNull()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser(null, "12345678");
               Assert.AreEqual("User Creation Failed", result);
       }
       [Test]       
        public void ShouldReturnSucessMessageWhenValidPassword()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("KashveTris", "AB345678");
               Assert.AreEqual("User Created Successfully", result);
       }
       [Test]
        public void ShouldReturnFailureMessageWhenInValidPassword()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("KashveTris", "password");
               Assert.AreEqual("User Creation Failed", result);
       }
        [Test]
        public void ShouldReturnFailureMessageWhenInValidPasswordagain()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("KashveTris", "password1");
               Assert.AreEqual("User Creation Failed", result);
       }
       [Test]
        public void ShouldReturnFailureMessageWhenPasswordlessthan8()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("KashveTris", "123456");
               Assert.AreEqual("User Creation Failed", result);
       }
       [Test]
        public void ShouldReturnFailureMessageWhenPasswordoestnotcontainalphabets()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("KashveTris", "12345678");
               Assert.AreEqual("User Creation Failed", result);
       }
        [Test]
        public void ShouldReturnFailureMessageWhenPassworddoesnotcontainminimum2alphabets()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("KashveTris", "1234567A");
               Assert.AreEqual("User Creation Failed", result);
       }
       [Test]
        public void ShouldReturnSuccessMessageWhenPasswordcontainsminimum2alphabets()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("KashveTris", "AB345678");
               Assert.AreEqual("User Created Successfully", result);
       }
       [Test]
        public void ShouldReturnFailureMessageWhenPassworddoesnotcontainanyinteger()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("KashveTris", "ABCDEFGH");
               Assert.AreEqual("User Creation Failed", result);
       }
        [Test]
        public void ShouldReturnFailureMessageWhenPassworddoesnotcontainminimum2integers()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("KashveTris", "ABCDEFG1");
               Assert.AreEqual("User Creation Failed", result);
       }
       [Test]
        public void ShouldReturnSuccessMessageWhenPasswordcontainminimum2integers()
       {
               CreateAccount createAccount = new CreateAccount();
               string result = createAccount.CreateUser("KashveTris", "ABCDEF11");
               Assert.AreEqual("User Created Successfully", result);
       }
    }
}