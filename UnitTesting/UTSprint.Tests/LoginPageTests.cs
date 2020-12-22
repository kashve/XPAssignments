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
    }
}