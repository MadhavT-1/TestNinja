namespace TestNinja.Tests;

public class ErrorLoggerTests
{
    [Test]
    
    public void Log_WhenCalled_ShouldSetLastErrorProperty()
    {
        var logger = new ErrorLogger();
        
        logger.Log("Log from test class");
        
        Assert.That(logger.LastError,Is.EqualTo("Log from test class"));
    }

    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void Log_InvalidError_ThrowArgumentNullException(string error)
    {
        var logger = new ErrorLogger();
        // logger.Log(error);
        
        Assert.That(() =>logger.Log(error),Throws.ArgumentNullException);
        
    }

    [Test]
    public void Log_ValidError_RaiseErrorLoggedEvent()
    {
        var logger = new ErrorLogger();

        var id = Guid.Empty;
        logger.ErrorLogged += (sender, args) => { id = args; };
        logger.Log("a");
        Assert.That(id, Is.Not.EqualTo(Guid.Empty));
    }
}