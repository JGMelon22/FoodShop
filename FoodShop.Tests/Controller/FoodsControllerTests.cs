using FluentAssertions.Common;
using FoodShop.Controllers;
using FoodShop.Domain.Entities;
using FoodShop.DTOs.Category;
using FoodShop.DTOs.Food;
using FoodShop.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop.Tests.Controller;

public class FoodsControllerTests
{
    private readonly FoodsController _foodsController;
    private readonly IFoodRepository _foodRepository;

    public FoodsControllerTests()
    {
        _foodRepository = A.Fake<IFoodRepository>();

        // SUT
        _foodsController = new FoodsController(_foodRepository);
    }

    [Fact]
    public void FoodsController_GetAllFoodsAsync_ReturnsFoods()
    {
        // Arrange
        var foods = A.Fake<ServiceResponse<List<FoodResult>>>();
        A.CallTo(() => _foodRepository.GetAllFoodsAsync()).Returns(foods);

        // Act
        var result = _foodsController.GetAllFoodsAsync();

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<IActionResult>>();
    }

    [Fact]
    public void FoodsController_GetFoodByIdAsync_ReturnsFood()
    {
        // Arrange
        int id = 2;
        var food = A.Fake<ServiceResponse<FoodResult>>();
        A.CallTo(() => _foodRepository.GetFoodByIdAsync(id)).Returns(food);

        // Act
        var result = _foodsController.GetFoodByIdAsync(id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<IActionResult>>();
    }

    [Fact]
    public void FoodsController_AddFoodAsync_ReturnsFood()
    {
        // Arrange
        var newFood = A.Fake<FoodInput>();
        var foodResult = A.Fake<ServiceResponse<FoodResult>>();
        A.CallTo(() => _foodRepository.AddFoodAsync(newFood)).Returns(foodResult);

        // Act
        var result = _foodsController.AddFoodAsync(newFood);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<IActionResult>>();
    }

    [Fact]
    public void FoodsController_UpdateFoodAsync_ReturnsFood()
    {
        // Arrange
        int id = 2;
        var updatedFood = A.Fake<FoodInput>();
        var foodResult = A.Fake<ServiceResponse<FoodResult>>();
        A.CallTo(() => _foodRepository.UpdateFoodAsync(id, updatedFood)).Returns(foodResult);

        // Act
        var result = _foodsController.UpdateFoodAsync(id, updatedFood);

        // Assert
        result.Should().NotBeNull().And.BeOfType<Task<IActionResult>>();
    }

    [Fact]
    public void FoodsController_RemoveFoodAsync_ReturnsSuccess()
    {
        // Arrange
        int id = 2;
        var success = A.Fake<ServiceResponse<bool>>();
        A.CallTo(() => _foodRepository.RemoveFoodAsync(id)).Returns(success);

        // Act
        var result = _foodsController.RemoveFoodAsync(id);

        // Assert
        result.Should().NotBeNull().And.BeOfType<Task<IActionResult>>();
    }
}