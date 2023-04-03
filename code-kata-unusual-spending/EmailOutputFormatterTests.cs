namespace code_kata_unusual_spending;

public class EmailOutputFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ThrowsExceptionIfNoPayments()
    {
        var formatter = new EmailOutputFormatter();
        var payments = new List<Payment>();
        Assert.Throws(typeof(ArgumentException), () => formatter.Format(payments));
    }
}