using Bogus;
using FoodShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Infrastructure.Configuration.Seeding;

public static class InitialSeeding
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var category = new Faker<Category>()
            .RuleFor(c => c.Id, f => f.IndexFaker + 1)
            .RuleFor(c => c.Name, f => f.Commerce.ProductName())
            .RuleFor(c => c.FoodId, f => f.Random.Number(1, 50))
            .Generate(50);

        var food = new Faker<Food>()
            .RuleFor(f => f.Id, f => f.IndexFaker + 1)
            .RuleFor(f => f.Name, f => f.Commerce.ProductName())
            .RuleFor(f => f.IsHealthy, f => f.Random.Bool())
            .Generate(50);

        var typicalPlace = new Faker<TypicalPlace>()
            .RuleFor(tp => tp.Id, f => f.IndexFaker + 1)
            .RuleFor(tp => tp.Country, f => f.Address.Country())
            .Generate(50);

        var foodTypicalPlace = new Faker<FoodTypicalPlace>()
            .RuleFor(ftp => ftp.FoodId, f => f.PickRandom(food).Id)
            .RuleFor(ftp => ftp.TypicalPlaceId, f => f.PickRandom(typicalPlace).Id)
            .Generate(50);

        modelBuilder.Entity<Category>()
            .HasData(category);

        modelBuilder.Entity<Food>()
            .HasData(food);

        modelBuilder.Entity<TypicalPlace>()
            .HasData(typicalPlace);

        modelBuilder.Entity<FoodTypicalPlace>()
            .HasData(foodTypicalPlace);
    }
}