using System;
using NUnit.Framework;
using UTSprint;

namespace UTSprint.Tests
{
    public class LoginPageTests
    {
        // User Login Validation - Test Case 1
        [Test]
        public void ShouldReturnFailureMessageWhenCredentialsMismatch()
        {

            //Arrange

            UserAccountCreation.UserCredentials.Add("Kashve", "ABC456");
            var loginPage = new LoginPage();

            //Act

            var expectedresult = loginPage.UserLogin("Kashve", "DEF789");

            //Assert

            Assert.AreNotEqual("Login has failed as password mismatches", expectedresult);

        }
        // User Login Validation - Test Case 2
        [Test]
        public void ShouldReturnSuccessMessageWhenCredentialsMatch()
        {

            //Arrange

            UserAccountCreation.UserCredentials.Add("Kashve", "ABC456");
            var loginPage = new LoginPage();

            //Act

            var expectedresult = loginPage.UserLogin("Kashve", "ABC456");

            //Assert

            Assert.AreEqual("Login is successful", expectedresult);

        }
        // User Login Validation - Test Case 3
        [Test]
        public void ShouldReturnFailureMessageWhenPasswordNotOfMinimumLength()
        {

            //Arrange

            UserAccountCreation.UserCredentials.Add("Kashve", "ABC456");
            var loginPage = new LoginPage();

            //Act

            var expectedresult = loginPage.UserLogin("Kashve", "ABC45");

            //Assert

            Assert.AreEqual("Password should be of minimum 6 characters length with 1 Alphabet and 1 Integer", expectedresult);

        }

       
    }
}