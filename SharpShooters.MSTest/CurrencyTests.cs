using Sharp_Shooters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShooters.MSTest
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void Test_ConvertCurrency_SameCurrency_Return_SameAmount()
        {
            //Arrange
            var fromCurrency = new Accounts("test1", 100, "USD", "$");
            var toCurrency = new Accounts("test2", 100, "USD", "$");
            double amount = 100.0;

            //Act 
            double convertedAmount = Currency.ConvertCurrency(amount, fromCurrency, toCurrency);            

            Assert.AreEqual(amount, convertedAmount);
        }

        [TestMethod]
        public void Test_ConvertCurrency_DifferentCurrency_Return_CorrectConversion()
        {
            //Arrange
            var fromCurrency = new Accounts("USD", 100, "USD", "$");
            var toCurrency = new Accounts("EURO", 100, "EURO", "€");
            double amount = 100.0;
            var expectedAmount = amount * 0.93;

            //Act
            double convertedAmount = Currency.ConvertCurrency(amount, fromCurrency, toCurrency);

            //Assert
            Assert.AreEqual(expectedAmount, convertedAmount);

        }

        [TestMethod]
        public void Test_ConvertCurrency_InvalidCurrency_Return_NoConversion()
        {
            // Arrange
            var fromCurrency = new Accounts("USD", 100, "USD", "$");
            var toCurrency = new Accounts("INVALID", 100, "INVALID", "?");
            double amount = 100.0;

            //Act
            double convertedAmount = Currency.ConvertCurrency(amount, fromCurrency, toCurrency);

            //Assert
            Assert.AreEqual(amount, convertedAmount, "Expected no conversion when invalid currency is provided.");
        }


        [TestMethod]
        public void Test_ConvertCurrency_NullAmount_Return_0()
        {
            //Arrange
            var fromCurrency = new Accounts("USD", 1212, "USD", "$");
            var toCurrency = new Accounts("EUR", 1000, "EUR", "€");
            double? amount = null;

            //Act 
            var result = Currency.ConvertCurrency(amount?? 0, fromCurrency, toCurrency);
            var expected = 0;

            //Act & Assert
            Assert.AreEqual(expected, result);

        }
    }
}
