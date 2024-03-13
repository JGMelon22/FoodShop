using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodShop.Infrastructure.Configuration;

public class FoodTypicalPlaceConfiguration : IEntityTypeConfiguration<FoodTypicalPlace>
{
    public void Configure(EntityTypeBuilder<FoodTypicalPlace> builder)
    {
        builder.ToTable("foods_typical_places");

        builder.HasKey(ftp => new
        {
            ftp.FoodId,
            ftp.TypicalPlaceId
        }).HasName("pk_foods_typical_places");

        builder.HasIndex(ftp => ftp.FoodId)
            .HasDatabaseName("idx_food_id_foods_typical_places");

        builder.HasIndex(ftp => ftp.FoodId)
            .HasDatabaseName("idx_food_id_foods_typical_places");

        builder.Property(ftp => ftp.FoodId)
            .HasColumnType("INT")
            .HasColumnName("food_id");

        builder.Property(ftp => ftp.TypicalPlaceId)
            .HasColumnType("INT")
            .HasColumnName("typical_place_id");

        // Fks
        builder.HasOne(ftp => ftp.Food)
            .WithMany(f => f.FoodTypicalPlaces)
            .HasForeignKey(ftp => ftp.FoodId)
            .HasConstraintName("fk_foods_food_typical_places");

        builder.HasOne(ftp => ftp.Food)
            .WithMany(f => f.FoodTypicalPlaces)
            .HasForeignKey(ftp => ftp.FoodId)
            .HasConstraintName("fk_typical_places_food_typical_places");
    }
}