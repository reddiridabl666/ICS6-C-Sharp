namespace tests;

public class Tests
{
    readonly Calc.Calculator calculator = new();

    [Test]
    public void TestPlus()
    {
        Assert.That(calculator.Calculate("2 + 3"), Is.EqualTo(5));
    }

    [Test]
    public void TestMinus()
    {
        Assert.That(calculator.Calculate("2 - 3"), Is.EqualTo(-1));
    }

    [Test]
    public void TestMultiply()
    {
        Assert.That(calculator.Calculate("2 * 3"), Is.EqualTo(6));
    }

    [Test]
    public void TestDivide()
    {
        Assert.That(calculator.Calculate("10 / 2"), Is.EqualTo(5));
    }

    [Test]
    public void TestOpOrder()
    {
        Assert.That(calculator.Calculate("1 + 2 * 3"), Is.EqualTo(7));
    }

    [Test]
    public void TestParenthesis()
    {
        Assert.That(calculator.Calculate("(234 - 11)*34"), Is.EqualTo(7582));
    }

    [Test]
    public void TestInvalidCharacters()
    {
        Assert.Throws<Exception>(() => calculator.Calculate("(234 - ds11)*34"));
    }

    [Test]
    public void TestInvalidParenthesisEnd()
    {
        Assert.Throws<Exception>(() => calculator.Calculate("(234 - 11)*34)"));
    }

    [Test]
    public void TestInvalidParenthesisStart()
    {
        Assert.Throws<Exception>(() => calculator.Calculate("(234 - 11)*34("));
    }
}
