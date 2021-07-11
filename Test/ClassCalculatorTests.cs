using Calculator4NUnit;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Test
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator sut;
        ICalculator calculator;
        public CalculatorTests()
        {
           sut = new Calculator();
           calculator = Substitute.For<ICalculator>();
        }

        [Test]
        public void AddTwoNumbers_ShouldReturnResult()
        {
            //Arrange
            int number1 = 1;
            int number2 = 2;
            calculator.AddTwoNumbers(number1,number2).Returns(3);

            //Act
            int outputNumbers = sut.AddTwoNumbers(number1, number2);

            //Assert
            outputNumbers.ShouldBe(calculator.AddTwoNumbers(number1, number2));
        }

        [Test]
        public void SubstractTwoNumbers_ReturnsResult()
        {
            //Arrange
            int number1 = 5;
            int number2 = 3;
            calculator.SubstractTwoNumbers(number1, number2).Returns(2);

            //Act
            var outputNumber = sut.SubstractTwoNumbers(number1, number2);

            //Assert
            outputNumber.ShouldBe(calculator.SubstractTwoNumbers(number1, number2));
        }

        [Test]
        public void MultiplyTwoNumbers_ReturnsResult()
        {
            //Arrange
            int number1 = 5;
            int number2 = 3;
            calculator.MultiplyTwoNumbers(number1, number2).Returns(15);

            //Act
            var outputNumber = sut.MultiplyTwoNumbers(number1, number2);

            //Assert
            outputNumber.ShouldBe(calculator.MultiplyTwoNumbers(number1, number2));
        }

        [Test]
        public void DivideTwoNumbers_ReturnsResult()
        {
            //Arrange
            int number1 = 15;
            int number2 = 3;          
            calculator.DivideTwoNumbers(number1, number2).Returns(5);

            //Act
            var outputNumber = sut.DivideTwoNumbers(number1, number2);
           
            //Assert
            outputNumber.ShouldBe(calculator.DivideTwoNumbers(number1, number2));
        }
    }
}
