using FoodShop.DTOs.Food;

namespace FoodShop.Interfaces;

public interface IFoodRepository
{
    Task<ServiceResponse<List<FoodResult>>> GetAllFoodsAsync();
    Task<ServiceResponse<FoodResult>> GetFoodByIdAsync(int id);
    Task<ServiceResponse<FoodResult>> AddFoodAsync(FoodInput newFood);
    Task<ServiceResponse<FoodResult>> UpdateFoodAsync(int id, FoodInput updatedFood);
    Task<ServiceResponse<bool>> RemoveFoodAsync(int id);
}