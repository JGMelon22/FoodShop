using FoodShop.Domain.Entities;
using FoodShop.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Food> Foods { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<TypicalPlace> TypicalPlaces { get; set; }

    public DbSet<FoodTypicalPlace> FoodTypicalPlaces { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new FoodConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new TypicalPlaceConfiguration());
        modelBuilder.ApplyConfiguration(new FoodTypicalPlaceConfiguration());
    }
}