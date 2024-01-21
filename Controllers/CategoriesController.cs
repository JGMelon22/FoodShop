using FoodShop.DTOs.Category;
using FoodShop.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController(ICategoryRepository repository) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> AddCategoryAsync(CategoryInput newCategory)
    {
        var category = await repository.AddCategoryAsync(newCategory);
        return category.Data is not null
            ? Ok(category)
            : BadRequest(category);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCategoriesAsync()
    {
        var categories = await repository.GetAllCategoriesAsync();
        return categories.Data is not null
            ? Ok(categories)
            : NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategoryByIdAsync(int id)
    {
        var categories = await repository.GetCategoryByIdAsync(id);
        return categories.Data is not null
            ? Ok(categories)
            : NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveCategoryAsync(int id)
    {
        var category = await repository.RemoveCategoryAsync(id);
        return category.Success is not false
            ? NoContent()
            : NotFound(category);
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateCategoryAsync(int id, CategoryInput updatedCategory)
    {
        var category = await repository.UpdateCategoryAsync(id, updatedCategory);
        return category.Data is not null
            ? Ok(category)
            : BadRequest(category);
    }
}