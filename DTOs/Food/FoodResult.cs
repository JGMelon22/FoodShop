namespace FoodShop.DTOs.Food;

public record FoodResult
{
    public int Id { get; init; }
    public string FoodName { get; init; } 
    public bool IsHealthy { get; init; }
}
