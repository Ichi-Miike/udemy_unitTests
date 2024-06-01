using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.MSTest;

[TestClass]
public class CustomerControllerTests
{
    private CustomerController _customerController;

    [TestInitialize]
    public void SetUp()
    {
        _customerController = new CustomerController();
    }


    [TestMethod]
    public void GetCustomer_IdIsZero_ReturnNotFound()
    {
        var result = _customerController.GetCustomer(0);
        
        Assert.IsTrue(result.GetType().Name == "NotFound");
    }


    [TestMethod]
    public void GetCustomer_IdIsNotZero_ReturnOK()
    {
        var result = _customerController.GetCustomer(1);
        
        Assert.IsTrue(result.GetType().Name == "Ok");
    }

}