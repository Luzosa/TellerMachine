using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedTellerMachine;
using Xunit;

namespace AutomatedTellerMachine.Tests
{
    public class CreditCardTests
    {
        
        [Fact]
        public void InitCard_ShouldBeAvailable()
        {

            // Arrange
            double expected = 10000;
            double minValue = 0;
            CreditCard card = new CreditCard();

            // Act
            double maxValue = card.MaxCredit;
            double result = card.InitCredit;

            // Assert
            Assert.Equal(expected, result);
            Assert.InRange(result, minValue, maxValue);
        }
    }
}
