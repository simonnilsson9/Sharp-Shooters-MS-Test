using Sharp_Shooters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShooters.MSTest
{
    [TestClass]
    public class InitializeUsersTests
    {
        [TestMethod]
        public void Test_InitializeUser_CreatesCorrectNumberOfUsers_Return_4()
        {            
            List<User> users = Admin.InitializeUser();
            var expectedUsers = 4;
            var result = users.Count;

            Assert.AreEqual(expectedUsers, result);
        }

        [TestMethod]
        public void Test_InitializeUser_UsersHaveCorrectUsernameAndPinCode()
        {
            List<User> users = Admin.InitializeUser();

            // Assert
            Assert.AreEqual("theo", users[0].UserName);
            Assert.AreEqual(1111, users[0].PinCode);

            Assert.AreEqual("eddie", users[1].UserName);
            Assert.AreEqual(2222, users[1].PinCode);

            Assert.AreEqual("torbjorn", users[2].UserName);
            Assert.AreEqual(3333, users[2].PinCode);

            Assert.AreEqual("simon", users[3].UserName);
            Assert.AreEqual(4444, users[3].PinCode);
        }
    }
}
