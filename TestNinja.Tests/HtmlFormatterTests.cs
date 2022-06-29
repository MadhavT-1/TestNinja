namespace TestNinja.Tests;

public class HtmlFormatterTests
{
    [Test]
    public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
    {
        var formatter = new HtmlFormatter();

        var result = formatter.FormatAsBold("madhav");
        
        //specific
        Assert.That(result,Is.EqualTo("<strong>madhav</strong>"));
        
        //More general
        
        Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
        Assert.That(result, Does.EndWith("</strong>"));
        Assert.That(result,Does.Contain("madhav"));
        
        
    }
}