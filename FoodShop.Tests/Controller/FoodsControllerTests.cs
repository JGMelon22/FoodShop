using FluentAssertions.Common;
using FoodShop.Controllers;
using FoodShop.Domain.Entities;
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
}