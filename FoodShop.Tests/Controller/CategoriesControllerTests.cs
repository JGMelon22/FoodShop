using FoodShop.Controllers;
using FoodShop.Domain.Entities;
using FoodShop.DTOs.Category;
using FoodShop.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop.Tests.Controller;

public class CategoriesControllerTests
{
    private readonly CategoriesController _categoriesController;
    private readonly ICategoryRepository _categoryRepository;

    public CategoriesControllerTests()
    {
        _categoryRepository = A.Fake<ICategoryRepository>();

        // SUT
        _categoriesController = new CategoriesController(_categoryRepository);
    }

    [Fact]
    public void CategoriesController_GetAllCategoriesAsync_ReturnsCategories()
    {
        // Arrange 
        var categories = A.Fake<ServiceResponse<List<CategoryResult>>>();
        A.CallTo(() => _categoryRepository.GetAllCategoriesAsync()).Returns(categories);

        // Act
        var result = _categoriesController.GetAllCategoriesAsync();

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<IActionResult>>();
    }

    [Fact]
    public void CategoriesController_CategoryByIdAsync_ReturnsCategory()
    {
        // Arrange
        var id = 1;
        var category = A.Fake<ServiceResponse<CategoryResult>>();
        A.CallTo(() => _categoryRepository.GetCategoryByIdAsync(id)).Returns(category);

        // Act
        var result = _categoriesController.GetCategoryByIdAsync(id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<IActionResult>>();
    }

    [Fact]
    public void CategoriesController_AddCategoryAsync_ReturnsCategory()
    {
        // Arrange
        var newCategory = A.Fake<CategoryInput>();
        var categoryResult = A.Fake<ServiceResponse<CategoryResult>>();
        A.CallTo(() => _categoryRepository.AddCategoryAsync(newCategory)).Returns(categoryResult);

        // Act
        var result = _categoriesController.AddCategoryAsync(newCategory);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<IActionResult>>();
    }

    [Fact]
    public void CategoriesController_UpdateCategoryAsync_ReturnsCategory()
    {
        // Arrange
        var id = 1;
        var updatedCategory = A.Fake<CategoryInput>();
        var categoryResult = A.Fake<ServiceResponse<CategoryResult>>();
        A.CallTo(() => _categoryRepository.UpdateCategoryAsync(id, updatedCategory)).Returns(categoryResult);

        // Act
        var result = _categoriesController.UpdateCategoryAsync(id, updatedCategory);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<IActionResult>>();
    }

    [Fact]
    public void CategoriesController_RemoveCategoryAsync_ReturnsSuccess()
    {
        // Arrange
        var id = 1;
        var success = A.Fake<ServiceResponse<bool>>();
        A.CallTo(() => _categoryRepository.RemoveCategoryAsync(id)).Returns(success);

        // Act
        var result = _categoriesController.RemoveCategoryAsync(id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<IActionResult>>();
    }
}