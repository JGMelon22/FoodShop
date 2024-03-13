using FoodShop.DTOs.Food;
using FoodShop.Infrastructure.Mappling;
using FoodShop.Interfaces;

namespace FoodShop.Infrastructure.Repositories;

public class FoodRepository(AppDbContext dbContext) : IFoodRepository
{
    public async Task<ServiceResponse<FoodResult>> AddFoodAsync(FoodInput newFood)
    {
        var serviceResponse = new ServiceResponse<FoodResult>();

        try
        {
            var mapper = new FoodMapper();
            var food = mapper.FoodToFoodInputDto(newFood);
            
            await dbContext.Foods.AddAsync(food);
            await dbContext.SaveChangesAsync();

            var foodResult = mapper.FoodToFoodResultDto(food);

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

            //
            var mapper = new FoodMapper();
            var foodResults = foods.Select(x => mapper.FoodToFoodResultDto(x)).ToList();
            //

            serviceResponse.Data = foodResults;
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

            var mapper = new FoodMapper();
            var foodResult = mapper.FoodToFoodResultDto(food);

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

            var mapper = new FoodMapper();
            var foodResult = mapper.FoodToFoodResultDto(food);

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