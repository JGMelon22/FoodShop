using FoodShop.DTOs.Food;
using FoodShop.Interfaces;

namespace FoodShop.Infrastructure.Repositories;

public class FoodRepository(AppDbContext dbContext) : IFoodRepository
{
    public async Task<ServiceResponse<FoodResult>> AddFoodAsync(FoodInput newFood)
    {
        var serviceResponse = new ServiceResponse<FoodResult>();

        try
        {
            var food = new Food
            {
                Name = newFood.Name,
                IsHealthy = newFood.IsHealthy
            };

            await dbContext.SaveChangesAsync();

            var foodResult = new FoodResult
            {
                Id = food.Id,
                Name = food.Name,
                IsHealthy = food.IsHealthy
            };

            serviceResponse.Data = foodResult;
        }

        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<List<FoodResult>>> GetAllFoodsAsync()
    {
        var serviceResponse = new ServiceResponse<List<FoodResult>>();

        try
        {
            var foods = await dbContext.Foods
                .AsNoTracking()
                .ToListAsync()
                ?? throw new Exception("Foods list is empty!");


            var foodsMapped = new List<FoodResult>();

            foreach (var food in foods)
            {
                var foodResult = new FoodResult
                {
                    Id = food.Id,
                    Name = food.Name,
                    IsHealthy = food.IsHealthy
                };

                foodsMapped.Add(foodResult);
            }

            serviceResponse.Data = foodsMapped;
        }


        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<FoodResult>> GetFoodByIdAsync(int id)
    {
        var serviceResponse = new ServiceResponse<FoodResult>();

        try
        {
            var food = await dbContext.Foods.FindAsync(id)
                       ?? throw new Exception($"Food with id {id} not found!");

            var foodResult = new FoodResult
            {
                Id = food.Id,
                Name = food.Name,
                IsHealthy = food.IsHealthy
            };

            serviceResponse.Data = foodResult;
        }

        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<bool>> RemoveFoodAsync(int id)
    {
        var serviceResponse = new ServiceResponse<bool>();

        try
        {
            var food = await dbContext.Foods.FindAsync(id) 
                       ?? throw new Exception($"Food with id {id} not found!");

            dbContext.Foods.Remove(food);
        }
        
        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<FoodResult>> UpdateFoodAsync(int id, FoodInput updatedFood)
    {
        var serviceResponse = new ServiceResponse<FoodResult>();

        try
        {
            var food = await dbContext.Foods.FindAsync(id)
                       ?? throw new Exception($"Food with id {id} not found!");

            food.Name = updatedFood.Name;
            food.IsHealthy = updatedFood.IsHealthy;

            await dbContext.SaveChangesAsync();

            var foodResult = new FoodResult
            {
                Name = food.Name,
                IsHealthy = food.IsHealthy
            };

            serviceResponse.Data = foodResult;
        }

        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }
}