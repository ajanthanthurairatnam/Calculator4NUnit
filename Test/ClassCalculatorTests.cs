using Calculator4NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator sut;
        public CalculatorTests()
        {
           sut = new Calculator();
        }

        [Test]
        public void AddTwoNumbers_ShouldReturnResult()
        {
            //Arrange
            int number1 = 1;
            int number2 = 2;

            int resultNumber = 3;

            //Act
            int outputNumbers = sut.AddTwoNumbers(number1, number2);

            //Assert
            Assert.AreEqual(resultNumber, outputNumbers);
        }

        [Test]
        public void SubstractTwoNumbers_ReturnsResult()
        {
            //Arrange
            int number1 = 5;
            int number2 = 3;

            int resultNumber = 2;

            //Act
            var outputNumber = sut.SubstractTwoNumbers(number1, number2);

            Assert.AreEqual(resultNumber, outputNumber);
        }

        [Test]
        public void MultiplyTwoNumbers_ReturnsResult()
        {
            //Arrange
            int number1 = 5;
            int number2 = 3;

            int resultNumber = 15;

            //Act
            var outputNumber = sut.MultiplyTwoNumbers(number1, number2);

            Assert.AreEqual(resultNumber, outputNumber);
        }

        [Test]
        public void DivideTwoNumbers_ReturnsResult()
        {
            //Arrange
            int number1 = 15;
            int number2 = 3;

            int resultNumber = 5;

            //Act
            var outputNumber = sut.DivideTwoNumbers(number1, number2);

            Assert.AreEqual(resultNumber, outputNumber);
        }
    }
}
