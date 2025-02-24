using NUnit.Framework;
using NUnit;
using StringUtilsNameSpace;
  

[TestFixture]
public class StringUtilsTests
{
    [Test]
    public void Reverse_GivenString_ReturnsReversedString()
    {
        string input = "hello";
        string expected = "olleh";
        string result = StringUtils.Reverse(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void IsPalindrome_GivenPalindromeString_ReturnsTrue()
    {
        string input = "madam";
        bool result = StringUtils.IsPalindrome(input);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsPalindrome_GivenNonPalindromeString_ReturnsFalse()
    {
        string input = "hello";
        bool result = StringUtils.IsPalindrome(input);
        Assert.That(result, Is.False);
    }

    [Test]
    public void ToUpperCase_GivenString_ReturnsUppercaseString()
    {
        string input = "hello";
        string expected = "HELLO";
        string result = StringUtils.ToUpperCase(input);
        Assert.That(result, Is.EqualTo(expected));
    }

}



