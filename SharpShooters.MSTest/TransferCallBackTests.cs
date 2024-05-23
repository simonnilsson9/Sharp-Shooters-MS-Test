using Sharp_Shooters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShooters.MSTest
{
    [TestClass]
    public class TransferCallBackTests
    {
        [TestMethod]
        public void Test_TransferCallback_Return_CorrectBalance()
        {
            // Arrange
            var sourceAccount = new Accounts("Account1", 1000, "USD", "$");
            var destinationAccount = new Accounts("Account2", 500, "USD", "$");
            var loggedInUser = new User("User1", 1234, new List<Accounts> { sourceAccount }, new List<string>(), 0);
            var recipientUser = new User("User2", 5678, new List<Accounts> { destinationAccount }, new List<string>(), 0);

            var transferData = new TransferData(loggedInUser, sourceAccount, recipientUser, destinationAccount, 200);

            // Act
            TransferData.TransferCallback(transferData);

            // Assert
            Assert.AreEqual(800, sourceAccount.AccountBalance);
            Assert.AreEqual(700, destinationAccount.AccountBalance);
            Assert.IsTrue(loggedInUser.Transactions[0].Contains("Transfer of 200 $ to USER2's Account2"));
            Assert.IsTrue(recipientUser.Transactions[0].Contains("You received 200 $ to your Account2 from USER1"));

        }        

        [TestMethod]
        public void Test_TransferCallback_InvalidAmount_Return_NoTransfer()
        {
            // Arrange
            var sourceAccount = new Accounts("Account1", 1000, "USD", "$");
            var destinationAccount = new Accounts("Account2", 500, "USD", "$");
            var loggedInUser = new User("User1", 1234, new List<Accounts> { sourceAccount }, new List<string>(), 0);
            var recipientUser = new User("User2", 5678, new List<Accounts> { destinationAccount }, new List<string>(), 0);
           
            var invalidAmount = -200; 
            var transferData = new TransferData(loggedInUser, sourceAccount, recipientUser, destinationAccount, invalidAmount);
            
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw); // Omdirigera standard output

                //Act
                TransferData.TransferCallback(transferData);

                var expectedOutput = "Invalid input. Please enter a valid amount...";
                var result = sw.ToString().Trim(); // Hämta och trimma output-strängen
                
                //Assert
                Assert.AreEqual(expectedOutput, result); // Jämför output med förväntat resultat
                Assert.AreEqual(1000, sourceAccount.AccountBalance);
                Assert.AreEqual(500, destinationAccount.AccountBalance);
            }                        
        }
    }
}
