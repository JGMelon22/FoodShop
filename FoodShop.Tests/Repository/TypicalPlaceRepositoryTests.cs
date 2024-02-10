using FoodShop.Domain.Entities;
using FoodShop.DTOs.TypicalPlace;
using FoodShop.Infrastructure.Data;
using FoodShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Tests.Repository;

public class TypicalPlaceRepositoryTests
{
    private readonly AppDbContext _dbContext;
    private readonly TypicalPlaceRepository _typicalPlaceRepository;

    public TypicalPlaceRepositoryTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        _dbContext = new AppDbContext(options);
        _dbContext.Database.EnsureCreated();
        _typicalPlaceRepository = new TypicalPlaceRepository(_dbContext);

        if (_dbContext.TypicalPlaces.Count() == 0)
        {
            for (var i = 0; i < 10; i++)
            {
                _dbContext.TypicalPlaces.Add(
                    new TypicalPlace
                    {
                        Country = "Test Country"
                    }
                );

                _dbContext.SaveChanges();
            }
        }
    }

    [Fact]
    public void TypicalPlaceRepository_AddTypicalPlace_ReturnsTypicalPlace()
    {
        // Arrange
        var typicalPlaceInput = new TypicalPlaceInput("New Typical Place");

        // Act
        var result = _typicalPlaceRepository.AddTypicalPlaceAsync(typicalPlaceInput);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<TypicalPlaceResult>>>();
    }

    [Fact]
    public void TypicalPlaceRepository_GetAllTypicalPlaces_ReturnsTypicalPlaces()
    {
        // Arrange

        // Act
        var result = _typicalPlaceRepository.GetAllTypicalPlacesAsync();

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<List<TypicalPlaceResult>>>>();
    }

    [Fact]
    public void TypicalPlaceRepository_GetTypicalPlaceById_ReturnsTypicalPlace()
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
    public void TypicalPlaceRepository_UpdateTypicalPlace_ReturnsTypicalPlace()
    {
        // Arrange
        var id = 1;
        var updatedTypicalPlace = A.Fake<TypicalPlaceInput>();

        // Act
        var result = _typicalPlaceRepository.UpdateTypicalPlaceAsync(id, updatedTypicalPlace);

        // Assert
        result.Should().BeOfType<Task<ServiceResponse<TypicalPlaceResult>>>();
    }

    [Fact]
    public void TypicalPlaceRepository_RemoveTypicalPlace_ReturnsSuccess()
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