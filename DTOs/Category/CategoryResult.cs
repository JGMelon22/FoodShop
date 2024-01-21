namespace FoodShop.DTOs.Category;

public record CategoryResult
{
    public int Id { get; init; }
    public string Name { get; init; }
    public int FoodId { get; init; }
    public Food Food { get; init; }
}