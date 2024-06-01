using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests.MSTest;


[TestClass]
public class MathTests
{
    private Math _math;

    [TestInitialize]
    public void SetUp()
    {
        _math = new Math();
    }
        
    
    [TestMethod]
    public void Add_WhenCalled_ReturnSumOfArguments()
    {
        //  Act
        var result = _math.Add(3, 2);
        
        //  Assert
        Assert.AreEqual(5, result);
    }


    
    [TestMethod]
    [DataRow (2, 1, 2)]
    [DataRow (1, 2, 2)]
    [DataRow (1, 1, 1)]
    public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
    {
        var result = _math.Max(a, b);

        Assert.AreEqual(result, expectedResult);
    }

    
    [TestMethod]
    [Ignore("Dummy test to be ignored")]
    public void DummyTest_toBeIgnored()
    {
        Assert.AreEqual("Fred", "Wilma");
    }


    [TestMethod]
    public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
    {
        var result = _math.GetOddNumbers(5);
        
        Assert.IsTrue(result.Any());
        Assert.AreEqual(3, result.Count());
        
        Assert.IsTrue(result.Contains(1));
        Assert.IsTrue(result.Contains(3));
        Assert.IsTrue(result.Contains(5));

    }
}