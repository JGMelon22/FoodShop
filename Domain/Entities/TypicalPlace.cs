namespace FoodShop.Domain.Entities;

public class TypicalPlace
{
    public int Id { get; set; }
    public string Country { get; set; } = null!;
    public List<FoodTypicalPlace> FoodTypicalPlaces { get; set; }
}