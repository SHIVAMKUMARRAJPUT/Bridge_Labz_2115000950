using NUnit.Framework;
using NUnit;
using System;
using UnitTestExample;

namespace UnitTestExample.Tests
{
    public class CalculatorTestsClass1
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

       

            [Test]
        public void AdditionTest()
        {
            int expected = 10;
            int actual = _calculator.Add(4, 6);
            Assert.That(actual, Is.EqualTo(expected));
        }

        
        [Test]
        public void Subtract_ValidInputs_ReturnsCorrectDifference()
        {
            int expected = 3;
            int actual = _calculator.Subtract(8, 5);
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Multiply_ValidInputs_ReturnsCorrectProduct()
        {
            int expected = 15;
            int actual = _calculator.Multiply(3, 5);
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Divide_ValidInputs_ReturnsCorrectQuotient()
        {
            int expected = 4;
            int actual = _calculator.Divide(8, 2);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.That(() => _calculator.Divide(10, 0), Throws.TypeOf<DivideByZeroException>());
        }


    }
}
