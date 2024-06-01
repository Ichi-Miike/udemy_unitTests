using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests.NUnit;
[TestFixture]
public class MathTests
{
    private Math _math;

    [SetUp]
    public void SetUp()
    {
        _math = new Math();
    }
    
    
    [Test]
    public void Add_WhenCalled_ReturnSumOfArguments()
    {
        var result = _math.Add(2, 3);

        Assert.That(result, Is.EqualTo(5));
    }



    [Test]
    [TestCase(2, 1, 2)]
    [TestCase(1, 2, 2)]
    [TestCase(1, 1, 1)]
    public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
    {
        var result = _math.Max(a, b);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    
    [Test]
    [Ignore("Dummy test to be ignored")]
    public void DummyTest_toBeIgnored()
    {
        Assert.That("Fred", Is.EqualTo("Wilma"));
    }


    [Test]
    public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
    {
        var result = _math.GetOddNumbers(5);
        
        Assert.That(result, Is.Not.Empty);
        Assert.That(result.Count(), Is.EqualTo(3));
        
        Assert.That(result, Does.Contain(1));
        Assert.That(result, Does.Contain(3));
        Assert.That(result, Does.Contain(5));
        
        Assert.That(result, Is.EquivalentTo(new [] {1, 3, 5 }));
    }
    
}