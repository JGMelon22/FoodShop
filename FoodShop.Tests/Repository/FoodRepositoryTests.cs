using FoodShop.Domain.Entities;
using FoodShop.DTOs.Food;
using FoodShop.Infrastructure.Data;
using FoodShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Tests.Repository;

public class FoodRepositoryTests
{
    // private readonly AppDbContext _dbContext;
    private readonly FoodRepository _foodRepository;

    public FoodRepositoryTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var dbContext = new AppDbContext(options);
        dbContext.Database.EnsureCreated();
        _foodRepository = new FoodRepository(dbContext);

        if (dbContext.Foods.Any())
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
    public void FoodRepository_AddFood_ReturnsFood()
    {
        // Arrange
        var newFood = new FoodInput("New Food", true);

        // Act
        var result = _foodRepository.AddFoodAsync(newFood);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<FoodResult>>>();
    }
}