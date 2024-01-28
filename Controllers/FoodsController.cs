using FoodShop.DTOs.Food;
using FoodShop.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FoodsController(IFoodRepository repository) : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> AddFoodAsync(FoodInput newFood)
    {
        var foods = await repository.AddFoodAsync(newFood);
        return foods.Data != null
            ? Ok(foods)
            : BadRequest(foods);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllFoodsAsync()
    {
        var food = await repository.GetAllFoodsAsync();
        return food.Data != null
            ? Ok(food)
            : NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetFoodByIdAsync(int id)
    {
        var food = await repository.GetFoodByIdAsync(id);
        return food.Data != null
            ? Ok(food)
            : NotFound(food);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveFoodAsync(int id)
    {
        var food = await repository.RemoveFoodAsync(id);
        return food.Success != false
            ? NoContent()
            : BadRequest(food);
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateFoodAsync(int id, FoodInput updatedFood)
    {
        var food = await repository.UpdateFoodAsync(id, updatedFood);
        return food.Data != null
            ? Ok(food)
            : BadRequest(food);
    }
}