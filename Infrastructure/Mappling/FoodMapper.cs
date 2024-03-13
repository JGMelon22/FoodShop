using FoodShop.DTOs.Food;
using Riok.Mapperly.Abstractions;

namespace FoodShop.Infrastructure.Mappling;

[Mapper]
public partial class FoodMapper
{
    public partial FoodResult FoodToFoodResultDto(Food food);
    public partial Food FoodToFoodInputDto(FoodInput food);
}