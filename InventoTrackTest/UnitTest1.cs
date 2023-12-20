using Microsoft.VisualStudio.TestTools.UnitTesting;
using InventoTrack;

namespace InventoTrackTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoginSuccess()
        {
            // Arrange
            //Users usertest = new Users(1, "test1", "test1@gmail.com", "test1");
            string username = "test1";
            string password = "test1";
            // Act
            bool result = Users.checkUserLogin(username, password);
           // bool expected = true;

            // Assert

            Assert.IsTrue(result, "Login should be successful");
        }

        public void TestLoginFailure()
        {
        }

        public void SaveTwoSameItems()
        {
        }
    }
}