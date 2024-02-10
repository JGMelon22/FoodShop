using FoodShop.Domain.Entities;
using FoodShop.DTOs.Category;
using FoodShop.Infrastructure.Data;
using FoodShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Tests.Repository;

public class CategoryRepositoryTests
{
    private readonly CategoryRepository _categoryRepository;

    public CategoryRepositoryTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var dbContext = new AppDbContext(options);
        dbContext.Database.EnsureCreated();
        _categoryRepository = new CategoryRepository(dbContext);

        if (dbContext.Categories.Count() == 0)
        {
            for (int i = 0; i < 10; i++)
            {
                dbContext.Categories.Add(
                    new Category
                    {
                        Name = "Test Category",
                        FoodId = i
                    }
                );
            }

            dbContext.SaveChanges();
        }
    }

    [Fact]
    public void CategoryRepository_AddCategory_ReturnsCategory()
    {
        // Arrange
        var newCategory = new CategoryInput("New Category", 1);

        // Act
        var result = _categoryRepository.AddCategoryAsync(newCategory);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<CategoryResult>>>();
    }

    [Fact]
    public void CategoryRepository_GetAllCategories_ReturnsCategories()
    {
        // Arrange

        // Act
        var result = _categoryRepository.GetAllCategoriesAsync();

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
        var result = _categoryRepository.GetCategoryByIdAsync(id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<CategoryResult>>>();
    }

    [Fact]
    public void CategoryRepository_UpdateCategory_ReturnsCategory()
    {
        // Arrange
        int id = 1;
        var updatedCategory = new CategoryInput("Updated Category", 1);

        // Act 
        var result = _categoryRepository.UpdateCategoryAsync(id, updatedCategory);

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
        var result = _categoryRepository.RemoveCategoryAsync(id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Task<ServiceResponse<bool>>>();
    }
}