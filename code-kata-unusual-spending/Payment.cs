namespace code_kata_unusual_spending;

public record Payment(
    double Price,
    string Description,
    Category Category
);