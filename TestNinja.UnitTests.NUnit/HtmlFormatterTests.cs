using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.NUnit;

[TestFixture]
public class HtmlFormatterTests
{
    private HtmlFormatter _htmlFormatter; 
    
    [SetUp]
    public void SetUp()
    {
        _htmlFormatter = new HtmlFormatter();
    }


    [Test]
    public void FormatAsBold_WhenCalled_ShouldReturnFomattedString()
    {
        var result = _htmlFormatter.FormatAsBold("Some Text");
        
        Assert.That(result, Is.EqualTo("<strong>Some Text</strong>").IgnoreCase);
        Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
        Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
        Assert.That(result, Does.Contain("Some Text").IgnoreCase);
    }
}