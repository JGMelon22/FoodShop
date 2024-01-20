using FoodShop.Domain.Entities;
using FoodShop.DTOs.TypicalPlace;

namespace FoodShop.Interfaces;

public interface ITypicalPlaceRepository
{
    Task<ServiceResponse<List<TypicalPlaceResult>>> GetAllTypicalPlacesAsync();
    Task<ServiceResponse<TypicalPlaceResult>> GetTypicalPlaceByIdAsync(int id);
    Task<ServiceResponse<TypicalPlaceResult>> AddTypicalPlaceAsync(TypicalPlaceInput newTypicalPlace);
    Task<ServiceResponse<TypicalPlaceResult>> UpdateTypicalPlaceAsync(int id, TypicalPlaceInput updatedTypicalPlace);
    Task<ServiceResponse<bool>> RemoveTypicalPlacesAsync(int id);

}