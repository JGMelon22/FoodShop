﻿// <auto-generated />
using FoodShop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FoodShop.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("FoodId")
                        .HasColumnType("INT")
                        .HasColumnName("food_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("category_name");

                    b.HasKey("Id")
                        .HasName("pk_category");

                    b.HasIndex("FoodId");

                    b.HasIndex("Id")
                        .HasDatabaseName("idx_category_id");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("FoodShop.Domain.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("food_id");

                    b.Property<sbyte>("IsHealthy")
                        .HasColumnType("TINYINT")
                        .HasColumnName("is_healthy");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("food_name");

                    b.HasKey("Id")
                        .HasName("pk_food");

                    b.HasIndex("Id")
                        .HasDatabaseName("idx_food_id");

                    b.ToTable("foods", (string)null);
                });

            modelBuilder.Entity("FoodShop.Domain.Entities.FoodTypicalPlace", b =>
                {
                    b.Property<int>("FoodId")
                        .HasColumnType("INT")
                        .HasColumnName("food_id");

                    b.Property<int>("TypicalPlaceId")
                        .HasColumnType("INT")
                        .HasColumnName("typical_place_id");

                    b.HasKey("FoodId", "TypicalPlaceId")
                        .HasName("pk_foods_typical_places");

                    b.HasIndex("FoodId")
                        .HasDatabaseName("idx_food_id_foods_typical_places");

                    b.HasIndex("TypicalPlaceId");

                    b.ToTable("foods_typical_places", (string)null);
                });

            modelBuilder.Entity("FoodShop.Domain.Entities.TypicalPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("country_name");

                    b.HasKey("Id")
                        .HasName("pk_typical_place");

                    b.HasIndex("Id")
                        .HasDatabaseName("idx_typical_place_id");

                    b.ToTable("typical_places", (string)null);
                });

            modelBuilder.Entity("FoodShop.Domain.Entities.Category", b =>
                {
                    b.HasOne("FoodShop.Domain.Entities.Food", "Food")
                        .WithMany("Categories")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_categories_foods");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("FoodShop.Domain.Entities.FoodTypicalPlace", b =>
                {
                    b.HasOne("FoodShop.Domain.Entities.Food", "Food")
                        .WithMany("FoodTypicalPlaces")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_typical_places_food_typical_places");

                    b.HasOne("FoodShop.Domain.Entities.TypicalPlace", "TypicalPlace")
                        .WithMany("FoodTypicalPlaces")
                        .HasForeignKey("TypicalPlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("TypicalPlace");
                });

            modelBuilder.Entity("FoodShop.Domain.Entities.Food", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("FoodTypicalPlaces");
                });

            modelBuilder.Entity("FoodShop.Domain.Entities.TypicalPlace", b =>
                {
                    b.Navigation("FoodTypicalPlaces");
                });
#pragma warning restore 612, 618
        }
    }
}
