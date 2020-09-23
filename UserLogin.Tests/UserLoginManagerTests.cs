using System;
using System.Collections.Generic;
using Xunit;

namespace UserLogin.Tests
{
    /*
        Test UserLoginManager for the following.

        1: Password must have a letter and a diget(number).
        2: Username is unique(only one).
        3: Can only login with a excisting user and there password must match.

        side note - TDD - Test Driven Dev
    */
    public class UserLoginManagerTests
    {
        [Fact]// tells xUnit its a test
        public void TestTemplate()
        {
            //Arrange - preper whats needed to do the test


            //Act - run method that we are testing 


            //Assert - did it do what its supposed to do
            
        }
        


        [Fact]// tells xUnit its a test
        public void ValidPassword()
        {
            //Arrange - preper whats needed to do the test
            UserLoginManager manager = new UserLoginManager();
            string goodPassword = "password123";

            //Act - run method that we are testing 
            bool result = manager.ValidatePassword(goodPassword);

            //Assert - did it do what its supposed to do
            Assert.True(result);
        }

        [Fact]// tells xUnit its a test
        public void OnlyLettersPassword()
        {
            //Arrange - preper whats needed to do the test
            UserLoginManager manager = new UserLoginManager();
            string onlyLetters = "badPassword";

            //Act - run method that we are testing 
            bool result = manager.ValidatePassword(onlyLetters);

            //Assert - did it do what its supposed to do
            Assert.False(result);
        }

        [Fact]// tells xUnit its a test
        public void OnlyDigietsPassword()
        {
            //Arrange - preper whats needed to do the test
            UserLoginManager manager = new UserLoginManager();
            string onlyDigits = "123";

            //Act - run method that we are testing 
            bool result = manager.ValidatePassword(onlyDigits);

            //Assert - did it do what its supposed to do
            Assert.False(result);
        }

        [Fact]// tells xUnit its a test
        public void OnlySymbolsPassword()
        {
            //Arrange - preper whats needed to do the test
            UserLoginManager manager = new UserLoginManager();
            string onlySymbols = "!@#$";

            bool result = manager.ValidatePassword(onlySymbols);

            //Assert - did it do what its supposed to do
            Assert.False(result);
        }

        [Fact]// tells xUnit its a test
        public void DefualtAmountOfUsers()
        {
            //Arrange - preper whats needed to do the test
            UserLoginManager manager = new UserLoginManager();
            int expected = 2;

            //Act - run method that we are testing 
            int actual = manager.UserCount();

            //Assert - did it do what its supposed to do
            Assert.Equal(expected, actual);
        }

        [Fact]// tells xUnit its a test
        public void EmptyUserList()
        {
            //Arrange - preper whats needed to do the test
            UserLoginManager manager = new UserLoginManager( new Dictionary<string,string>() );
            int expected = 0;

            //Act - run method that we are testing 
            int actual = manager.UserCount();

            //Assert - did it do what its supposed to do
            Assert.Equal(expected, actual);
        }

    }
}
