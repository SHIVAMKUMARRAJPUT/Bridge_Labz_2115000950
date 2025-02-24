using NUnit.Framework;
using Parameterized;
[TestFixture]
public class MathOperationsTests
{
    [Test]
    public void IsEven_GivenNumber2_ReturnsTrue()
    {
        int number = 2;
        bool result = MathOperations.IsEven(number);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsEven_GivenNumber4_ReturnsTrue()
    {
        int number = 4;
        bool result = MathOperations.IsEven(number);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsEven_GivenNumber6_ReturnsTrue()
    {
        int number = 6;
        bool result = MathOperations.IsEven(number);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsEven_GivenNumber7_ReturnsFalse()
    {
        int number = 7;
        bool result = MathOperations.IsEven(number);
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsEven_GivenNumber9_ReturnsFalse()
    {
        int number = 9;
        bool result = MathOperations.IsEven(number);
        Assert.That(result, Is.False);
    }
}
