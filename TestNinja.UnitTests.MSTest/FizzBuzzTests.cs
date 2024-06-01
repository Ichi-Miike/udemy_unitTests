using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.MSTest;

[TestClass]
public class FizzBuzzTests
{
    [TestMethod]
    public void GetOutput_DivisibleByThree_ReturnFizz()
    {
        var result = FizzBuzz.GetOutput(3);
        Assert.AreEqual("Fizz", result);
    }
    
    [TestMethod]
    public void GetOutput_DivisibleByFive_ReturnBuzz()
    {
        var result = FizzBuzz.GetOutput(5);
        Assert.AreEqual("Buzz", result);
    }
    
    [TestMethod]
    public void GetOutput_DivisibleByThreeAndFive_ReturnFizzBuzz()
    {
        var result = FizzBuzz.GetOutput(15);
        Assert.AreEqual("FizzBuzz", result);
    }
    
    [TestMethod]
    public void GetOutput_NotDivisibleByThreeOrFive_ReturnOriginalNumber()
    {
        var result = FizzBuzz.GetOutput(4);
        Assert.AreEqual("4", result);
    }
}