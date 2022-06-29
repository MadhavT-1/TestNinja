namespace TestNinja.Tests;

public class MathTests
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

    [Test]
    public void GetOddNumbers_LimitGreaterThanZero_ReturnOddNumbersUptoLimit()
    {
        var result = _math.GetOddNumbers(5);
        
        
        // Assert.That(result,Is.Not.Empty);
        //
        // Assert.That(result.Count(),Is.EqualTo(3));
            
        // Assert.That(result,Does.Contain(1));
        // Assert.That(result,Does.Contain(3));
        // Assert.That(result,Does.Contain(5));
        Assert.That(result,Is.EquivalentTo(new [] {1,3,5}));
        // Assert.That(result, Is.Ordered);
        // Assert.That(result,Is.Unique);
    }
}