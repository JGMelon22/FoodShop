namespace FoodShop.Domain.Entities;

public class Food
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsHealthy { get; set; }
    public List<Category> Categories { get; set; }
    public List<FoodTypicalPlace> FoodTypicalPlaces { get; set; }
}