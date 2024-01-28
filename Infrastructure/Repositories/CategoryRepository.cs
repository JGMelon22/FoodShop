using FoodShop.DTOs.Category;
using FoodShop.Interfaces;

namespace FoodShop.Infrastructure.Repositories;

// Using Primary constructor 
public class CategoryRepository(AppDbContext dbContext) : ICategoryRepository
{
    public async Task<ServiceResponse<CategoryResult>> AddCategoryAsync(CategoryInput newCategory)
    {
        var serviceResponse = new ServiceResponse<CategoryResult>();

        try
        {
            var category = new Category
            {
                Name = newCategory.Name,
                FoodId = newCategory.FoodId
            };

            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            var categoryResult = new CategoryResult
            {
                Id = category.Id,
                Name = category.Name,
                FoodId = category.FoodId
            };

            serviceResponse.Data = categoryResult;
        }
        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<List<CategoryResult>>> GetAllCategoriesAsync()
    {
        var serviceResponse = new ServiceResponse<List<CategoryResult>>();

        try
        {
            var categories = await dbContext.Categories
                                 .AsNoTracking()
                                 .ToListAsync()
                             ?? throw new Exception("Categories list is empty!");

            var categoriesMapped = new List<CategoryResult>();

            foreach (var category in categories)
            {
                var categoryResult = new CategoryResult
                {
                    Id = category.Id,
                    Name = category.Name,
                    FoodId = category.FoodId
                };

                categoriesMapped.Add(categoryResult);
            }

            serviceResponse.Data = categoriesMapped;
        }
        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<CategoryResult>> GetCategoryByIdAsync(int id)
    {
        var serviceResponse = new ServiceResponse<CategoryResult>();

        try
        {
            var category = await dbContext.Categories
                .FindAsync(id)
                ?? throw new Exception($"Category with id {id} not found!");

            var categoryResult = new CategoryResult
            {
                Id = category.Id,
                Name = category.Name,
                FoodId = category.FoodId
            };

            serviceResponse.Data = categoryResult;
        }
        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<bool>> RemoveCategoryAsync(int id)
    {
        var serviceResponse = new ServiceResponse<bool>();

        try
        {
            var category = await dbContext.Categories.FindAsync(id) 
                          ?? throw new Exception($"Category with id {id} not found!");

            dbContext.Categories.Remove(category);

            await dbContext.SaveChangesAsync();
        }

        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<CategoryResult>> UpdateCategoryAsync(int id, CategoryInput updatedCategory)
    {
        var serviceResponse = new ServiceResponse<CategoryResult>();

        try
        {
            var category = await dbContext.Categories.FindAsync(id)
                           ?? throw new Exception($"Category with id {id} not found!");

            category.Name = updatedCategory.Name;
            category.FoodId = updatedCategory.FoodId;

            await dbContext.SaveChangesAsync();

            var categoryResult = new CategoryResult
            {
                Id = category.Id,
                Name = category.Name,
                FoodId = category.FoodId
            };

            serviceResponse.Data = categoryResult;
        }
        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }
}