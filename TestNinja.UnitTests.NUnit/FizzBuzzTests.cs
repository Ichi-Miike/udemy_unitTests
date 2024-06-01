using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.NUnit;

[TestFixture]
public class FizzBuzzTests
{
    [Test]
    public void GetOutput_DivisibleByThree_ReturnFizz()
    {
        var result = FizzBuzz.GetOutput(3);
        Assert.That(result, Is.EqualTo("Fizz"));
    }
    
    [Test]
    public void GetOutput_DivisibleByFive_ReturnBuzz()
    {
        var result = FizzBuzz.GetOutput(5);
        Assert.That(result, Is.EqualTo("Buzz"));
    }
    
    [Test]
    public void GetOutput_DivisibleByThreeAndFive_ReturnFizzBuzz()
    {
        var result = FizzBuzz.GetOutput(15);
        Assert.That(result, Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void GetOutput_NotDivisibleByThreeOrFive_ReturnOriginalNumber()
    {
        var result = FizzBuzz.GetOutput(4);
        Assert.That(result, Is.EqualTo("4"));
    }
    
    
}