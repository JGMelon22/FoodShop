using FoodShop.Domain.Entities;
using FoodShop.DTOs.Category;
using FoodShop.Infrastructure.Data;
using FoodShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Tests.Repository;

public class CategoryRepositoryTests
{
    private readonly AppDbContext _dbContext;
    private readonly CategoryRepository _categoryRepository;

    public CategoryRepositoryTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        _dbContext = new AppDbContext(options);
        _dbContext.Database.EnsureCreated();
        _categoryRepository = new CategoryRepository(_dbContext);

        if (_dbContext.Categories.Any())
        {
            for (int i = 0; i < 10; i++)
            {
                _dbContext.Categories.Add(
                    new Category
                    {
                        Name = "Test Category",
                        FoodId = i
                    }
                );

                _dbContext.SaveChanges();
            }
        }
    }

    [Fact]
    public void CategoryRepository_AddCategory_ReturnsCategory()
    {
        // Arrange
        var category = new CategoryInput("New Category", 2);

        // Act
        var result =  _categoryRepository.AddCategoryAsync(category);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<CategoryResult>>>();
    }

    [Fact]
    public void CategoryRepository_GetAllCategories_ReturnsCategories()
    {
        // Arrange

        // Act
        var result =  _categoryRepository.GetAllCategoriesAsync();

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<List<CategoryResult>>>>();
    }

    [Fact]
    public void CategoryRepository_GetCategoryByIdAsync_ReturnsCategory()
    {
        // Arrange
        int id = 1;

        // Act
        var result =  _categoryRepository.GetCategoryByIdAsync(id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<CategoryResult>>>();
    }

    [Fact]
    public void CategoryRepository_UpdateCategory_ReturnsCategory()
    {
        // Arrange
        int id = 1;
        var updatedCategory = A.Fake<CategoryInput>();

        // Act 
        var result =  _categoryRepository.UpdateCategoryAsync(id, updatedCategory);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<CategoryResult>>>();
    }

    [Fact]
    public void CategoryRepository_RemoveCategory_ReturnsSuccess()
    {
        // Arrange
        int id = 1;

        // Act
        var result =  _categoryRepository.RemoveCategoryAsync(id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<bool>>>();
    }
}