using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.NUnit;

[TestFixture]
public class CustomerControllerTests
{
    private CustomerController _customerController;

    [SetUp]
    public void SetUp()
    {
        _customerController = new CustomerController();
    }


    [Test]
    public void GetCustomer_IdIsZero_ReturnNotFound()
    {
        var result = _customerController.GetCustomer(0);
        
        Assert.That(result, Is.TypeOf<NotFound>());
        Assert.That(result, Is.InstanceOf<NotFound>());
    }


    [Test]
    public void GetCustomer_IdIsNotZero_ReturnOK()
    {
        var result = _customerController.GetCustomer(1);
        
        Assert.That(result, Is.TypeOf<Ok>());
        Assert.That(result, Is.InstanceOf<Ok>());
    }
    
}