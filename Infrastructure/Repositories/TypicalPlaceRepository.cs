using FoodShop.DTOs.TypicalPlace;
using FoodShop.Interfaces;

namespace FoodShop.Infrastructure.Repositories;

// Using Primary constructor 
public class TypicalPlaceRepository(AppDbContext dbContext) : ITypicalPlaceRepository
{
    public async Task<ServiceResponse<TypicalPlaceResult>> AddTypicalPlaceAsync(TypicalPlaceInput newTypicalPlace)
    {
        var serviceResponse = new ServiceResponse<TypicalPlaceResult>();

        try
        {
            var typicalPlace = new TypicalPlace
            {
                Country = newTypicalPlace.Country
            };

            await dbContext.TypicalPlaces.AddAsync(typicalPlace);
            await dbContext.SaveChangesAsync();

            var typicalPlaceResult = new TypicalPlaceResult
            {
                Id = typicalPlace.Id,
                Country = typicalPlace.Country
            };

            serviceResponse.Data = typicalPlaceResult;
        }

        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<List<TypicalPlaceResult>>> GetAllTypicalPlacesAsync()
    {
        var serviceResponse = new ServiceResponse<List<TypicalPlaceResult>>();

        try
        {
            var typicalPlaces = await dbContext.TypicalPlaces
                .AsNoTracking()
                .ToListAsync() ?? throw new Exception("Typical Places list is empty!");

            var typicalPlacesMapped = new List<TypicalPlaceResult>();

            foreach (var typicalPlace in typicalPlaces)
            {
                var typicalPlaceResult = new TypicalPlaceResult
                {
                    Id = typicalPlace.Id,
                    Country = typicalPlace.Country
                };

                typicalPlacesMapped.Add(typicalPlaceResult);
            }

            serviceResponse.Data = typicalPlacesMapped;
        }

        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<TypicalPlaceResult>> GetTypicalPlaceByIdAsync(int id)
    {
        var serviceResponse = new ServiceResponse<TypicalPlaceResult>();

        try
        {
            var typicalPlace = await dbContext.TypicalPlaces
                .FindAsync(id) ?? throw new Exception($"Typical Place with id {id} not found!");

            var typicalPlaceMapped = new TypicalPlaceResult
            {
                Id = typicalPlace.Id,
                Country = typicalPlace.Country
            };

            serviceResponse.Data = typicalPlaceMapped;
        }
        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<bool>> RemoveTypicalPlacesAsync(int id)
    {
        var serviceResponse = new ServiceResponse<bool>();

        try
        {
            var typicalPlace = await dbContext.TypicalPlaces
                .FindAsync(id) ?? throw new Exception($"Typical Place with id {id} not found!");

            dbContext.TypicalPlaces.Remove(typicalPlace);

            await dbContext.SaveChangesAsync();
        }

        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<TypicalPlaceResult>> UpdateTypicalPlaceAsync(int id,
        TypicalPlaceInput updatedTypicalPlace)
    {
        var serviceResponse = new ServiceResponse<TypicalPlaceResult>();

        try
        {
            var typicalPlace = await dbContext.TypicalPlaces
                .FindAsync(id);

            if (typicalPlace is null)
                throw new Exception($"Typical Place with id {id} not found!");

            typicalPlace.Country = updatedTypicalPlace.Country;

            await dbContext.SaveChangesAsync();

            var typicalPlaceResult = new TypicalPlaceResult
            {
                Id = typicalPlace.Id,
                Country = typicalPlace.Country
            };

            serviceResponse.Data = typicalPlaceResult;
        }

        catch (Exception ex)
        {
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;
        }

        return serviceResponse;
    }
}