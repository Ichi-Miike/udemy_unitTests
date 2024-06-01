using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.MSTest;

[TestClass]
public class ErrorLoggerTests
{
    private ErrorLogger _errorLogger;

    [TestInitialize]
    public void SetUp()
    {
        _errorLogger = new ErrorLogger();
    }


    [TestMethod]
    public void Log_WhenCalled_ShouldSetLastErrorProperty()
    {
        _errorLogger.Log("error_message");
        
        Assert.AreEqual("error_message", _errorLogger.LastError);
    }


    [TestMethod]
    [DataRow(null)]
    [DataRow("")]
    [DataRow(" ")]
    public void Log_WhenCalled_WithNullParameter_ShouldException(string error)
    {
        Assert.ThrowsException<ArgumentNullException>(() => _errorLogger.Log(error));
    }


    [TestMethod]
    public void Log_ValidError_RaiseErrorLoggedEvent()
    {
        var id = Guid.Empty;

        _errorLogger.ErrorLogged += (sender, args) => { id = args; };
        
        _errorLogger.Log("Error");
        
        Assert.AreNotEqual(id, Guid.Empty);
    }
}