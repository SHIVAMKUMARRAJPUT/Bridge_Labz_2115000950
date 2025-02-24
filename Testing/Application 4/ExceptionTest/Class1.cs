using NUnit.Framework;
using System;
using ExceptionHandling;

[TestFixture]
public class MathOperationsTests
{
    private MathOperations _mathOperations;

    [SetUp]
    public void Setup()
    {
        _mathOperations = new MathOperations();
    }

    [Test]
    public void Divide_GivenZeroAsDivisor_ThrowsArithmeticException()
    {
        int a = 10;
        int b = 0;
        var ex = Assert.Throws<ArithmeticException>(() => _mathOperations.Divide(a, b));
        Assert.That(ex.Message, Is.EqualTo("Division by zero is not allowed."));
    }

    [Test]
    public void Divide_GivenPositiveNumbers_ReturnsCorrectResult()
    {
        int a = 10;
        int b = 2;
        var result = _mathOperations.Divide(a, b);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Divide_GivenNegativeDivisor_ReturnsNegativeResult()
    {
        int a = 10;
        int b = -2;
        var result = _mathOperations.Divide(a, b);
        Assert.That(result, Is.EqualTo(-5));
    }

    [Test]
    public void Divide_GivenNegativeDividend_ReturnsNegativeResult()
    {
        int a = -10;
        int b = 2;
        var result = _mathOperations.Divide(a, b);
        Assert.That(result, Is.EqualTo(-5));
    }

    [Test]
    public void Divide_GivenBothNegativeNumbers_ReturnsPositiveResult()
    {
        int a = -10;
        int b = -2;
        var result = _mathOperations.Divide(a, b);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Divide_GivenLargeNumbers_ReturnsCorrectResult()
    {
        int a = 1000000;
        int b = 1000;
        var result = _mathOperations.Divide(a, b);
        Assert.That(result, Is.EqualTo(1000));
    }

    [Test]
    public void Divide_GivenZeroAsDividend_ReturnsZero()
    {
        int a = 0;
        int b = 10;
        var result = _mathOperations.Divide(a, b);
        Assert.That(result, Is.EqualTo(0));
    }
}
