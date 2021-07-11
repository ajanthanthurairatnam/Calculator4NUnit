using Calculator4NUnit;
using NSubstitute;
using NUnit.Framework;

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
            Assert.AreEqual(calculator.AddTwoNumbers(number1, number2), outputNumbers);
        }

        [Test]
        public void SubstractTwoNumbers_ReturnsResult()
        {
            //Arrange
            int number1 = 5;
            int number2 = 3;

            int resultNumber = 2;
            calculator.SubstractTwoNumbers(number1, number2).Returns(8);


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

            calculator.MultiplyTwoNumbers(number1, number2).Returns(15);

            //Act
            var outputNumber = sut.MultiplyTwoNumbers(number1, number2);

            Assert.AreEqual(calculator.MultiplyTwoNumbers(number1, number2), outputNumber);
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
            calculator.DivideTwoNumbers(number1, number2).Returns(3);

            Assert.AreEqual(resultNumber, outputNumber);
        }
    }
}
