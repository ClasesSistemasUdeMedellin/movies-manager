using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManager.Model.Tests
{
    [TestClass]
    public class MoviesManagerTests
    {
        [TestMethod]
        public void Authenticate_User_With_Correct_Credentials()
        {
            // Arrange
            string username = "cursoapoo";
            string password = "apoo20222";
            string name = "Chucho";
            string email = "jehincapie@udemedellin.edu.co";
            User user = new User(username, name, email, password);

            // Act
            user.Authenticate();

            // Assert
            Assert.IsTrue(user.IsAuthenticated);
        }

        [TestMethod]
        public void Authenticate_User_With_InCorrect_Credentials_Throws()
        {
            // Arrange
            string username = "user";
            string password = "pass";
            string name = "Chucho";
            string email = "jehincapie@udemedellin.edu.co";
            User user = new User(username, name, email, password);

            // Act and assert
            Assert.ThrowsException<Exception>(() => user.Authenticate());
        }
    }
}