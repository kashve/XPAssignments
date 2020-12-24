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
            UserAccountCreation useraccountcreation = new UserAccountCreation();
            useraccountcreation.UserCredentials.Add("Kashve", "ABC456");
            var loginPage = new LoginPage(useraccountcreation);

            //Act

            var expectedresult = loginPage.UserLogin("Kashve", "DEF789");

            //Assert

            Assert.AreEqual("Login has failed as password mismatches", expectedresult);

        }
        // User Login Validation - Test Case 2
        [Test]
        public void ShouldReturnSuccessMessageWhenCredentialsMatch()
        {

            //Arrange
            UserAccountCreation useraccountcreation = new UserAccountCreation();
            useraccountcreation.UserCredentials.Add("Kashve", "ABC456");
            var loginPage = new LoginPage(useraccountcreation);

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
            UserAccountCreation useraccountcreation = new UserAccountCreation();
            useraccountcreation.UserCredentials.Add("Kashve", "ABC456");
            var loginPage = new LoginPage(useraccountcreation);

            //Act

            var expectedresult = loginPage.UserLogin("Kashve", "ABC45");

            //Assert

            Assert.AreEqual("Login has failed as password mismatches", expectedresult);

        }

       
    }
}