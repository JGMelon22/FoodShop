namespace FoodShop.Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int FoodId { get; set; }
    public Food Food { get; set; } = null!;
}