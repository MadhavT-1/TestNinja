namespace TestNinja.Tests;
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
        
        //NotFound Object
        Assert.That(result,Is.TypeOf<NotFound>());
        
        //NotFound object or one of its derivatives
        // Assert.That(result,Is.InstanceOf<NotFound>());
    }

    [Test]
    public void GetCustomer_IdIsNotZero_ReturnOk()
    {
        var result = _customerController.GetCustomer(1);
        
        //NotFound Object
        Assert.That(result,Is.TypeOf<Ok>());
        
        //NotFound object or one of its derivatives
        // Assert.That(result,Is.InstanceOf<Ok>());

    }
}