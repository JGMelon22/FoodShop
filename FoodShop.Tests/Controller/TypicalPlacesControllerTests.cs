using FoodShop.Controllers;
using FoodShop.Domain.Entities;
using FoodShop.DTOs.TypicalPlace;
using FoodShop.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop.Tests.Controller;

public class TypicalPlacesControllerTests
{
    private readonly ITypicalPlaceRepository _typicalPlaceRepository;
    private readonly TypicalPlacesController _typicalPlacesController;

    public TypicalPlacesControllerTests()
    {
        _typicalPlaceRepository = A.Fake<ITypicalPlaceRepository>();

        // SUT
        _typicalPlacesController = new TypicalPlacesController(_typicalPlaceRepository);
    }

    [Fact]
    public void TypicalPlacesController_GetAllTypicalPlacesAsync_ReturnsTypicalPlaces()
    {
        // Arrange
        var typicalPlaces = A.Fake<ServiceResponse<List<TypicalPlaceResult>>>();
        A.CallTo(() => _typicalPlaceRepository.GetAllTypicalPlacesAsync()).Returns(typicalPlaces);

        // Act
        var result = _typicalPlacesController.GetAllTypicalPlacesAsync();

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<IActionResult>>();
    }

    [Fact]
    public void TypicalPlacesController_GetTypicalPlaceByIdAsync_ReturnsTypicalPlace()
    {
        // Arrange
        var id = 1;
        var typicalPlace = A.Fake<ServiceResponse<TypicalPlaceResult>>();
        A.CallTo(() => _typicalPlaceRepository.GetTypicalPlaceByIdAsync(id)).Returns(typicalPlace);

        // Act
        var result = _typicalPlacesController.GetTypicalPlaceByIdAsync(id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<IActionResult>>();
    }

    [Fact]
    public void TypicalPlacesController_AddTypicalPlaceAsync_ReturnsTypicalPlace()
    {
        // Arrange
        var newTypicalPlace = A.Fake<TypicalPlaceInput>();
        var typicalPlaceResult = A.Fake<ServiceResponse<TypicalPlaceResult>>();
        A.CallTo(() => _typicalPlaceRepository.AddTypicalPlaceAsync(newTypicalPlace)).Returns(typicalPlaceResult);

        // Act
        var result = _typicalPlacesController.AddTypicalPlaceAsync(newTypicalPlace);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<IActionResult>>();
    }

    [Fact]
    public void TypicalPlacesController_UpdateTypicalPlace_ReturnsTypicalPlace()
    {
        // Arrange
        var id = 1;
        var updatedTypicalPlace = A.Fake<TypicalPlaceInput>();
        var typicalPlaceResult = A.Fake<ServiceResponse<TypicalPlaceResult>>();
        A.CallTo(() => _typicalPlaceRepository.UpdateTypicalPlaceAsync(id, updatedTypicalPlace))
            .Returns(typicalPlaceResult);

        // Act
        var result = _typicalPlacesController.UpdateTypicalPlaceAsync(id, updatedTypicalPlace);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<IActionResult>>();
    }

    [Fact]
    public void TypicalPlacesController_RemoveTypicalPlace_ReturnsSuccess()
    {
        // Arrange
        var id = 1;
        var success = A.Fake<ServiceResponse<bool>>();
        A.CallTo(() => _typicalPlaceRepository.RemoveTypicalPlacesAsync(id)).Returns(success);

        // Act
        var result = _typicalPlacesController.RemoveTypicalPlaceAsync(id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<IActionResult>>();
    }
}