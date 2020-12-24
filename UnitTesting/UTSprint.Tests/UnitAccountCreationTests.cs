using System;
using NUnit.Framework;
using UTSprint;

namespace UTSprint.Tests
{
    public class UnitAccountCreationTests
    {
       // User Account Creation - Test Case 1
       [Test]
        public void ShouldReturnFailureMessageWithInvalidUserName()
        {
            //Arrange
            var useraccountcreation = new UserAccountCreation();
            var username = "123";
            var password = "ABC456";

            //Act
            var result = useraccountcreation.UserCreation(username, password);

            //Assert
            Assert.AreEqual("Registration is a Failure", result);
        }

        [Test]
        public void ShouldReturnSuccessMessageWithValidCredentials()
        {

            //Arrange

            var useraccountcreation = new UserAccountCreation();
            var expectedusername = "Kashve";
            var expectedpassword = "ABC456";

            //Act

            var result = useraccountcreation.UserCreation(expectedusername, expectedpassword);

            //Assert

            Assert.AreEqual("Registration is a Success", result);

        }

        // User Login Validation - Test Case 4
        [Test]
        public void ShouldReturnFailureMessageWhenPasswordNotOfMinimumLengthof6()
        {

            //Arrange
            var useraccountcreation = new UserAccountCreation();
            var expectedusername = "Kashve";
            var expectedpassword = "ABC";

            //Act
            var result = useraccountcreation.UserCreation(expectedusername, expectedpassword);

            //Assert
            Assert.AreEqual("Registration is a Failure", result);
        }

        // User Account Creation - Test Case 5

        [Test]
        public void ShouldReturnFailureMessageWhenPasswordDoesNotAlphabets()
        {

            //Arrange
            var useraccountcreation = new UserAccountCreation();
            var expectedusername = "Kashve";
            var expectedpassword = "256789";

            //Act
            var result = useraccountcreation.UserCreation(expectedusername, expectedpassword);

            //Assert
            Assert.AreEqual("Registration is a Failure", result);
        }

        // User Account Creation - Test Case 6
        [Test]
        public void ShouldReturnFailureMessageWhenPasswordDoesNotContainInteger()
        {

            //Arrange
            var useraccountcreation = new UserAccountCreation();
            var expectedusername = "Kashve";
            var expectedpassword = "XYCVBH";

            //Act
            var result = useraccountcreation.UserCreation(expectedusername, expectedpassword);

            //Assert
            Assert.AreEqual("Registration is a Failure", result);
        }


    }
}