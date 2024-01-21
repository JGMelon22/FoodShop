using FoodShop.DTOs.Category;

namespace FoodShop.Interfaces;

public interface ICategoryRepository
{
    Task<ServiceResponse<List<CategoryResult>>> GetAllCategoriesAsync();
    Task<ServiceResponse<CategoryResult>> GetCategoryByIdAsync(int id);
    Task<ServiceResponse<CategoryResult>> AddCategoryAsync(CategoryInput newCategory);
    Task<ServiceResponse<CategoryResult>> UpdateCategoryAsync(int id, CategoryInput updatedCategory);
    Task<ServiceResponse<bool>> RemoveCategoryAsync(int id);
}