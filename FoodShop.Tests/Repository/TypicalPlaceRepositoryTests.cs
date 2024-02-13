using FoodShop.Domain.Entities;
using FoodShop.DTOs.TypicalPlace;
using FoodShop.Infrastructure.Data;
using FoodShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Tests.Repository;

public class TypicalPlaceRepositoryTests
{
    private readonly TypicalPlaceRepository _typicalPlaceRepository;

    public TypicalPlaceRepositoryTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var dbContext = new AppDbContext(options);
        dbContext.Database.EnsureCreated();
        _typicalPlaceRepository = new TypicalPlaceRepository(dbContext);

        if (dbContext.TypicalPlaces.Count() == 0)
        {
            for (var i = 0; i < 10; i++)
            {
                dbContext.TypicalPlaces.Add(
                    new TypicalPlace
                    {
                        Country = "Test Country"
                    }
                );
            }
            
            dbContext.SaveChanges();
        }
    }

    [Fact]
    public void TypicalPlaceRepository_AddTypicalPlaceAsync_ReturnsTypicalPlace()
    {
        // Arrange
        var newTypicalPlace = new TypicalPlaceInput("New Typical Place");

        // Act
        var result = _typicalPlaceRepository.AddTypicalPlaceAsync(newTypicalPlace);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<TypicalPlaceResult>>>();
    }

    [Fact]
    public void TypicalPlaceRepository_GetAllTypicalPlacesAsync_ReturnsTypicalPlaces()
    {
        // Arrange

        // Act
        var result = _typicalPlaceRepository.GetAllTypicalPlacesAsync();

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<List<TypicalPlaceResult>>>>();
    }

    [Fact]
    public void TypicalPlaceRepository_GetTypicalPlaceByIdAsync_ReturnsTypicalPlace()
    {
        // Arrange
        int id = 1;

        // Act
        var result = _typicalPlaceRepository.GetTypicalPlaceByIdAsync(id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<TypicalPlaceResult>>>();
    }

    [Fact]
    public void TypicalPlaceRepository_UpdateTypicalPlaceAsync_ReturnsTypicalPlace()
    {
        // Arrange
        int id = 1;
        var updatedTypicalPlace = new TypicalPlaceInput("Updated Country");

        // Act
        var result = _typicalPlaceRepository.UpdateTypicalPlaceAsync(id, updatedTypicalPlace);

        // Assert
        result.Should().BeOfType<Task<ServiceResponse<TypicalPlaceResult>>>();
    }

    [Fact]
    public void TypicalPlaceRepository_RemoveTypicalPlaceAsync_ReturnsSuccess()
    {
        // Arrange
        var id = 1;

        // Act
        var result = _typicalPlaceRepository.RemoveTypicalPlacesAsync(id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<bool>>>();
    }
}