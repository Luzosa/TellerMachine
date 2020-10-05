using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutomatedTellerMachine;

namespace AutomatedTellerMachine.Tests
{
    public class BankTests
    {


        [Fact]
        public void InitBank_ShouldInitIfNameNotEmpty()
        {
            // Arrange
            Bank bank = new Bank();
            string expected = "Novea";
            // Act
            string result = bank.InitBank("Novea");

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void InitBank_ShouldFailInitIfNameEmpty(string name)
        {
            // Arrange
            Bank bank = new Bank();
            // Assert
            Assert.Throws<ArgumentException>(() => bank.InitBank(name));
        }


        [Fact]
        public void GetMachine_IfCorrectFormat()
        {
            // Arrange
            Bank bank = new Bank();
            Machine machine = bank.GetMachine(new Machine(), 1);

            // Assert
            Assert.IsType<Machine>(machine);
        }
    }
}
