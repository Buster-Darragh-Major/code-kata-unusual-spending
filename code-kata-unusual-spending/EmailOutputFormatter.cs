using System.Text;

namespace code_kata_unusual_spending;

public class EmailOutputFormatter : IOutputFormatter
{
    public string Format(IEnumerable<Payment> payments)
    {
        if (!payments.Any())
        {
            throw new ArgumentException();
        }
        
        var sb = new StringBuilder();
        /*sb.AppendLine($"User {userId} has made the following payments:");
        foreach (var payment in payments)
        {
            sb.AppendLine($"Payment {payment.Id} for {payment.Amount} on {payment.Date}");
        }*/
        return sb.ToString();
    }
}
