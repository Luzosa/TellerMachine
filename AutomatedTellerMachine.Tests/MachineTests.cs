using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutomatedTellerMachine;

namespace AutomatedTellerMachine.Tests
{
    public class MachineTests
    {

        [Theory]
        [InlineData(500, 9500)]
        [InlineData(10000, 0)]
        [InlineData(10, 9990)]
        public void Withdraw_ShouldWorkIfBelowCurrentCredit(double withdrawal, double expected)
        {

            // Arrange
            Machine machine = new Machine();
            CreditCard card = new CreditCard();

            // Act
            double result = machine.Withdraw(card, withdrawal);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10001)]
        [InlineData(108000)]
        [InlineData(108450)]
        public void Withdraw_ShouldFailIfAboveCurrentCredit(double withdrawal)
        {

            // Arrange
            Machine machine = new Machine();
            CreditCard card = new CreditCard();

            // Assert
            Assert.Throws<ArgumentException>(() => machine.Withdraw(card, withdrawal));
        }

        [Theory]
        [InlineData(1000,11000)]
        [InlineData(5,10005)]
        public void Deposit_ShouldWorkIfBelowMaxCredit(double amount, double expected)
        {

            // Arrange
            Machine machine = new Machine();
            CreditCard card = new CreditCard();

            // Act
            double result = machine.Deposit(card, amount);

            // Assert
            Assert.Equal(expected, result);
            


        }

        [Theory]
        [InlineData(100000)]
        [InlineData(551440)]
        public void Deposit_ShouldFailIfAboveMaxCredit(double amount)
        {

            // Arrange
            Machine machine = new Machine();
            CreditCard card = new CreditCard();

            // Assert
            Assert.Throws<ArgumentException>(() => machine.Deposit(card, amount));

        }
    }
}
