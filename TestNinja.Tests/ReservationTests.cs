namespace TestNinja.Tests;

public class ReservationTests
{
    private Math _math;
    [SetUp]
    public void Setup()
    {
        _math = new Math();
    }

    [Test]
    [TestCase(1,2,3)]
    public void Add_WhenCalled_ReturnsSumOfArguments(int a,int b, int expectedResult)
    {
        var result = _math.Add(a, b);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(1,2,2)]
    [TestCase(2,1,2)]
    [TestCase(1,1,1)]
    public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
    {
        var result = _math.Max(a, b);
        
        Assert.That(result,Is.EqualTo(expectedResult));
    }
}