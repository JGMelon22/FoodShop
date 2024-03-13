namespace FoodShop.DTOs.Food;

public record FoodResult
{
    public int Id { get; init; }
    public string Name { get; init; }
    public bool IsHealthy { get; init; }
}