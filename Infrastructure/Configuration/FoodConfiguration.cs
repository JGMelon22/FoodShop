using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodShop.Infrastructure.Configuration;

public class FoodConfiguration : IEntityTypeConfiguration<Food>
{
    public void Configure(EntityTypeBuilder<Food> builder)
    {
        builder.ToTable("foods");

        builder.HasKey(f => f.Id)
            .HasName("pk_food");

        builder.HasIndex(f => f.Id)
            .HasDatabaseName("idx_food_id");

        builder.Property(f => f.Id)
            .HasColumnType("INT")
            .HasColumnName("food_id")
            .ValueGeneratedOnAdd();

        builder.Property(f => f.Name)
            .HasColumnType("VARCHAR")
            .HasColumnName("food_name")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(f => f.IsHealthy)
            .HasColumnType("TINYINT")
            .HasColumnName("is_healthy")
            .IsRequired();
    }
}