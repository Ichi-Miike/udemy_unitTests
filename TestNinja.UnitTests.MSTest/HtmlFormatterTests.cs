using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.MSTest;

[TestClass]
public class HtmlFormatterTests
{
    private HtmlFormatter _htmlFormatter;
    
    [TestInitialize]
    public void SetUp()
    {
        _htmlFormatter = new HtmlFormatter();
    }


    [TestMethod]
    public void FormatAsBold_WhenCalled_ShouldReturnFomattedString()
    {
        var result = _htmlFormatter.FormatAsBold("Some Text");
        
        Assert.AreEqual(result, "<strong>Some Text</strong>");
        Assert.IsTrue(result.StartsWith("<strong>"));
        Assert.IsTrue(result.EndsWith("</strong>"));
        Assert.IsTrue(result.Contains("Some Text"));
    }
}