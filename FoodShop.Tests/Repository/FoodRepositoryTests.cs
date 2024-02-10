using FoodShop.Domain.Entities;
using FoodShop.DTOs.Food;
using FoodShop.Infrastructure.Data;
using FoodShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Tests.Repository;

public class FoodRepositoryTests
{
    private readonly FoodRepository _foodRepository;

    public FoodRepositoryTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var dbContext = new AppDbContext(options);
        dbContext.Database.EnsureCreated();
        _foodRepository = new FoodRepository(dbContext);

        if (dbContext.Foods.Count() == 0)
        {
            for (int i = 0; i < 10; i++)
            {
                dbContext.Foods.Add(
                    new Food
                    {
                        Name = "New Food",
                        IsHealthy = true
                    });
            }

            dbContext.SaveChanges();
        }
    }

    [Fact]
    public void FoodRepository_AddFoodAsync_ReturnsFood()
    {
        // Arrange
        var newFood = new FoodInput("New Food", true);

        // Act
        var result = _foodRepository.AddFoodAsync(newFood);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<FoodResult>>>();
    }

    [Fact]
    public void FoodRepository_GetAllFoodsAsync_ReturnsFoods()
    {
        // Arrange

        // Act
        var result = _foodRepository.GetAllFoodsAsync();

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<List<FoodResult>>>>();
    }

    [Fact]
    public void FoodRepository_GetFoodByIdAsync_ReturnsFood()
    {
        // Arrange
        int id = 1;

        // Act 
        var result = _foodRepository.GetFoodByIdAsync(id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<FoodResult>>>();
    }

    [Fact]
    public void FoodRepository_UpdateFoodAsync_ReturnsFood()
    {
        // Arrange
        int id = 1;
        var updatedFood = new FoodInput("New Food", false);

        // Act
        var result = _foodRepository.UpdateFoodAsync(id, updatedFood);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<FoodResult>>>();
    }

    [Fact]
    public void FoodRepository_RemoveFoodAsync_ReturnsFood()
    {
        // Arrange
        int id = 1;

        // Act
        var result = _foodRepository.RemoveFoodAsync(id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<bool>>>();
    }
}