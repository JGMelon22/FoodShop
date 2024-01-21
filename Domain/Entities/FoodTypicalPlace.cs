namespace FoodShop.Domain.Entities;

public class FoodTypicalPlace
{
    public int FoodId { get; set; }
    public Food Food { get; set; } = null!;
    public int TypicalPlaceId { get; set; }
    public TypicalPlace TypicalPlace { get; set; }
}