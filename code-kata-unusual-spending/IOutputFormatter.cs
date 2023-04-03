namespace code_kata_unusual_spending;

public interface IOutputFormatter
{
    string Format(IEnumerable<Payment> payments);
}