using Sharp_Shooters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShooters.MSTest
{
    [TestClass]
    public class ExchangeRatesTests
    {
        
        [TestMethod]
        public void TestUsdToEuro_Return_Euro_ExRate()
        {
            //Arrange
            var fromAccount = new Accounts("USD Account", 1212, "USD", "$");
            var toAccount = new Accounts("Euro Account", 3434, "EURO", "€");

            //Act
            double result = Currency.GetExchangeRate(fromAccount, toAccount);

            //Assert
            Assert.AreEqual(0.93, result);
        }

        [TestMethod]
        public void TestUsdToKronor_Return_Kr_ExRate()
        {
            //Arrange
            var fromAccount = new Accounts("USD Account", 1212, "USD", "$");
            var toAccount = new Accounts("Kronor Account", 5656, "KRONOR", "kr");

            //Act
            double result = Currency.GetExchangeRate(fromAccount, toAccount);

            //Assert
            Assert.AreEqual(10.86, result);
        }

        [TestMethod]
        public void TestEuroToUsd_Return_Usd_ExRate()
        {
            //Arrange
            var fromAccount = new Accounts("Euro Account", 3434, "EURO", "€");
            var toAccount = new Accounts("USD Account", 1212, "USD", "$");

            //Act
            double result = Currency.GetExchangeRate(fromAccount, toAccount);

            //Assert
            Assert.AreEqual(1.07, result);
        }

        [TestMethod]
        public void TestEuroToKronor_Return_Kr_ExRate()
        {
            //Arrange
            var fromAccount = new Accounts("Euro Account", 3434, "EURO", "€");
            var toAccount = new Accounts("Kronor Account", 5656, "KRONOR", "kr");

            //Act
            double result = Currency.GetExchangeRate(fromAccount, toAccount);

            //Assert
            Assert.AreEqual(11.68, result);
        }

        [TestMethod]
        public void TestKronorToUsd_Return_Usd_ExRate()
        {
            //Arrange
            var fromAccount = new Accounts("Kronor Account", 5656, "KRONOR", "kr");
            var toAccount = new Accounts("USD Account", 1212, "USD", "$");

            //Act
            double result = Currency.GetExchangeRate(fromAccount, toAccount);

            //Assert
            Assert.AreEqual(0.10, result);
        }

        [TestMethod]
        public void TestKronorToEuro_Return_Euro_ExRate()
        {
            //Arrange
            var fromAccount = new Accounts("Kronor Account", 5656, "KRONOR", "kr");
            var toAccount = new Accounts("Euro Account", 3434, "EURO", "€");

            //Act
            double result = Currency.GetExchangeRate(fromAccount, toAccount);

            //Assert
            Assert.AreEqual(0.091, result);
        }

        [TestMethod]
        public void TestSameCurrency_Return_Same()
        {
            //Arrange
            var fromAccount = new Accounts("USD Account", 1212, "USD", "$");
            var toAccount = new Accounts("USD Account", 1212, "USD", "$");

            //Act
            double result = Currency.GetExchangeRate(fromAccount, toAccount);

            //Assert
            Assert.AreEqual(1.0, result);
        }

        [TestMethod]
        public void TestUnknownCurrency_Return_Same()
        {
            //Arrange
            var fromAccount = new Accounts("GBP Account", 7878, "GBP", "£");
            var toAccount = new Accounts("USD Account", 1212, "USD", "$");

            //Act
            double result = Currency.GetExchangeRate(fromAccount, toAccount);

            //Assert
            Assert.AreEqual(1.0, result);
        }
    }
}
