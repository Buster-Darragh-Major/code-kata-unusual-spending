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
        Assert.Throws(typeof(ArgumentException), () => formatter.Format(new List<Payment>()));
    }

    [Test]
    public void FormatsPayments()
    {
        var formatter = new EmailOutputFormatter();
        Assert.That(formatter.Format(new Payment[]
        {
            new Payment(10, "Some description", Category.Entertainment)
        }), Is.EqualTo(@"Hello card user!

We have detected unusually high spending on your card in these categories:

* You spent $10 on Entertainment

Love,

The Credit Card Company
"));
    }
}