using System;
using NUnit.Framework;
using UTSprint;

namespace UTSprint.Tests
{
    public class LoginPageTests
    {
   
        [Test]
        public void ShouldReturnSucessMessage()
        {
             //Arrange
            var loginpage = new LoginPage();
            var expectedusername = "Kashve";
            var expectedpassword = "ABC456";

            //Act
            var result = loginpage.UserRegistration(expectedusername,expectedpassword);

            //Assert
            Assert.AreEqual("Registration is successful",result);
        }

        [Test]
        public void ShouldReturnFailureMessage()
        {
             //Arrange
            var loginpage = new LoginPage();
            var expectedusername = "!@#$%8";
            var expectedpassword = "ABC456";

            //Act
            var result = loginpage.UserRegistration(expectedusername,expectedpassword);

            //Assert
            Assert.AreEqual("Registration has failed",result);
        }

        [Test]
        public void ShouldReturnFailureWhenUserNameIsNull()
        {
            //Arrange
            var loginpage = new LoginPage();
            var expectedpassword = "ABC456";

            //Act
            var result = loginpage.UserRegistration(null,expectedpassword);

            //Assert
            Assert.AreEqual("Registration has failed",result);
            

        }

        [Test]
        public void ShouldReturnSuccessWhenCredentialsMatch()
        {
            //Arrange
            var loginpage = new LoginPage();
            var expectedusername = "Kashve";
            var expectedpassword = "ABC456";

            //Act
            var validresult = loginpage.ValidateUser(expectedusername,expectedpassword);

            //Assert
            Assert.AreEqual("Login is successful",validresult);
            

        }

        [Test]
        public void ShouldReturnFailureWhenCredentialsMismatch()
        {
            //Arrange
            var loginpage = new LoginPage();
            var expectedusername = "Kashve";
            var expectedpassword = "12ABC";

            //Act
            var validresult = loginpage.ValidateUser(expectedusername,expectedpassword);

            //Assert
            Assert.AreNotEqual("Login has failed",validresult);
            

        }

        [Test]
        public void ShouldReturnInvalidMessageWhenPasswordisnotofminimumlength()
        {
            //Arrange
            var loginpage = new LoginPage();
            var expectedpassword = "12ABC";

            //Act
            var validresult = loginpage.ValidatePassword(expectedpassword);

            //Assert
            Assert.AreEqual("Password should be of minimum 6 characters length with 1 Alphabet and 1 Integer",validresult);
            

        }
        [Test]
        public void ShouldReturnInvalidMessageWhenPassworddoesnotcontainalphabets()
        {
            //Arrange
            var loginpage = new LoginPage();
            var expectedpassword = "123456";

            //Act
            var validresult = loginpage.ValidatePassword(expectedpassword);

            //Assert
            Assert.AreEqual("Password should be of minimum 6 characters length with 1 Alphabet and 1 Integer",validresult);
            

        }

        [Test]
         public void ShouldReturnInvalidMessageWhenPassworddoesnotcontaininteger()
        {
            //Arrange
            var loginpage = new LoginPage();
            var expectedpassword = "ABCDEF#";

            //Act
            var validresult = loginpage.ValidatePassword(expectedpassword);

            //Assert
            Assert.AreEqual("Password should be of minimum 6 characters length with 1 Alphabet and 1 Integer",validresult);
            

        }
        
        [Test]
         public void ShouldReturnSuccessMessageWithValidPassword()
        {
            //Arrange
            var loginpage = new LoginPage();
            var expectedpassword = "ABCD123";

            //Act
            var validresult = loginpage.ValidatePassword(expectedpassword);

            //Assert
            Assert.AreEqual("Password is correct",validresult);
            

        }
    }
}