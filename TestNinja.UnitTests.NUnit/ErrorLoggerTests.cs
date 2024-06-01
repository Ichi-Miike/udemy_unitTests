using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.NUnit;

[TestFixture]
public class ErrorLoggerTests
{
    private ErrorLogger _errorLogger;

    [SetUp]
    public void SetUp()
    {
        _errorLogger = new ErrorLogger();
    }


    [Test]
    public void Log_WhenCalled_ShouldSetLastErrorProperty()
    {
        _errorLogger.Log("error_message");
        
        Assert.That(_errorLogger.LastError, Is.EqualTo("error_message"));
    }
    

    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void Log_InvalidError_ThrowArgumentNullException(string? error)
    {
        Assert.Throws<ArgumentNullException>(() => _errorLogger.Log(error));
        Assert.That(() => _errorLogger.Log(error), Throws.ArgumentNullException);   
    }


    [Test]
    public void Log_ValidError_RaiseErrorLoggedEvent()
    {
        var id = Guid.Empty;
        _errorLogger.ErrorLogged += (sender, args) => { id = args; };
        
        _errorLogger.Log("Error");

        Assert.That(id, Is.Not.EqualTo(Guid.Empty));
    }
}