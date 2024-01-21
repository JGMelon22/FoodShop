using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodShop.Infrastructure.Configuration;

public class TypicalPlaceConfiguration : IEntityTypeConfiguration<TypicalPlace>
{
    public void Configure(EntityTypeBuilder<TypicalPlace> builder)
    {
        builder.ToTable("typical_places");

        builder.HasKey(tp => tp.Id)
            .HasName("pk_typical_place");

        builder.HasIndex(tp => tp.Id)
            .HasDatabaseName("idx_typical_place_id");

        builder.Property(tp => tp.Country)
            .HasColumnType("VARCHAR")
            .HasColumnName("country_name")
            .HasMaxLength(100)
            .IsRequired();
    }
}