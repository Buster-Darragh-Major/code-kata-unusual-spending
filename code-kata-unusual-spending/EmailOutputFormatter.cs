using System.Text;

namespace code_kata_unusual_spending;

public class EmailOutputFormatter : IOutputFormatter
{
    public string Format(IEnumerable<Payment> payments)
    {
        if (!paymentßs.Any())
        {
            throw new ArgumentException();
        }
        
        var sb = new StringBuilder();
        sb.AppendLine($"Hello card user!");
        sb.AppendLine();
        sb.AppendLine($"We have detected unusually high spending on your card in these categories:");
        sb.AppendLine();
        foreach (var payment in payments)
        {
            sb.AppendLine($"* You spent ${payment.Price} on {payment.Category}");
        }
        sb.AppendLine();
        sb.AppendLine($"Love,");
        sb.AppendLine();
        sb.AppendLine($"The Credit Card Company");
        
        return sb.ToString();
    }
}
