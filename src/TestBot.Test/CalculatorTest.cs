using ClassLibrary1;
using NUnit.Framework;

namespace TestBot.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var calculator = new Calculator();

        Assert.That(calculator.Sum(1, 2).Equals(3));
    }
}