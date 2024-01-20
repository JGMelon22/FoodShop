using FoodShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodShop.Infrastructure.Configuration;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("categories");

        builder.HasKey(c => c.Id)
            .HasName("pk_category");

        builder.HasIndex(c => c.Id)
            .HasDatabaseName("idx_category_id");

        builder.Property(c => c.Id)
            .HasColumnName("category_id");

        builder.Property(c => c.Name)
            .HasColumnType("VARCHAR")
            .HasColumnName("category_name")
            .HasMaxLength(100)
            .IsRequired();

        // FK
        builder.Property(c => c.FoodId)
            .HasColumnType("INT")
            .HasColumnName("food_id");

        // One-To-Many
        builder.HasOne(c => c.Food)
            .WithMany(f => f.Categories)
            .HasForeignKey(c => c.FoodId)
            .HasConstraintName("fk_categories_foods");
    }
}