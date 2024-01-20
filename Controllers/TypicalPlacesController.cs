using FoodShop.DTOs.TypicalPlace;
using FoodShop.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop.Controllers;

[ApiController]
[Route("api/[controller]")]

// Using Primary constructor 
public class TypicalPlacesController(ITypicalPlaceRepository repository) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> AddTypicalPlaceAsync(TypicalPlaceInput newTypicalPlace)
    {
        var typicalPlace = await repository.AddTypicalPlaceAsync(newTypicalPlace);
        return typicalPlace.Data is not null
            ? Ok(typicalPlace)
            : BadRequest(typicalPlace);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllTypicalPlacesAsync()
    {
        var typicalPlaces = await repository.GetAllTypicalPlacesAsync();
        return typicalPlaces.Data is not null
            ? Ok(typicalPlaces)
            : NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAllTypicalPlacesAsync(int id)
    {
        var typicalPlace = await repository.GetTypicalPlaceByIdAsync(id);
        return typicalPlace.Data is not null
            ? Ok(typicalPlace)
            : NotFound(typicalPlace);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveTypicalPlaceAsync(int id)
    {
        var typicalPlace = await repository.RemoveTypicalPlacesAsync(id);
        return typicalPlace.Success is not false
            ? NoContent()
            : NotFound(typicalPlace);
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateTypicalPlaceAsync(int id, TypicalPlaceInput updatedTypicalPlace)
    {
        var typicalPlace = await repository.UpdateTypicalPlaceAsync(id, updatedTypicalPlace);
        return typicalPlace.Data is not null
            ? Ok(typicalPlace)
            : BadRequest(typicalPlace);
    }
}