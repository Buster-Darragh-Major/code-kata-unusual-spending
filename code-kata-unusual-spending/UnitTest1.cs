namespace code_kata_unusual_spending;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Trigger_User42_EmailNotEmpty()
    {
        var triggersUnusualSpendingEmail = new TriggersUnusualSpendingEmail();
        Assert.IsNotEmpty(triggersUnusualSpendingEmail.Trigger(42));
    }
}